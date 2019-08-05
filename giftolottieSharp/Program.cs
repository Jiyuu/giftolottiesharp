using System;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System.Linq;
using System.Collections.Generic;
using giftolottieSharp.Schema;

namespace giftolottieSharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var image = SixLabors.ImageSharp.Image.Load(new Configuration() { },"test.gif",new SixLabors.ImageSharp.Formats.Gif.GifDecoder());
            var frame_blocks = await getFrameBlocks(image);
            var optimized_frames = await optimizeFrames(frame_blocks);

            var prepare_layers = await initialLayers(optimized_frames);

            var animation = new Animation();
            animation.V = "5.5.2";
            animation.Fr = 60;
            animation.Ip = 0;
            animation.Op = 60;
            animation.W = image.Width;
            animation.H = image.Height;
            animation.Tgs = 1;
            animation.Layers = prepare_layers.ToList();

            var res = animation.ToJson();

        }

        private static async Task<AnimationLayer[]> initialLayers(Frame[] optimized_frames)
        {
            var frame_tasks = optimized_frames.Select(f => initialLayer(f)).ToArray();
            return Task.WhenAll(frame_tasks).Result;
        }

        private static async Task<AnimationLayer> initialLayer(Frame f)
        {
            //Animation a = new Animation();
            //a.Layers = new List<AnimationLayer>();
            var layer = new AnimationLayer();
            layer.Ty = 4;
            layer.Ks = new KsClass();
            layer.Ip = f.Index;
            layer.Op = f.Index+1; //might not need +1
            layer.St = layer.Ip;
            layer.Sr = 1;
            layer.Shapes = new List<LayerIt>();

            foreach (var shape in f.Shapes)
            {
                var groupshape = new LayerIt() { };
                groupshape.Ty = "gr";
                groupshape.Nm = "";
                groupshape.Bm = 0;
                groupshape.It = new List<ItIt>();
                var shapeRect = new ItIt();
                shapeRect.Ty = "rc";
                shapeRect.Nm = "";
                //shapeRect.D = 1;
                shapeRect.P = new PurplePosition() { K = new double[] {(shape.Start.X+shape.End.X)/2, (shape.Start.Y + shape.End.Y) / 2 } };
                shapeRect.S = new PurpleSize() { K = new CK() { AnythingArray=new double[] { shape.End.X + shape.Start.X, shape.End.Y + shape.Start.Y } } };
                var shapeFl = new ItIt();
                shapeFl.Ty = "fl";
                shapeFl.C = new PurpleColor() { K = new int[] { shape.Color.R, shape.Color.G, 255 } }; 
                var shapeTr= new ItIt();
                shapeTr.Ty = "tr";

                groupshape.It.Add(shapeRect);
                groupshape.It.Add(shapeFl);
                groupshape.It.Add(shapeTr);

                layer.Shapes.Add(groupshape);
            }




            //Layer l = new Layer();
            //l.Type = 4;
            //l.Ks = new LayerKs();

            return layer;
        }

        private static async Task<Frame[]> optimizeFrames(Frame[] frame_blocks)
        {
            var frame_tasks = frame_blocks.Select(f => optimizeFrame(f)).ToArray();
            return Task.WhenAll(frame_tasks).Result;
        }

        private static async Task<Frame> optimizeFrame(Frame frame)
        {
            if (frame.Shapes.Count == 0) //in case of an empty frame
                return frame;
            List<Rect> optimized_shapes= new List<Rect>();
            
            //optimized_shapes.Add(frame.Shapes[0]);
            var current_optimizing_shape = (frame.Shapes[0].Start, frame.Shapes[0].End, frame.Shapes[0].Color);
            for (int i = 1; i < frame.Shapes.Count; i++)
            {
                //var prev_shape = frame.Shapes[i - 1];
                var shape = frame.Shapes[i];

                if (current_optimizing_shape.Start.Y == shape.Start.Y && current_optimizing_shape.Color == shape.Color)
                    current_optimizing_shape.End = shape.End;
                else
                {
                    optimized_shapes.Add(new Rect(current_optimizing_shape.Start, current_optimizing_shape.End, current_optimizing_shape.Color));
                    current_optimizing_shape = (shape.Start, shape.End, shape.Color);
                }

            }

            optimized_shapes.Add(new Rect(current_optimizing_shape.Start, current_optimizing_shape.End, current_optimizing_shape.Color));


            return new Frame(optimized_shapes, frame.Index);
        }

        private static async Task<Frame[]> getFrameBlocks(Image<Rgba32> image)
        {
            var frame_tasks = image.Frames.Select((f,i) => BlocksFrame(f, i)).ToArray();
            //var frame_blocks = Parallel.ForEach(image.Frames, async (frame) => await FrameToBlocks(frame));

            var frames_data = Task.WhenAll(frame_tasks).Result;
            return frames_data;
        }

        private static async Task<Frame> BlocksFrame(ImageFrame<Rgba32> frame,int index)
        {
            var rects = new List<Rect>();
            for (int y = 0; y < frame.Height; y++)
            {
                for (int x = 0; x < frame.Width; x++)
                {
                    if (frame[x, y].A==255 && frame[x, y].Rgba != 4294967295)//hack because alpha doesnt get detected
                        rects.Add(new Rect(new Point(x, y), new Point(x, y), frame[x, y].Rgb));
                }
            }

            return new Frame(rects, index);
        }
    }
}

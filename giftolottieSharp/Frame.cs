using System.Collections.Generic;

namespace giftolottieSharp
{
    internal class Frame
    {
        public int Index { get; set; }
        public List<Rect> Shapes { get; set; }
        public Frame(List<Rect> shapes,int index)
        {
            this.Shapes = shapes;
            this.Index = index;
        }
    }
}
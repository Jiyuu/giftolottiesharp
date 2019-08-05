using SixLabors.ImageSharp.PixelFormats;

namespace giftolottieSharp
{
    internal struct Rect
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Rgb24 Color { get; set; }

        public Rect(Point start, Point end, Rgb24 color)
        {
            this.Start = start;
            this.End = end;
            this.Color = color;

        }
        public override string ToString()
        {
            return $"[{Start},{End},{Color}]";
        }
    }
}
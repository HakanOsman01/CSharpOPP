
using System.Text;

namespace P01.ClassBoxData
{
    public class Box
    {
        private double widht;
        private double height;
        private double lenght;

        public Box(double lenght,double widht,double height)
        {
            Length = lenght;
            Width = widht;
            Height = height;
           
        }
        public double Width { 
            get 
            {
                return widht;
            } 
            private set 
            {
                if(value<=0)
                {
                    throw new ArgumentException($"{nameof(this.W)} cannot be zero or negative.");
                }
                widht = value;
            }
        }
        public double Length
        {
            get
            {
                return lenght;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }
                lenght = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                height = value;
            }
        }
        public double SurfaceArea()
        {
            double surfaceArea=2*lenght*widht+2*lenght*height+2*widht*height;
            return surfaceArea;
        }
        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * lenght * height + 2 * widht * height;
            return lateralSurfaceArea;
        }
        public double Volume()
        {
            double volume = lenght * widht * height;
            return volume;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            double surFaceArea = SurfaceArea();
            builder.AppendLine($"Surface Area - {surFaceArea:f2}");
            double lateralSurFace = LateralSurfaceArea();
            builder.AppendLine($"Lateral Surface Area - {lateralSurFace:f2}");
            double volume = Volume();
            builder.AppendLine($"Volume - {volume:f2}");
            return builder.ToString().TrimEnd();
        }
    }
}

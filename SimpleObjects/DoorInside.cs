using a01.Shared.Functions;

namespace a01.Shared.Objects
{
    public class DoorInside
    {
        public DoorInside(double width, double height,Type type,Climate climate)
        {
            Width = width;
            Height = height;
            Area = width * height;
            if (type==Type.Usual)
            {
                SmokeResistance = 5300 / climate.DensitySupply;
            }
            else if (type==Type.SmokeResistant)
            {
                SmokeResistance = 60000 / climate.DensitySupply;
            }
        }
        public DoorInside(double width, double height, double smokeResistance)
        {
            Width = width;
            Height = height;
            SmokeResistance = smokeResistance;
            Area = width * height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }
        public double SmokeResistance { get; set; }
        public enum Type
        {
            Usual,
            SmokeResistant
        }

    }

}

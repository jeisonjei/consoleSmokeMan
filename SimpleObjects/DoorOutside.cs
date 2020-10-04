namespace a01.Shared.Objects
{
    public class DoorOutside
    {
        public DoorOutside(double width,double height)
        {
            Width = width;
            Height = height;
            Area = width * height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }
    }

}

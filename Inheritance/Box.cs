namespace oops.Inheritance
{
    public class Box
    {
        public decimal Length {get; set;}
        public decimal Height { get; set; }
        public decimal Width { get; set; }

        public decimal GetVolume(){
            return Length * Width * Height;
        }

    }
}
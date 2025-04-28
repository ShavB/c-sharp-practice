namespace oops.Inheritance
{
    public class Cube : Box
    {
        public string Color {get; set;} = "red";

        public void DisplayColor(){
            Console.WriteLine($"Cube color: {Color}");
        }
    }
}
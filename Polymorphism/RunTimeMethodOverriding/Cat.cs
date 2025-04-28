namespace oops.Polymorphism.RunTimeMethodOverriding
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            // base.MakeSound();
            Console.WriteLine("Cat meows!!!");
        }
    }
}
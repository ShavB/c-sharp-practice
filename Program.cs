// using Encapsulation.Vehicle;

// Encapsulation

// Vehicle vh = new();
// vh.VehicleName = "toyota";

// Console.WriteLine(vh.VehicleName);

// using Abstaraction.Vehicle;
// using oops.Abstraction;

// Car c = new();
// c.Start();
// c.Stop();

// AbsCars abc = new();
// abc.DisplayInfo();
// abc.Start();


// using oops.Inheritance;

// Cube cube = new()
// {
//     Height = 10,
//     Width = 10,
//     Length = 10
// };
// cube.GetVolume();

// cube.DisplayColor();

// Polymorphism

// using oops.Polymorphism;
// using oops.Polymorphism.RunTimeMethodOverriding;

// Calculator calc = new();
// Console.WriteLine( calc.Add(2, 2));
// Console.WriteLine( calc.Add(2, 2, 2));
// Console.WriteLine( calc.Add(2, 2, 2, 2));

// Animal cat = new Dog();
// Animal dog = new Cat();

// cat.MakeSound();
// dog.MakeSound();


using oops.practice;

Animal cat = new Cat();
Animal dog = new Dog();
cat.MakeSound();
dog.MakeSound();

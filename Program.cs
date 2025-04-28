// using Encapsulation.Vehicle;

// Encapsulation

// Vehicle vh = new();
// vh.VehicleName = "toyota";

// Console.WriteLine(vh.VehicleName);

using Abstaraction.Vehicle;
using oops.Abstraction;

Car c = new();
c.Start();
c.Stop();

AbsCars abc = new();
abc.DisplayInfo();
abc.Start();
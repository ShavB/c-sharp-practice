using Abstraction.IVehicle;

namespace Abstaraction.Vehicle;

public class Car : IVehicle
{
    public void Start(){
        Console.WriteLine("Car started!!!!");
    }

    public void Stop(){
        Console.WriteLine("Car stopped!!!!");
    }
}
namespace Encapsulation.Vehicle;

/*
    What is encapsulation?

    it involves binding or bundling of data, fields, or properties and their behaviours
    or method in a single unit called `class`. it hides the internal state of the object
    and exposes only the necessary functionalties.

    Encapsulation can be achieved by using access modifiers like `private` and `protected`
    and we can update the data using getters and setter like methods.

    we can acheive data hiding, security and maintainence of the code.

    Eg. 
*/

public class Vehicle
{
    private string? vehicleName;
    public string? VehicleName
    {
        get {return vehicleName;}
        set {vehicleName = value;}
    }

}
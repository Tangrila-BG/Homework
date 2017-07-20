namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._3Ferrari
{

    internal interface ICar
    {
        string Driver { get; set; }
        string Model { get; set; }

        string Accelerate();
        string Brake();

    }

}

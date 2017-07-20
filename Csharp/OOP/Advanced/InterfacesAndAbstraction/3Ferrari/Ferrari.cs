using System.Text;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._3Ferrari
{
    internal class Ferrari : ICar
    {
        public override string ToString()
        {
            //<model>/<brakes>/<gas pedal>/<driver's name>
            var sb = new StringBuilder(
                $"{this.Model}/{this.Brake()}/{this.Accelerate()}/{this.Driver}");
            return sb.ToString();
        }

        public Ferrari(string driver, string model = "488-Spider")
        {
            this.Driver = driver;
            this.Model = model;
        }

        public string Driver { get; set; }
        public string Model { get; set; }

        public string Accelerate()
        {
            return "Zadu6avam sA!";
        }

        public string Brake()
        {
            return "Brakes!";
        }
    }

}
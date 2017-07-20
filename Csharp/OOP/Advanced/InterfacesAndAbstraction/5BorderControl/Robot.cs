namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._5BorderControl
{
    class Robot : IIdentifiable
    {
        public string Id { get; }
        public string Model { get; }

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}

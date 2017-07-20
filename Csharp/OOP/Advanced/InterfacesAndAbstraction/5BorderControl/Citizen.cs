﻿namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._5BorderControl
{
    class Citizen : IIdentifiable
    {
        public string Id { get; }
        public string Name { get; }
        public int Age { get; }

        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

    }
}

﻿namespace Csharp.OOP.Basics.Inheritance._6.Animals
{

    class Tomcat : Cat
    {
        public override string ProduceSound()
        {
            return "Give me one million b***h";
        }

        public Tomcat(string name, int age, string gender) : base(name, age, "Male")
        {
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Inheritance._1.Person
{
    public static class _1Person
    {
        public static void Solution()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }

        class Person
        {
            protected int _age;
            private string _name;

            public string Name
            {
                get { return _name; }
                set
                {
                    if (value.Length < 3)
                        throw new ArgumentException("Name’s length should not be less than 3 symbols!");

                    _name = value;
                }
            }

            public virtual int Age
            {
                get { return _age; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Age must be positive!");

                    _age = value;
                }
            }

            public override string ToString()
            {
                return $"Name: {this.Name}, Age: {this.Age}";
            }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
        }

        class Child : Person
        {
            public sealed override int Age
            {
                get { return _age; }
                set
                {
                    if (value > 15)
                        throw new ArgumentException("Child’s age must be less than 15!");

                    base.Age = value;
                }
            }

            public Child(string name, int age) : base(name, age)
            {
            }
        }
    }
}

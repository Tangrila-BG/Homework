using System;

namespace Csharp.OOP.Basics.Inheritance._6.Animals
{

    class Animal
    {
        private string _name;
        private int _age;
        private string _gender;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid input!");

                _name = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid input!");

                _age = value;
            }
        }

        public string Gender
        {
            get { return _gender; }
            set
            {
                var temp = value.ToLowerInvariant();

                if (temp != "male" && temp != "female")
                    throw new ArgumentException("Invalid input!");

                _gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return "Not implemented!";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}\n" +
                   $"{this.Name} {this.Age} {this.Gender}\n" +
                   $"{this.ProduceSound()}";
        }

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }

}

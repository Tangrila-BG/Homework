using System.Collections.Generic;

namespace Csharp.OOP.Basics.DefiningClasses._12.Google
{
    public static partial class _12Google
    {
        private class Person
        {
            private string _name;
            private Car _car = new Car();
            private Company _company = new Company();
            private List<Child> _children = new List<Child>();
            private List<Parent> _parents = new List<Parent>();
            private List<Pokemon> _pokemons = new List<Pokemon>();

            public Person(string name)
            {
                _name = name;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public void UpdatePerson(Car car)
            {
                _car.Model = car.Model;
                _car.Speed = car.Speed;
            }

            public void UpdatePerson(Company company)
            {
                _company.Name = company.Name;
                _company.Department = company.Department;
                _company.Salary = company.Salary;
            }

            public void UpdatePerson(Child child)
            {
                _children.Add(child);
            }

            public void UpdatePerson(Parent parent)
            {
                _parents.Add(parent);
            }

            public void UpdatePerson(Pokemon pokemon)
            {
                _pokemons.Add(pokemon);
            }

            public override string ToString()
            {
                string pokemons = string.Join("\n", _pokemons);
                string parents = string.Join("\n", _parents);
                string children = string.Join("\n", _children);
                return
                    $"{_name}" +
                    $"\nCompany:\n{_company}".TrimEnd() +
                    $"\nCar:\n{_car}\n".TrimEnd() +
                    $"\nPokemon:\n{pokemons}".TrimEnd() +
                    $"\nParents:\n{parents}".TrimEnd() +
                    $"\nChildren:\n{children}".TrimEnd();
            }
        }
    }

}

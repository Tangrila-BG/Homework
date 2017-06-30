using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._03.OldestFamilyMember
{
    public static partial class _03OldestFamilyMember
    {
        private class Family
        {
            private List<Person> _people;

            public void AddMember(Person member)
            {
                this._people.Add(member);
            }

            public Person GetOldestMember()
            {
                return this._people.First(x => x.Age == this._people.Max(y => y.Age));
            }

            public Family()
            {
                this._people = new List<Person>();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp.OOP.Advanced.IteratorsAndComparators._8PetClinics
{
    class _8PetClinics
    {
        public static void Solution()
        {
            var database = new Database();
            var petStore = new PetStore(database);
            var clinicStore = new ClinicStore(database);
            var manager = new Manager(petStore, clinicStore);

            var n = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Trim().Split();
                try
                {
                    Parser(input, manager);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
        }

        static void Parser(string[] input, Manager manager)
        {
            string clinicName;

            if (input[0].Equals("Create"))
            {
                string name;

                if (input[1].Equals("Pet"))
                {
                    name = input[2];
                    var age = int.Parse(input[3]);
                    var kind = input[4];

                    manager.CreatePet(name, age, kind);
                }
                else
                {
                    name = input[2];
                    var rooms = int.Parse(input[3]);

                    manager.CreateClinic(name, rooms);
                }
            }
            else if (input[0].Equals("Add"))
            {
                var petName = input[1];
                clinicName = input[2];

                Console.WriteLine(manager.Add(petName, clinicName).ToString().ToLowerInvariant());
            }
            else if (input[0].Equals("Release"))
            {
                clinicName = input[1];

                Console.WriteLine(manager.Release(clinicName).ToString().ToLowerInvariant());
            }
            else if (input[0].Equals("HasEmptyRooms"))
            {
                clinicName = input[1];

                Console.WriteLine(manager.HasEmptyRooms(clinicName).ToString().ToLowerInvariant());
            }
            else
            {
                clinicName = input[1];

                if (input.Length == 3)
                {
                    var room = int.Parse(input[2]);
                    manager.Print(clinicName, room);
                }
                else
                {
                    manager.Print(clinicName);
                }

            }
        }

        class Database
        {
            private readonly ICollection<Clinic> _clinics;
            private readonly ICollection<Pet> _pets;
            private readonly ICollection<Room> _rooms;

            public ICollection<Clinic> Clinics => _clinics;
            public ICollection<Pet> Pets => _pets;
            public ICollection<Room> Rooms => _rooms;

            public Database()
            {
                _clinics = new HashSet<Clinic>();
                _pets = new HashSet<Pet>();
                _rooms = new HashSet<Room>();
            }
        }

        abstract class Store<T>
        {
            public abstract void Create(T item);
        }

        interface IPetStore
        {
            Pet FindByName(string name);
        }

        interface IClinicStore
        {
            Clinic FindByName(string name);
        }

        class PetStore : Store<Pet>, IPetStore
        {
            private readonly Database _database;

            public override void Create(Pet item)
            {
                _database.Pets.Add(item);
            }

            public Pet FindByName(string name)
            {
                var pet = _database.Pets.First(p => p.Name.Equals(name));

                if (pet is null)
                    throw new InvalidOperationException("Invalid Operation!");

                return pet;
            }

            public PetStore(Database database)
            {
                _database = database;
            }
        }

        class ClinicStore : Store<Clinic>, IClinicStore
        {
            private readonly Database _database;

            public override void Create(Clinic item)
            {
                _database.Clinics.Add(item);
            }

            public Clinic FindByName(string name)
            {
                return _database.Clinics.First(c => c.Name.Equals(name));
            }

            public ClinicStore(Database database)
            {
                _database = database;
            }
        }

        class Manager
        {
            private PetStore _petStore;
            private ClinicStore _clinicStore;


            public void CreatePet(string name, int age, string kind)
            {
                _petStore.Create(new Pet(name, age, kind));
            }

            public void CreateClinic(string name, int rooms)
            {
                _clinicStore.Create(new Clinic(rooms, name));
            }

            public bool Add(string petName, string clinicName)
            {
                var clinic = _clinicStore.FindByName(clinicName);
                var pet = _petStore.FindByName(petName);

                return clinic.AddPet(pet);
            }

            public bool Release(string clinicName)
            {
                var clinic = _clinicStore.FindByName(clinicName);

                return clinic.Release();
            }

            public bool HasEmptyRooms(string clinicName)
            {
                var clinic = _clinicStore.FindByName(clinicName);

                return clinic.HasEmptyRooms();
            }

            public void Print(string clinicName, int room)
            {
                var clinic = _clinicStore.FindByName(clinicName);

                clinic.Print(room);
            }

            public void Print(string clinicName)
            {
                var clinic = _clinicStore.FindByName(clinicName);

                clinic.Print();
            }

            public Manager(PetStore petStore, ClinicStore clinicStore)
            {
                _petStore = petStore;
                _clinicStore = clinicStore;
            }

        }

        class Room
        {
            private Pet _pet;

            public Pet Pet
            {
                get => _pet;
                private set => _pet = value;
            }

            public bool IsFree => _pet is null;

            public bool TreatPet(Pet pet)
            {
                if (!this.IsFree)
                    return false;

                _pet = pet;
                return true;
            }

            public bool Release()
            {
                if (this.IsFree)
                    return false;

                _pet = default(Pet);
                return true;
            }

            public override string ToString()
            {
                var sb = new StringBuilder("Room empty");

                if (!this.IsFree)
                    sb.Clear()
                        .Append(_pet);

                return sb.ToString();
            }
        }

        class Clinic
        {
            public IList<Room> Rooms { get; }
            public string Name { get; }

            public bool AddPet(Pet pet)
            {
                var center = this.Rooms.Count / 2;
                var currentRoom = center;

                var step = 0;
                var stepsTaken = 0;
                var goLeft = true;

                while (!this.Rooms[currentRoom].IsFree && step <= center)
                {
                    if (goLeft)
                    {
                        currentRoom = center - step;
                    }
                    else
                    {
                        currentRoom = center + step;
                    }

                    goLeft = !goLeft;

                    stepsTaken++;

                    if (stepsTaken != 2)
                        continue;

                    step++;
                    stepsTaken = 0;
                }

                return this.Rooms[currentRoom].TreatPet(pet);
            }

            public bool Release()
            {
                var center = Rooms.Count / 2;
                if (this.Rooms[center].Release())
                {
                    return true;
                }

                var currentRoom = center;
                do
                {
                    if (this.Rooms[currentRoom].Release())
                        return true;

                    currentRoom = ++currentRoom % this.Rooms.Count;
                } while (this.Rooms.Count - 1 > currentRoom);

                return false;
            }

            public void Print(int room)
            {
                Console.WriteLine(this.Rooms[room - 1]);
            }

            public void Print()
            {
                foreach (var room in this.Rooms)
                {
                    Console.WriteLine(room);
                }
            }

            public bool HasEmptyRooms()
            {
                return this.Rooms.Any(r => r.IsFree);
            }

            public Clinic(int rooms, string name)
            {
                if (rooms % 2 == 0)
                    throw new InvalidOperationException("Invalid Operation!");

                this.Rooms = new List<Room>();
                for (int i = 0; i < rooms; i++)
                {
                    this.Rooms.Add(new Room());
                }

                Name = name;
            }
        }

        class Pet
        {
            public string Name { get; }
            public int Age { get; }
            public string Kind { get; }

            public override string ToString()
            {
                return new StringBuilder($"{this.Name} {this.Age} {this.Kind}").ToString();
            }

            public Pet(string name, int age, string kind)
            {
                Name = name;
                Age = age;
                Kind = kind;
            }
        }
    }
}

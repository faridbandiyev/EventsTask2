using System;
using System.Collections;

namespace ImplementCommonInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People people = new People
            {
                new Person(1, "Elvin", 33),
                new Person(2, "Musa", 25)
            };

            foreach (Person person in people)            
            {
                Console.WriteLine(person);
            }
            
        }

        class People : IEnumerable<Person>
        {
            public List<Person> _people = new List<Person>();

            public Person this[int index] => _people[index];

            public void Add(Person person)
            {
                _people.Add(person);
            }

            public IEnumerator<Person> GetEnumerator()
            {
                foreach (Person person in _people)
                {
                    yield return person;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }

        class Person : IComparable<Person>, IEquatable<Person>, ICloneable
        {
            public Person()
            {
                    
            }

            public Person(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }

            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public Person Manager { get; set; } 


            public object Clone()
            {
                var person = new Person();
                person.Id = Id;
                person.Name = Name;
                person.Age = Age;

                if (Manager != null)
                    person.Manager = (Person)Manager.Clone();

                return person;
            }

            public int CompareTo(Person? other)
            {
                if (other == null) throw new ArgumentException("Is null");

                return Name.CompareTo(other.Name);
            }

            public bool Equals(Person? other)
            {
                return Name == other.Name && Id == other.Id && Age == other.Age;
            }

            public override string ToString()
            {
                return $"{Id} {Name} {Age}";
            }
        }

        class PersonComparer : IComparer<Person>
        {
            public enum CompareField
            {
                Name,
                NameAndAge,
                Id,
                Age
            }

            public CompareField SortBy;

            public int Compare(Person? x, Person? y)
            {
                switch (SortBy)
                {
                    case CompareField.Id:
                        return x.Id.CompareTo(y.Id);
                    case CompareField.Name:
                        return x.Name.CompareTo(y.Name);
                    case CompareField.Age:
                        return x.Age.CompareTo(y.Age);
        
                    default: throw new ArgumentException();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Person
    {
        public Person(string name, string surname, int age, int height, int weight)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;

        }

        public string Name { get; set; }
        public string Surname { get; set;}
        public int Height { get; set;}
        public int Weight { get; set;}
        public int Age { get; set;}

        public void ToStirng()
        {
            Console.WriteLine( $"Name: {Name}, Surname: {Surname}, Age:  {Age}, Height: {Height}, Weight:  {Weight}");

        }
        
    }
}

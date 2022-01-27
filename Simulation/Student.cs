using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
   internal class Student:Human
    {
        public Student(string name) : base(name) { }
        public override void Evacuation()
        {
            Console.WriteLine($"Студент {Name} встает, собирает вещи," +
                $"организованно") ;
        }
        public override string ToString()
        {
            return $"Студент {Name}";
        }
    }
}

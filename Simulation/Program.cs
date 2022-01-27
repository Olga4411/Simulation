using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //сделаем симуляцию двух систем:
            //1. система пожарной трев-ги

            Human human = new Teacher(" Василий Васильевич");
            Console.WriteLine(human);

            human.Evacuation();
            

            human = new Student("Петя");
            Console.WriteLine(human);
            human.Evacuation();

            Console.ReadLine();
        }
    }
}

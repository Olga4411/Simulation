using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    class Program
    {
        // тестирование пожарной системы
        static void TestFireSystem()
        {
            // 1.создадим учителя
            Teacher teacher = new Teacher("Борис Глебыч ");
            // создадим студентов
            Student[] students = new Student[]
            {
                new Student("Миша"),
                new Student("Маша")
            };

            //3 подключаем наши объекты к пожарной системе
            //3/1 подключаем учителя
            FireSystem.alarm += teacher.Evacuation;
            //3/2 подключаем учеников
            foreach(Student student in students)
            FireSystem.alarm += student.Evacuation;
            // 4.симилируем пожар
            while (FireSystem.checkSmokeLevel()==false)
            {
                Console.WriteLine($"Все нормально, дыма нет");
            }
            Console.WriteLine("Случился пож-р");
            //5. симилируем ложное
            while (FireSystem.checkSmokeLevel() == false)
            {
                Console.WriteLine($"Ай ай горим");
            }
            Console.WriteLine("Фуу  ложное срабатывание");
        }
        static void Main(string[] args)
        {
            //сделаем симуляцию двух систем:
            //1. система пожарной трев-ги

            //Human human = new Teacher(" Василий Васильевич");
            //Console.WriteLine(human);

            //human.Evacuation();


            //human = new Student("Петя");
            //Console.WriteLine(human);
            //human.Evacuation();
            //TestFireSystem();

            
            Console.ReadLine();
        }
    }
}

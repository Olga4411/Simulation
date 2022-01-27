using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{// класс наследууется
    internal class Teacher:Human
    {
        
        public Teacher(string name) : base(name) { }
        // переопределяем метод эвакуции для учителя
        public override void Evacuation()
        {
            Console.WriteLine($"Учитель {Name} встает, закрывает окна," +
                $"организовывает группу на эвакуацию," +
                $"выходит последним из аудитории");
        }
            // Метод получения объекта в виде строки
            public override string ToString()
        {
            return $"Учитель {Name}";
        }

    }

    
}

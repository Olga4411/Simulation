using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    // Базовый класс
    internal abstract class Human
    {
        //задаем имя человке-общее
        public string Name { get; set; }
        // конструктор
        public Human (string name)
        {
            Name = name;//инициализация
        }
        // абстрактный метод симуляции эвак-и
        public abstract void Evacuation();

        // Метод симуляции отмены 
        public void DeclainEvakuation()
        {
            Console.WriteLine($"{Name} отменил эвакуацию");
        }
    }
}

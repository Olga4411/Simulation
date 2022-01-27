using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    //класс, симулирующий систему оповещения о пожарной тревоги
  internal class FireSystem
    {
        // нужен делегат, который будет хранить методы
        // объявление делегата
        public delegate void AlarmDelegate();

        // экземпляр делегата тревоги
        // Поле сущетсвует без класса
        //Статическое поле -поле, принадлежит не объекту класса,а  в целом к классу
        public static AlarmDelegate alarm = null;
    }
}

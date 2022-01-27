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
        // метод, который симулирует срабатыывание тревоги
        public static bool checkSmokeLevel()
        {
            //рандомная заглушка
            Random random = new Random(DateTime.Now.Millisecond);
            if (random.Next(1,5)==3)
            {
                // Пожар
                makeAlarm();// вызываем оповещение
                return true;
            }
            return false;
        }
        // методы оповещения всех подписчиков о пожаре
        public static void makeAlarm()
        {
            //if(alarm !=null)// если есть кого оповещать
            //{
            //    alarm.Invoke();//вызов
            //}
            alarm?.Invoke();// Идентичный коду выше
            //InVoke вызовет все делегаты
        }
    }
}

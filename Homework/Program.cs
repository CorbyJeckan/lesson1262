using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Programm
    {
        static void Main(string[] args)
        {

          Console.WriteLine("Введите максимальную и минимальную суточную температуру");
            
            int maxtemp, mintemp;
            
            Console.WriteLine("Введите максимальную температуру за сутки");
            
            maxtemp = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите минимальную температру за сутки");
            
            mintemp = Convert.ToInt32(Console.ReadLine());

            int result = (maxtemp + mintemp) / 2;

            Console.WriteLine("Средняя температура за сутки = " + result );

            //Задание № 2

            Console.WriteLine("Введите порядковый номер текущего месяца");

            int n = int.Parse(Console.ReadLine());
            if (n == 1)
                Console.WriteLine("Месяц под номером " + n + " : Январь");
            if (n == 2)
                Console.WriteLine("Месяц под номером " + n + " : Февраль");
            if (n == 3)
                Console.WriteLine("Месяц под номером " + n + " : Март");
            if (n == 4)
                Console.WriteLine("Месяц под номером " + n + " : Апрель");
            if (n == 5)
                Console.WriteLine("Месяц под номером " + n + " : Май");
            if (n == 6)
                Console.WriteLine("Месяц под номером " + n + " : Июнь");
            if (n == 7)
                Console.WriteLine("Месяц под номером " + n + " : Июль");
            if (n == 8)
                Console.WriteLine("Месяц под номером " + n + " : Август");
            if (n == 9)
                Console.WriteLine("Месяц под номером " + n + " :  Сентябрь");
            if (n == 10)
                Console.WriteLine("Месяц под номером " + n + " : Октябрь");
            if (n == 11)
                Console.WriteLine("Месяц под номером " + n + " : Ноябрь");
            if (n == 12)
                Console.WriteLine("Месяц под номером " + n + " : Декабрь");
            Console.ReadKey();


        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Классы в.Net.Класс - инструмент для создания ссылочных типов в .Net.
    Класс по умолчанию имеет модификатор  internal (доступ только в текущем проекте-сборке).
    Поля класса, методы класса по умолчанию приватные как и в c++.
Наш тип от родителя object получает набор готовых методов среди которых есть ToString
Данный метод выполняет пребразование нашего типа к строке.Для переопределения используется
ключевое слово override*/

namespace Classbeg
{
    
    class Program
    {
        static void Main(string[] args)
        {
           /* City a = new City("Ivan",20);//Stud *a;*/
            City city1 = new City();
            city1.NameCity = "Kiev";
            city1.NameCountry = "Ukraine";
            city1.NameRegion = "Kievska obl";
            city1.People = 4500000;
            city1.Phone = 380;
            Console.Write(city1);
            Console.ReadLine();
        }
    }
}

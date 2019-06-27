using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.

namespace CW_1._3_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            int sm, m;
            Console.WriteLine("Введите расстояние в сантиметрах:");
            string textAsNum = Console.ReadLine();
            sm = int.Parse(textAsNum);
            m = sm/100;
            Console.Write("Число полных метров: ");
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}

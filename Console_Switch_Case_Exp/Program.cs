using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Switch_Case_Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.Sayiyi giriniz:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2.Sayiyi Giriniz:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1-Toplama\n2-Fark\n3-Carpim\n4-Oran");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine(number1 + number2);
                    break;
                case 2:
                    Console.WriteLine(Math.Abs(number1 - number2));
                    break;
                case 3:
                    Console.WriteLine(number1 * number2);
                    break;
                case 4:
                    Console.WriteLine(number1 / number2);
                    break;

            }

            Console.ReadKey();

        }
    }
}

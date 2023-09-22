using System;
using System.Globalization;

namespace Course
{
    class URI1008
    {
        static void Main(string[] args)
        {

            double number, HorasTrabalhadas, salary, ValorHora;

            number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            HorasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = ValorHora * HorasTrabalhadas;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();


        }
    }
}
using System;
using System.Globalization;

namespace Salary
{
    class Program
    {
        static void Main()
        {
            int cod = int.Parse(Console.ReadLine());

            int horas = int.Parse(Console.ReadLine());
            
            decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            decimal sal = horas * valor;

            Console.WriteLine($"NUMBER = {cod}");
            Console.WriteLine($"SALARY = {sal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

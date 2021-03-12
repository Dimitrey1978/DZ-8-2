using System;

namespace DZ_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество клиентов (до 20): ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            long numberPaths = Faktorial(quantity);
            Console.WriteLine($"Количество вариантов маршрутов: {numberPaths}");

        }

        static long Faktorial (int A)
        {
            if (A != 0)
                {
                return A*Faktorial(A-1);
            }
            else
                return 1;
        }
    }
}

using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string xs = null;
            double x = 0; 

            Console.WriteLine("Функция вида ln(1+x), где x пренадлежит промежутку от - 1 до +1 \nвведите x: ");
            try
            {
                xs = Console.ReadLine();
                x = double.Parse(xs);
                Console.WriteLine(ln(x));
            }
            catch (Exception)
            {
                try
                {
                    x = double.Parse(xs, System.Globalization.CultureInfo.InvariantCulture);
                    Console.WriteLine(ln(x));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

            }
            
        }
        static double ln(double x)
        {
            if (-1 < x && x < 1 )
            { 
                double ln = x,
                        hashX = x,
                        counter = 2,
                        y = 0;
                do
                {
                    hashX *= x;
                    y = hashX / counter;
                    if (counter % 2 == 0)
                        ln -= y;
                    else
                        ln += y;
                    counter++;
                }
                while (y > 1e-7);
                return ln;
            }
            else
            {
                return -1;
            }
        }
    }
}

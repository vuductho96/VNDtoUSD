using System;

namespace UsdToVNd
{
    class UsdToVNd
    {
        static void Main(string[] args)
        {
            const int Rate = 23000;

            Console.Write("Enter the amount of USD you have: ");
            float USD = float.Parse(Console.ReadLine());

            Console.WriteLine("You entered: " + USD.ToString("C") + " USD");

            float Result = USD * Rate;
            Console.WriteLine("The amount in VND is: " + Result.ToString("C") + " VND");
        }
    }
}


using System;

namespace udemy
{
    class Program
    {
        static void Main(string[] args)
        {
 //Converting angles to radian

            
            const int PI = 180;
            double radian;

            Console.WriteLine("Enter angle - ");
            double angle = double.Parse(Console.ReadLine());

            radian = angle / PI;
            Console.WriteLine("Your answer is - {0}", radian);
            



           
        }
    }
}

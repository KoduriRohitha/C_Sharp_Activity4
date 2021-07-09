using System;

namespace Robot_Barman
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(drinks / shelves);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("At least 1 shelf");
            }


            catch (Exception e)
            {
                Console.WriteLine("Please insert an integer");
            }
        }
    }
}

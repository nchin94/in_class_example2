using System;

namespace in_class_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many years experience do you have in professional programming:");
            int years = Convert.ToInt32(Console.ReadLine());
            int index = 0;

            while (index <= years)
            {
                Console.WriteLine("You have " +index + " of experience");
                index++;
            }
             
        }
    }
}

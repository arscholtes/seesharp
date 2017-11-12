using System;

namespace work_tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band?");
            string name = Console.ReadLine();

            Console.WriteLine("How many people are in your band?");
            int numberOfMembers = 0;
            if (!int.TryParse(Console.ReadLine(), out numberOfMembers));
            {
                Console.WriteLine("input was not valid");
                Enviornment.Exit(0);
            }


            Console.WriteLine(name + " has " + numberOfMembers + " talented musicians.");
        }
    }
}

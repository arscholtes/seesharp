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
            int.TryParse(Console.ReadLine(), out numberOfMembers);
            if(numberOfMembers == 0)
                Console.WriteLine("You must have atleast 1 member in your band.");
            else if(numberOfMembers == 1)
                Console.WriteLine(name + " is a solo.");
            else if(numberOfMembers == 2)
                Console.WriteLine(name + " is a duo.");
            else
                Console.WriteLine(name + " has " + numberOfMembers + "members.");


            Console.WriteLine(name + " has " + numberOfMembers + " talented musicians.");
        }
    }
}

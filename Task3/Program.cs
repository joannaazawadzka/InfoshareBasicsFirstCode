using System.ComponentModel.Design;
using System.Security.Claims;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = -1;

            if (age >= 18)
            {
                Console.WriteLine("Jestes dorosly");
            }
            else if (age < 18 && age >= 0)
            {
                Console.WriteLine("Jestes dzieckiem");
            }
            else 
            {
                Console.WriteLine("Blad");
            }
                

            
        }
    }
}

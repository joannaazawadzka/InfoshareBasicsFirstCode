namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 55;
            char sex = 'M';

            if (age >= 18 && sex == 'K')
            {
                Console.WriteLine("Jestes kobieta");
            }   
            else if (age >=18 && sex == 'M')
            {
                Console.WriteLine("Jestes mezczyzna");
            }
            else if (age <18 && age >=0) 
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

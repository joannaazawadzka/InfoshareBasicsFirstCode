namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;
            char sign = '+';
            double result = 0;
            
            switch (sign)
            {
                case '+':
                    result = a + b; 
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':       
                    result = a * b; 
                    break;
                case '/':
                    result = a / b;
                    break;

            }
            Console.WriteLine(result);
        }
    }
}

// ------------------------------
// Uebung_1_2
// ------------------------------

namespace Uebung_1_2;

class Program
{
    static void Main(string[] args)
    {
       for(int i = 0; i <= 100; i++)
        {
            if(i%3 != 0 && i%5 != 0)
            {
                Console.WriteLine($"{i}\n");
            }
            else if(i%3 == 0 && i%5 != 0)
            {
                Console.WriteLine("Fizz\n");
            }
            else if(i%3 != 0 && i%5 == 0)
            {
                Console.WriteLine("Buzz\n");
            }
            else
            {
                Console.WriteLine("FizzBuzz\n");
            }
        }
    }
}

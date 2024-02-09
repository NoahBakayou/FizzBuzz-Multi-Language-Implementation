namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) //updates i by 1 ever loop
            {
                if (i % 3 == 0 && i % 5 == 0){ //checks if value is a multiple of 3 and 5
                    Console.WriteLine("FizzBuzz!");
                }
                else if (i % 3 == 0){ //check if i is a multiple of 3
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0){ //check if i is a multiple of 5
                    Console.WriteLine("Buzz");
                }
                else{
                    Console.WriteLine(i); //else just prints i 
                }
            }
        }
    }
}

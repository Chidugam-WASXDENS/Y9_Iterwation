using System.IO.Pipes;

namespace Y9_Iterwation
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int myAge = 8;
            string boom = "Boom";
            string word = "Crash";
            // Definite iteration below
            for (int i = 0; i <= 10; i++) // 3 parameters
            {
            Console.WriteLine(i);
            }
            // Indefinite iteration below
            // While loops will run 0 or more times
            while (myAge == 27)
            {
                Console.WriteLine(myAge);
                Console.WriteLine(boom);
                //myAge = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("I'm FREE!!!");
            // Do loops will run one or more rimes
            //do
            //{
            //    while (myAge == 27)
            //    {
            //        Console.WriteLine(myAge);
            //    }
            //    } while (myAge == 27);


            // Switch case statements
            // Try using them with ranges
            switch (myAge)
            {
                case > 27:
                    Console.WriteLine("You are over 27 years old");
                    break;
                case 26:
                    Console.WriteLine("You are 26 years old");
                    break;
                default:
                    Console.WriteLine("You are not 26 or 27 years old");
                    break;

            }
            switch (myAge) {
                case < 5 :
                    Console.WriteLine("You are probably in nursery");
                    break;
                case int i when i > 4 && i < 7:
                    Console.WriteLine("You are in KS1");
                    break;
                case 
            
            }
        }
    }
}

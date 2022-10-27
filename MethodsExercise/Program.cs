using System.Reflection.Metadata;

namespace MethodsExercise
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("What is your name?");

            String userName = Console.ReadLine();
            Console.ReadLine();
            if (userName == "Dakota")
            {
                Console.WriteLine("hey whats good Dakota!");
            }
            else
            {
                Console.WriteLine($"You're not Dakota!Intruder! sike, how are you {userName}");
            }
            Console.WriteLine("What is your favorite color?");

            String favoriteColor = Console.ReadLine();
            Console.ReadLine();
            if (favoriteColor == "Black")
            {
                Console.WriteLine("thats a great color!");
            }
            else
            {
                Console.WriteLine($"thats not as good as the color Black!");

            }
            Console.WriteLine("What is your favorite Animal?");

            String favoriteAnimal = Console.ReadLine();
            Console.ReadLine();
            if (favoriteAnimal == "Honey Badger")
            {
                Console.WriteLine("yea they are vicious little monsters!");
            }
            else
            {
                Console.WriteLine($"Boo i bet a honey badger could beat it!");

            }
            Console.WriteLine("who is your favorite band?");

            string favoriteBand = Console.ReadLine();
            Console.ReadLine();
            if (favoriteBand == "NWA")
            {
                Console.WriteLine("EasyE and IceCube are dope!");
            }
            else
            {
                Console.WriteLine($"wow ive never heard of them before!");

            }
            Console.WriteLine($"Hey {userName}, i heard {favoriteColor} was the best color!, did you know {favoriteAnimal} is also {favoriteColor}? they give off {favoriteBand} kind of attitude as well!");


            var sum = Sum(2, 4);
            Console.WriteLine($"Sum of 2 and 4: {sum}");

            var multiplyResult = Multiply(4, 5);
            Console.WriteLine($"Multiplying 4 and 5 gives {multiplyResult}");
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }


        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}


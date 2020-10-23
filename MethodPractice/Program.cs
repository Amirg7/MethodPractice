using System;

namespace MethodPractice
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
            
        }
        public static int Multiplication(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }
        static void Main(string[] args)
        {
            var amountOfCar = Sum(2, 6);
            var productOfCar = Multiplication(10, 2);

            Console.WriteLine(amountOfCar);
            Console.WriteLine(Sum(2,2));
            Console.WriteLine(productOfCar);
            Console.WriteLine(Multiplication(10, 2));

            
               
            
       
                //-----------exercise 1------------
                //Name: Michael
                //Favorite Color: Blue
                // Favorite Animal: Walrus
                //Favorite Band: The Beatles

                Console.WriteLine("Hello - What is your first name?");
                var userName = Console.ReadLine();

                Console.WriteLine($"Hi, {userName} What is your favorite color?");
                var color = Console.ReadLine();

                Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
                var animal = Console.ReadLine();

                Console.WriteLine("Great! What is your favorite band?");
                var band = Console.ReadLine();

                Console.WriteLine($"Thanks, {userName}! Here is your profile");
                Console.WriteLine("------------------");


                Console.WriteLine($"Name: {userName}");
                Console.WriteLine($"Favorite color: {color}");
                Console.WriteLine($"Favorite Animal: {animal}");
                Console.WriteLine($"Favorite Band: {band}");

                //-----------exercise 2------------




            }
        }
    }
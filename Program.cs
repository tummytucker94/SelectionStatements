using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                The purpose of this exercise is to allow a user
                to play a game where they must guess what your favorite number
                is
            */

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favNumber){
                Console.WriteLine("too low!");
            }else if(userInput > favNumber){
                Console.WriteLine("too high!");
            }else{
                Console.WriteLine("Nevermind!");
            }

            var favoriteSubject = Console.ReadLine();
            switch(favoriteSubject){
                case "Math":
                    Console.WriteLine("Mathematics is a great subject.");
                    break;
                case "Technology":
                    Console.WriteLine("Technology is Techn-awesome.");
                    break;
                case "Science":
                    Console.WriteLine("Did you know science means\"knowledge\" in Latin?");
                    break;
                case "Engineering":
                    Console.WriteLine("Engineering is applying the science and math to real-world problems.");
                    break;
                default:
                    Console.WriteLine($"{favoriteSubject} is a great subject.");
                    break;
            }
        }
    }
}

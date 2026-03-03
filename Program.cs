using System;

namespace SeaShark_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects
            Player player = new Player("Eavan");
            Quiz quiz = new Quiz("Which keyword is used to define a class in C#?", 1);

            // GameManager handles interaction
            GameManager game = new GameManager(player, quiz);

            // Start game
            game.StartGame();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
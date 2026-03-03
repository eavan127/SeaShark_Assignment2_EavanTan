using System;

namespace SeaShark
{
    // The main program class that acts as the entry point
    class Program
    {
        // Main method where the execution begins
        static void Main(string[] args)
        {
            // Initialize a new player named "SeaShark"
            Player player = new Player("SeaShark");
            
            // Create a GameManager instance and pass the player into it
            GameManager game = new GameManager(player);

            // Start the main game logic
            game.StartGame();

            // Wait for user to press a key before closing the console window
            Console.ReadKey();
        }
    }
}
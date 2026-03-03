using System;

namespace SeaShark
{
    // The main program class that acts as the entry point
    class Program
    {
        // Main method where the execution begins
        static void Main(string[] args)
        {
            // Ask the user to type their own player name
            Console.Write("Enter your player name: ");
            string playerName = Console.ReadLine(); // Read the name typed by the user

            // Validate that the name is not empty; use a default name if nothing is entered
            if (string.IsNullOrWhiteSpace(playerName))
            {
                playerName = "Player"; // Default name if nothing is entered
            }

            // Initialize a new player with the name entered by the user
            Player player = new Player(playerName);

            // Create a GameManager instance and pass the player into it
            GameManager game = new GameManager(player);

            // Start the main game logic
            game.StartGame();

            // Wait for user to press a key before closing the console window
            Console.ReadKey();
        }
    }
}
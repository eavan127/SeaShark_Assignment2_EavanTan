using System;

namespace SeaShark
{
    // Manages the overall game flow, state, and interaction between objects
    public class GameManager
    {
        // Private fields to maintain game state (Encapsulation)
        private Player player; // Reference to the current player

        // Constructor to initialize GameManager with a player
        public GameManager(Player p)
        {
            player = p; // Assign the provided player to the private field
        }

        // Method to start the game sequence
        public void StartGame()
        {
            // Display game title and player name
            Console.WriteLine("\n===== SEA SHARK GAME =====");
            Console.WriteLine($"Player: {player.PlayerName}");

            // Initialize the first level as BeginnerLevel
            // The timer is now managed inside the Level class
            Level currentLevel = new BeginnerLevel();

            // Start the level, this also starts the timer
            currentLevel.StartLevel();
            // Load and run the quiz for the beginner level, retry until all correct
            currentLevel.LoadQuiz();

            // Check if the beginner level was successfully completed
            if (currentLevel.Completed)
            {
                // Transition to the advanced level
                Console.WriteLine("Unlocking Advanced Level...");
                Console.WriteLine();

                // Create a new AdvancedLevel (Polymorphism)
                currentLevel = new AdvancedLevel();
                // Start the advanced level, this also starts its own timer
                currentLevel.StartLevel();
                // Load and run the quiz for the advanced level, retry until all correct
                currentLevel.LoadQuiz();
            }

            // Finish the game
            EndGame();
        }

        // Method to handle end of the game's logic
        public void EndGame()
        {
            Console.WriteLine("\n===== GAME OVER ====="); // Display game over message
            Console.WriteLine("Thank you for playing SeaShark!");
        }
    }
}
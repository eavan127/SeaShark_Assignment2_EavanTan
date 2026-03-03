using System;

namespace SeaShark
{
    // Manages the overall game flow, state, and interaction between objects
    public class GameManager
    {
        // Private fields to maintain game state (Encapsulation)
        private Player player; // Reference to the current player
        private Level currentLevel; // The level currently being played
        private Timer timer; // Timer to track gameplay time

        // Constructor to initialize GameManager with a player
        public GameManager(Player p)
        {
            player = p; // Assign the provided player to the private field
        }

        // Method to start the game sequence
        public void StartGame()
        {
            // Display game title and player name
            Console.WriteLine("===== SEA SHARK GAME =====");
            Console.WriteLine($"Player: {player.PlayerName}");

            // Initialize the first level as BeginnerLevel
            currentLevel = new BeginnerLevel();
            // Set the timer for 300 seconds (5 minutes) for the Beginner level
            timer = new Timer(300);

            // Start the timer and the current level
            timer.StartTimer();
            currentLevel.StartLevel();
            // Load and display the quiz for the beginner level
            currentLevel.LoadQuiz();

            // Check if the current level was successfully completed
            if (currentLevel.Completed)
            {
                // Transition to the advanced level
                Console.WriteLine("Unlocking Advanced Level...");
                // Reassign currentLevel to AdvancedLevel (Polymorphism)
                currentLevel = new AdvancedLevel();
                // Reset timer to 420 seconds (7 minutes) for the Advanced level
                timer = new Timer(420);
                timer.StartTimer(); // Start the new timer for advanced level
                currentLevel.StartLevel();
                // Load and display the quiz for the advanced level
                currentLevel.LoadQuiz();
            }

            // Finish the game
            EndGame();
        }

        // Method to handle end-of-game logic
        public void EndGame()
        {
            Console.WriteLine("\nGame Over."); // Display game over message
        }
    }
}
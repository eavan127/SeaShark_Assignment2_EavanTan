using System;

namespace SeaShark
{
    // Manages the overall game flow, state, and interaction between objects
    public class GameManager
    {
        // Private fields to maintain game state (Encapsulation) 
        private Player player;         // Reference to the current player 
        private Level currentLvl;      // The level currently being played 
        private Timer timer;           // Timer to track gameplay time 

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
            currentLvl = new BeginnerLevel();
            // Set the timer for 300 seconds (5 minutes) for the Beginner level
            timer = new Timer(300);

            // Start the level, this also starts its internal timer
            currentLvl.StartLevel();
            // Load and run the quiz for the beginner level, retry until all correct
            currentLvl.LoadQuiz();

            // Check if the beginner level was successfully completed
            if (currentLvl.Completed)
            {
                // Use the Unlock method to transition to the next level
                Unlock();
            }

            // Finish the game
            End();
        }

        // Method to restart the player's position 
        public void RestartPosition()
        {
            player.ResetPosition(); // Calls the player's ResetPosition method
            Console.WriteLine("Player position has been restarted.");
        }

        // Method to unlock and transition to the next level 
        public void Unlock()
        {
            Console.WriteLine("Unlocking Advanced Level...");
            Console.WriteLine();

            // Create a new AdvancedLevel (Polymorphism)
            currentLvl = new AdvancedLevel();
            // Set the timer for 420 seconds (7 minutes) for the Advanced level
            timer = new Timer(420);

            // Start the advanced level, this also starts its own timer
            currentLvl.StartLevel();
            // Load and run the quiz for the advanced level, retry until all correct
            currentLvl.LoadQuiz();
        }

        // Method to handle end-of-game logic
        public void End()
        {
            Console.WriteLine("\n===== GAME OVER ====="); // Display game over message
            Console.WriteLine("Thank you for playing SeaShark!");
        }
    }
}
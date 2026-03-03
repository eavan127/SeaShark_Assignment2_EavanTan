using System;

namespace SeaShark
{
    // The Player class represents the user playing the Sea Shark game.
    // It stores the player's state and controls player-related actions.
    public class Player
    {
        // Private Fields (Encapsulation)
        // These fields cannot be accessed directly from outside the class.
        private string playerName;   // Stores the name of the player
        private int currentPosition; // Tracks the player's position on the map
        private int currentLevel;    // Tracks the current level the player is on
        private int collectedKeys;   // Tracks the number of keys the player has collected

        // Public Properties
        // Provide controlled reading and writing access to private fields
        // Property to get the player's name which is read-only access from outside
        public string PlayerName
        {
            get { return playerName; }
        }

        // Property to get or set the player's current level
        public int CurrentLevel
        {
            get { return currentLevel; }
            set
            {
                if (value > 0) // Simple validation to ensure level is always positive
                {
                    currentLevel = value;
                }
            }
        }

        // This is the Constructor
        // Called when a new Player object is created
        public Player(string name)
        {
            playerName = name;     // Set the provided name
            currentPosition = 0;   // Start at position 0
            currentLevel = 1;      // Start at level 1
            collectedKeys = 0;     // Start with 0 keys
        }

        // These are the public Method to define behaviors for the Player
        // Method to simulate the player moving forward
        public void MoveForward()
        {
            currentPosition++; // Increase current position
            Console.WriteLine($"{playerName} moved forward to position {currentPosition}");
        }

        // Method to reset the player's position to the beginning
        public void ResetPosition()
        {
            currentPosition = 0; // Set the position back to 0
            Console.WriteLine($"{playerName} returned to the starting position.");
        }

        // Method to simulate the player to collect a key
        public void CollectKey()
        {
            collectedKeys++; // Increment key count
            Console.WriteLine($"{playerName} collected a key! Total keys: {collectedKeys}");
        }
    }
}
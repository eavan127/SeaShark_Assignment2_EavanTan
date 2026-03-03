using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaShark_Assignment2
{
    // The Player class represents the user playing the Sea Shark game.
    // It stores the player's state and controls player-related actions.
    public class Player
    {
        // =========================
        // Private Fields (Encapsulation)
        // These fields cannot be accessed directly from outside the class.
        // =========================
        private string playerName;
        private int currentPosition;
        private int currentLevel;
        private int collectedKeys;

        // =========================
        // Public Properties
        // Provide controlled access to private fields
        // =========================

        public string PlayerName
        {
            get { return playerName; }
        }

        public int CurrentLevel
        {
            get { return currentLevel; }
            set
            {
                if (value > 0) // simple validation
                {
                    currentLevel = value;
                }
            }
        }

        // =========================
        // Constructor
        // =========================
        public Player(string name)
        {
            playerName = name;
            currentPosition = 0;
            currentLevel = 1;
            collectedKeys = 0;
        }

        // =========================
        // Methods
        // =========================

        public void MoveForward()
        {
            currentPosition++;
            Console.WriteLine($"{playerName} moved forward to position {currentPosition}");
        }

        public void ResetPosition()
        {
            currentPosition = 0;
            Console.WriteLine($"{playerName} returned to the starting position.");
        }

        public void CollectKey()
        {
            collectedKeys++;
            Console.WriteLine($"{playerName} collected a key! Total keys: {collectedKeys}");
        }
    }
}
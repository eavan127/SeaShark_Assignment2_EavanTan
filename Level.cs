using System;

namespace SeaShark
{
    // Abstract base class representing a generic game level (Abstraction + Encapsulation)
    public abstract class Level
    {
        // Protected fields accessible by derived classes (e.g., BeginnerLevel, AdvancedLevel)
        protected int difficultyIndex; // The difficulty rating of the level
        protected int timeLimit;       // Allowed time to complete the level
        protected bool completed;      // Tracks if the level has been successfully finished
        protected Quiz quiz;           // The quiz associated with this level

        // Public property to check if the level is completed
        public bool Completed => completed;

        // Constructor to initialize the level's basic properties
        public Level(int difficulty, int time)
        {
            difficultyIndex = difficulty; // Set the level difficulty
            timeLimit = time;             // Set the time limit
            completed = false;            // Level is initially not completed
        }

        // Method to visually indicate the start of the level
        public void StartLevel()
        {
            Console.WriteLine($"\nStarting Level {difficultyIndex}");
        }

        // Method called when the level is successfully beaten
        public void CompleteLevel()
        {
            completed = true; // Mark as done
            Console.WriteLine("Level Completed!");
        }

        // Abstract method meant to be overridden by derived classes (Polymorphism)
        // This forces each specific level to define its own quiz-loading logic
        public abstract void LoadQuiz();
    }
}
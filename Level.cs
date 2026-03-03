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
        protected Timer timer;         // Timer to track time during this level

        // Public property to check if the level is completed
        public bool Completed => completed;

        // Constructor to initialize the level's basic properties
        public Level(int difficulty, int time)
        {
            difficultyIndex = difficulty; // Set the level difficulty
            timeLimit = time;             // Set the time limit
            completed = false;            // Level is initially not completed
            timer = new Timer(time);      // Create a timer with the level's time limit
        }

        // Method to visually indicate the start of the level and begin the timer
        public void StartLevel()
        {
            Console.WriteLine($"\nStarting Level {difficultyIndex}");
            timer.StartTimer(); // Start the countdown timer when the level begins
        }

        // Method called when the level is successfully beaten
        public void CompleteLevel()
        {
            timer.StopTimer();         // Stop the timer when the level is completed
            completed = true;          // Mark as done
            Console.WriteLine("Level Completed!");
            timer.DisplayTimeSummary(); // Show the time taken vs the time limit
            Console.WriteLine();
        }

        // Method called when the level is failed (time runs out or quiz not passed)
        public void FailLevel()
        {
            timer.StopTimer();         // Stop the timer
            timer.DisplayTimeSummary(); // Show the time taken vs the time limit
        }

        // Abstract method meant to be overridden by derived classes (Polymorphism)
        // This forces each specific level to define its own quiz-loading logic
        public abstract void LoadQuiz();
    }
}
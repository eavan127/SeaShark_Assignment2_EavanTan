using System;
using System.Collections.Generic; // Required for List<Quiz>

namespace SeaShark
{
    // Abstract base class representing a generic game level 
    public abstract class Level
    {
        // Protected fields accessible by derived classes 
        protected int difficultyIndex;    // The difficulty rating of the level
        protected double timeLimit;       // Allowed time to complete the level 
        protected bool completed;         // Tracks if the level has been successfully finished 
        protected List<Quiz> quiz;        // List of quizzes for this level 
        protected Timer timer;            // Timer to track time during this level

        // Public property to check if the level is completed
        public bool Completed => completed;

        // Constructor to initialize the level's basic properties
        public Level(int difficulty, double time)
        {
            difficultyIndex = difficulty;     // Set the level difficulty
            timeLimit = time;                 // Set the time limit
            completed = false;                // Level is initially not completed
            quiz = new List<Quiz>();          // Initialize empty quiz list
            timer = new Timer((int)time);     // Create a timer with the level's time limit
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
        public abstract void LoadQuiz();
    }
}
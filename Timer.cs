using System;
using System.Diagnostics; // Required for the Stopwatch class

namespace SeaShark
{
    // Controls countdown timer for levels or gameplay segments
    public class Timer
    {
        // Private field tracking the remaining time in seconds
        private int timeLeft;

        // Stopwatch object to track elapsed time during gameplay
        private Stopwatch stopwatch;

        // Private field for the total time limit
        private int timeLimit;

        // Public property to read the remaining time
        public int TimeLeft => Math.Max(0, timeLimit - ElapsedSeconds);

        // Public property to get the number of seconds that have elapsed
        public int ElapsedSeconds => (int)stopwatch.Elapsed.TotalSeconds;

        // Constructor to initialize the timer with a specific duration
        public Timer(int seconds)
        {
            timeLimit = seconds;          // Assign the time limit in seconds
            timeLeft = seconds;           // Set the initial remaining time
            stopwatch = new Stopwatch();  // Create a new Stopwatch instance
        }

        // Method to start the countdown timer
        public void StartTimer()
        {
            stopwatch.Start(); // Begin counting elapsed time
            Console.WriteLine($"Timer started: {timeLimit} seconds ({timeLimit / 60} minutes) remaining.");
        }

        // Method to stop the timer
        public void StopTimer()
        {
            stopwatch.Stop(); // Stop counting elapsed time
        }

        // Method to update the timer, recalculating the remaining time
        public void UpdateTimer()
        {
            timeLeft = Math.Max(0, timeLimit - ElapsedSeconds); // Recalculate remaining time
        }

        // Method to check if the time has run out
        public bool TimeUp()
        {
            return ElapsedSeconds >= timeLimit; // Returns true if elapsed time exceeds the limit
        }

        // Method to display the time taken vs the time limit
        public void DisplayTimeSummary()
        {
            int elapsed = ElapsedSeconds; // Get the total elapsed seconds
            // Format the output to show time taken out of the total time limit
            Console.WriteLine($"Time Taken: {elapsed} seconds / {timeLimit} seconds ({timeLimit / 60} minutes limit)");
        }
    }
}
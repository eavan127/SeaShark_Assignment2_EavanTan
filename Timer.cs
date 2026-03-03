using System;
using System.Diagnostics; // Required for the Stopwatch class

namespace SeaShark
{
    // Controls countdown timer for levels or gameplay segments
    public class Timer
    {
        // Private field tracking the total time limit in seconds
        private int timeLimit;

        // Stopwatch object to track elapsed time during gameplay
        private Stopwatch stopwatch;

        // Public property to read the time limit
        public int TimeLimit => timeLimit;

        // Public property to get the number of seconds that have elapsed
        public int ElapsedSeconds => (int)stopwatch.Elapsed.TotalSeconds;

        // Public property to get the remaining seconds
        public int TimeLeft => Math.Max(0, timeLimit - ElapsedSeconds);

        // Constructor to initialize the timer with a specific duration
        public Timer(int seconds)
        {
            timeLimit = seconds;          // Assign the time limit in seconds
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

        // Method to check if the time has run out
        public bool IsTimeUp()
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
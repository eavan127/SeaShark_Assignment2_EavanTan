using System;

namespace SeaShark
{
    // Controls countdown timer for levels or gameplay segments
    public class Timer
    {
        // Private field tracking remaining seconds
        private int timeLeft;

        // Public property to securely read the remaining time
        public int TimeLeft => timeLeft;

        // Constructor to initialize the timer with a specific duration
        public Timer(int seconds)
        {
            timeLeft = seconds; // Assign initial time in seconds
        }

        // Method to start the timer
        public void StartTimer()
        {
            Console.WriteLine($"Timer started: {timeLeft} seconds remaining.");
        }

        // Method to decrease the time left
        public void DecreaseTime()
        {
            timeLeft--; // Reduce the remaining time by 1
        }

        // Method to check if the time has run out
        public bool IsTimeUp()
        {
            return timeLeft <= 0; // Returns true if 0 or fewer seconds remain
        }
    }
}
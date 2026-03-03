using System;

namespace SeaShark
{
    // Controls countdown timer
    public class Timer
    {
        private int timeLeft;

        public int TimeLeft => timeLeft;

        public Timer(int seconds)
        {
            timeLeft = seconds;
        }

        public void StartTimer()
        {
            Console.WriteLine($"Timer started: {timeLeft} seconds remaining.");
        }

        public void DecreaseTime()
        {
            timeLeft--;
        }

        public bool IsTimeUp()
        {
            return timeLeft <= 0;
        }
    }
}
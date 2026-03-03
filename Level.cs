using System;

namespace SeaShark
{
    // Abstract Level class (Abstraction + Encapsulation)
    public abstract class Level
    {
        protected int difficultyIndex;
        protected int timeLimit;
        protected bool completed;
        protected Quiz quiz;

        public bool Completed => completed;

        public Level(int difficulty, int time)
        {
            difficultyIndex = difficulty;
            timeLimit = time;
            completed = false;
        }

        public void StartLevel()
        {
            Console.WriteLine($"\nStarting Level {difficultyIndex}");
        }

        public void CompleteLevel()
        {
            completed = true;
            Console.WriteLine("Level Completed!");
        }

        // Abstract method (Polymorphism)
        public abstract void LoadQuiz();
    }
}
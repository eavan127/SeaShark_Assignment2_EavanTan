using System;

namespace SeaShark
{
    public class BeginnerLevel : Level
    {
        public BeginnerLevel() : base(1, 60)
        {
        }

        public override void LoadQuiz()
        {
            string[] options = { "class", "loop", "array" };
            quiz = new Quiz(
                "Which keyword is used to define a class in C#?",
                options,
                0
            );

            quiz.ShowQuiz();

            Console.Write("Enter answer: ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (quiz.CheckAnswer(answer))
            {
                CompleteLevel();
            }
        }
    }
}
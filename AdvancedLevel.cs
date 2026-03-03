using System;

namespace SeaShark
{
    public class AdvancedLevel : Level
    {
        public AdvancedLevel() : base(2, 90)
        {
        }

        public override void LoadQuiz()
        {
            string[] options = { "Encapsulation", "Inheritance", "Compilation" };
            quiz = new Quiz(
                "Which OOP concept hides internal data?",
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
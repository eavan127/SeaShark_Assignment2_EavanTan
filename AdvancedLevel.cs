using System;

namespace SeaShark
{
    // AdvancedLevel inherits from the base Level class (Inheritance)
    public class AdvancedLevel : Level
    {
        // Constructor that calls the base class constructor
        // Sets the difficulty Index to 2 and time limit to 420 seconds (7 minutes)
        public AdvancedLevel() : base(2, 420)
        {
        }

        // Overrides the abstract method from the Level class (Polymorphism)
        public override void LoadQuiz()
        {
            // Define the available options for this quiz
            string[] options = { "Virtual", "Abstract", "Sealed", "Static" };
            
            // Instantiate a new Quiz object with the question, options, and index of the correct answer (2)
            quiz = new Quiz(
                "Which keyword is used to prevent a class from being inherited in C#?",
                options,
                2 // the answer is "Sealed" is at index 2
            );

            // Display the quiz question and numbered options
            quiz.ShowQuiz();

            // Prompt the player to input their answer
            Console.Write("Enter answer: ");
            // Read user input and convert the string into an integer
            int answer = Convert.ToInt32(Console.ReadLine());

            // Validate the player's answer
            if (quiz.CheckAnswer(answer))
            {
                // If correct, mark the level as completed
                CompleteLevel();
            }
        }
    }
}
using System;

namespace SeaShark
{
    // BeginnerLevel inherits from the base Level class (Inheritance)
    public class BeginnerLevel : Level
    {
        // Constructor that calls the base class constructor
        // Sets difficulty Index to 1 and time limit to 300 seconds (5 minutes)
        public BeginnerLevel() : base(1, 300)
        {
        }

        // Overrides the abstract method from the Level class (Polymorphism)
        public override void LoadQuiz()
        {
            // Define the available options for this quiz
            string[] options = { "integer score = 10;", "int score = 10;", "var score = 10" , "Declare Int score(10)"};
            
            // Instantiate a new Quiz object with the question, options, and index of the correct answer (0)
            quiz = new Quiz(
                "Which of the following is the correct syntax to declare an integer variable named 'score' with a value of 10?",
                options,
                1 // the answer is "int score = 10;" is at index 1
                
            );

            // Display the quiz question and numbered options
            quiz.ShowQuiz();

            // Prompt the player to input their answer as a letter  
            Console.Write("Enter answer (A/B/C/D): ");
            // Read user input as a string and convert it to uppercase for consistent matching
            string answer = Console.ReadLine().Trim().ToUpper();

            // Validate the player's answer using the letter input
            if (quiz.CheckAnswer(answer))
            {
                // If correct, mark the level as completed
                CompleteLevel();
            }
        }
    }
}
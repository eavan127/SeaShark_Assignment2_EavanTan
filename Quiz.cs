using System;

// Fixing namespace to match the rest of the project
namespace SeaShark
{
    // The Quiz class handles quiz logic including question display
    // and answer validation.
    public class Quiz
    {
        // Private fields (Encapsulation)
        private string question;            // The question text
        private string[] options;           // The choices available to the user
        private int correctAnswerIndex;     // The index of the correct answer
        private int score;                  // Tracks the user's score for the quiz

        // Public property to securely access the score externally
        public int Score
        {
            get { return score; }
        }

        // Constructor
        // Used to create a new quiz question
        public Quiz(string questionText, string[] optionsArray, int correctIndex)
        {
            question = questionText;          // Initialize question text
            options = optionsArray;           // Initialize the choices
            correctAnswerIndex = correctIndex; // Set which choice is correct 
            score = 0;                        // Initial score is 0
        }

        // Display the quiz question and its options
        public void ShowQuiz()
        {
            Console.WriteLine("\nQuiz Question:");
            Console.WriteLine(question); // Print the question
            
            // Loop through all options to display them as a numbered list
            for (int i = 0; i < options.Length; i++)
            {
                // Display options starting with 1 (e.g., 1. OptionA)
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
        }

        // Check the user's answer
        public bool CheckAnswer(int userAnswer)
        {
            // userrAnswer is using 1, 2, 3...
            // so subtract 1 to compare it with the 0-based correctAnswerIndex
            if ((userAnswer - 1) == correctAnswerIndex)
            {
                score++; // Increment score
                Console.WriteLine("Correct answer!");
                return true; // Successfully answered
            }
            else
            {
                Console.WriteLine("Wrong answer!");
                return false; // Failed to answer correctly
            }
        }
    }
}

using System;

namespace SeaShark
{
    // The Quiz class handles quiz logic including question display
    // and answer validation.
    public class Quiz
    {
        // Private fields (Encapsulation)
        private string question;            // The question text
        private string[] options;           // The choices available to the user
        private int correctAnswerIndex;     // The zero-based index of the correct answer
        private int score;                  // Tracks the user's score for this quiz

        // Public property to securely access the score externally
        public int Score
        {
            get { return score; }
        }

        // Constructor
        // Used to create a new quiz question
        public Quiz(string questionText, string[] optionsArray, int correctIndex)
        {
            question = questionText;           // Initialize question text
            options = optionsArray;            // Initialize the choices
            correctAnswerIndex = correctIndex; // Set which choice is correct (0-based)
            score = 0;                         // Initial score is 0
        }

        // Display the quiz with their specific question numbers and total count
        public void ShowQuiz(int questionNumber, int totalQuestions)
        {
            // Display the question number of total questions
            Console.WriteLine($"\n--- Question {questionNumber} of {totalQuestions} ---");
            Console.WriteLine(question); // Print the question text

            // Loop through all options and label them A, B, C, D
            for (int i = 0; i < options.Length; i++)
            {
                // Convert index to letter: 0 = A, 1 = B, 2 = C, 3 = D
                char letter = (char)('A' + i);
                Console.WriteLine($"{letter}. {options[i]}"); // Display as "A. Option"
            }
        }

        // Check the user's answer using a letter (A, B, C, D)
        public bool CheckAnswer(string userAnswer)
        {
            // Convert the letter (A, B, C, D) to a 0-based index
            int userIndex = userAnswer[0] - 'A';

            if (userIndex == correctAnswerIndex) // Compare with the correct index
            {
                score++; // Increment score for a correct answer
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

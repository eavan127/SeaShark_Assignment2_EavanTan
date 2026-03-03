using System;
using System.Collections.Generic; // Required for List<Quiz>

namespace SeaShark
{
    // The Quiz class handles quiz logic including question display
    // and answer validation.
    public class Quiz
    {
        // Private fields (Encapsulation)
        private string[] questions;         // Array of question text (matches UML: questions: string[])
        private string[] options;           // The choices available to the user
        private int correctAnswerIndex;     // The zero-based index of the correct answer
        private int currentQuestionIndex;   // Tracks which question is currently active (UML field)
        private int score;                  // Tracks the user's score for this quiz

        // Constructor
        public Quiz(string questionText, string[] optionsArray, int correctIndex)
        {
            questions = new string[] { questionText }; // Store the question in an array
            options = optionsArray;                     // Initialize the choices
            correctAnswerIndex = correctIndex;          // Set which choice is correct (0-based)
            currentQuestionIndex = 0;                   // Start at the first question
            score = 0;                                  // Initial score is 0
        }

        // Display the quiz with their specific question numbers and total count
        public void ShowQuiz(int questionNumber, int totalQuestions)
        {
            // Display the question number of total questions
            Console.WriteLine($"\n--- Question {questionNumber} of {totalQuestions} ---");
            Console.WriteLine(questions[currentQuestionIndex]); // Print the current question text

            // Loop through all options and label them A, B, C, D
            for (int i = 0; i < options.Length; i++)
            {
                // Convert index to letter: 0 = A, 1 = B, 2 = C, 3 = D
                char letter = (char)('A' + i);
                Console.WriteLine($"{letter}. {options[i]}"); // Display as "A. Option"
            }
        }

        // Display a hint for the current question
        public void ShowHint()
        {
            // Provide a hint by revealing the first letter of the correct answer option
            string correctOption = options[correctAnswerIndex]; // Get the correct option text
            Console.WriteLine($"Hint: The correct answer starts with '{correctOption[0]}'...");
        }

        // Check the user's answer using a letter (A, B, C, D)
        public bool CheckAns(string userAnswer)
        {
            // Convert the letter (A, B, C, D) to a 0-based index
            int userIndex = userAnswer[0] - 'A';

            if (userIndex == correctAnswerIndex) // Compare with the correct index
            {
                UpdateScore(); // Use the separate method to update score 
                Console.WriteLine("Correct answer!");
                return true; // Successfully answered
            }
            else
            {
                Console.WriteLine("Wrong answer!");
                return false; // Failed to answer correctly
            }
        }

        // Method to update the score 
        public void UpdateScore()
        {
            score++; // Increment score by 1 for each correct answer
        }

        // Method to get the current score 
        public int GetScore()
        {
            return score; // Return the current score value
        }
    }
}

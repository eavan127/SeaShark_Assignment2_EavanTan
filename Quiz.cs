using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaShark_Assignment2
{
    // The Quiz class handles quiz logic including question display
    // and answer validation.
    public class Quiz
    {
        // Private fields
        private string question;
        private int correctAnswerIndex;
        private int score;

        // Public property to access score safely
        public int Score
        {
            get { return score; }
        }

        // Constructor
        public Quiz(string questionText, int correctIndex)
        {
            question = questionText;
            correctAnswerIndex = correctIndex;
            score = 0;
        }

        // Display the quiz question
        public void ShowQuiz()
        {
            Console.WriteLine("\nQuiz Question:");
            Console.WriteLine(question);
            Console.WriteLine("1. Class");
            Console.WriteLine("2. Variable");
            Console.WriteLine("3. Loop");
        }

        // Check the user's answer
        public bool CheckAnswer(int userAnswer)
        {
            if (userAnswer == correctAnswerIndex)
            {
                score++;
                Console.WriteLine("Correct answer!");
                return true;
            }
            else
            {
                Console.WriteLine("Wrong answer!");
                return false;
            }
        }
    }
}

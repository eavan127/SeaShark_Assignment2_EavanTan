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
            // Define an array of 3 Quiz objects for the Advanced level
            // and add them to the quiz list 
            quiz.Add(new Quiz(
                "Which keyword is used to prevent a class from being inherited in C#?",
                new string[] { "Virtual", "Abstract", "Sealed", "Static" },
                2 // Question 1: correct answer is index 2 = "Sealed"
            ));
            quiz.Add(new Quiz(
                "Which OOP concept hides internal data and only exposes what is necessary?",
                new string[] { "Encapsulation", "Polymorphism", "Inheritance", "Abstraction" },
                0 // Question 2: correct answer is index 0 = "Encapsulation"
            ));
            quiz.Add(new Quiz(
                "Which keyword is used in a derived class to provide a new implementation of a virtual method?",
                new string[] { "new", "override", "virtual", "abstract" },
                1 // Question 3: correct answer is index 1 = "override"
            ));

            bool allCorrect = false; // Flag to track if all answers are correct

            // Keep retrying the entire quiz until all answers are correct
            while (!allCorrect)
            {
                int correctCount = 0; // Reset correct count for each attempt

                // Loop through each question one by one
                for (int i = 0; i < quiz.Count; i++)
                {
                    // Display the question with its number
                    quiz[i].ShowQuiz(i + 1, quiz.Count);

                    // Prompt the player to enter their answer as a letter
                    Console.Write("Enter answer (A/B/C/D): ");
                    // Read the input, trim spaces, and convert to uppercase for matching
                    string answer = Console.ReadLine().Trim().ToUpper();

                    // Validate the answer using CheckAns 
                    if (quiz[i].CheckAns(answer))
                    {
                        correctCount++; // Increment for each correct answer
                    }
                }

                // Show the player their total score for this attempt
                Console.WriteLine($"\nAdvanced Level Score: {correctCount}/{quiz.Count}");

                // Check if all questions were answered correctly
                if (correctCount == quiz.Count)
                {
                    allCorrect = true;   // Exit the retry loop
                    CompleteLevel();      // Mark level as completed
                }
                else
                {
                    // Inform the player they must retry all questions
                    Console.WriteLine("You need to answer all questions correctly to complete the level.");
                    Console.WriteLine("Restarting Advanced Level quiz...\n");
                }
            }
        }
    }
}
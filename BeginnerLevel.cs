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
            // Define an array of 3 Quiz objects for the Beginner level
            // and add them to the quiz list 
            quiz.Add(new Quiz(
                "Which of the following is the correct syntax to declare an integer variable named 'score' with a value of 10?",
                new string[] { "integer score = 10;", "int score = 10;", "var score = 10;", "Declare Int score(10);" },
                1 // Question 1: correct answer is index 1 = "int score = 10;"
            ));
            quiz.Add(new Quiz(
                "Which keyword is used to define a class in C#?",
                new string[] { "class", "define", "struct", "object" },
                0 // Question 2: correct answer is index 0 = "class"
            ));
            quiz.Add(new Quiz(
                "Which method is used to print text to the console in C#?",
                new string[] { "System.Print()", "Console.Write()", "Console.WriteLine()", "Print.Line()" },
                2 // Question 3: correct answer is index 2 = "Console.WriteLine()"
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
                Console.WriteLine($"\nBeginner Level Score: {correctCount}/{quiz.Count}");

                // Check if all questions were answered correctly
                if (correctCount == quiz.Count)
                {
                    allCorrect = true;   // Exit the retry loop
                    CompleteLevel();      // Mark level as completed to unlock Advanced Level
                }
                else
                {
                    // Inform the player they must retry all questions
                    Console.WriteLine("You need to answer all questions correctly to proceed.");
                    Console.WriteLine("Restarting Beginner Level quiz...\n");
                }
            }
        }
    }
}
using System;

namespace SeaShark
{
    public class GameManager
    {
        private Player player;
        private Level currentLevel;
        private Timer timer;

        public GameManager(Player p)
        {
            player = p;
        }

        public void StartGame()
        {
            Console.WriteLine("===== SEA SHARK GAME =====");
            Console.WriteLine($"Player: {player.PlayerName}");

            currentLevel = new BeginnerLevel();
            timer = new Timer(60);

            timer.StartTimer();
            currentLevel.StartLevel();
            currentLevel.LoadQuiz();

            if (currentLevel.Completed)
            {
                Console.WriteLine("Unlocking Advanced Level...");
                currentLevel = new AdvancedLevel();
                currentLevel.StartLevel();
                currentLevel.LoadQuiz();
            }

            EndGame();
        }

        public void EndGame()
        {
            Console.WriteLine("\nGame Over.");
        }
    }
}
using System;

namespace SeaShark
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Eavan");
            GameManager game = new GameManager(player);

            game.StartGame();

            Console.ReadKey();
        }
    }
}
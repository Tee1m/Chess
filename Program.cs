using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Game;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            SetUpGame SetGame = new SetUpGame("White", "Black");
            //SetUpGame SetGame = new SetUpLoadedGame();
            ChessGame Chess = new ChessGame(SetGame);
            Chess.StartGame();

            
        }
        
        static void GameSetUp(int window_with,int window_heigh)
        {
            Console.SetWindowSize(window_with, window_heigh);
        }
    }
}

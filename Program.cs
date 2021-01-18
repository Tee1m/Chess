using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Game;
using Chess.Game.TeamFolder;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamGenerator FirstTeam = new TeamGenerator("White");
            TeamGenerator SecondTeam = new TeamGenerator("Black");

            SetUpGame SetGame = new SetUpGame(FirstTeam , SecondTeam);
            ChessGame Chess = new ChessGame(SetGame);
            Chess.StartGame();

            
        }
        
        static void GameSetUp(int window_with,int window_heigh)
        {
            Console.SetWindowSize(window_with, window_heigh);
        }
    }
}

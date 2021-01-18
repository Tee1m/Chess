using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Pieces;
using Chess.Game.GUI;
using Chess.Game.TeamFolder;

namespace Chess.Game
{
    class ChessGame
    {   
        Dashboard game;
        CursorOnDashboard CursorDashboard;
        Team FirstTeam;
        Team SecondTeam;
        public ChessGame(SetUpGame SetGame)
        {
            game = new Dashboard(8, 8);
            SetGame.SetUpDashboard();
            game.Board = SetGame.SetUpDashboard();
            FirstTeam = SetGame.WhiteTeam;
            SecondTeam = SetGame.BlackTeam;
        }

        public void StartGame()
        {   
            CursorDashboard = new CursorOnDashboard(game);
            CursorDashboard.ChosingPiece(FirstTeam);
            Console.ReadKey();
            Console.ReadKey();
        }
            
    }
}

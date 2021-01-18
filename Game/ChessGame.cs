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
        Team First;
        Team Second;
        public ChessGame(SetUpGame SetGame)
        {
            game = new Dashboard(8, 8);
            SetGame.SetUpDashboard();
            game.Board = SetGame.SetUpDashboard();
            First = SetGame.WhiteTeam;
            Second = SetGame.BlackTeam;
        }

        public void StartGame()
        {   
            CursorDashboard = new CursorOnDashboard(game);
            CursorDashboard.ChosingPiece(First.team_color);
            Console.ReadKey();
            Console.ReadKey();
        }
            
    }
}

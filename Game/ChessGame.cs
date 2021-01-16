using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Pieces;
using Chess.Game.GUI;

namespace Chess.Game
{
    class ChessGame
    {   
        Dashboard game;
        CursorOnDashboard CursorDashboard;
        public ChessGame(SetUpGame SetGame)
        {
            game = new Dashboard(8, 8);
            SetGame.SetUpDashboard();
            game.Board = SetGame.SetUpDashboard();
            
            
        }

        public void StartGame()
        {
            CursorDashboard = new CursorOnDashboard(game);
            CursorDashboard.ChosingPiece();
            Console.ReadKey();
            Console.ReadKey();
        }
            
    }
}

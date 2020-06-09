using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Move
    {
        public static bool MovePiece(List<GameTile> board, int boardPos, int newBoardPos) {
            //thinking that i will get the reference at boardPos, which will give the piece type
            //then I will validate the move (i.e. if its null, or if it can/cannot take that piece)
            //so in other words, when this is called, its saying the piece at boardPos, wants to move to newBoardPos
            
            //finds out which piece is being moved
            if (board[boardPos].type.type == "P") //pawn
            {
                Console.WriteLine("Moving Pawn");
            } 
            else if (board[boardPos].type.type == "R") //rook
            {
                Console.WriteLine("Moving Rook");
            }
            else if (board[boardPos].type.type == "H") //horse (knight)
            {
                Console.WriteLine("Moving Horse (Knight)");
            }
            else if (board[boardPos].type.type == "B") //bishop
            {
                Console.WriteLine("Moving Bishop");
            }
            else if (board[boardPos].type.type == "K") //king
            {
                Console.WriteLine("Moving King");
            }
            else if (board[boardPos].type.type == "Q") //queen
            {
                Console.WriteLine("Moving Queen");
            }

            return false;
        }

    }
}

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
            if (board[boardPos].piece.type == "P") //pawn
            {
                Console.WriteLine("Moving Pawn");

                //pawns can move forwards if no pieces are there, and can take pieces diagonally. It can do no other moves
                //as of right now not going to worry about en passant

                //check invalid directions first

   
                if (board[boardPos].piece.color) //white piece
                {
                    //assuming below is correct, it should give an error if you try to move a pawn backwards
                    if (boardPos > newBoardPos)
                    {
                        Console.WriteLine("Error: Cannot move pawns backwards.");
                        return false;
                    }
                }
                else { //black piece
                
                }
                
            } 
            else if (board[boardPos].piece.type == "R") //rook
            {
                Console.WriteLine("Moving Rook");
            }
            else if (board[boardPos].piece.type == "H") //horse (knight)
            {
                Console.WriteLine("Moving Horse (Knight)");
            }
            else if (board[boardPos].piece.type == "B") //bishop
            {
                Console.WriteLine("Moving Bishop");
            }
            else if (board[boardPos].piece.type == "K") //king
            {
                Console.WriteLine("Moving King");
            }
            else if (board[boardPos].piece.type == "Q") //queen
            {
                Console.WriteLine("Moving Queen");
            }

            return false;
        }

    }
}

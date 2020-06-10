using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Move
    {

        /**
         *  Thinking I might need to recreate the way I do this.
         *  First, I should check that the piece is being moved in an okay direction.
         *      - For this I will need to create a way to compare what row the pieces are on
         *  Then, i'll check if its a valid take/position
         *  
         *  Once I have all pieces validating right, then theres other conditions (like moving yourself out of check and such)
         */

        private static int[,] rowBoundriesOne = { { 0, 8, 16, 24, 32, 40, 48, 56 }, { 7, 15, 23, 31, 39, 47, 55, 63 } };

        public static bool MovePiece(List<GameTile> board, int boardPos, int newBoardPos) {
            //thinking that i will get the reference at boardPos, which will give the piece type
            //then I will validate the move (i.e. if its null, or if it can/cannot take that piece)
            //so in other words, when this is called, its saying the piece at boardPos, wants to move to newBoardPos

            if (board[boardPos].piece != null)
            {

                //finds out which piece is being moved
                if (board[boardPos].piece.type == "P") //pawn
                {
                    Console.WriteLine("Moving Pawn");

                    //pawns can move forwards if no pieces are there, and can take pieces diagonally. It can do no other moves
                    //as of right now not going to worry about en passant

                    //check invalid directions first

                    if (board[boardPos].piece.color) //white piece
                    {


                        //use rowboundries array to check directions for pawn next.


                        //if new board pos is same color as the piece you are moving
                        if (board[newBoardPos].piece.color)
                        {
                            Console.WriteLine("Error: Trying to move piece onto same colored piece");
                        }

                        //I believe this covers it being moved to the right/backwards.
                        if (boardPos < newBoardPos)
                        {
                            Console.WriteLine("Error: Cannot move pawns backwards.");
                            return false;
                        }

                        //Next I need to cover moving left
                        /*if () 
                        {
                            return false;
                        }*/

                    }
                    else
                    { //black piece
                        if (!board[newBoardPos].piece.color)
                        {
                            Console.WriteLine("Error: Trying to move piece onto same colored piece");
                        }
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
            }
            else {
                Console.WriteLine("Error: Piece null at this position.");
            }

            return false;
        }

    }
}

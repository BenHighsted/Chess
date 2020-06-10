using System;
using System.Collections.Generic;

namespace Chess
{
    class MainClass
    {
        public static List<GameTile> board = new List<GameTile>();

        public static void Main(string[] args)
        {
            int boardSize = 8;

            new Board(board, boardSize);
            PrintBoard(board);
            
            Move.MovePiece(board, 49, 50);
        }

        private static void PrintBoard(List<GameTile> board)
        {
            Console.WriteLine();
            Console.WriteLine("   ---------------------------------");
            Console.Write("   | ");

            foreach (GameTile tile in board) {
                if (tile.piece != null)
                    Console.Write(tile.piece.type);
                else
                    Console.Write("+");

                Console.Write(" | ");

                if (tile.row == 7)
                {
                    Console.WriteLine();
                    if (tile.col != 7)
                    {
                        Console.WriteLine("   ---------------------------------");
                        Console.Write("   | ");
                    }
                }
            }
            Console.WriteLine("   ---------------------------------");
            Console.WriteLine();

            int count = 0;

            foreach (GameTile tile in board) {

                Console.Write(count + " ");
                count++;

                if (tile.row == 7) {
                    Console.WriteLine();
                }
            }


        }
    }

    public class GameTile
    {
        public int row;
        public int col;//board positions

        public bool color; //white = true, black = false ?

        public Piece piece; //holds a piece object, or is null if nothing on board here
    }

    public class Piece
    {
        public bool color; //also true or false, instead we are talking about the piece color here
        public string type; //piece type (i.e. pawn)
    }
}
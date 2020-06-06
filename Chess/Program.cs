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
        }

        private static void PrintBoard(List<GameTile> board)
        {
            foreach (GameTile tile in board)
            {
                //Console.Write(tile.type + " ");
                Console.Write(tile.row.ToString() + " ");
                if (tile.row == 7)
                    Console.WriteLine();
            }
        }
    }

    public class GameTile
    {
        public int row;
        public int col;//board positions

        public bool color; //white = true, black = false ?

        public Piece type; //holds a piece object, or is null if nothing on board here
    }

    public class Piece
    {
        public bool color; //also true or false, instead we are talking about the piece here
        public string type; //piece type (i.e. pawn)
    }
}

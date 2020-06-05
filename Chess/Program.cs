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
            printBoard(board);
        }

        private static void printBoard(List<GameTile> board)
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

    public class GameTile //thinking i'll need a seperate class for each piece
    {
        public int row;
        public int col;//board positions

        public string type;//piece type (i.e. pawn)
    }
}

using System;
using System.Collections.Generic;

namespace Chess
{
    class MainClass
    {
        private static List<GameTile> board = new List<GameTile>();

        public static void Main(string[] args)
        {
            int boardSize = 8;
            initialiseBoard(boardSize);
            printBoard();

        }

        //will probably move these to a seperate file (where all the board related stuff will be located
        private static void initialiseBoard(int size) {
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {

                    GameTile tile = new GameTile();

                    tile.col = i;
                    tile.row = j;
                    tile.type = "P";//this will need to be the piece type. (i.e. pawn)

                    board.Add(tile);
                }
            }
        }

        private static void printBoard()
        {
            foreach (GameTile tile in board)
            {
                Console.Write(tile.type + " ");
                if (tile.row == 7)
                    Console.WriteLine();
            }
        }

        private static void setupBoard() { }//this method will setup the board for a new game

    }

    public class GameTile
    {
        public int row;
        public int col;
        public String type;
    }
}

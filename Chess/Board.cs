using System;
using System.Collections.Generic;
namespace Chess
{
    public class Board
    {
        public Board(List<GameTile> board, int boardSize)
        {
            setupBoard(board, boardSize);
        }

        private static void initialiseBoard(List<GameTile> board, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    GameTile tile = new GameTile();

                    tile.col = i;
                    tile.row = j;
                    tile.type = "P";

                    board.Add(tile);
                }
            }
        }

        public static void setupBoard(List<GameTile> board, int boardSize)//this method will setup the board for a new game
        {
            initialiseBoard(board, boardSize);
        }
    }
}

using System;
using System.Collections.Generic;

namespace Chess
{
    public class Board
    {
        public string[] pieces = {"R", "H", "B"};


        public Board(List<GameTile> board, int boardSize)
        {
            SetupBoard(board, boardSize);
        }

        private static void InitialiseBoard(List<GameTile> board, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    GameTile tile = new GameTile();

                    tile.col = i;
                    tile.row = j;

                    //sets the colors of the tiles
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                            tile.color = true;
                        else
                            tile.color = false;
                    }
                    else {
                        if (j % 2 == 0)
                            tile.color = false;
                        else
                            tile.color = true;
                    }


                    //tile.type = new Piece(); (TO BE ADDED)

                    board.Add(tile);
                }
            }
        }

        private static void PlacePieces(List<GameTile> board) {

        }

        public static void SetupBoard(List<GameTile> board, int boardSize)//this method will setup the board for a new game
        {
            InitialiseBoard(board, boardSize);
        }
    }
}

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

        private static string[] piecesArrOne = { "R", "H", "B", "K", "Q", "B", "H", "R" };

        private static void PlacePieces(List<GameTile> board, int size) {
            //Board setup is as follows:
            //Rook, Horse, Bishop, King, Queen, Bishop, Horse, Rook
            //Pawn, Pawn, Pawn, Pawn, Pawn, Pawn, Pawn, Pawn

            //Pawn, Pawn, Pawn, Pawn, Pawn, Pawn, Pawn, Pawn
            //Rook, Horse, Bishop, King, Queen, Bishop, Horse, Rook

            //I believe the king starts on his color, if using the current layout black is at the top
            //and white starts at the bottom

            //places black pieces (top of board)
            for (int i = 0; i < 8; i++) {
                board[i].type = new Piece { color = false, type = piecesArrOne[i] };
            }

            for(int i = 8; i < 16; i++)
            {
                board[i].type = new Piece { color = false, type = "P" };
            }

            //places white pieces (bottom of board)
            int count = 0;
            for (int i = 56; i < 64; i++) {
                board[i].type = new Piece { color = true, type = piecesArrOne[count] };
                count++;
            }

            for (int i = 48; i < 56; i++) {
                board[i].type = new Piece { color = true, type = "P" };
            }
            
        }

        public static void SetupBoard(List<GameTile> board, int boardSize)
        {
            InitialiseBoard(board, boardSize);
            PlacePieces(board, boardSize);
        }
    }
}

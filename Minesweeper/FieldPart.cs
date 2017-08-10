using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minesweeper
{
    public class FieldPart
    {
        public bool IsMine { get; set; }
        public int ID { get; set; }
        public int NumberOfNeighbourMines { get; set; }

        static Random mineCreator = new Random();
        int theMine = mineCreator.Next(1, 4);

        public FieldPart()
        {
            if (theMine == 1)
            {
                IsMine = true;
            }

            else
            {
                IsMine = false;
            }
        }

        public bool NeighbourChecker(int x, int y)
        {
            if (theMine == 1)
            {
                IsMine = true;
            }
            else
            {
                //if (field[x + 1, y] == 1)
                //{
                //    NumberOfNeighbourMines += 1;
                //}

                //if (field[x - 1, y] == 1)
                //{
                //    NumberOfNeighbourMines += 1;
                //}
            }
            return false;
        }
    }
}
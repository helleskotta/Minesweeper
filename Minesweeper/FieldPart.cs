using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minesweeper
{
    public class FieldPart
    {
        public bool IsMine { get; set; }
        public bool IsClicked { get; set; }
        public int ID { get; set; }
        public int NumberOfNeighbourMines { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Status { get; set; }
        public int MineCount { get; set; }

        static Random mineCreator = new Random();
        int theMine = mineCreator.Next(1, 4);

        public FieldPart(int x, int y)
        {
            X = x;
            Y = y;
            MineCount = 0;
            IsClicked = false;
        }

        public bool NeighbourChecker(int x, int y)
        {
            if (theMine == 1)
            {
                IsMine = true;
            }
            else
            {
                
            }
            return false;
        }
        
    }
}
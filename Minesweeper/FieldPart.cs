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
    }
}
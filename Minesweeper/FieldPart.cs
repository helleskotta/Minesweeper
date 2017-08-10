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

        //public int MineBeside { get; set; }

        public FieldPart(bool isMine, int id)
        {
            IsMine = isMine;
            ID = id;
        }
    }
}
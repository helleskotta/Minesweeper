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
        public int Width { get; set; }
        public int Height { get; set; }
        public int MineCount { get; set; }

        //public int MineBeside { get; set; }

        public FieldPart(bool isMine, int id)
        {
            IsMine = isMine;
            ID = id;
        }

        public string DrawField()
        {
            Random random = new Random();
            random.Next(0, Width);

            random.Next(0, Height);

            FieldPart[,] field = new FieldPart[Width, Height];

            string elementOnField = "";
            int counter = 0;

            // Kolumn
            for (int y = 0; y < Height; y++)
            {
                elementOnField += "<tr>";

                // Rad
                for (int x = 0; x < Width; x++)
                {
                    elementOnField += $"<td style=\"border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {field[x, y].IsMine});\"></td>";
                }
                elementOnField += "</tr>";
            }
            return elementOnField;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minesweeper
{
    public class GameField
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int MineCount { get; set; }

        //public int MineBeside { get; set; }

        public GameField()
        {
        }

        public string DrawField()
        {
            Width = Height = 3;
            Random random = new Random();
            //random.Next(0, Width);
            //random.Next(0, Height);

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
                    FieldPart fieldPart = new FieldPart();
                    field[x, y] = fieldPart;

                    elementOnField += $"<td style=\"border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {fieldPart.IsMine.ToString().ToLower()});\"></td>";
                }
                elementOnField += "</tr>";
            }

            return elementOnField;
        }
    }
}
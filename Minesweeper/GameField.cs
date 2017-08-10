using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minesweeper
{
    public class GameField
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int MineCount { get; set; }
        public FieldPart[,] field;

        //public int MineBeside { get; set; }

        public GameField(int x, int y)
        {
            X = x;
            Y = y;
            field = new FieldPart[X, Y];
        }

        public string DrawField()
        {
            Random random = new Random();

            //random.Next(0, Width);
            //random.Next(0, Height);

            string elementOnField = "";
            int counter = 0;

            // Kolumn
            for (int y = 0; y < Y; y++)
            {
                elementOnField += "<tr>";

                // Rad
                for (int x = 0; x < X; x++)
                {
                    FieldPart fieldPart = new FieldPart(x, y);
                    field[x, y] = fieldPart;

                    elementOnField += $"<td style=\"border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {fieldPart.IsMine.ToString().ToLower()}, {fieldPart.X}, {fieldPart.Y});\"></td>";
                }
                elementOnField += "</tr>";
            }

            return elementOnField;
        }
    }
}
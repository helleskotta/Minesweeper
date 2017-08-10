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
                    FieldPart fieldPart = field[x, y];

                    if (fieldPart.IsClicked)
                    {
                        if (fieldPart.IsMine)
                        {
                            elementOnField += $"<td style=\"background: red; border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {fieldPart.IsMine.ToString().ToLower()}, {fieldPart.X}, {fieldPart.Y});\"></td>";
                        }
                        else
                        {
                            elementOnField += $"<td style=\"background: green; border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {fieldPart.IsMine.ToString().ToLower()}, {fieldPart.X}, {fieldPart.Y});\"></td>";
                        }
                    }
                    else
                    {
                    elementOnField += $"<td style=\"border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {fieldPart.IsMine.ToString().ToLower()}, {fieldPart.X}, {fieldPart.Y});\"></td>";
                    }

                }
                elementOnField += "</tr>";
            }

            return elementOnField;
        }

        internal void CheckGameField(int x, int y)
        {

        }

        internal void BuildGamePlan()
        {
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    field[i, j] = new FieldPart(i, j);
                }
            }

            // TODO: Slumpa in mina 
            field[5, 5].IsMine = true;
        }
    }
}
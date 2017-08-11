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
            for (int y = 1; y < Y - 1; y++)
            {
                elementOnField += "<tr>";

                // Rad
                for (int x = 1; x < X - 1; x++)
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
                            elementOnField += $"<td style=\"background: green; border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {fieldPart.IsMine.ToString().ToLower()}, {fieldPart.X}, {fieldPart.Y});\">{fieldPart.MineCount}</td>";
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
            if (field[x - 1, y - 1].IsMine)
            {
                field[x, y].MineCount++;
            }

            if (field[x - 1, y].IsMine)
            {
                field[x, y].MineCount++;
            }
            if (field[x - 1, y + 1].IsMine)
            {
                field[x, y].MineCount++;
            }
            if (field[x, y - 1].IsMine)
            {
                field[x, y].MineCount++;
            }
            if (field[x, y + 1].IsMine)
            {
                field[x, y].MineCount++;
            }
            if (field[x + 1, y - 1].IsMine)
            {
                field[x, y].MineCount++;
            }
            if (field[x + 1, y].IsMine)
            {
                field[x, y].MineCount++;
            }
            if (field[x + 1, y + 1].IsMine)
            {
                field[x, y].MineCount++;
            }
            
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
            field[2, 1].IsMine = true;
            field[1, 1].IsMine = true;
            field[2, 2].IsMine = true;
        }
    }
}
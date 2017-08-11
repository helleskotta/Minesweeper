using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minesweeper
{
    public class GameField
    {
        public int FieldX { get; set; }
        public int FieldY { get; set; }
        public FieldPart[,] field;

        //public int MineBeside { get; set; }

        public GameField(int fieldX, int fieldY)
        {
            FieldX = fieldX;
            FieldY = fieldY;
            field = new FieldPart[FieldX, FieldY];
        }

        public string DrawField()
        {
            Random random = new Random();

            //random.Next(0, Width);
            //random.Next(0, Height);

            string elementOnField = "";
            int counter = 0;

            // Kolumn
            for (int y = 1; y < FieldY - 1; y++)
            {
                elementOnField += "<tr>";

                // Rad
                for (int x = 1; x < FieldX - 1; x++)
                {
                    FieldPart fieldPart = field[x, y];

                    if (fieldPart.IsClicked)
                    {
                        if (fieldPart.IsMine)
                        {
                            elementOnField += $"<td style=\"background: red; border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {fieldPart.IsMine.ToString().ToLower()}, {fieldPart.X}, {fieldPart.Y});\"></td>";
                        }
                        else if (fieldPart.MineCount == 0)
                        {
                            elementOnField += $"<td style=\"background: green; border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {fieldPart.IsMine.ToString().ToLower()}, {fieldPart.X}, {fieldPart.Y});\"></td>";
                        }
                        else
                        {
                            elementOnField += $"<td style=\"background: green; border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {fieldPart.IsMine.ToString().ToLower()}, {fieldPart.X}, {fieldPart.Y});\">{fieldPart.MineCount}</td>";
                        }
                    }

                    else
                    {
                        elementOnField += $"<td style=\"border: 1px solid black;\" id=\"{counter}\" onclick=\"tdclick({counter++}, {fieldPart.IsMine.ToString().ToLower()}, {fieldPart.X}, {fieldPart.Y});\"><font color=\"white\">{fieldPart.MineCount}</font></td>";
                    }

                }
                elementOnField += "</tr>";
            }

            return elementOnField;
        }

        internal int CheckGameField(int x, int y)
        {
            bool emptyField = true;
            int mineCount = 0;

            if (x > 0 && y > 0 && x < FieldX && y < FieldY)
            {
                if (field[x - 1, y - 1].IsMine)
                {
                    field[x, y].MineCount++;
                    emptyField = false;
                }
                //else if (x != 1 || y != 1 || x != FieldX - 1 || y != FieldY - 1)
                //{
                //    didSth = CheckGameField(x - 1, y - 1);
                //}

                if (field[x - 1, y].IsMine)
                {
                    field[x, y].MineCount++;
                    emptyField = false;
                }
                //else if (x != 1 || y != 1 || x != FieldX - 1 || y != FieldY - 1)
                //{
                //    didSth = CheckGameField(x - 1, y);
                //}

                if (field[x - 1, y + 1].IsMine)
                {
                    field[x, y].MineCount++;
                    emptyField = false;
                }
                //else if (x != 1 || y != 1 || x != FieldX - 1 || y != FieldY - 1)
                //{
                //    didSth = CheckGameField(x - 1, y + 1);
                //}

                if (field[x, y - 1].IsMine)
                {
                    field[x, y].MineCount++;
                    emptyField = false;
                }
                //else if (x != 1 || y != 1 || x != FieldX - 1 || y != FieldY - 1)
                //{
                //    didSth = CheckGameField(x, y - 1);
                //}

                if (field[x, y + 1].IsMine)
                {
                    field[x, y].MineCount++;
                    emptyField = false;
                }
                //else if (x != 1 || y != 1 || x != FieldX - 1 || y != FieldY - 1)
                //{
                //    didSth = CheckGameField(x, y + 1);
                //}

                if (field[x + 1, y - 1].IsMine)
                {
                    field[x, y].MineCount++;
                    emptyField = false;
                }
                //else if (x != 1 || y != 1 || x != FieldX - 1 || y != FieldY - 1)
                //{
                //    didSth = CheckGameField(x + 1, y - 1);
                //}

                if (field[x + 1, y].IsMine)
                {
                    field[x, y].MineCount++;
                    emptyField = false;
                }
                //else if (x != 1 || y != 1 || x != FieldX - 1 || y != FieldY - 1)
                //{
                //    didSth = CheckGameField(x + 1, y);
                //}

                if (field[x + 1, y + 1].IsMine)
                {
                    field[x, y].MineCount++;
                    emptyField = false;
                }
                //else if (x != 1 || y != 1 || x != FieldX - 1 || y != FieldY - 1)
                //{
                //    didSth = CheckGameField(x + 1, y + 1);
                //}
                mineCount = field[x, y].MineCount;
            }

            //if (emptyField && field[x, y].IsChecked == false)
            //{
            //    ContinueNeighbourCheck(x, y);
            //}
            return mineCount;
        }

        public void ContinueNeighbourCheck(int x, int y)
        {
            x--;
            y--;
            int mineCount = 0;
            
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    if (i > 0 && j > 0 && i < FieldX && j < FieldY)
                    {
                        if (field[i, j].IsClicked == false || field[i, j].MineCount == 0)
                        {
                            mineCount = CheckGameField(i, j);

                            if (mineCount > 0)
                            {
                                //break;
                            }
                            else
                            {
                                field[i, j].IsClicked = true;
                            }

                        }
                    }
                }

                if (mineCount > 0)
                {
                    //break;
                }
            }


        }

        internal void BuildGamePlan()
        {
            for (int i = 0; i < FieldX; i++)
            {
                for (int j = 0; j < FieldY; j++)
                {
                    field[i, j] = new FieldPart(i, j);
                }
            }

            // TODO: Slumpa in mina 
            field[2, 1].IsMine = true;
            field[1, 5].IsMine = true;
            field[2, 2].IsMine = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Minesweeper
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GameField gameField = new GameField(10, 10);

            if (Session["GameField"] != null)
            {
                // Ladda spelplan från session
                gameField.field = (FieldPart[,])Session["GameField"];
            }
            else
            {
                gameField.BuildGamePlan();
                Session["GameField"] = gameField.field;
            }

            if (Request["action"] != null)
            {
                string action = Request["action"];

                if (action == "click")
                {
                    int x = Convert.ToInt32(Request["x"]);
                    int y = Convert.ToInt32(Request["y"]);

                    gameField.field[x, y].IsClicked = true;
                    gameField.CheckGameField(x, y);
                }
            }

            PlayField.Text = gameField.DrawField();

            #region bortkommenterad kod
            //List<int> playField = new List<int>()
            //{
            //    3, 4, 5, 6, 7, 8, 9, 10, 11
            //};
            //foreach (int squareOnField in playField)
            //{
            //    int tempID = squareOnField;
            //    bool tempMine;

            //    // Mine or not
            //    if (random.Next(1, 3) == 1)
            //    {
            //        tempMine = true;
            //    }
            //    else
            //    {
            //        tempMine = false;
            //    }

            //    field.Add(new FieldPart(tempMine, tempID));
            //}

            //string elementOnField = "";
            //int counter = 0;

            //Random mine = new Random();
            //mine.Next(0, 3);
            //foreach (var square in field)
            //{
            //    if (square.ID % 3 == 0)
            //    {
            //        elementOnField += "<tr>";
            //        elementOnField += $"<td style=\"border: 1px solid black;\" class=\"{(square.IsMine)}\" id=\"{counter}\" onclick=\"tdclick({counter++}, {square.IsMine});\"></td>";
            //        elementOnField += $"<td style=\"border: 1px solid black;\"class=\"{square.IsMine}\" id=\"{counter}\" onclick=\"tdclick({counter++}, {square.IsMine});\"></td>";
            //        elementOnField += $"<td style=\"border: 1px solid black;\"class=\"{square.IsMine}\" id=\"{counter}\" onclick=\"tdclick({counter++}, {square.IsMine});\"></td>";
            //        elementOnField += "</tr>";
            //    }
            //}
            #endregion
        }


    }
}
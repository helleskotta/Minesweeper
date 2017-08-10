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
            // Spelplansrandom
            Random random = new Random();
            random.Next(1, 10);

            List<FieldPart> field = new List<FieldPart>();

            List<int> playField = new List<int>()
            {
                3, 4, 5, 6, 7, 8, 9, 10, 11
            };

            foreach (int squareOnField in playField)
            {
                int tempID = squareOnField;
                bool tempMine;
                
                // Mine or not
                if (random.Next(1, 3) == 1)
                {
                    tempMine = true;
                }
                else
                {
                    tempMine = false;
                }

                field.Add(new FieldPart(tempMine, tempID));
            }

            string elementOnField = "";
            int counter = 0;
            Random mine = new Random();
            mine.Next(0, 3);


            foreach (var square in field)
            {
                if (square.ID % 3 == 0)
                {
                    elementOnField += "<tr>";
                    elementOnField += $"<td style=\"border: 1px solid black;\" class=\"{square.IsMine}\" id=\"{counter}\" onclick=\"tdclick({counter++}, {square.IsMine});\"></td>";
                    elementOnField += $"<td style=\"border: 1px solid black;\"class=\"{square.IsMine}\" id=\"{counter}\" onclick=\"tdclick({counter++}, {square.IsMine});\"></td>";
                    elementOnField += $"<td style=\"border: 1px solid black;\"class=\"{square.IsMine}\" id=\"{counter}\" onclick=\"tdclick({counter++}, {square.IsMine});\"></td>";
                    elementOnField += "</tr>";
                }
            }

            PlayField.Text = elementOnField;
        }
    }
}
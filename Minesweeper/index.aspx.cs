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
            Random random = new Random();
            random.Next(1, 10);

            #region spelbräde
            //int[,] field = new int[,]
            //{
            //    {0, 1, 2},
            //    {3, 4, 5},
            //    {6, 7, 8}
            //};
            #endregion

            List<int> playField = new List<int>()
            {
                3, 4, 5, 6, 7, 8, 9, 10, 11
            };

            string elementOnField = "";
            int counter = 0;

            foreach (var item in playField)
            {
                if (item % 3 == 0)
                {
                    elementOnField += "<tr>";
                    elementOnField += $"<td id=\"{counter}\" onclick=\"tdclick({ counter++});\"> X</td>";
                    elementOnField += $"<td id=\"{counter}\" onclick=\"tdclick({ counter++});\"> X</td>";
                    elementOnField += $"<td id=\"{counter}\" onclick=\"tdclick({ counter++});\"> X</td>";
                    elementOnField += "</tr>";
                }
            }

            PlayField.Text = elementOnField;

            // TODO: add Javascript function tdclick
        }
    }
}
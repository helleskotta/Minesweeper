//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace Minesweeper
//{
//    public class FindNeighbors
//    {
//        public FieldPart[,] GetNeighbors(int width, int height, bool isMine)
//        {
//            var nearbyPanels = Panels.Where(panel => panel.X >= (x - depth) && panel.X <= (x + depth)
//                        && panel.Y >= (y - depth) && panel.Y <= (y + depth));
//            var currentPanel = Panels.Where(panel => panel.X == x && panel.Y == y);

//            return nearbyPanels.Except(currentPanel).ToList();
//        }
//    }
//}
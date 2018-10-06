using Conways_Game_Of_Life.Library.CellService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conways_Game_Of_Life.Library.GUI
{
    public class GUIWriter
    {
        public static void WriteGui(int collumns, List<Cell> cellList)
        {
            StringBuilder gui = new StringBuilder();
            int i = 0;
            var stopWatch = Stopwatch.StartNew();
            foreach(var cell in cellList)
            {
                if (cell.IsAlive)
                {
                    gui.Append("O ");
                    i++;
                }
                else
                {
                    gui.Append(". ");
                    i++;
                }
                if (i == collumns)
                {
                    gui.AppendLine();
                    i = 0;
                }
            }
            //Console.WriteLine("Foreach time {0}ms", stopWatch.ElapsedMilliseconds);
            Console.WriteLine(gui.ToString());
            stopWatch.Stop();
        }
    }
}

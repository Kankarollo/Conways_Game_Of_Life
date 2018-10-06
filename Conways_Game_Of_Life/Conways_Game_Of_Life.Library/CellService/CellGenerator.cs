using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conways_Game_Of_Life.Library.CellService
{
    public class CellGenerator
    {
        public CellGenerator()
        {

        }
        public List<Cell> CellListGenerator(int rows, int collumns, List<int> whichCellisAlive)
        {
            List<Cell> cellListGenerator = new List<Cell>();
            for(int i = 0; i< rows*collumns; i++)
            {
                if(whichCellisAlive.Any(x=> x == i))
                    cellListGenerator.Add(new Cell(rows, collumns, i, true));
                else
                    cellListGenerator.Add(new Cell(rows, collumns, i, false));
            }
            return cellListGenerator;
        }
    }
}

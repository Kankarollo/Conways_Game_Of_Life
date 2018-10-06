using Conways_Game_Of_Life.Library.CellService;
using Conways_Game_Of_Life.Library.GUI;
using Conways_Game_Of_Life.Library.RulesApplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conways_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 100;
            int collumns = 100;
            int howManyCells = 1000;

            CellRandomizer randomizer = new CellRandomizer(rows,collumns);
            var randomCellID = randomizer.GenerateRandomNumbers(howManyCells);
            CellGenerator cellGenerator = new CellGenerator();
            var cellList = cellGenerator.CellListGenerator(rows, collumns, randomCellID);
            DeadOrAliveStatusUpdater updater = new DeadOrAliveStatusUpdater(rows, collumns);
            while (true)
            {
                GUIWriter.WriteGui(collumns,cellList);
                Console.ReadKey();
                Console.Clear();
                cellList = updater.CellListUpdater(cellList);
            }
        }
    }
}

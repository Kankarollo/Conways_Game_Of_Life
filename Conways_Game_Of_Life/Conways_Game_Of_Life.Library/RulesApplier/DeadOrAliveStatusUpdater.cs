using Conways_Game_Of_Life.Library.CellService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conways_Game_Of_Life.Library.RulesApplier
{
    public class DeadOrAliveStatusUpdater
    {
        private int rows;
        private int collumns;

        public DeadOrAliveStatusUpdater(int _rows, int _collumns)
        {
            rows = _rows;
            collumns = _collumns;
        }

        public List<Cell> CellListUpdater(List<Cell> cellList)
        {
            var stopwatch = Stopwatch.StartNew();
            foreach (var cell in cellList)
            {
                int neighbours = CalculateNeighbours(rows, collumns, cellList, cell);
                cell.IsAlive = IsCellAliveAfterUpdate(neighbours, cell.IsAlive);
            }
            Console.WriteLine("ForeachMethod {0}ms", stopwatch.ElapsedMilliseconds);
            //stopwatch.Restart();
            //Parallel.ForEach(cellList, cell =>
            //{
            //    int neighbours = CalculateNeighbours(rows, collumns, cellList, cell);
            //    cell.IsAlive = IsCellAliveAfterUpdate(neighbours, cell.IsAlive);
            //});
            //Console.WriteLine("ParallelMethod {0}ms", stopwatch.ElapsedMilliseconds);
            //Console.ReadKey();
            stopwatch.Stop();
            return cellList;
        }


        public bool IsCellAliveAfterUpdate(int neighbours, bool isAlive)
        {
            if (neighbours == 3)
                return true;
            if (isAlive && neighbours == 2)
                return true;
            return false;
        }

        public int CalculateNeighbours(int rows, int collumns, List<Cell> cellList, Cell cell)
        {
            int neighbours = 0;
            int collumn_of_cell = cell.Collumn;
            int row_of_cell = cell.Row;
            int id_of_cell = cell.ID;
            neighbours = CalculatorOfNeighbours(rows, collumns, cellList, neighbours, collumn_of_cell, row_of_cell, id_of_cell);
            return neighbours;
        }

        //WARNING! BAD CODE , IF GENERATOR!!!
        private static int CalculatorOfNeighbours(int rows, int collumns, List<Cell> cellList, int neighbours, int collumn_of_cell, int row_of_cell, int id_of_cell)
        {
            if (row_of_cell == 0)
            {
                if (collumn_of_cell == 0)
                {
                    if (cellList[id_of_cell + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns + 1].IsAlive)
                        neighbours++;

                }
                else if (collumn_of_cell == collumns - 1)
                {
                    if (cellList[id_of_cell - 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns - 1].IsAlive)
                        neighbours++;
                }
                else
                {
                    if (cellList[id_of_cell + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns - 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - 1].IsAlive)
                        neighbours++;
                }
            }
            else if (row_of_cell == rows - 1)
            {
                if (collumn_of_cell == 0)
                {
                    if (cellList[id_of_cell + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns + 1].IsAlive)
                        neighbours++;
                }
                else if (collumn_of_cell == collumns - 1)
                {
                    if (cellList[id_of_cell - 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns - 1].IsAlive)
                        neighbours++;
                }
                else
                {
                    if (cellList[id_of_cell + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns - 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - 1].IsAlive)
                        neighbours++;
                }
            }
            else
            {
                if (collumn_of_cell == 0)
                {
                    if (cellList[id_of_cell + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns + 1].IsAlive)
                        neighbours++;
                }
                else if (collumn_of_cell == collumns - 1)
                {
                    if (cellList[id_of_cell - 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns - 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns - 1].IsAlive)
                        neighbours++;
                }
                else
                {
                    if (cellList[id_of_cell + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns + 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - collumns - 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell - 1].IsAlive)
                        neighbours++;
                    if (cellList[id_of_cell + collumns - 1].IsAlive)
                        neighbours++;
                }
            }

            return neighbours;
        }
    }
}

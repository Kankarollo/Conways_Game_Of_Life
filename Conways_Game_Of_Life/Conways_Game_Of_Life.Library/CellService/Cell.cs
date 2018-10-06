using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conways_Game_Of_Life.Library.CellService
{
    public class Cell : ICell
    {
        private int row;
        private int collumn;
        private int id;
        private bool isAlive;
        public Cell(int _row, int _collumn, int _id, bool _isAlive = false)
        {
            id = _id;
            row = _id/_row;
            collumn = _id %_collumn;
            isAlive = _isAlive;
        }
        public int Row
        {
            get => row;
        }
        public int Collumn
        {
            get => collumn;
        }
        public int ID
        {
            get => id;
        }
        public bool IsAlive
        {
            get => isAlive;
            set => isAlive = value;
        }
    }
}

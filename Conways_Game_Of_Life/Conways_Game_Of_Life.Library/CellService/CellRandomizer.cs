using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conways_Game_Of_Life.Library.CellService
{
    public class CellRandomizer
    {
        private int rows;
        private int collumns;

        public CellRandomizer(int _rows, int _collumns )
        {
            rows = _rows;
            collumns = _collumns;
        }

        public List<int> GenerateRandomNumbers(int howManyRandomNumbers)
        {
            List<int> randomNumbers = new List<int>();
            Random random = new Random();
            int i = 0;
            while (i < howManyRandomNumbers)
            {
                int number = random.Next(1, rows * collumns);
                if (!randomNumbers.Any(x => x == number))
                {
                    randomNumbers.Add(number);
                    i++;
                }
            }
            return randomNumbers;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsFarm.PD
{
    class cFarm
    {
        private int iPetSCat = 1;
        private int iPetSDog = 2;
        private cPet[,] farmMap = null;
        public cFarm(int _cols, int _rows, int _petsCount)
        {
            //fill farm by empty cells
            cPet[,] _Farm = new cPet[_cols, _rows];
            for (int c = 0; c < _cols; c++)
                for (int r = 0; r < _rows; r++)
                    _Farm[c, r] = null;
            //add pets to farm
            Random rPet = new Random();
            Random rCoord = new Random();
            int[] rCols = new int[_petsCount];
            for (int i = 0; i < rCols.Length; i++)
                rCols[i] = rCoord.Next(0, _cols);

            int[] rRows = new int[_petsCount];
            for (int i = 0; i < rRows.Length; i++)
                rRows[i] = rCoord.Next(0, _rows);

            int iPet = 0;
            for (int i = 0; i < _petsCount; i++)
            {
                iPet = rPet.Next(1, 3);
                if (iPet == iPetSCat)
                {
                    _Farm[rCols[i], rRows[i]] = new cCat("Kitty");
                }
                if (iPet == iPetSDog)
                {
                    _Farm[rCols[i], rRows[i]] = new cDog("Doge");
                }
            }
            farmMap = _Farm;

        }

        public int getFarmCols()
        {
            return farmMap.GetLength(0);
        }
        public int getFarmRows()
        {
            return farmMap.GetLength(1);
        }
        public object getFarmCell(int _col, int _row)
        {
            object oResult = null;
            if ((_col < getFarmCols()) && (_row < getFarmRows()))
            {
                oResult = farmMap[_col, _row];
            }
            return oResult;
        }
    }
}

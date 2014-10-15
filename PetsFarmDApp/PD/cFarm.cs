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
        private List<cPet> petsList = null;

        public cFarm(int _cols, int _rows, int _petsCount)
        {
            //fill farm by empty cells
            cPet[,] _Farm = new cPet[_cols, _rows];
            petsList = new List<cPet>();

            for (int c = 0; c < _cols; c++)
                for (int r = 0; r < _rows; r++)
                    _Farm[c, r] = null;
            farmMap = _Farm;
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
                    petsList.Add(new cCat(this, rCols[i], rRows[i], "Kitty" + rCols[i].ToString() + rRows[i].ToString()));
                }
                if (iPet == iPetSDog)
                {
                    petsList.Add(new cDog(this, rCols[i], rRows[i], "Doge" + rCols[i].ToString() + rRows[i].ToString()));
                }
            }
        }

        //Function to get random number
        /*private readonly Random getrandom = new Random();
        private readonly object syncLock = new object();
        public int getRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }*/

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
        public void setPetOnFarmCell(int _col, int _row, cPet _pet)
        {
            farmMap[_col, _row] = _pet;
        }
        public void movePetOnFarmCell(int _cCol, int _cRow, int _nCol, int _nRow)
        {
            if ((_nCol > 0) && (_nCol < getFarmCols()) && (_nRow > 0) && (_nRow < getFarmRows()))
            {
                if ((farmMap[_cCol, _cRow] != null) && (farmMap[_nCol, _nRow] == null))
                {
                    farmMap[_nCol, _nRow] = farmMap[_cCol, _cRow];
                    //farmMap[_nCol, _nRow]
                    farmMap[_cCol, _cRow] = null;
                }
            }
        }
        public List<String> doTick()
        {
            List<String> sLog = new List<String>();
            foreach(cPet aPet in petsList)
            {
                sLog.Add(aPet.doTick());
            }
            return sLog;
        }
    }
}

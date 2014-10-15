using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsFarm.PD
{
    class cPet
    {
        private cFarm farmOwner;
        private int iCol;
        private int iRow;
        private String nickName;
        protected String sPetType;

        public cPet(cFarm _farmOwner, int _col, int _row, String _nickName)
        {
            nickName = _nickName;
            iCol = _col;
            iRow = _row;
            farmOwner = _farmOwner;
            farmOwner.setPetOnFarmCell(iCol, iRow, this);
        }

        public String getPetSimbol()
        {
            return sPetType;
        }
        public String getPetNickname()
        {
            return nickName;
        }
        public int getPetCol()
        {
            return iCol;
        }
        public int getPetRow()
        {
            return iRow;
        }



        public virtual String doVoice()
        {
            return nickName + ": ";
        }

        public void moveUp()
        {
            if (iRow - 1 >= 0)
            {
                if (farmOwner.movePetOnFarmCell(iCol, iRow, iCol, iRow - 1))
                {
                    iRow = iRow - 1;
                }
            }
        }

        public void moveRight()
        {
            if (iCol + 1 < farmOwner.getFarmCols())
            {
                if (farmOwner.movePetOnFarmCell(iCol, iRow, iCol + 1, iRow))
                {
                    iCol = iCol + 1;
                }
            }
        }

        public void moveLeft()
        {
            if (iCol - 1 >= 0)
            {
                if (farmOwner.movePetOnFarmCell(iCol, iRow, iCol - 1, iRow))
                {
                    iCol = iCol - 1;
                }
            }
        }

        public void moveDown()
        {
            if (iRow + 1 < farmOwner.getFarmCols())
            {
                if (farmOwner.movePetOnFarmCell(iCol, iRow, iCol, iRow + 1))
                {
                    iRow = iRow + 1;
                }
            }
        }

        public void doTick1()
        {
            
        }

        public String doTick()
        {
            int iMove = cRandomInt.GetRandomNumber(0, 5);
            if (iMove == 1)
            {
                moveUp();
            }
            if (iMove == 2)
            {
                moveRight();
            }
            if (iMove == 3)
            {
                moveLeft();
            }
            if (iMove == 4)
            {
                moveDown();
            }
            return nickName + ":move " + iMove.ToString();
        }

    }
}

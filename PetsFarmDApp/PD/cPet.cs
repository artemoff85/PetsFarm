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
        private int iGender;
        private int iLoveTickCount;
        private String nickName;
        protected String sPetType;

        private void setPetGender()
        {
            iGender = cRandomInt.GetRandomNumber(0, 2);
        }

        public cPet(cFarm _farmOwner, int _col, int _row, String _nickName)
        {
            nickName = _nickName;
            iCol = _col;
            iRow = _row;
            iLoveTickCount = 0;
            setPetGender();
            farmOwner = _farmOwner;
            farmOwner.setPetOnFarmCell(iCol, iRow, this);
        }

        public Boolean IsPetMale()
        {
            return iGender > 0;
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
            if (iRow + 1 < farmOwner.getFarmRows())
            {
                if (farmOwner.movePetOnFarmCell(iCol, iRow, iCol, iRow + 1))
                {
                    iRow = iRow + 1;
                }
            }
        }

        private object scanCellByDirection(int iDirect)
        {
            object oResult = null;
            if (iDirect == 1)
            {//up
                if (iRow - 1 > 0)
                {
                    oResult = farmOwner.getFarmCell(iCol, iRow - 1);
                }
            }
            if (iDirect == 2)
            {//right
                if (iCol + 1 < farmOwner.getFarmCols())
                oResult = farmOwner.getFarmCell(iCol + 1, iRow);
            }
            if (iDirect == 3)
            {//left
                if (iCol - 1 > 0)
                {
                    oResult = farmOwner.getFarmCell(iCol - 1, iRow);
                }
            }
            if (iDirect == 4)
            {//down
                if (iRow + 1 < farmOwner.getFarmRows())
                {
                    oResult = farmOwner.getFarmCell(iCol, iRow + 1);
                }
            }
            return oResult;
        }

        private void moveByDirection(int iDirect)
        {
            if (iDirect == 1)
            {//up
                moveUp();
            }
            if (iDirect == 2)
            {//right
                moveRight();
            }
            if (iDirect == 3)
            {//left
                moveLeft();
            }
            if (iDirect == 4)
            {//down
                moveDown();
            }
        }

        public void fuckPetByLove(cPet aPet)
        {
            iLoveTickCount = 2;
            aPet.getFuckedByPet();
        }

        public void getFuckedByPet()
        {
            iLoveTickCount = 2;
        }

        public Boolean HasLove()
        {
            return iLoveTickCount > 0;
        }

        public String doTick()
        {
            String sPetState = String.Empty;
            if (iLoveTickCount == 0)
            {
                int iDirect = cRandomInt.GetRandomNumber(0, 5);
                object oCell = scanCellByDirection(iDirect);
                if (oCell == null)
                {//can move by direction
                    moveByDirection(iDirect);
                    sPetState = "move " + iDirect.ToString();
                }
                else
                {
                    cPet aPet = (cPet)oCell;
                    if ((this.getPetSimbol() == aPet.getPetSimbol()) && (this.IsPetMale() && !aPet.IsPetMale()))
                    //if (this.getPetSimbol() == aPet.getPetSimbol())
                    {//can move by direction & fuck this pet
                        sPetState = "LOVE!!!";// +iDirect.ToString();
                        fuckPetByLove(aPet);
                        //iLoveTickCount = 2;
                    }
                }
            }
            else
            {
                sPetState = "LOVE!!!";
                iLoveTickCount = iLoveTickCount - 1;
            }
            return nickName + ":" + sPetState;
        }

    }
}

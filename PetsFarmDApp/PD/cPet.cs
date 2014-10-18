using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsFarm.PD
{
    class cPet
    {
        protected cFarm farmOwner;
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
        public void setPetCol(int _iCol)
        {
            iCol = _iCol;
        }
        public void setPetRow(int _iRow)
        {
            iRow = _iRow;
        }
        
        public virtual String doVoice()
        {
            return nickName + ": ";
        }

        public void moveUp()
        {
            farmOwner.movePetOnFarmCell(iCol, iRow, iCol, iRow - 1);
        }

        public void moveRight()
        {
            farmOwner.movePetOnFarmCell(iCol, iRow, iCol + 1, iRow);
        }

        public void moveLeft()
        {
            farmOwner.movePetOnFarmCell(iCol, iRow, iCol - 1, iRow);
        }

        public void moveDown()
        {
            farmOwner.movePetOnFarmCell(iCol, iRow, iCol, iRow + 1);
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
            }else if (iDirect == 2)
            {//right
                if (iCol + 1 < farmOwner.getFarmCols())
                {
                    oResult = farmOwner.getFarmCell(iCol + 1, iRow);
                }
            }else if (iDirect == 3)
            {//left
                if (iCol - 1 > 0)
                {
                    oResult = farmOwner.getFarmCell(iCol - 1, iRow);
                }
            }else if (iDirect == 4)
            {//down
                if (iRow + 1 < farmOwner.getFarmRows())
                {
                    oResult = farmOwner.getFarmCell(iCol, iRow + 1);
                }
            }
            return oResult;
        }

        private Boolean canMoveByDirection(int iDirect)
        {
            //object oResult = null;
            Boolean bResult = false;
            if (iDirect == 1)
            {//up
                bResult = (iRow - 1 >= 0);
            }
            else if (iDirect == 2)
            {//right
                bResult = (iCol + 1 <= farmOwner.getFarmCols() - 1);
            }
            else if (iDirect == 3)
            {//left
                bResult = (iCol - 1 >= 0);
            }
            else if (iDirect == 4)
            {//down
                bResult = (iRow + 1 <= farmOwner.getFarmRows() - 1);
            }
            return bResult;
        }

        private Boolean isFreeCellByDirection(int iDirect)
        {
            Boolean oResult = false;
            if (iDirect == 1)
            {//up
                if (iRow - 1 > 0)
                {
                    oResult = (farmOwner.getFarmCell(iCol, iRow - 1) == null);
                }
            }
            else if (iDirect == 2)
            {//right
                if (iCol + 1 < farmOwner.getFarmCols())
                {
                    oResult = (farmOwner.getFarmCell(iCol + 1, iRow) == null);
                }
            }
            else if (iDirect == 3)
            {//left
                if (iCol - 1 > 0)
                {
                    oResult = (farmOwner.getFarmCell(iCol - 1, iRow) == null);
                }
            }
            else if (iDirect == 4)
            {//down
                if (iRow + 1 < farmOwner.getFarmRows())
                {
                    oResult = (farmOwner.getFarmCell(iCol, iRow + 1) == null);
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

        protected virtual void BirthPet(int _col, int _row)
        {
            //abstract
        }

        private int getFirstFreeDirection()
        {
            int iDirect = 0;
            Boolean canSelect = true;
            for (int i = 1; i <= 4; i++)
            {
                if (canSelect)
                {
                    if (canMoveByDirection(i))
                    {
                        if (isFreeCellByDirection(i))
                        {
                            iDirect = i;
                            canSelect = false;
                        }
                    }
                }
            }
            return iDirect;
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
                    //if can move on cell by direction
                    if (canMoveByDirection(iDirect))
                    {
                        moveByDirection(iDirect);
                        sPetState = "move " + iDirect.ToString();
                    }
                }
                else
                {
                    cPet aPet = (cPet)oCell;
                    if ((this.getPetSimbol() == aPet.getPetSimbol()) && (this.IsPetMale() && !aPet.IsPetMale()))
                     {//can move by direction & fuck this pet
                        //sPetState = "LOVE!!!";
                         if (!aPet.HasLove())
                             fuckPetByLove(aPet);
                     }
                }
            }
            else
            {
                //sPetState = "LOVE!!!";
                iLoveTickCount = iLoveTickCount - 1;
                if (!IsPetMale() && (iLoveTickCount == 0))
                {//try birth new same pet
                    int iDirect = getFirstFreeDirection(); // 0;
                    if (iDirect > 0)
                    {
                        if (iDirect == 1)
                            BirthPet(iCol, iRow - 1);
                        else if (iDirect == 2)
                            BirthPet(iCol + 1, iRow);
                        else if (iDirect == 3)
                            BirthPet(iCol - 1, iRow);
                        else if (iDirect == 4)
                            BirthPet(iCol, iRow + 1);
                    }
                }
                //
            }
            return nickName + ":" + sPetState;
        }

    }
}

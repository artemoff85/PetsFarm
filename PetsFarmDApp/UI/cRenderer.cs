using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PetsFarm.PD;

namespace PetsFarm.UI
{
    static class cRenderer
    {
        private static Pen aPen = new Pen(Color.Red, 2);
        private static Brush aBrush = new SolidBrush(Color.Green);
        private static Font aFont = new Font("System", 10);
        private static Font aFontTag = new Font("Arial", 8);

        private static cFarm aFarm;
        private static Graphics gCanvas;
        private static int iPxCellSize;
        private static Brush maleColor = Brushes.Blue;
        private static Brush femaleColor = Brushes.Red;
        private static Brush petDog = Brushes.Blue;
        private static Brush petCat = Brushes.Red;
        private static Brush dieColor = Brushes.Silver;


        private static void RenderSelectedPet()
        {
            cPet selectedPet = aFarm.getSelectedPet();
            if (selectedPet != null)
            {
                gCanvas.DrawRectangle(aPen, selectedPet.getPetCol() * iPxCellSize, selectedPet.getPetRow() * iPxCellSize, iPxCellSize, iPxCellSize);
            }
        }

        private static Brush RenderPetGender(cPet aPet)
        {
            Brush bResult = femaleColor;
            if (aPet.IsPetMale()) { bResult = maleColor; }
            return bResult;
        }

        private static Brush RenderPetClass(cPet aPet)
        {
            Brush bResult = petCat;
            if (aPet is cDog ) { bResult = petDog; }
            return bResult;
        }

        private static void RenderPetsLove(cPet aPet)
        {
            if (aPet.HasLove())
            {
                gCanvas.DrawString("♥", aFontTag, Brushes.Pink, new Point(aPet.getPetCol() * iPxCellSize, aPet.getPetRow() * iPxCellSize));
            }
        }

        private static void RenderPetDie(cPet aPet, int _iFarmX, int _iFarmY)
        {
            gCanvas.DrawString(aPet.getPetSimbol(), aFont, dieColor, new Point(_iFarmX, _iFarmY));
        }

        public static void RenderFarm(cFarm _aFarm, Graphics _gCanvas, int _iPxCellSize)
        {
            int _cols = _aFarm.getFarmCols();
            int _rows = _aFarm.getFarmRows();
            int iFarmX = 0;
            int iFarmY = 0;
            aFarm = _aFarm;
            gCanvas = _gCanvas;
            iPxCellSize = _iPxCellSize;
            object aCell = null;
            cPet aPet = null;
            for (int c = 0; c < _cols; c++)
                for (int r = 0; r < _rows; r++)
                {
                    iFarmX = c * iPxCellSize;
                    iFarmY = r * iPxCellSize;
                    gCanvas.FillRectangle(aBrush, iFarmX, iFarmY, iPxCellSize, iPxCellSize);
                    aCell = aFarm.getFarmCell(c, r);
                    if (aCell != null)
                    {
                        aPet = (cPet)aCell;
                        if (aPet.isAlive())
                        {
                            //gCanvas.DrawString(aPet.getPetSimbol(), aFont, RenderPetGender(aPet), new Point(iFarmX, iFarmY));
                            gCanvas.DrawString(aPet.getPetSimbol(), aFont, RenderPetClass(aPet), new Point(iFarmX, iFarmY));
                            RenderPetsLove(aPet);
                        }
                        else
                        {
                            RenderPetDie(aPet, iFarmX, iFarmY);
                        }

                    }
                }
            RenderSelectedPet();
        }
    }
}

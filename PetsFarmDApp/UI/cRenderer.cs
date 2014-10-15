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

        public static void RenderFarm(cFarm _aFarm, Graphics gCanvas, int _iPxCellSize)
        {
            int _cols = _aFarm.getFarmCols();
            int _rows = _aFarm.getFarmRows();
            int iFarmX = 0;
            int iFarmY = 0;
            object aCell = null;
            cPet aPet = null;
            for (int c = 0; c < _cols; c++)
                for (int r = 0; r < _rows; r++)
                {
                    iFarmX = c * _iPxCellSize;
                    iFarmY = r * _iPxCellSize;
                    gCanvas.FillRectangle(aBrush, iFarmX, iFarmY, _iPxCellSize, _iPxCellSize);
                    aCell = _aFarm.getFarmCell(c, r);
                    if (aCell != null)
                    {
                        aPet = (cPet)aCell;
                        gCanvas.DrawString(aPet.getPetSimbol(), aFont, Brushes.White, new Point(iFarmX, iFarmY));
                        cPet selectedPet = _aFarm.getSelectedPet();
                        if (selectedPet != null)
                        {
                            gCanvas.DrawRectangle(aPen, selectedPet.getPetCol() * _iPxCellSize, selectedPet.getPetRow() * _iPxCellSize, _iPxCellSize, _iPxCellSize);
                        }
                    }
                }
        }
    }
}

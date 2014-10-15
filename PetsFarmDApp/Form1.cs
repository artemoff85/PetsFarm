using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetsFarm.PD;

namespace PetsFarm
{
    public partial class Form1 : Form
    {
        Pen aPen;
        Brush aBrush;
        Font aFont;

        cFarm aFarm;
        int iPxCellSize = 15;
        int iColsCount = 20;
        int iRowsCount = 20;
        int iPetsCount = 20;

        private void RenderFarm(cFarm _aFarm, Graphics gCanvas, int _iPxCellSize)
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
                    }
                }
        }

        private String GetFarmClick(Point _clickLocation, cFarm _aFarm, int _iPxCellSize)
        {
            String sResult = "___";
            int iPosX = _clickLocation.X / _iPxCellSize;
            int iPosY = _clickLocation.Y / _iPxCellSize;
            object aCell = _aFarm.getFarmCell(iPosX, iPosY);
            if (aCell != null)
            {
                cPet aPet = (cPet)aCell;
                sResult = aPet.doVoice();
            }
            return sResult;
        }

        public Form1()
        {
            InitializeComponent();
            aPen = new Pen(Color.Red, 2);
            aBrush = new SolidBrush(Color.Green);
            aFont = new Font("System", 10);
            aFarm = new cFarm(iColsCount, iRowsCount, iPetsCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aFarm = new cFarm(iColsCount, iRowsCount, iPetsCount);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            RenderFarm(aFarm, e.Graphics, iPxCellSize);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvnt = (MouseEventArgs)e;
            lbVoice.Text = GetFarmClick(mouseEvnt.Location, aFarm, iPxCellSize);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(aFarm.doTick().ToArray());
            //aFarm.doTick().ToArray();
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}

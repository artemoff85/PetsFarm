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
        //cPet MyPet;
        Pen aPen;
        Brush aBrush;
        Font aFont;

        //int[,] aFarm;
        cPet[,] aFarm;
        int iPetSCat = 1;
        int iPetSDog = 2;
        int iPxCellSize = 15;
        //int iPetCat = 3;
        //int iPetDog = 4;

        private cPet[,] InitFarm(int _cols, int _rows, int _petsCount)
        {
            //fill farm by empty cells
            cPet[,] _aFarm = new cPet[_cols, _rows];
            for (int c = 0; c < _cols; c++)
                for (int r = 0; r < _rows; r++)
                    _aFarm[c, r] = null;
            //add pets to farm
            Random rPet = new Random();
            Random rCoord = new Random();
            int[] rCols = new int[_petsCount+1];
            for (int i = 0; i < rCols.Length; i++)
                rCols[i] = rCoord.Next(0, _cols);

            int[] rRows = new int[_petsCount+1];
            for (int i = 0; i < rRows.Length; i++)
                rRows[i] = rCoord.Next(0, _rows);

            int iPet = 0;
            for (int i = 0; i < _petsCount + 1; i++)
            {
                iPet = rPet.Next(1, 3);
                if (iPet == iPetSCat){
                    _aFarm[rCols[i], rRows[i]] = new cCat("Kitty");
                }
                if (iPet == iPetSDog){
                    _aFarm[rCols[i], rRows[i]] = new cDog("Doge");
                }
            }
            return _aFarm;
        }

        private void RenderFarm(cPet[,] _aFarm, Graphics gCanvas, int _iPxCellSize)
        {
            //int _size = 15;
            int _cols = _aFarm.GetLength(0);
            int _rows = _aFarm.GetLength(1);
            int iFarmX = 0;
            int iFarmY = 0;
            //Text = _cols.ToString() + " " + _rows.ToString();
            for (int c = 0; c < _cols; c++)
                for (int r = 0; r < _rows; r++)
                {
                    iFarmX = c * _iPxCellSize;
                    iFarmY = r * _iPxCellSize;
                    gCanvas.FillRectangle(aBrush, iFarmX, iFarmY, _iPxCellSize, _iPxCellSize);
                    if (_aFarm[c, r] != null)
                    {
                        gCanvas.DrawString(_aFarm[c, r].getPetSimbol(), aFont, Brushes.White, new Point(iFarmX, iFarmY));
                    }
                }
        }

        public Form1()
        {
            InitializeComponent();
            aPen = new Pen(Color.Red, 2);
            aBrush = new SolidBrush(Color.Green);
            aFont = new Font("System", 10);
            aFarm = InitFarm(10, 10, 9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aFarm = InitFarm(10, 10, 9);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            RenderFarm(aFarm, e.Graphics, iPxCellSize);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            int iPosX = me.Location.X / iPxCellSize;
            int iPosY = me.Location.Y / iPxCellSize;
            cPet aPet = aFarm[iPosX, iPosY];
            if (aPet != null)
            {
                lbVoice.Text = aPet.doVoice();
            }
            else
            {
                lbVoice.Text = "___";
            }
        }
    }
}

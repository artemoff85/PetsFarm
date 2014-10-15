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
        cPet MyPet;
        Pen aPen;
        Brush aBrush;
        Font aFont;

        int[,] aFarm;
        int iPetSCat = 1;
        int iPetSDog = 2;
        int iPetCat = 3;
        int iPetDog = 4;


        private int[,] InitFarm(int _cols, int _rows, int _petsCount)
        {
            //fill farm by empty cells
            int[,] _aFarm = new int[_cols, _rows];
            for (int c = 0; c < _cols; c++)
                for (int r = 0; r < _rows; r++)
                    _aFarm[c, r] = 0;
            //add pets to farm
            Random rPet = new Random();
            Random rCoord = new Random();
            int[] rCols = new int[_petsCount+1];
            for (int i = 0; i < rCols.Length; i++)
                rCols[i] = rCoord.Next(0, _cols);

            int[] rRows = new int[_petsCount+1];
            for (int i = 0; i < rRows.Length; i++)
                rRows[i] = rCoord.Next(0, _rows);

            for (int i = 0; i < _petsCount + 1; i++)
                _aFarm[rCols[i], rRows[i]] = rPet.Next(1, 3);

            return _aFarm;
        }

        private void RenderFarm(int[,] _aFarm, Graphics gCanvas)
        {
            int _size = 15;
            int _cols = _aFarm.GetLength(0);
            int _rows = _aFarm.GetLength(1);
            int iFarmX = 0;
            int iFarmY = 0;
            //Text = _cols.ToString() + " " + _rows.ToString();
            for (int c = 0; c < _cols; c++)
                for (int r = 0; r < _rows; r++)
                {
                    iFarmX = c * _size;
                    iFarmY = r * _size;
                    gCanvas.FillRectangle(aBrush, iFarmX, iFarmY, _size, _size);
                    if (_aFarm[c, r] == iPetSCat)
                    {
                        gCanvas.DrawString("k", aFont, Brushes.White, new Point(iFarmX, iFarmY));
                    }
                    if (_aFarm[c, r] == iPetSDog)
                    {
                        gCanvas.DrawString("d", aFont, Brushes.White, new Point(iFarmX, iFarmY));
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
            /*
            MyPet = null;
            switch (new Random().Next(1, 3))
            {
                case 1:
                    MyPet = new cCat("Murka");
                    break;
                case 2:
                    MyPet = new cDog("Zhuchka");
                    break;

            }
            if (MyPet != null)
            {
                label1.Text = MyPet.doVoice();
            }*/

            aFarm = InitFarm(10, 10, 9);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            RenderFarm(aFarm, e.Graphics);
        }
    }
}

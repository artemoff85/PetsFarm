﻿using System;
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

        public Form1()
        {
            InitializeComponent();
            aPen = new Pen(Color.Red, 2);
            aBrush = new SolidBrush(Color.Green);
            aFont = new Font("System", 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyPet = null;
            switch (new Random().Next(1, 3))
            {
                case 1:
                    MyPet = new cCat("Murka");
                    break;
                case 2:
                    MyPet = new cDog("Zhuchka");
                    break;
                /*
                default:
                    break;*/
            }
            if (MyPet != null)
            {
                label1.Text = MyPet.doVoice();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(aPen, 5, 5, 20, 20);
            e.Graphics.FillRectangle(aBrush, 5, 5, 15, 15);
            e.Graphics.DrawString("d", aFont, Brushes.White, new Point(5, 5));
        }
    }
}

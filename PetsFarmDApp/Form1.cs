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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int aPetType = rnd.Next(1, 2);
            MyPet = null;
            switch (new Random().Next(1, 3))
            {
                case 1:
                    //Console.WriteLine("Case 1");
                    MyPet = new cCat("Murka");
                    break;
                case 2:
                    //Console.WriteLine("Case 2");
                    MyPet = new cDog("Zhuchka");
                    break;
                /*
                default:
                    //Console.WriteLine("Default case");
                    MyPet = new cCat("Murka");
                    break;*/
            }
            if (MyPet != null)
            {
                label1.Text = MyPet.doVoice();
            }
        }
    }
}

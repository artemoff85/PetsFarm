using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetsFarm.UI;
using PetsFarm.PD;

namespace PetsFarm
{
    public partial class Form1 : Form
    {
        Pen aPen;
        Brush aBrush;
        Font aFont;
        cFarm aFarm;

        int iPxCellSize;
        int iColsCount;
        int iRowsCount;
        int iPetsCount;

        private void InitFormVars()
        {
            iPxCellSize = 15;
            iColsCount = 3;
            iRowsCount = 3;
            iPetsCount = 4;
            aPen = new Pen(Color.Red, 2);
            aBrush = new SolidBrush(Color.Green);
            aFont = new Font("System", 10);
            aFarm = new cFarm(iColsCount, iRowsCount, iPetsCount);
            lbPetsCount.Text = aFarm.getPetsCount().ToString();
        }

        private void DoOnFarmClick(Point _clickLocation, cFarm _aFarm, int _iPxCellSize)
        {
            int iPosX = _clickLocation.X / _iPxCellSize;
            int iPosY = _clickLocation.Y / _iPxCellSize;
            if ((iPosX < _aFarm.getFarmCols()) && (iPosY < aFarm.getFarmRows()))
            {
                object aCell = _aFarm.getFarmCell(iPosX, iPosY);
                if (aCell != null)
                {
                    cPet aPet = (cPet)aCell;
                    lbVoice.Text = aPet.doVoice();
                    aFarm.selectPet(aPet);
                }
                else
                {
                    aFarm.selectPet(null);
                    lbVoice.Text = "empty";
                }
            }
            else
            {
                aFarm.selectPet(null);
                lbVoice.Text = "void";
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitFormVars();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitFormVars();
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            cRenderer.RenderFarm(aFarm, e.Graphics, iPxCellSize);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvnt = (MouseEventArgs)e;
            DoOnFarmClick(mouseEvnt.Location, aFarm, iPxCellSize);
            pictureBox1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String[] sLog = aFarm.doTick().ToArray();
            lbPetsCount.Text = aFarm.getPetsCount().ToString();
            listBox1.Items.Clear();
            if (sLog != null)
                listBox1.Items.AddRange(sLog);
            cPet aPet = aFarm.getSelectedPet();
            if (aPet != null)
                listBox1.SetSelected(listBox1.FindString(aPet.getPetNickname()), true);
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled) { button3.Text = "Stop"; }
            else { button3.Text = "Start"; }
        }

        private String getSelectedPetNickName(String sLogLine)
        {
            return sLogLine.Split(new Char[] { ':' })[0];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                //selectedPetNickName = getSelectedPetNickName(listBox1.Items[selectedIndex].ToString());
                aFarm.selectPet(aFarm.getFarmPetByNickname(getSelectedPetNickName(listBox1.Items[selectedIndex].ToString())));
                lbVoice.Text = aFarm.getSelectedPet().doVoice();
                pictureBox1.Refresh();
            }
        }
    }
}

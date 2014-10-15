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
        int selectedIndex;
        String selectedPetNickName;

        private void InitFormVars()
        {
            iPxCellSize = 15;
            iColsCount = 20;
            iRowsCount = 20;
            iPetsCount = 50;
            selectedIndex = 0;
            selectedPetNickName = String.Empty;
            aPen = new Pen(Color.Red, 2);
            aBrush = new SolidBrush(Color.Green);
            aFont = new Font("System", 10);
            aFarm = new cFarm(iColsCount, iRowsCount, iPetsCount);
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
                aFarm.selectPet(aPet);
                //listBox1.SetSelected(selectedIndex, false);
                selectedIndex = -1;
            }
            return sResult;
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
            lbVoice.Text = GetFarmClick(mouseEvnt.Location, aFarm, iPxCellSize);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(aFarm.doTick().ToArray());
            pictureBox1.Refresh();
            if ((aFarm.getSelectedPet() != null) && (selectedIndex > 0)) { listBox1.SetSelected(selectedIndex, true); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private String getSelectedPetNickName(String sLogLine)
        {
            return sLogLine.Split(new Char[] { ':' })[0];
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            /*selectedIndex = listBox1.SelectedIndex;
            selectedPetNickName = getSelectedPetNickName(listBox1.Items[selectedIndex].ToString());
            aFarm.selectPet(aFarm.getFarmPetByNickname(selectedPetNickName));
            lbVoice.Text = aFarm.getSelectedPet().doVoice();*/
        }
    }
}

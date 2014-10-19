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
            iColsCount = Convert.ToInt32(tbCols.Text);
            iRowsCount = Convert.ToInt32(tbRows.Text); ;
            iPetsCount = Convert.ToInt32(tbPCount.Text); ;
            aPen = new Pen(Color.Red, 2);
            aBrush = new SolidBrush(Color.Green);
            aFont = new Font("System", 10);
            aFarm = new cFarm(iColsCount, iRowsCount, iPetsCount);
            lbPetsCount.Text = aFarm.getPetsCount().ToString();
            lbFarmSize.Text = (iRowsCount * iColsCount).ToString();
            listBox1.Items.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.ChartAreas[0].AxisY.Maximum = iRowsCount * iColsCount;
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
                    lbVoice.Text = "";
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
            //listBox1.Items.Clear();
            //Tick logging
            //if (sLog != null && gbxLog.Visible)
                //listBox1.Items.AddRange(sLog);
            if (gbxLog.Visible)
                listBox1.Items.AddRange(
                    new String[] {
                        "--- Age " + aFarm.getAge().ToString(),
                        "Pets count = " + aFarm.getPetsCount().ToString(),
                    }
                );
            //
            cPet aPet = aFarm.getSelectedPet();
            if (aPet != null && aPet.isAlive())
                listBox1.SetSelected(listBox1.FindString(aPet.getPetNickname()), true);
            lbFarmAge.Text = aFarm.getAge().ToString();
            chart1.Series[0].Points.AddXY(aFarm.getAge(), aFarm.getPetsCount());
            chart1.Series[1].Points.AddXY(aFarm.getAge(), aFarm.getCatsCount());
            chart1.Series[2].Points.AddXY(aFarm.getAge(), aFarm.getDogsCount());
            lbCatsCount.Text = aFarm.getCatsCount().ToString();
            lbDogsCount.Text = aFarm.getDogsCount().ToString();
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
                aFarm.selectPet(aFarm.getFarmPetByNickname(getSelectedPetNickName(listBox1.Items[selectedIndex].ToString())));
                lbVoice.Text = aFarm.getSelectedPet().doVoice();
                pictureBox1.Refresh();
            }
        }

        private void nudTimeout_ValueChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = Convert.ToInt32(nudTimeout.Value);
            timer1.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            gbxLog.Visible = !gbxLog.Visible;
            if (gbxLog.Visible)
            {
                bViewLog.Text = "Hide log";
            }else
            {
                bViewLog.Text = "View log";
            }
        }
    }
}

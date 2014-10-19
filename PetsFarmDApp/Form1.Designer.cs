namespace PetsFarm
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.lbVoice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPetsCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFarmAge = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFarmSize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCols = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nudTimeout = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.bViewLog = new System.Windows.Forms.Button();
            this.gbxLog = new System.Windows.Forms.GroupBox();
            this.lbCatsCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDogsCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).BeginInit();
            this.gbxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "New farm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbVoice
            // 
            this.lbVoice.AutoSize = true;
            this.lbVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVoice.ForeColor = System.Drawing.Color.Red;
            this.lbVoice.Location = new System.Drawing.Point(15, 143);
            this.lbVoice.Name = "lbVoice";
            this.lbVoice.Size = new System.Drawing.Size(19, 13);
            this.lbVoice.TabIndex = 1;
            this.lbVoice.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 337);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 152);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pets count:";
            // 
            // lbPetsCount
            // 
            this.lbPetsCount.AutoSize = true;
            this.lbPetsCount.Location = new System.Drawing.Point(82, 64);
            this.lbPetsCount.Name = "lbPetsCount";
            this.lbPetsCount.Size = new System.Drawing.Size(13, 13);
            this.lbPetsCount.TabIndex = 9;
            this.lbPetsCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Farm age:";
            // 
            // lbFarmAge
            // 
            this.lbFarmAge.AutoSize = true;
            this.lbFarmAge.Location = new System.Drawing.Point(75, 9);
            this.lbFarmAge.Name = "lbFarmAge";
            this.lbFarmAge.Size = new System.Drawing.Size(13, 13);
            this.lbFarmAge.TabIndex = 11;
            this.lbFarmAge.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbPCount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbRows);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudTimeout);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbCols);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 51);
            this.panel1.TabIndex = 12;
            // 
            // lbFarmSize
            // 
            this.lbFarmSize.AutoSize = true;
            this.lbFarmSize.Location = new System.Drawing.Point(75, 37);
            this.lbFarmSize.Name = "lbFarmSize";
            this.lbFarmSize.Size = new System.Drawing.Size(13, 13);
            this.lbFarmSize.TabIndex = 19;
            this.lbFarmSize.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Farm size:";
            // 
            // tbPCount
            // 
            this.tbPCount.Location = new System.Drawing.Point(382, 15);
            this.tbPCount.Name = "tbPCount";
            this.tbPCount.Size = new System.Drawing.Size(52, 20);
            this.tbPCount.TabIndex = 17;
            this.tbPCount.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pets count:";
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(248, 14);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(52, 20);
            this.tbRows.TabIndex = 15;
            this.tbRows.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rows:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cols:";
            // 
            // tbCols
            // 
            this.tbCols.Location = new System.Drawing.Point(146, 14);
            this.tbCols.Name = "tbCols";
            this.tbCols.Size = new System.Drawing.Size(52, 20);
            this.tbCols.TabIndex = 12;
            this.tbCols.Text = "50";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbDogsCount);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lbCatsCount);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbFarmSize);
            this.panel3.Controls.Add(this.gbxLog);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.bViewLog);
            this.panel3.Controls.Add(this.lbVoice);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbPetsCount);
            this.panel3.Controls.Add(this.lbFarmAge);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(759, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 519);
            this.panel3.TabIndex = 14;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 403);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Black;
            series10.Legend = "Legend1";
            series10.LegendText = "Population";
            series10.Name = "Series1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Red;
            series11.Legend = "Legend1";
            series11.LegendText = "Cats";
            series11.Name = "Series2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Blue;
            series12.Legend = "Legend1";
            series12.LegendText = "Dogs";
            series12.Name = "Series3";
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(740, 155);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // nudTimeout
            // 
            this.nudTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTimeout.Location = new System.Drawing.Point(617, 15);
            this.nudTimeout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimeout.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTimeout.Name = "nudTimeout";
            this.nudTimeout.Size = new System.Drawing.Size(63, 20);
            this.nudTimeout.TabIndex = 8;
            this.nudTimeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimeout.ValueChanged += new System.EventHandler(this.nudTimeout_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tick timeout:";
            // 
            // bViewLog
            // 
            this.bViewLog.Location = new System.Drawing.Point(18, 170);
            this.bViewLog.Name = "bViewLog";
            this.bViewLog.Size = new System.Drawing.Size(75, 23);
            this.bViewLog.TabIndex = 10;
            this.bViewLog.Text = "View log";
            this.bViewLog.UseVisualStyleBackColor = true;
            this.bViewLog.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // gbxLog
            // 
            this.gbxLog.Controls.Add(this.listBox1);
            this.gbxLog.Location = new System.Drawing.Point(15, 336);
            this.gbxLog.Name = "gbxLog";
            this.gbxLog.Size = new System.Drawing.Size(186, 171);
            this.gbxLog.TabIndex = 11;
            this.gbxLog.TabStop = false;
            this.gbxLog.Text = "Log";
            this.gbxLog.Visible = false;
            // 
            // lbCatsCount
            // 
            this.lbCatsCount.AutoSize = true;
            this.lbCatsCount.Location = new System.Drawing.Point(82, 91);
            this.lbCatsCount.Name = "lbCatsCount";
            this.lbCatsCount.Size = new System.Drawing.Size(13, 13);
            this.lbCatsCount.TabIndex = 21;
            this.lbCatsCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cats count:";
            // 
            // lbDogsCount
            // 
            this.lbDogsCount.AutoSize = true;
            this.lbDogsCount.Location = new System.Drawing.Point(82, 118);
            this.lbDogsCount.Name = "lbDogsCount";
            this.lbDogsCount.Size = new System.Drawing.Size(13, 13);
            this.lbDogsCount.TabIndex = 23;
            this.lbDogsCount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Dogs count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 570);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Pets farm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).EndInit();
            this.gbxLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbVoice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPetsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFarmAge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCols;
        private System.Windows.Forms.Label lbFarmSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTimeout;
        private System.Windows.Forms.Button bViewLog;
        private System.Windows.Forms.GroupBox gbxLog;
        private System.Windows.Forms.Label lbDogsCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbCatsCount;
        private System.Windows.Forms.Label label9;
    }
}


namespace Proga_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Valve2_Down = new System.Windows.Forms.Button();
            this.lb_Valve2 = new System.Windows.Forms.Label();
            this.button_Valve2_Up = new System.Windows.Forms.Button();
            this.button_Valve3_Up = new System.Windows.Forms.Button();
            this.lb_Valve3 = new System.Windows.Forms.Label();
            this.button_Valve3_Down = new System.Windows.Forms.Button();
            this.button_Valve4_Up = new System.Windows.Forms.Button();
            this.lb_Valve4 = new System.Windows.Forms.Label();
            this.button_Valve4_Down = new System.Windows.Forms.Button();
            this.button_Valve1_Up = new System.Windows.Forms.Button();
            this.lb_Valve1 = new System.Windows.Forms.Label();
            this.button_Valve1_Down = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_IndexSetpoint = new System.Windows.Forms.Label();
            this.textBox_Setpoint = new System.Windows.Forms.TextBox();
            this.lb_CurrentSetpoint = new System.Windows.Forms.Label();
            this.lb_CurrentK = new System.Windows.Forms.Label();
            this.textBox_K = new System.Windows.Forms.TextBox();
            this.lb_IndexK = new System.Windows.Forms.Label();
            this.lb_CurrentTi = new System.Windows.Forms.Label();
            this.textBox_Ti = new System.Windows.Forms.TextBox();
            this.lb_IndexTi = new System.Windows.Forms.Label();
            this.lb_CurrentTd = new System.Windows.Forms.Label();
            this.textBox_Td = new System.Windows.Forms.TextBox();
            this.lb_IndexTd = new System.Windows.Forms.Label();
            this.button_Set = new System.Windows.Forms.Button();
            this.button_Mode = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_X1 = new System.Windows.Forms.Button();
            this.button_X10 = new System.Windows.Forms.Button();
            this.lb_FirstVesselLevel = new System.Windows.Forms.Label();
            this.lb_SecondVesselLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_Valve2_Down
            // 
            this.button_Valve2_Down.Location = new System.Drawing.Point(25, 242);
            this.button_Valve2_Down.Name = "button_Valve2_Down";
            this.button_Valve2_Down.Size = new System.Drawing.Size(25, 25);
            this.button_Valve2_Down.TabIndex = 1;
            this.button_Valve2_Down.Text = "<";
            this.button_Valve2_Down.UseVisualStyleBackColor = true;
            this.button_Valve2_Down.Click += new System.EventHandler(this.button_Valve2_Down_Click);
            // 
            // lb_Valve2
            // 
            this.lb_Valve2.AutoSize = true;
            this.lb_Valve2.Location = new System.Drawing.Point(56, 248);
            this.lb_Valve2.Name = "lb_Valve2";
            this.lb_Valve2.Size = new System.Drawing.Size(10, 13);
            this.lb_Valve2.TabIndex = 2;
            this.lb_Valve2.Text = "-";
            // 
            // button_Valve2_Up
            // 
            this.button_Valve2_Up.Location = new System.Drawing.Point(80, 242);
            this.button_Valve2_Up.Name = "button_Valve2_Up";
            this.button_Valve2_Up.Size = new System.Drawing.Size(25, 25);
            this.button_Valve2_Up.TabIndex = 3;
            this.button_Valve2_Up.Text = ">";
            this.button_Valve2_Up.UseVisualStyleBackColor = true;
            this.button_Valve2_Up.Click += new System.EventHandler(this.button_Valve2_Up_Click);
            // 
            // button_Valve3_Up
            // 
            this.button_Valve3_Up.Location = new System.Drawing.Point(203, 242);
            this.button_Valve3_Up.Name = "button_Valve3_Up";
            this.button_Valve3_Up.Size = new System.Drawing.Size(25, 25);
            this.button_Valve3_Up.TabIndex = 6;
            this.button_Valve3_Up.Text = ">";
            this.button_Valve3_Up.UseVisualStyleBackColor = true;
            this.button_Valve3_Up.Click += new System.EventHandler(this.button_Valve3_Up_Click);
            // 
            // lb_Valve3
            // 
            this.lb_Valve3.AutoSize = true;
            this.lb_Valve3.Location = new System.Drawing.Point(178, 248);
            this.lb_Valve3.Name = "lb_Valve3";
            this.lb_Valve3.Size = new System.Drawing.Size(10, 13);
            this.lb_Valve3.TabIndex = 5;
            this.lb_Valve3.Text = "-";
            // 
            // button_Valve3_Down
            // 
            this.button_Valve3_Down.Location = new System.Drawing.Point(147, 242);
            this.button_Valve3_Down.Name = "button_Valve3_Down";
            this.button_Valve3_Down.Size = new System.Drawing.Size(25, 25);
            this.button_Valve3_Down.TabIndex = 4;
            this.button_Valve3_Down.Text = "<";
            this.button_Valve3_Down.UseVisualStyleBackColor = true;
            this.button_Valve3_Down.Click += new System.EventHandler(this.button_Valve3_Down_Click);
            // 
            // button_Valve4_Up
            // 
            this.button_Valve4_Up.Location = new System.Drawing.Point(310, 242);
            this.button_Valve4_Up.Name = "button_Valve4_Up";
            this.button_Valve4_Up.Size = new System.Drawing.Size(25, 25);
            this.button_Valve4_Up.TabIndex = 9;
            this.button_Valve4_Up.Text = ">";
            this.button_Valve4_Up.UseVisualStyleBackColor = true;
            this.button_Valve4_Up.Click += new System.EventHandler(this.button_Valve4_Up_Click);
            // 
            // lb_Valve4
            // 
            this.lb_Valve4.AutoSize = true;
            this.lb_Valve4.Location = new System.Drawing.Point(290, 248);
            this.lb_Valve4.Name = "lb_Valve4";
            this.lb_Valve4.Size = new System.Drawing.Size(10, 13);
            this.lb_Valve4.TabIndex = 8;
            this.lb_Valve4.Text = "-";
            // 
            // button_Valve4_Down
            // 
            this.button_Valve4_Down.Location = new System.Drawing.Point(259, 242);
            this.button_Valve4_Down.Name = "button_Valve4_Down";
            this.button_Valve4_Down.Size = new System.Drawing.Size(25, 25);
            this.button_Valve4_Down.TabIndex = 7;
            this.button_Valve4_Down.Text = "<";
            this.button_Valve4_Down.UseVisualStyleBackColor = true;
            this.button_Valve4_Down.Click += new System.EventHandler(this.button_Valve4_Down_Click);
            // 
            // button_Valve1_Up
            // 
            this.button_Valve1_Up.Location = new System.Drawing.Point(108, 22);
            this.button_Valve1_Up.Name = "button_Valve1_Up";
            this.button_Valve1_Up.Size = new System.Drawing.Size(25, 25);
            this.button_Valve1_Up.TabIndex = 12;
            this.button_Valve1_Up.Text = ">";
            this.button_Valve1_Up.UseVisualStyleBackColor = true;
            this.button_Valve1_Up.Click += new System.EventHandler(this.button_Valve1_Up_Click);
            // 
            // lb_Valve1
            // 
            this.lb_Valve1.AutoSize = true;
            this.lb_Valve1.Location = new System.Drawing.Point(83, 28);
            this.lb_Valve1.Name = "lb_Valve1";
            this.lb_Valve1.Size = new System.Drawing.Size(10, 13);
            this.lb_Valve1.TabIndex = 11;
            this.lb_Valve1.Text = "-";
            // 
            // button_Valve1_Down
            // 
            this.button_Valve1_Down.Location = new System.Drawing.Point(52, 22);
            this.button_Valve1_Down.Name = "button_Valve1_Down";
            this.button_Valve1_Down.Size = new System.Drawing.Size(25, 25);
            this.button_Valve1_Down.TabIndex = 10;
            this.button_Valve1_Down.Text = "<";
            this.button_Valve1_Down.UseVisualStyleBackColor = true;
            this.button_Valve1_Down.Click += new System.EventHandler(this.button_Valve1_Down_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(362, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(426, 300);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // lb_IndexSetpoint
            // 
            this.lb_IndexSetpoint.AutoSize = true;
            this.lb_IndexSetpoint.Location = new System.Drawing.Point(12, 335);
            this.lb_IndexSetpoint.Name = "lb_IndexSetpoint";
            this.lb_IndexSetpoint.Size = new System.Drawing.Size(46, 13);
            this.lb_IndexSetpoint.TabIndex = 14;
            this.lb_IndexSetpoint.Text = "Setpoint";
            // 
            // textBox_Setpoint
            // 
            this.textBox_Setpoint.Location = new System.Drawing.Point(66, 333);
            this.textBox_Setpoint.Name = "textBox_Setpoint";
            this.textBox_Setpoint.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setpoint.TabIndex = 15;
            // 
            // lb_CurrentSetpoint
            // 
            this.lb_CurrentSetpoint.AutoSize = true;
            this.lb_CurrentSetpoint.Location = new System.Drawing.Point(172, 336);
            this.lb_CurrentSetpoint.Name = "lb_CurrentSetpoint";
            this.lb_CurrentSetpoint.Size = new System.Drawing.Size(10, 13);
            this.lb_CurrentSetpoint.TabIndex = 16;
            this.lb_CurrentSetpoint.Text = "-";
            // 
            // lb_CurrentK
            // 
            this.lb_CurrentK.AutoSize = true;
            this.lb_CurrentK.Location = new System.Drawing.Point(172, 362);
            this.lb_CurrentK.Name = "lb_CurrentK";
            this.lb_CurrentK.Size = new System.Drawing.Size(10, 13);
            this.lb_CurrentK.TabIndex = 19;
            this.lb_CurrentK.Text = "-";
            // 
            // textBox_K
            // 
            this.textBox_K.Location = new System.Drawing.Point(66, 359);
            this.textBox_K.Name = "textBox_K";
            this.textBox_K.Size = new System.Drawing.Size(100, 20);
            this.textBox_K.TabIndex = 18;
            // 
            // lb_IndexK
            // 
            this.lb_IndexK.AutoSize = true;
            this.lb_IndexK.Location = new System.Drawing.Point(41, 362);
            this.lb_IndexK.Name = "lb_IndexK";
            this.lb_IndexK.Size = new System.Drawing.Size(14, 13);
            this.lb_IndexK.TabIndex = 17;
            this.lb_IndexK.Text = "K";
            // 
            // lb_CurrentTi
            // 
            this.lb_CurrentTi.AutoSize = true;
            this.lb_CurrentTi.Location = new System.Drawing.Point(172, 388);
            this.lb_CurrentTi.Name = "lb_CurrentTi";
            this.lb_CurrentTi.Size = new System.Drawing.Size(10, 13);
            this.lb_CurrentTi.TabIndex = 22;
            this.lb_CurrentTi.Text = "-";
            // 
            // textBox_Ti
            // 
            this.textBox_Ti.Location = new System.Drawing.Point(66, 385);
            this.textBox_Ti.Name = "textBox_Ti";
            this.textBox_Ti.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ti.TabIndex = 21;
            // 
            // lb_IndexTi
            // 
            this.lb_IndexTi.AutoSize = true;
            this.lb_IndexTi.Location = new System.Drawing.Point(39, 388);
            this.lb_IndexTi.Name = "lb_IndexTi";
            this.lb_IndexTi.Size = new System.Drawing.Size(16, 13);
            this.lb_IndexTi.TabIndex = 20;
            this.lb_IndexTi.Text = "Ti";
            // 
            // lb_CurrentTd
            // 
            this.lb_CurrentTd.AutoSize = true;
            this.lb_CurrentTd.Location = new System.Drawing.Point(172, 414);
            this.lb_CurrentTd.Name = "lb_CurrentTd";
            this.lb_CurrentTd.Size = new System.Drawing.Size(10, 13);
            this.lb_CurrentTd.TabIndex = 25;
            this.lb_CurrentTd.Text = "-";
            // 
            // textBox_Td
            // 
            this.textBox_Td.Location = new System.Drawing.Point(66, 411);
            this.textBox_Td.Name = "textBox_Td";
            this.textBox_Td.Size = new System.Drawing.Size(100, 20);
            this.textBox_Td.TabIndex = 24;
            // 
            // lb_IndexTd
            // 
            this.lb_IndexTd.AutoSize = true;
            this.lb_IndexTd.Location = new System.Drawing.Point(35, 414);
            this.lb_IndexTd.Name = "lb_IndexTd";
            this.lb_IndexTd.Size = new System.Drawing.Size(20, 13);
            this.lb_IndexTd.TabIndex = 23;
            this.lb_IndexTd.Text = "Td";
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(80, 304);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(75, 23);
            this.button_Set.TabIndex = 26;
            this.button_Set.Text = "Set";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // button_Mode
            // 
            this.button_Mode.Location = new System.Drawing.Point(80, 275);
            this.button_Mode.Name = "button_Mode";
            this.button_Mode.Size = new System.Drawing.Size(75, 23);
            this.button_Mode.TabIndex = 27;
            this.button_Mode.Text = "Auto";
            this.button_Mode.UseVisualStyleBackColor = true;
            this.button_Mode.Click += new System.EventHandler(this.button_Mode_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(362, 359);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 28;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(362, 330);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 29;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_X1
            // 
            this.button_X1.Location = new System.Drawing.Point(362, 388);
            this.button_X1.Name = "button_X1";
            this.button_X1.Size = new System.Drawing.Size(35, 35);
            this.button_X1.TabIndex = 31;
            this.button_X1.Text = "x1";
            this.button_X1.UseVisualStyleBackColor = true;
            this.button_X1.Click += new System.EventHandler(this.button_X1_Click);
            // 
            // button_X10
            // 
            this.button_X10.Location = new System.Drawing.Point(402, 388);
            this.button_X10.Name = "button_X10";
            this.button_X10.Size = new System.Drawing.Size(35, 35);
            this.button_X10.TabIndex = 32;
            this.button_X10.Text = "x10";
            this.button_X10.UseVisualStyleBackColor = true;
            this.button_X10.Click += new System.EventHandler(this.button_X10_Click);
            // 
            // lb_FirstVesselLevel
            // 
            this.lb_FirstVesselLevel.AutoSize = true;
            this.lb_FirstVesselLevel.Location = new System.Drawing.Point(98, 130);
            this.lb_FirstVesselLevel.Name = "lb_FirstVesselLevel";
            this.lb_FirstVesselLevel.Size = new System.Drawing.Size(10, 13);
            this.lb_FirstVesselLevel.TabIndex = 33;
            this.lb_FirstVesselLevel.Text = "-";
            // 
            // lb_SecondVesselLevel
            // 
            this.lb_SecondVesselLevel.AutoSize = true;
            this.lb_SecondVesselLevel.Location = new System.Drawing.Point(240, 130);
            this.lb_SecondVesselLevel.Name = "lb_SecondVesselLevel";
            this.lb_SecondVesselLevel.Size = new System.Drawing.Size(10, 13);
            this.lb_SecondVesselLevel.TabIndex = 34;
            this.lb_SecondVesselLevel.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_SecondVesselLevel);
            this.Controls.Add(this.lb_FirstVesselLevel);
            this.Controls.Add(this.button_X10);
            this.Controls.Add(this.button_X1);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Mode);
            this.Controls.Add(this.button_Set);
            this.Controls.Add(this.lb_CurrentTd);
            this.Controls.Add(this.textBox_Td);
            this.Controls.Add(this.lb_IndexTd);
            this.Controls.Add(this.lb_CurrentTi);
            this.Controls.Add(this.textBox_Ti);
            this.Controls.Add(this.lb_IndexTi);
            this.Controls.Add(this.lb_CurrentK);
            this.Controls.Add(this.textBox_K);
            this.Controls.Add(this.lb_IndexK);
            this.Controls.Add(this.lb_CurrentSetpoint);
            this.Controls.Add(this.textBox_Setpoint);
            this.Controls.Add(this.lb_IndexSetpoint);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_Valve1_Up);
            this.Controls.Add(this.lb_Valve1);
            this.Controls.Add(this.button_Valve1_Down);
            this.Controls.Add(this.button_Valve4_Up);
            this.Controls.Add(this.lb_Valve4);
            this.Controls.Add(this.button_Valve4_Down);
            this.Controls.Add(this.button_Valve3_Up);
            this.Controls.Add(this.lb_Valve3);
            this.Controls.Add(this.button_Valve3_Down);
            this.Controls.Add(this.button_Valve2_Up);
            this.Controls.Add(this.lb_Valve2);
            this.Controls.Add(this.button_Valve2_Down);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Valve2_Down;
        private System.Windows.Forms.Label lb_Valve2;
        private System.Windows.Forms.Button button_Valve2_Up;
        private System.Windows.Forms.Button button_Valve3_Up;
        private System.Windows.Forms.Label lb_Valve3;
        private System.Windows.Forms.Button button_Valve3_Down;
        private System.Windows.Forms.Button button_Valve4_Up;
        private System.Windows.Forms.Label lb_Valve4;
        private System.Windows.Forms.Button button_Valve4_Down;
        private System.Windows.Forms.Button button_Valve1_Up;
        private System.Windows.Forms.Label lb_Valve1;
        private System.Windows.Forms.Button button_Valve1_Down;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lb_IndexSetpoint;
        private System.Windows.Forms.TextBox textBox_Setpoint;
        private System.Windows.Forms.Label lb_CurrentSetpoint;
        private System.Windows.Forms.Label lb_CurrentK;
        private System.Windows.Forms.TextBox textBox_K;
        private System.Windows.Forms.Label lb_IndexK;
        private System.Windows.Forms.Label lb_CurrentTi;
        private System.Windows.Forms.TextBox textBox_Ti;
        private System.Windows.Forms.Label lb_IndexTi;
        private System.Windows.Forms.Label lb_CurrentTd;
        private System.Windows.Forms.TextBox textBox_Td;
        private System.Windows.Forms.Label lb_IndexTd;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.Button button_Mode;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_X1;
        private System.Windows.Forms.Button button_X10;
        private System.Windows.Forms.Label lb_FirstVesselLevel;
        private System.Windows.Forms.Label lb_SecondVesselLevel;
    }
}


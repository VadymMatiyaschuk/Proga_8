using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proga_8
{
    public partial class Form1 : Form
    {
        private ControlSystem controlSystem;

        public Form1()
        {
            controlSystem = new ControlSystem(1);
            InitializeComponent();
            button_Valve3_Down.Hide();
            button_Valve3_Up.Hide();
        }

        private void button_Valve1_Down_Click(object sender, EventArgs e)
        {
            controlSystem.objectModel.Valve1 -= 1;
            lb_Valve1.Text = controlSystem.objectModel.Valve1.ToString();
        }

        private void button_Valve1_Up_Click(object sender, EventArgs e)
        {
            controlSystem.objectModel.Valve1 += 1;
            lb_Valve1.Text = controlSystem.objectModel.Valve1.ToString();
        }

        private void button_Valve2_Down_Click(object sender, EventArgs e)
        {
            controlSystem.objectModel.Valve2 -= 1;
            lb_Valve2.Text = controlSystem.objectModel.Valve2.ToString();
        }

        private void button_Valve2_Up_Click(object sender, EventArgs e)
        {
            controlSystem.objectModel.Valve2 += 1;
            lb_Valve2.Text = controlSystem.objectModel.Valve2.ToString();
        }

        private void button_Valve3_Down_Click(object sender, EventArgs e)
        {
            controlSystem.objectModel.Valve3 -= 1;
            lb_Valve3.Text = controlSystem.objectModel.Valve3.ToString();
        }

        private void button_Valve3_Up_Click(object sender, EventArgs e)
        {
            controlSystem.objectModel.Valve3 += 1;
            lb_Valve3.Text = controlSystem.objectModel.Valve3.ToString();
        }

        private void button_Valve4_Down_Click(object sender, EventArgs e)
        {
            controlSystem.objectModel.Valve4 -= 1;
            lb_Valve4.Text = controlSystem.objectModel.Valve4.ToString();
        }

        private void button_Valve4_Up_Click(object sender, EventArgs e)
        {
            controlSystem.objectModel.Valve4 += 1;
            lb_Valve4.Text = controlSystem.objectModel.Valve4.ToString();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button_X1_Click(object sender, EventArgs e)
        {
            timer.Interval = 1000;
        }

        private void button_X10_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
        }

        private void button_Mode_Click(object sender, EventArgs e)
        {
            controlSystem.IsManual = !controlSystem.IsManual;

            if (controlSystem.IsManual) {
                button_Mode.Text = "Manual";

                button_Valve3_Down.Show();
                button_Valve3_Up.Show();
                button_Set.Hide();
                lb_IndexSetpoint.Hide();
                lb_IndexK.Hide();
                lb_IndexTi.Hide();
                lb_IndexTd.Hide();
                lb_CurrentSetpoint.Hide();
                lb_CurrentK.Hide();
                lb_CurrentTi.Hide();
                lb_CurrentTd.Hide();
                textBox_Setpoint.Hide();
                textBox_K.Hide();
                textBox_Ti.Hide();
                textBox_Td.Hide();
            } else {
                button_Mode.Text = "Auto";

                button_Valve3_Down.Hide();
                button_Valve3_Up.Hide();
                button_Set.Show();
                lb_IndexSetpoint.Show();
                lb_IndexK.Show();
                lb_IndexTi.Show();
                lb_IndexTd.Show();
                lb_CurrentSetpoint.Show();
                lb_CurrentK.Show();
                lb_CurrentTi.Show();
                lb_CurrentTd.Show();
                textBox_Setpoint.Show();
                textBox_K.Show();
                textBox_Ti.Show();
                textBox_Td.Show();
            }
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            if (textBox_Setpoint.Text != "")
            {
                controlSystem.Setpoint = double.Parse(textBox_Setpoint.Text.ToString());
                lb_CurrentSetpoint.Text = controlSystem.Setpoint.ToString();
            }
            if (textBox_K.Text != "")
            {
                controlSystem.K = double.Parse(textBox_K.Text.ToString());
                lb_CurrentK.Text = controlSystem.K.ToString();
            }
            if (textBox_Ti.Text != "")
            {
                controlSystem.Ti = double.Parse(textBox_Ti.Text.ToString());
                lb_CurrentTi.Text = controlSystem.Ti.ToString();
            }
            if (textBox_Td.Text != "")
            {
                controlSystem.Td = double.Parse(textBox_Td.Text.ToString());
                lb_CurrentTd.Text = controlSystem.Td.ToString();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var secondVesselLevel = controlSystem.GetValue();
            lb_Valve3.Text = controlSystem.objectModel.Valve3.ToString();

            chart1.Series[0].Points.AddXY(controlSystem.Time, secondVesselLevel);
            if (chart1.Series[0].Points.Count > 100)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.ChartAreas[0].RecalculateAxesScale();
            }
            lb_FirstVesselLevel.Text = controlSystem.objectModel.FirstVesselValue.ToString();
            lb_SecondVesselLevel.Text = controlSystem.objectModel.SecondVesselValue.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGdiSpeedometerApp
{
    public partial class Form1 : Form
    {
        private System.Threading.Timer timerRedraw;
        private double increment = 1f;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gdiSpeedometer1.MinSpeed = 0;
            gdiSpeedometer1.MaxSpeed = 100;
            gdiSpeedometer1.Speed = 63;
            gdiSpeedometer1.Text = "%";
            gdiSpeedometer1.ShowGaugeScale = true;
            gdiSpeedometer1.ShowNeedle = true;
            gdiSpeedometer1.GaugeThickness = 3;
            gdiSpeedometer1.BackColor = Color.White;
            gdiSpeedometer1.GaugeColor = Color.Black;
            gdiSpeedometer1.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gdiSpeedometer1.MinSpeed = -5;
            gdiSpeedometer1.MaxSpeed = 5;
            gdiSpeedometer1.Speed = -1;
            gdiSpeedometer1.BackColor = Color.White;
            gdiSpeedometer1.Text = "Accelerometer";
            gdiSpeedometer1.ShowGaugeScale = true;
            gdiSpeedometer1.ShowNeedle = true;
            gdiSpeedometer1.GaugeThickness = 5;
            gdiSpeedometer1.GaugeColor = Color.Black;
            gdiSpeedometer1.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gdiSpeedometer1.MinSpeed = -5;
            gdiSpeedometer1.MaxSpeed = 5;
            gdiSpeedometer1.Speed = -1;
            gdiSpeedometer1.BackColor = Color.Black;
            gdiSpeedometer1.Text = "Accelerometer";
            gdiSpeedometer1.ShowNeedle = false;
            gdiSpeedometer1.ShowGaugeScale = false;
            gdiSpeedometer1.GaugeThickness = 10;
            gdiSpeedometer1.GaugeColor = Color.White;
            gdiSpeedometer1.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gdiSpeedometer1.MinSpeed = 0;
            gdiSpeedometer1.MaxSpeed = 100;
            gdiSpeedometer1.Speed = 0;
            gdiSpeedometer1.Text = "%";
            gdiSpeedometer1.ShowGaugeScale = true;
            gdiSpeedometer1.ShowNeedle = true;
            gdiSpeedometer1.GaugeThickness = 3;
            gdiSpeedometer1.BackColor = Color.White;
            gdiSpeedometer1.GaugeColor = Color.Black;
            gdiSpeedometer1.ForeColor = Color.Black;

            increment = 1f;
            System.Threading.TimerCallback tcb = this.timerRedraw_tick_invoker;
            timerRedraw = new System.Threading.Timer(tcb, null, 0, 50);
        }

        private void timerRedraw_tick_invoker(object sender)
        {
            if (base.IsHandleCreated)
            {
                base.BeginInvoke((MethodInvoker)delegate { timerRedraw_tick(sender); });
            }
        }

        private void timerRedraw_tick(object sender)
        {
            if(gdiSpeedometer1.Speed < 100.0f)
            {
                gdiSpeedometer1.Speed = gdiSpeedometer1.Speed + increment;
            }
            else
            {
                timerRedraw.Dispose();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gdiSpeedometer1.MinSpeed = 0;
            gdiSpeedometer1.MaxSpeed = 100;
            gdiSpeedometer1.Speed = 0;
            gdiSpeedometer1.Text = "%";
            gdiSpeedometer1.ShowGaugeScale = true;
            gdiSpeedometer1.ShowNeedle = true;
            gdiSpeedometer1.GaugeThickness = 3;
            gdiSpeedometer1.BackColor = Color.White;
            gdiSpeedometer1.GaugeColor = Color.Black;
            gdiSpeedometer1.ForeColor = Color.Black;

            increment = 0.1f;
            System.Threading.TimerCallback tcb = this.timerRedraw_tick_invoker;
            timerRedraw = new System.Threading.Timer(tcb, null, 0, 10);
        }
    }
}

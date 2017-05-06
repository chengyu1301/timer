using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace timer
{
    public partial class Form1 : Form
    {
        private Point startPoint;

        Form2 f = new Form2();
        int screenWidth;
        int screenHeight;
        bool lockstate = false;
        

        public Form1()
        {
            /*
            Process[] ps = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (ps.Length > 1)
            {
                MessageBox.Show("Another process is running, please terminate it first!");
                //this.Close();
                Environment.Exit(Environment.ExitCode);
            }
            */
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            screenHeight = Screen.PrimaryScreen.WorkingArea.Height;


            this.Width = f.Width;
            this.Height = f.Height;

            this.Left = screenWidth - this.Width;
            this.Top = 1;
            f.Show(this);
            f.Top = this.Top;
            f.Left = this.Left;

            this.Opacity = 0.01;

            notifyIcon1.ShowBalloonTip(1000, "The timer is running", "You can change the color here!", ToolTipIcon.Info);
            if (lockstate)
            {
                this.Opacity = 0.01;
                lockToolStripMenuItem.Text = "Lock";
            }
            else
            {
                this.Opacity = 0;
                lockToolStripMenuItem.Text = "Unlock";
            }
            lockstate = !lockstate;
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            f.Top = this.Top;
            f.Left = this.Left;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(-e.X + SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(startPoint.X, startPoint.Y);
                Location = mousePos;
            }
        }

        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.updateColor("Red");
        }

        private void 藍色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.updateColor("Blue");
        }

        private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.updateColor("Black");
        }

        private void 白色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.updateColor("White");
        }

        private void 黃色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.updateColor("Yellow");
        }

        private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.updateColor("Green");
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lockstate)
            {
                this.Opacity = 0.01;
                lockToolStripMenuItem.Text = "Lock";
            }
            else
            {
                this.Opacity = 0;
                lockToolStripMenuItem.Text = "Unlock";
            }
            lockstate = !lockstate;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 0.3;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            if (lockstate)
            {
                this.Opacity = 0;
            }
            else
            {
                this.Opacity = 0.01;
            }
        }
    }



 
}

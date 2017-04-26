using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form2 : Form
    {

        private const uint WS_EX_LAYERED = 0x80000;

        private const int WS_EX_TRANSPARENT = 0x20;

        private const int GWL_STYLE = (-16);

        private const int GWL_EXSTYLE = (-20);

        private const int LWA_ALPHA = 0;


        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);

        public Form2()
        {
            InitializeComponent();
            SetPenetrate();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer1.Enabled = true;
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void updateColor(string c)
        {
            switch (c)
            {
                case "Red":
                    labelTime.ForeColor = Color.Red;
                    labelPromptString.ForeColor = Color.Red;
                    break;
                case "Blue":
                    labelTime.ForeColor = Color.DeepSkyBlue;
                    labelPromptString.ForeColor = Color.DeepSkyBlue;
                    break;
                case "Black":
                    labelTime.ForeColor = Color.Black;
                    labelPromptString.ForeColor = Color.Black;
                    break;
                case "White":
                    labelTime.ForeColor = Color.White;
                    labelPromptString.ForeColor = Color.White;
                    break;
                case "Yellow":
                    labelTime.ForeColor = Color.Yellow;
                    labelPromptString.ForeColor = Color.Yellow;
                    break;
                case "Green":
                    labelTime.ForeColor = Color.Lime;
                    labelPromptString.ForeColor = Color.Lime;
                    break;

                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ; GC.Collect();
        }


        public void SetPenetrate()
        {

            GetWindowLong(this.Handle, GWL_EXSTYLE);

            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);

        } 

    }
}

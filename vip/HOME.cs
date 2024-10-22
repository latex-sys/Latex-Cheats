using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vip
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(468, 577);
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                ss.Text = "Open Emulator";
                Console.Beep();
            }
            else
            {

            }
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2ToggleSwitch2.Checked)
            {
                ss.Text = "Open Emulator";
                Console.Beep();
            }
            else
            {

            }
        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2ToggleSwitch3.Checked)
            {
                ss.Text = "Open Emulator";
                Console.Beep();
            }
            else
            {

            }
        }

        private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2ToggleSwitch4.Checked)
            {
                ss.Text = "Open Emulator";
                Console.Beep();
            }
            else
            {

            }
        }

        private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2ToggleSwitch5.Checked)
            {
                
            }
            else
            {

            }
        }

        private void guna2ToggleSwitch10_CheckedChanged(object sender, EventArgs e)
        {

            if (guna2ToggleSwitch10.Checked)
            {
                ss.Text = "Open Emulator";
                Console.Beep();
            }
            else
            {

            }
        }

        private void guna2ToggleSwitch9_CheckedChanged(object sender, EventArgs e)
        {
            ss.Text = "Open Emulator";
            Console.Beep();
        }

        private void guna2ToggleSwitch8_CheckedChanged(object sender, EventArgs e)
        {
            ss.Text = "Open Emulator";
            Console.Beep();
        }

        private void loc_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2ToggleSwitch7_CheckedChanged(object sender, EventArgs e)
        {
            ss.Text = "Open Emulator";
            Console.Beep();
        }

        private void guna2ToggleSwitch6_CheckedChanged(object sender, EventArgs e)
        {
            ss.Text = "Open Emulator";
            Console.Beep();
        }

        private void guna2ToggleSwitch15_CheckedChanged(object sender, EventArgs e)
        {
            ss.Text = "Open Emulator";
            Console.Beep();
        }

        private void guna2ToggleSwitch14_CheckedChanged(object sender, EventArgs e)
        {
            ss.Text = "Open Emulator";
            Console.Beep();
        }

        private void guna2ToggleSwitch13_CheckedChanged(object sender, EventArgs e)
        {
            ss.Text = "Open Emulator";
            Console.Beep();
        }

        private void guna2ToggleSwitch12_CheckedChanged(object sender, EventArgs e)
        {
            ss.Text = "Open Emulator";
            Console.Beep();
        }

        private void guna2ToggleSwitch11_CheckedChanged(object sender, EventArgs e)
        {
            ss.Text = "Open Emulator";
            Console.Beep();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            aim.Visible = true;
            loc.Visible = false;
            stng.Visible = false;
            aim.Location = new Point(95, 164);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            stng.Visible = true;
            loc.Visible = false;
            aim.Visible = false;
            stng.Location = new Point(95, 164);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            loc.Visible = true;
            stng.Visible = false;
            aim.Visible = false;
            loc.Location = new Point(95, 164);
        }
    }
}

using KeyAuth;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyAuthApp.init();
        }
        public static api KeyAuthApp = new api(
    name: "freePANEL", // App name - VaultCord.com FREE Discord backup bot for members & your entire server saved from terms and nukes!
    ownerid: "rrxZQ6Y3VM", // Account ID
    version: "1.0" // Application version. Used for automatic downloads see video here https://www.youtube.com/watch?v=kW195PLCBKs
                   //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
);
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(user.Text, pass.Text);
            if (KeyAuthApp.response.success)
            {
                this.Hide();
                HOME HM = new HOME();
                HM.Show();


            }
            else
            {
                ss.Text = (KeyAuthApp.response.message);

            }
        }
    }
}

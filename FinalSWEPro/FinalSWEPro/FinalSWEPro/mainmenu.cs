using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSWEPro
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Go to user menu
                //this.Hide();
                usermenu userMenu = new usermenu();
                userMenu.Show();
            }
            else if (radioButton2.Checked)
            {
                // Go to admin menu
                //this.Hide();
                adminmenu adminMenu = new adminmenu();
                adminMenu.Show();
            }

        }

        private void mainmenu_Load(object sender, EventArgs e)
        {

        }
    }
}

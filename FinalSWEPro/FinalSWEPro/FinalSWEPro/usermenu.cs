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
    public partial class usermenu : Form
    {
        public usermenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Don_Form = new makedonation();
            Don_Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            viewpreviousdonations vpd = new viewpreviousdonations();
            vpd.Show();
        }

        private void usermenu_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FinalSWEPro
{
    public partial class viewpreviousdonations : Form
    {
        OracleDataAdapter adapter;

        DataSet ds;

        public viewpreviousdonations()
        {
            InitializeComponent();
        }

        private void VPD_btn_Click(object sender, EventArgs e)
        {
            string connection_str = "Data Source=orcl; User Id=hr;Password=hr;";

            string command_str = "select USERID, DONATIONID, DONATIONTYPE, DONATIONDATE from DONATIONS where USERID =: id";
            adapter = new OracleDataAdapter(command_str, connection_str);
            adapter.SelectCommand.Parameters.Add("id", textBox1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            DGV.DataSource = ds.Tables[0];
        }

        private void viewpreviousdonations_Load(object sender, EventArgs e)
        {

        }
    }
}

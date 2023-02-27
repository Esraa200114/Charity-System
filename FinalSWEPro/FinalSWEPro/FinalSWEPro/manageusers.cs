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
    public partial class manageusers : Form
    {
        OracleDataAdapter adapter;

        DataSet ds = new DataSet();

        OracleCommandBuilder builder;

        public manageusers()
        {
            InitializeComponent();
        }

        private void manageusers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_str = "Data Source=orcl; User Id=hr;Password=hr;";
            string cmd_str = "select * from user_table";

            adapter = new OracleDataAdapter(cmd_str, con_str);

            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
    }
}

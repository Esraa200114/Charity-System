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
    public partial class makedonation : Form
    {
        string oraDB = "Data Source=orcl; User Id=hr; Password=hr;";
        OracleConnection conn;

        public makedonation()
        {
            InitializeComponent();
        }

        private void makedonation_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(oraDB);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select USERID from USER_TABLE ";
            c.CommandType = CommandType.Text;
            OracleDataReader dataRead = c.ExecuteReader();
            while (dataRead.Read())
            {
                // DIDcomboBox1.Items.Add(dataRead[0].ToString());
                UserID.Items.Add(dataRead[0].ToString());
            }
            dataRead.Close();
            DatetxtBox.Text = DateTime.Now.ToString("dd-MMM-yy");
        }

        private void DonBtn_Click(object sender, EventArgs e)
        {
            int max;
            int newid;
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "GETID"; 
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            command.ExecuteNonQuery();

            try
            {
                max = Convert.ToInt32(command.Parameters["id"].Value.ToString());
                newid = max + 1;

            }
            catch
            {
                newid = 1;
            }


            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "insert into Donations values(:doid,:U,:DT,:Dda)";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add("d", newid);

            comm.Parameters.Add("UID", UserID.Text);
            comm.Parameters.Add("DType", DonTyetxtBox.Text);
            comm.Parameters.Add("Ddat", DatetxtBox.Text);

            int commRe = comm.ExecuteNonQuery();
            if (commRe != -1)
            {

                UserID.Items.Add(UserID.Text);
                MessageBox.Show("Donation Added Successfully !");


            }
        }
    }
}

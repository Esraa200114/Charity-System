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
    public partial class searchdonors : Form
    {
        string ordb = "Data Source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public searchdonors()
        {
            InitializeComponent();
        }

        private void searchdonors_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "select USERID from USER_TABLE";
            cm.CommandType = CommandType.Text;
            OracleDataReader DR = cm.ExecuteReader();
            while (DR.Read())
            {
                idcomboBox1.Items.Add(DR[0].ToString());
            }
            DR.Close();
        }

        private void idcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmdm = new OracleCommand();
            cmdm.Connection = conn;
            cmdm.CommandText = "select USERNAME,ADDRESS from USER_TABLE where USERID=:id";
            cmdm.CommandType = CommandType.Text;
            cmdm.Parameters.Add("id", idcomboBox1.SelectedItem.ToString());
            OracleDataReader dr = cmdm.ExecuteReader();
            if (dr.Read())
            {
                utextBox1.Text = dr[0].ToString();
                addtextBox2.Text = dr[1].ToString();
            }
            dr.Close();
            doncomboBox2.Items.Clear();
        }

        private void ShowDonID_Click(object sender, EventArgs e)
        {
            OracleCommand cmdd = new OracleCommand();
            cmdd.Connection = conn;
            cmdd.CommandText = "GetDonID";
            cmdd.CommandType = CommandType.StoredProcedure;
            cmdd.Parameters.Add("idd", idcomboBox1.SelectedItem.ToString());

            cmdd.Parameters.Add("idDon", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader DOR = cmdd.ExecuteReader();
            while (DOR.Read())

            {

                doncomboBox2.Items.Add(DOR[0].ToString());

            }


            DOR.Close();
        }
    }
}

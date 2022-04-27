using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Election_Management_System
{
    public partial class DisCandidates : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;password=tiger;";
        OracleConnection conn;
        public DisCandidates()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select  Constituency  , Name from Candidates ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cons_cmb.Items.Add(dr[0].ToString());
                Name_cmb.Items.Add(dr[1].ToString());
            }
            dr.Close();
        }
 private void Display_btn_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Candidates where Constituency =:Con ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("Con",Cons_cmb.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Name_cmb.Items.Add(dr[0].ToString());
                BD_txt.Text = dr[1].ToString();
                Add_txt.Text=dr[2].ToString();
                Cons_cmb.Items.Add(dr[3].ToString());
                Elc_txt.Text = dr[4].ToString();
                Bus_txt.Text = dr[5].ToString();
            }
            dr.Close();
        }
         private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Candidates where Name =:name ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", Name_cmb.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Name_cmb.Items.Add(dr[0].ToString());
                BD_txt.Text = dr[1].ToString();
                Add_txt.Text = dr[2].ToString();
                Cons_cmb.Items.Add(dr[3].ToString());
                Elc_txt.Text = dr[4].ToString();
                Bus_txt.Text = dr[5].ToString();
            }
            dr.Close();
        }
        private void candidates_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void DisCandidates_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}

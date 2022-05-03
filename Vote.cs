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
    public partial class Vote : Form
    {
        string ordb = "Data Source = orcl ;User Id=SCOTT ; password = tiger;";
        OracleConnection conn;
        string add;
        int Nid;
        String uname;

        public Vote(String address , int Id)
        {
            InitializeComponent();
            add = address;
            Nid= Id;    
        }

        private void Vote_Load(object sender, EventArgs e)
        {
           
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select Name from Candidates where Constitueny = :Zone";
            cmd.Parameters.Add("Zone", add);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Name_cmb.Items.Add(dr[0]);
            }
            dr.Close();
          
            cmd.CommandText = "Select Name from Users where ID = :id";
            cmd.Parameters.Add("id", Nid);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr1 = cmd.ExecuteReader();
            uname = dr[0].ToString();
            Welcome.Text = "Welcome" + dr[0].ToString();
            dr.Close();

        }

        private void Show_btn_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select Electoralcode , Business from Candidates where Name= :name";
            cmd.Parameters.Add("name", Name_cmb.SelectedItem.ToString());
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Sh_lbl.Text = dr[0].ToString();
                Disc_lbl.Text = dr[1].ToString();
            }
            dr.Close();
        }

        private void Vote_btn_Click(object sender, EventArgs e)
        {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select Voted from Users where Name = :name";
                cmd.Parameters.Add("name", uname);
                OracleDataReader dr0 = cmd.ExecuteReader();
                String voted = dr0[0].ToString();
                dr0.Close();
                if(voted.Equals("NotVoted"))
                {
                cmd.CommandText = "Select Numberofvoting from voting where Name = :name ";
                cmd.Parameters.Add("name", Name_cmb.SelectedItem.ToString());
                OracleDataReader dr = cmd.ExecuteReader();
                int num = Convert.ToInt32(dr[0].ToString());
                dr.Close();
                num++;
                
                cmd.CommandText = "insert into votingvalues (:Name , :Zone  , :Electoralcode , :Numberofvoting)";
                cmd.Parameters.Add("Name", Name_cmb.SelectedItem.ToString());
                cmd.Parameters.Add("Electoralcode", Sh_lbl.Text);
                cmd.Parameters.Add("Zone", add);
                cmd.Parameters.Add("Numberofvoting", num.ToString());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                }
            else
            {
                MessageBox.Show("You are try choose more than (2) and this not illegable");
            }


        }

        private void Vote_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}

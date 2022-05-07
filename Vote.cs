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
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select CANDNAME from Candidates where GOVERNORATE = :Zone";
            cmd.Parameters.Add("Zone", add);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Name_cmb.Items.Add(dr[0]);
            }
            dr.Close();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;

            cmd1.CommandText = "Select USERNAME from Users where ID = :id";
            cmd1.Parameters.Add("id", Id);
            cmd1.CommandType = CommandType.Text;
            OracleDataReader ex = cmd1.ExecuteReader();
            ex.Read();
            uname = ex[0].ToString();
            Welcome.Text = "Welcome  " + ex[0].ToString();
             ex.Close();
        }

  

        private void Show_btn_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select Electoralcode , Business from Candidates where CANDNAME= :name";
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
                cmd.CommandText = "Select Voted from Users where USERNAME = :name";
                cmd.Parameters.Add("name", uname);
                OracleDataReader dr0 = cmd.ExecuteReader();
                dr0.Read();
                String voted = dr0[0].ToString();
                dr0.Close();
                

                if(voted.Equals("n"))
                {
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "select NUMBEROFVOTES from VOTINGVALUES where CANDNAME = :name ";
                cmd1.Parameters.Add("name", Name_cmb.SelectedItem.ToString());
                OracleDataReader r = cmd.ExecuteReader();
                r.Read();
                string num = r[0].ToString();
                r.Close();
                int x = Convert.ToInt32(num);
                x++;
               
                cmd1.CommandText = @"update VOTINGVALUES set NUMBEROFVOTES= :Numberofvoting where CANDNAME = :name ";
                cmd1.Parameters.Add("Numberofvoting", x);
                cmd1.Parameters.Add("name", Name_cmb.SelectedItem.ToString());
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteNonQuery();

                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = @"update USERS set VOTED= :vote where ID = :id ";
                cmd2.Parameters.Add("vote", "y");
                cmd2.Parameters.Add("id", Nid);
                cmd2.CommandType = CommandType.Text;
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Done!!!!!!!");
            }
            
            else if(voted.Equals("y"))
            {
                MessageBox.Show("You can not vote again ");
            }
            else
            {
                MessageBox.Show("You are not allowed to vote ");
            }


        }

        private void Vote_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}

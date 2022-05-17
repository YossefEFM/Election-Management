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
        OracleConnection conn1;
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
        private int num_votes(string name)
        {
            conn1 = new OracleConnection(ordb);
            conn1.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn1;
            cmd1.CommandText = @"select NUMBEROFVOTES from VOTINGVALUES where CANDNAME =:name ";
            cmd1.Parameters.Add("name",name);
            OracleDataReader r = cmd1.ExecuteReader();
            int x = 0;
            if (r.Read())
            {
                String num = r["NUMBEROFVOTES"].ToString();
                x = Convert.ToInt32(num);
                x++;
                r.Close();
            }
            else
            {
                MessageBox.Show("No data found!!!!!!");
            }
            return x;
        }
        private void Vote_btn_Click(object sender, EventArgs e)
        {
                string name = Name_cmb.SelectedItem.ToString();
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
                
                int X = num_votes(name);
                cmd.CommandText = @"update VOTINGVALUES set NUMBEROFVOTES= :Numberofvoting where CANDNAME = :name ";
                cmd.Parameters.Add("Numberofvoting", X);
                cmd.Parameters.Add("name", Name_cmb.SelectedItem.ToString());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

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
            conn1.Dispose();
        }
    }
}

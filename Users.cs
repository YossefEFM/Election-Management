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
    public partial class Users : Form
    {
        string ordb = "Data Source= orcl ; User Id = SCOTT ; password = tiger ; ";
        OracleConnection conn;
        int Id;
        public Users(int F , String id)
        {
            InitializeComponent();
            if(F == 1 & id != null)
            {
                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update Users Set SIGNED = :si where ID = :id";
                cmd.Parameters.Add("si", "y");
                cmd.Parameters.Add("id", id);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                Id = Convert.ToInt32( id);
                Signed_lbl.Text = "Signed in";
            }
            else
            {
                Signed_lbl.Text = "You are not signed in till now";
            }
           
        }
        public void signed(int c , string id)
        {

           
        }

        private void Go_btn_Click(object sender, EventArgs e)
        {
            String choice = Action_cmb.SelectedItem.ToString();
            if(choice.Equals("Register"))
            {
                SignUp form = new SignUp();
                form.Show();
            }
            else if(choice.Equals("Sign Out"))
            {
                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Update Users Set signed = \'n\' where ID = :id";
                cmd.Parameters.Add("id", Id);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                Signed_lbl.Text = "Signed Out";
            }
            else if(choice.Equals("Sign In"))
            {
                SignIN form = new SignIN();
                form.Show();
            }
            else if(choice.Equals("Vote"))
            {
                if(Signed_lbl.Text == "Signed in")
                {
                    conn = new OracleConnection(ordb);
                    conn.Open();

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select GOVERNORATE from USERS where ID = :id";
                    cmd.Parameters.Add("id", Id);
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr =cmd.ExecuteReader();
                    dr.Read();
                    String Address = dr[0].ToString();
                    Vote form = new Vote(Address , Id);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("You should sign in before you vote");
                }
            }
            else if(choice.Equals("View Candidates"))
            {
                Candidates form = new Candidates();
                form.Show();
            }
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}

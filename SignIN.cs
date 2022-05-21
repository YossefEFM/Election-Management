
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
    public partial class SignIN : Form
    {
        string ordb = "Data Source = orcl ; User Id = SCOTT ; password = tiger;";
        OracleConnection conn;
        public SignIN()
        {
            InitializeComponent();
        }

        private void SignIn_btn_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select JOBTITLE from USERS where ID=:id and Password =:Pass";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", Id_txt.Text);
            cmd.Parameters.Add("Pass", Pass_txt.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string title = dr[0].ToString();
                if (title.Equals("A"))
                {
                    admin ad = new admin(Convert.ToInt32(Id_txt.Text.ToString()));
                    this.Close();
                    ad.Show();
                }
                else if(title.Equals("C"))
                {
                    Commitee comm = new Commitee(Convert.ToInt32(Id_txt.Text.ToString()));
                    this.Close();
                    comm.Show();
                }
                else if (title.Equals("V"))
            {
                    Users form = new Users(1 , Id_txt.Text);
                    this.Close();
                    form.Show();
                }
            dr.Close();
            
        }
        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            SignUp reg = new SignUp();
            reg.Visible = true;
            this.Visible = false;
        }

        private void SignIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}

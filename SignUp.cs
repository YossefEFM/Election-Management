
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
    public partial class SignUp : Form
    {
        string ordb = "Data Source = orcl ; User Id=SCOTT; password = tiger;";
        OracleConnection conn;
        public SignUp()
        {
            InitializeComponent();
        }

        private void Rigester_btn_Click(object sender, EventArgs e)
        {
         

            if(Pass_txt.Text.Equals(ConPass_txt.Text))
            {   
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO USERS VALUES (ID = :id , USERNAME = :name ,PASSWORD = :password ,GOVERNORATE = :BAddress ,BDATE = :BDate ,NOTCONFIRMED = :Notconfirmed ,SIGNED = :signed , VOTED = :Voted , JOBTITLE = :Job) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", Convert.ToInt32(ID_txt.Text));
                cmd.Parameters.Add("name", Name_txt.Text);
                cmd.Parameters.Add("Pass", Pass_txt.Text);
                cmd.Parameters.Add("BAddress", Address_txt.Text);
                cmd.Parameters.Add("BDate", Convert.ToDateTime(Birth_txt.Text.ToString()));
                cmd.Parameters.Add("Notconfirmed", 'n');
                cmd.Parameters.Add("Notconfirmed", 'n');
                cmd.Parameters.Add("Voted", 'n');
                cmd.Parameters.Add("Voted", 'V');
                int r =cmd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("Rigesteration done to confirm");
                else
                    MessageBox.Show("Rigesteration not happened!!!!!!!!!!");
            }
            else
            {
                label7.Text = " The password is not correct";
            }
            
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {         conn = new OracleConnection(ordb);
                 conn.Open();

        }
    }
}

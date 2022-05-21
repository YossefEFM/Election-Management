
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
                cmd.CommandText = @"INSERT INTO USERS VALUES (:id , :name ,:password ,:BAddress ,:BDate ,:Notconfirmed ,:signed , :Voted , :Job) ";
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Clear(); 
                int ID = Convert.ToInt32(ID_txt.Text);
                DateTime dateTime = Convert.ToDateTime(Birth_txt.Text);
                String N = "n";
                String V = "V";
                String Y = "y";
                cmd.Parameters.Add("id", ID);
                cmd.Parameters.Add("name", Name_txt.Text);
                cmd.Parameters.Add("Password", Pass_txt.Text);
                cmd.Parameters.Add("BAddress", Address_txt.Text);
                cmd.Parameters.Add("BDate",dateTime);
                cmd.Parameters.Add("Notconfirmed", Y);
                cmd.Parameters.Add("signed", N);
                cmd.Parameters.Add("Voted", N);
                cmd.Parameters.Add("Job", V);
                int r =cmd.ExecuteNonQuery();
                if(r != -1)
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

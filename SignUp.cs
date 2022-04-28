
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
        string ordb = "Data Source=orcl;User Id=scott;password=tiger;";
        OracleConnection conn;
        public SignUp()
        {
            InitializeComponent();
        }

        private void Rigester_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            if(Pass_txt.Text.Equals(ConPass_txt.Text))
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Users values (:id , :name , :password , :BAddress , :BDate , :Notconfirmed , :signed , :Voted) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", ID_txt.Text);
                cmd.Parameters.Add("name", Name_txt.Text);
                cmd.Parameters.Add("Pass", Pass_txt.Text);
                cmd.Parameters.Add("BAddress", Address_txt.Text);
                cmd.Parameters.Add("BDate", Birth_txt.Text);
                cmd.Parameters.Add("Notconfirmed", "Yes");
                cmd.Parameters.Add("Notconfirmed", "Signed Out");
                cmd.Parameters.Add("Voted", "NotVoted");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rigesteration done to confirm");
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
    }
}

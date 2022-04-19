using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election_Management_System
{
    public partial class SignIN : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;password=tiger;";
        OracleConnection conn;
        public SignIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     
        
        private void SignIn_btn_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select title from Users where National_ID=:id and Password =:Pass";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", Id_txt.Text);
            cmd.Parameters.Add("Pass", Pass_txt.Text);
            String dr = cmd.ExcuteNonQuery();
            
                if(dr.Equals("Admin"))
                {
                    admin ad = new admin();
                    this.Close();
                    ad.Show();
                }
                else if(dr.Equals("Committee"))
                {
                    Commitee comm = new Commitee();
                    this.Close();
                    comm.Show();
                }
                else
                {

                    Actor form = new Actor();
                    this.Close();
                    form.Show();
                }
            
        }

        private void SignIN_Load(object sender, EventArgs e)
        {
          
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            SignUp reg = new SignUp();
            this.Close();
            reg.Show();
        }
    }
}

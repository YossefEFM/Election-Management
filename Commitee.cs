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
    public partial class Commitee : Form
    {
        String ID;
        string ordb = "Data Source = orcl ; User Id = SCOTT ; password = tiger;";
        OracleConnection conn;
        public Commitee(String id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Commitee_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select USERNAME from Users where ID= :id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", ID);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            Welcome_lbl.Text = dr[0].ToString();
            dr.Close();


        }

        private void show_btn_Click(object sender, EventArgs e)
        {

        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update Users Set signed = \'n\' where ID = :id";
            cmd.Parameters.Add("id", ID);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            this.Close();
            Users form = new Users(0, "");
            form.Show();
        }
    }
}

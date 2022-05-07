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
    public partial class admin : Form
    {
        int Id;
        string ordb = "Data Source = orcl ; User Id = SCOTT ; password = tiger;";
        OracleConnection conn;
        public admin(int id)
        {
            InitializeComponent();
            Id = id;

        }

        private void admin_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select USERNAME from Users where ID=:id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", Id);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            Welcome_lbl.Text = "Welcome MR." + dr[0].ToString();
            dr.Close();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddnewCandidates form = new AddnewCandidates();
            form.Show();
        }

        private void RVI_btn_Click(object sender, EventArgs e)
        {
            userconfirmattion form = new userconfirmattion();
            form.Show();
        }

        private void RR_btn_Click(object sender, EventArgs e)
        {

        }

        private void Signoout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Users form = new Users(0, "");
            form.Show();
        }
    }
}

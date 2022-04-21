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
    public partial class Addcandidates : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;password=tiger;";
        OracleConnection conn;
        public Addcandidates()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandText = "insert into Candidates values (:name , :Birthdate , :Address , :Constituency , :Electoralcode , :Business)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", Name_txt.Text);
            cmd.Parameters.Add("Birthdate", BD_txt.Text);
            cmd.Parameters.Add("Address", Address_txt.Text);
            cmd.Parameters.Add("Constituency", Con_txt.Text);
            cmd.Parameters.Add("Electoralcode", EC_txt.Text);
            cmd.Parameters.Add("Business", Bus_txt.Text);
            cmd.ExecuteNonQuery();
        }

        private void Addcandidates_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}

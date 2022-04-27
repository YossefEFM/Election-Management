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
    public partial class userconfirmattion : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;password=tiger;";
        OracleConnection conn;
        public userconfirmattion()
        {
            InitializeComponent();
        }

        private void userconfirmattion_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ID from Users where Notconfirmed = Yes";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ID_cmb.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void Approve_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
           
            cmd.Connection = conn;
            cmd.CommandText = "insert into Users values (:id , :name , :password , :BAddress , :BDate)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", ID_cmb.SelectedItem);
            cmd.Parameters.Add("name", Name_txt.Text);
            cmd.Parameters.Add("password", Password_txt.Text);
            cmd.Parameters.Add("BAddress", Address_txt.Text);
            cmd.Parameters.Add("BDate", BD_txt.Text);
            cmd.ExecuteNonQuery();
         
            cmd.CommandText = "Delete from NUsers ID=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", ID_cmb.SelectedItem);
            cmd.ExecuteNonQuery();
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open ();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ID , Name , Password , Birthdate , Address from NUsers where ID=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", ID_cmb.SelectedItem);
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Name_txt.Text = dr[1].ToString();
                Password_txt.Text = dr[2].ToString();
                BD_txt.Text = dr[3].ToString();
                Address_txt.Text=dr[4].ToString();
            }
            dr.Close ();   
        }

        private void userconfirmattion_FormClosing(object sender, FormClosingEventArgs e)
        {
             conn.Dispose();   
        }
    }
}

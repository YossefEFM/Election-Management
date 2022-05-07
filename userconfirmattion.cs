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
        string ordb = "Data Source = orcl ; User Id = SCOTT ; password = tiger;";
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
            cmd.CommandText = "select ID from Users where NOTCONFIRMMED = :N";
            cmd.Parameters.Add("N", "y");
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
            cmd.CommandText = "Update Users set NOTCONFIRMMED = :N where ID= :id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("N", "n");
            cmd.Parameters.Add("id", ID_cmb.SelectedItem);
            cmd.ExecuteNonQuery();
            ID_cmb.Items.Remove(ID_cmb.SelectedItem);
            ID_cmb.SelectedItem = null;
            MessageBox.Show("Confirmed");
             
         
            
        }

        private void Show_btn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open ();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ID , USERNAME , Password , BDate , GOVERNORATE from Users where ID=:id";
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

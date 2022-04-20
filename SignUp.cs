﻿using Oracle.DataAccess.Client;
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
                cmd.CommandText = "insert into Users values (:id , :name , :password , :BAddress , :BDate) ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", ID_txt.Text);
                cmd.Parameters.Add("name", Name_txt.Text);
                cmd.Parameters.Add("Pass", Pass_txt.Text);
                cmd.Parameters.Add("BAddress", Address_txt.Text);
                cmd.Parameters.Add("BDate", Birth_txt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rigesteration Done");
            }
            else
            {
                label7.Text = " The password is not correct";
            }
            
        }
    }
}
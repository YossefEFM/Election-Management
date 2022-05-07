using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace report_secound_trial
{
  
    public partial class Form1 : Form
    {  string ordb = "Data Source =orcl; User Id = hr ;Password= hr;";
    OracleConnection conn;
        CrystalReport1 cr;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            conn = new OracleConnection(ordb);
            conn.Open();
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select candName from  votingvalues";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            listBox1.Items.Add("The Candidates Names and the Total No Of Votes :\n\n");
            while (dr.Read())
            {

                listBox1.Items.Add(dr[0] );
                listBox1.Items.Add("\n");
            }
            dr.Close();
            // listBox1.Items.Add("hello");


            /* OracleCommand cmd = new OracleCommand();
             cmd.Connection = conn;
             cmd.CommandText = @"select max(NumberofVotes)
                                from :votingvalues";
             cmd.CommandType = CommandType.Text;*/


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            cr = new CrystalReport1();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
           /* OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = @"  select  flagVoteConfirmed
                                   from    votingvalues ";
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd1.ExecuteReader();
            while (dr2.Read())
            {
               // listBox1.Items.Add(dr2[0]);

            }
            dr2.Close();
           */
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @" select  flagVoteConfirmed
                                   from  votingvalues ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            Boolean confirm = false;
            while (dr.Read())
            {
                string value = dr[0].ToString();
                if (value=="y")
                {
                    confirm = true;
                    crystalReportViewer1.ReportSource = cr;
                }
                break;

            }
            if (confirm == false)
            {
                listBox1.Items.Add(" election result ");
                listBox1.Items.Add(" has not been ");
                listBox1.Items.Add("confirmed yet!");

            }


            // crystalReportViewer1.ReportSource = cr;
            // listBox1.Items.Add("The Candidates Names and the Total No Of Votes :\n\n");



        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

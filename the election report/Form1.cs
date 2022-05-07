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



namespace the_election_report
{
    public partial class Form1 : Form
    {
        string ordb = " Data Source =orcl;User Id = hr;Password= hr;";
        OracleConnection conn;
        CrystalReport1 cr;

        public Form1()
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            cr = new CrystalReport1();
            crystalReportViewer1.ReportSource = cr;


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
           
            cmd.CommandText = @" update votingvalues  
                                set flagVoteConfirmed ='y'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
          //  cmd.Parameters.Add("var", 'y');
          

            // check on the update statement 

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = @" select  flagVoteConfirmed
                                   from  votingvalues ";
             cmd1.CommandType = CommandType.Text;
            OracleDataReader dr = cmd1.ExecuteReader();
            string value;
            while(dr.Read())
            {
                value = dr[0].ToString();
                //listBox1.Items.Add(dr[0]);
                if (value=="y")
                {
                    listBox1.Items.Add(" the confirmation has");
                    listBox1.Items.Add(" been done !");
                    break;
                }
              

            }
            dr.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

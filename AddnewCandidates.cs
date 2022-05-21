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
    public partial class AddnewCandidates : Form
    {
        
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet set;
        public AddnewCandidates()
        {
            InitializeComponent();
        }

        private void AddnewCandidates_Load(object sender, EventArgs e)
        {
            string ordb = "Data Source=orcl;User Id=scott;password=tiger;";
            string cmdstr = "Select * from Candidates";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            set = new DataSet();
            adapter.Fill(set);
            dataGridView1.DataSource = set.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(set.Tables[0]);
        }
    }
}

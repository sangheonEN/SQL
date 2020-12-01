using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200831
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			bool retValue = false;
			string dbIp = "localhost";
			string dbName = "XE";
			string dbId = "HR";
			string dbPw = "1234";

			try
			{
				OracleConnection pgOraConn = new OracleConnection(
					$"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
					$"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
				pgOraConn.Open();
				OracleCommand pgOraCmd = new OracleCommand($"{textBox1.Text}", pgOraConn);
				OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);
				DataSet ds = new DataSet();

				oda.Fill(ds);
				dataGridView1.DataSource = ds.Tables[0];
				MessageBox.Show("Success DB connecion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

				retValue = true;
                Console.WriteLine("retValue"+retValue);
			}
			catch (Exception ae)
			{
				retValue = false;
				MessageBox.Show($"DB connection fail.\n {ae.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConOpenClose
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(DataSource.DS);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenClose_Click(object sender, EventArgs e)
        {
           
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    btnOpenClose.Text = "Disconnect";
                    lblOpenClose.Text = "Open";
                    
                }
                else   
                {

                connection.Close();
                btnOpenClose.Text = "Connect";
                lblOpenClose.Text = "Close";

                }

        }

        
    }
}

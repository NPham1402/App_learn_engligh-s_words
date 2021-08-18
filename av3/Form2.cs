using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace av3
{
    public partial class btn_test : Form
    {
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-CB0987P;Initial Catalog=developent;Integrated Security=True");
        public btn_test()
        {
            InitializeComponent();
            con2.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dsp = new SqlDataAdapter("select * from History_study", con2);
            dsp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            con2.Close();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

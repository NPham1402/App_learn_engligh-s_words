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
    public partial class notice : Form
    {
        String getdate = System.DateTime.Now.ToString("MM/dd/yyyy");
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-CB0987P;Initial Catalog=developent;Integrated Security=True");
        public notice()
        {
            InitializeComponent();
        }
        int checkword_add()
        {
            string cmtext = "select COUNT(*) as count from [History_word], word_study where id=stt and The_date_add= '" + getdate + "'";
            SqlCommand cm2 = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            int temp = (int)dr2["count"];
            con2.Close();
            return temp;     
        }
        int checkword_study_word()
        {
            string cmtext = "select SUM(The_numer_Correct) as count from history_word, word_study where id=stt and The_date_add= '" + getdate + "'";
            SqlCommand cm2 = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            int temp = (int)dr2["count"];
            con2.Close();
            return temp;
        }
        void show_word()
        {
            con2.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dsp;
            dsp = new SqlDataAdapter("select top 10 Word as [The New Word] from Word_study,history_word where stt=id and  ID_ADD !=0 order by stt desc ", con2);
            dsp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
            con2.Close();
         
        }

        private void changecellcolor()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }

        private void notice_Load(object sender, EventArgs e)
        {
            show_word();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
            if (checkword_add() < 10)
            {
                pb_Answer1.Image = new Bitmap(@"C: \Users\09382\OneDrive\Hình ảnh\icon_x_red.png");
                lbl_task1.ForeColor = Color.Red;
            }
            else
            {

                if (checkword_study_word() < 10)
                {

                    lbl_task2.ForeColor = Color.Red;
                }
                else
                {

                    lbl_task2.ForeColor = Color.DarkBlue;
                }

            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            profile2.Location = new Point(0, -vScrollBar1.Value);
        }
    }
}

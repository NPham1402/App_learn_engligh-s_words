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
    public partial class profile : UserControl
    {
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-CB0987P;Initial Catalog=developent;Integrated Security=True");
        public profile()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void profile_Load(object sender, EventArgs e)
        {
            Show_allword();
            Show_test_number();
            Show_time_study();
            Show_adventure();
        }
        void Show_allword()
        {
            string cmtext = "select COUNT(*) as count from [History_word], word_study where id=stt";
            SqlCommand cm2 = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            int temp = (int)dr2["count"];
            con2.Close();
            lbl_all_word.Text = Convert.ToString(temp);
        }
        void Show_test_number()
        {
            string cmtext = "select COUNT(*) as count from History_study";
            SqlCommand cm2 = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            int temp = (int)dr2["count"];
            con2.Close();
            lbl_number_test.Text = Convert.ToString(temp);

        }
        void Show_time_study()
        {
            string cmtext = "select sum( DATEPART(SECOND, [Timer]))/ 60 + sum(DATEPART(MINUTE, [Timer])) + sum(DATEPART(HOUR, [Timer]) ) * 60 as 'TotalTime'  FROM history_study";
            SqlCommand cm2 = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            int temp = (int)dr2["TotalTime"];
            con2.Close();
            lbl_time.Text = Convert.ToString(temp);
        }
        void Show_adventure()
        {
            string cmtext = "select (sum(correct)*100/ sum([correct]+[uncorrect])) as adventure  FROM history_study";
            SqlCommand cm2 = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            int temp = (int)dr2["adventure"];
            con2.Close();
            lbl_adventure.Text = Convert.ToString(temp);
        }
    }
}

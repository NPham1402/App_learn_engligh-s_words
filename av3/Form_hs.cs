using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace av3
{

    public partial class HOME : Form
    {
        String getdate = System.DateTime.Now.ToString("dd.MM.yyyy");
        int numberdatabase = 0;
     
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-CB0987P;Initial Catalog=hoctu;Integrated Security=True");
        public HOME()
        {
            InitializeComponent();
        }
        private void HOME_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoctuDataSet.Hoc' table. You can move, or remove it, as needed.
            this.hocTableAdapter.Fill(this.hoctuDataSet.Hoc);
            string textmessage = "Bạn hãy học 10 từ Ngày " + getdate;
            label1.Text = "Từ mới của ngày" + textmessage;
            MessageBox.Show(textmessage, "Thông báo", MessageBoxButtons.OK);
            teststart();
        }
        int checkid(string temp)
        {
            SqlCommand cm_check = new SqlCommand("select count(*) as count form Word_study where Từ='" + temp + "'",con2);
            con2.Open();
            SqlDataReader dr2 = cm_check.ExecuteReader();
            dr2.Read();
            int a= (int)dr2["count"];
            con2.Close();
            return a;
        }
        public void updatecol()
        {
            string cmtext2 = "select COUNT(*) as count from Hoc";
            SqlCommand cm2 = new SqlCommand(cmtext2, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            numberdatabase = (int)dr2["count"];
            con2.Close();
        }
        private void teststart()
        {
            updatecol();
            string[] loaitu_mean = new string[2];
         
            string cmtext = "select TOP 1 * from AV ORDER BY Newid()";
            SqlCommand cm = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            txt_word1.Text = (string)dr["word"];
            txt_mean1.Text = (string)dr["meaning"];
            

            ////con2.Close();
            //if (wordtest.Contains(meaning))
            //{
            //    textBox1.Text = meaning;
            //    //con2.Open();
            //    //string cmtext2 = "insert into Hoc values('" + word + "','none," + loaitu_mean[1] + "','" + getdate + "','0,0)";
            //    //SqlCommand cm2 = new SqlCommand(cmtext2, con2);
            //    //cm2.ExecuteReader();
            //    //Array.Clear(loaitu_mean, 0, 2);
            //    //con2.Close();
            //}
            //else
            //{
            //    //con2.Open();
            //    loaitu_mean = meaning.Split(',');
            //    textBox1.Text = loaitu_mean[1];

            //    //string cmtext3 = "insert into Hoc values('" + word + "','" + loaitu_mean[0] + "','" + loaitu_mean[1] + "','" + getdate + "','0,0)";
            //    //SqlCommand cm3 = new SqlCommand(cmtext3, con2);
            //    //cm3.ExecuteReader();
            //    //Array.Clear(loaitu_mean, 0, 2);
            //    //con2.Close();
            //}
            //con2.Open();
        }
        private void Btntest_Click(object sender, EventArgs e)
        {
            HOME.ActiveForm.Close();
            Test test = new Test();
            test.Show();
        }
    }

}

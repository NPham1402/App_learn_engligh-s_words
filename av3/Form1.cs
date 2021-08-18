using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Windows.Forms;

namespace av3
{
    public partial class Test : Form
    {
       
        int id =1;
        int dem_dung = 0;
        int dem_sai = 0;
        //int number = 0;
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-CB0987P;Initial Catalog=developent;Integrated Security=True");
        string temp;
        //string temp2;
        String getdate = System.DateTime.Now.ToString("yyyy-MM-dd");
        public Test()
        {
            InitializeComponent();
        }
        void select_date_add()
        {
            cb_date_add.Text = getdate;
            string cmtext2 = "select  The_date_add from History_word group by The_date_add order by the_date_add";
            SqlCommand cm2 = new SqlCommand(cmtext2, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            while (dr2.Read())
            {
                string[] words = dr2["The_date_add"].ToString().Split(' ');
                cb_date_add.Items.Add(words[0]);
            }
            con2.Close();
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
      
                update_date();
                string a = txtmeaning.Text.ToLower();
                string b = txt_tow.Text.ToLower();
                if (a == null)
                {
                    lblanswer.Text = "Vui lòng nhập đáp án";
                }
                else
                {
                    if (temp.Contains(a))
                    {
                        dem_dung++;
                        update_correct(true);
                        lbl_dapan.Visible = false;
                    }
                    else
                    {
                        dem_sai++;
                        update_correct(false);
                        lbl_dapan.Visible = true;
                        lbl_dapan.Text = "Đáp án đúng là:" + temp;
                    }
                    lblanswer.Text = "Số câu đúng:" + dem_dung + "   Số câu sai:" + dem_sai +"";
                    id++;
                    teststart(id);
                    txtWord.Clear();
                    txtmeaning.Clear();
                    txt_tow.Clear();
                }
            
        }
        void update_correct(bool a)
        {
            string cmtext;
            if (a == true)
            {
                 cmtext = "Update [dbo].[History_word] set The_numer_Correct=The_numer_Correct+1  where id=" + id;

            }
            else
            {
                cmtext = "Update [dbo].[History_word] set the_number_incorrect=the_number_incorrect+1 where id=" + id;
            }
                SqlCommand cm2 = new SqlCommand(cmtext, con2);
                con2.Open();
                SqlDataReader dr2 = cm2.ExecuteReader();
                con2.Close();
            
        }
        void update_date()
        {
            string cmtext = "Update [dbo].[History_word] set The_Date_last_study='"+getdate+"'  where id="+id;
            SqlCommand cm2 = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            con2.Close();
        }
        void insert_history(int dung,int sai)
        {
            if (sai+dung>=5 )
            {
                String getdate2 = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string cmtext = "insert into History_study values ('" + getdate2 + "'," + dung + "," + sai + ")";
                SqlCommand cm2 = new SqlCommand(cmtext, con2);
                 con2.Open();
                SqlDataReader dr2 = cm2.ExecuteReader();
                con2.Close();
            }
        }
        private void btnstart_Click(object sender, EventArgs e)
        {
            btnnext.Visible = true;
            btnstop.Visible = true;
            btnstart.Visible = false;
            lblanswer.Visible = true;
            pb_switch.Visible = false;
            txtmeaning.ReadOnly = false;
            txt_tow.ReadOnly = false;
            btn_history.Visible = false;
            teststart(id);
        }
        int test_word_stt(string date)
        {
            SqlCommand cm_test = new SqlCommand("select min(stt) as min from Word_study where [Date add]='" + date + "'",con2);
            con2.Open();
            SqlDataReader dr = cm_test.ExecuteReader();
            dr.Read();
            int a = (int)dr["min"];
            con2.Close();
            return a;
        }
        private void teststart(int id)
        {
            string cmtext = "select * from Word_study, History_word where STT = "+id;
            if (cb_date.Checked==true)
            {
                cmtext = "select * from Word_study, History_word where STT = History_word.ID and the_date_add='" + cb_date_add.Text + "'";
            }
            if (cb_between.Checked == true)
            {
                cmtext = "select Word,Type_of_word,Mean from Word_study,history_word where stt=id and stt>=" + txt_from.Text + " and stt<=" + txt_to.Text + "order by STT";
            }
            
            SqlCommand cm = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr = cm.ExecuteReader();
            try
            {
                dr.Read();
                if (lbltxt1.Text=="English")
                {
                    txtWord.Text="";
                    txtWord.Text = (string)dr["Word"];
                    temp = (string)dr["Mean"];
                    temp = temp.ToLower();
                }
                else
                {
                    txtWord.Text = "";
                    txtWord.Text = (string)dr["Mean"];
                    temp = (string)dr["Word"];
                    temp = temp.ToLower();
                }
                con2.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void btnstop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn dừng bài test", "Cảnh cáo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txtmeaning.Clear();
                txtWord.Clear();
                lblanswer.Visible = false;
                btnnext.Visible = false;
                btnstart.Visible = true;
                btnstop.Visible = false;
                pb_switch.Visible = true;
                lbl_dapan.Visible = false;
                txtmeaning.ReadOnly = true;
                txt_tow.ReadOnly = true;
                btn_history.Visible = true;
                string caption = "Số câu đúng:" + dem_dung + "  Số câu sai:" + dem_sai;
                insert_history(dem_dung, dem_sai);
                lblanswer.Text = "Thống kê";
                MessageBox.Show(caption, "Thống kê:");
                id = 1;
                dem_dung = 0;
                dem_sai = 0;
            }
        } 
        private void txt_tow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");             
            }
     
        }
        private void btn_history_Click(object sender, EventArgs e)
        {

            if (btn_history.Text == "Open History")
            {
                btn_test a = new btn_test();
                a.TopLevel = false;
                a.Dock = DockStyle.Right;
                a.AutoScroll = false;
                pn_history.Controls.Add(a);
                a.Show();
                btn_history.Text = "Close History";
            }
            else
            {
                btn_history.Text = "Open History";
                pn_history.Controls.Clear();
            }
                

           
        }
        void  insert_txt_to()
        {
            string cmtext2 = "select count( STT) as count from Word_study,history_word where stt=id and  ID_ADD !=0";
            SqlCommand cm2 = new SqlCommand(cmtext2, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            var temp = ((int)dr2["count"]).ToString();
            con2.Close();
            txt_to.Text = temp;
        }
        private void Test_Load(object sender, EventArgs e)
        {
            select_date_add();
            insert_txt_to();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {

            Form10word a = new Form10word();
            a.Show();
            this.Close();
        }
        private void pb_switch_Click(object sender, EventArgs e)
        {
            string a = "";
            a=  lbltxt1.Text;
            lbltxt1.Text = lbltxt2.Text;
            lbltxt2.Text = a;
        }
        private void cb_date_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_date.Checked==true)
            {
                cb_date_add.Visible = true;
                cb_between.Checked = false;
            }
            else
            {
                cb_date_add.Visible = false;
            }
        }
       private void cb_between_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_between.Checked == true)
            {
                pn_between.Visible = true;
                cb_date.Checked = false;
            }
            else
            {
                pn_between.Visible = false;
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cb_speak_CheckedChanged(object sender, EventArgs e)
        {
            btn_speak.Visible = true;
            
        }
        private void ckb_random_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_random.Checked==true)
            {

            }
        }
    }
}

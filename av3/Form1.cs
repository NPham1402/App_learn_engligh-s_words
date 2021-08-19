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
        List_Word list;
        int max_id=0;
        int id =0;
        int dem_dung = 0;
        int dem_sai = 0;
        //int number = 0;
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-CB0987P;Initial Catalog=developent;Integrated Security=True");
        string temp;
        string temp2;
        string temp3;
        String getdate = System.DateTime.Now.ToString("yyyy-MM-dd");
        public Test()
        {
            InitializeComponent();
            list = new List_Word(1);
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
                Console.WriteLine(words[0]);
                cb_date_add.Items.Add(words[0]);
            }
            con2.Close();
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            if (id == max_id)
            {
                txtmeaning.Clear();
                txtWord.Clear();
                btnnext.Visible = false;
                btnstart.Visible = true;
                pb_switch.Visible = true;
                txtmeaning.ReadOnly = true;
                txt_tow.ReadOnly = true;
                btn_history.Visible = true;
                string caption = "Số câu đúng:" + dem_dung + "  Số câu sai:" + dem_sai;
                insert_history(dem_dung, dem_sai);
                btnstart.Text = "❌Stop❌";
                MessageBox.Show(caption, "Thống kê:");
                id = 1;
                dem_dung = 0;
                dem_sai = 0;
            }
            else
            {
                update_date();
                string a = txtmeaning.Text.ToLower();
                string b = txt_tow.Text.ToLower();
                if (a == null)
                {
                    MessageBox.Show("Vui lòng điền đáp án", "Lỗi");
                }
                else
                {
                    if (temp.Contains(a))
                    {
                        dem_dung++;
                        update_correct(true);
                    }
                    else
                    {
                        dem_sai++;
                        update_correct(false);
                        this.dgv_Detail_word.Rows.Add(temp2,temp3,temp);
                    }
                    this.dataGridView2.Rows.Add("Số câu đúng:"+dem_dung,"Số câu sai:"+ dem_sai);
                    id++;
                    txtWord.Clear();
                    txtmeaning.Clear();
                    txt_tow.Clear();
                    teststart(id);

                }

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
            if (btnstart.Text == "✅Start✅")
            {
                btnnext.Visible = true;
                pb_switch.Visible = false;
                txtmeaning.ReadOnly = false;
                txt_tow.ReadOnly = false;
                label6.Visible = true;
                label7.Visible = true;
                dataGridView2.Visible = true;
                lbl_answer.Text = "Statistics";
                dgv_Detail_word.Visible = true;
                dataGridView1.Visible = false;
                btn_history.Visible = false;
                btnstart.Text = "❌Stop❌";
                if (cb_between.Checked)
                {
                    id =int.Parse(txt_from.Text);
                    max_id = int.Parse(txt_to.Text);
                }
                if (cb_date.Checked)
                {
                    id = list.xuat_date_min(cb_date_add.Text);
                    max_id = list.xuat_date_max(cb_date_add.Text);
                }
                teststart(id);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn dừng bài test", "Cảnh cáo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtmeaning.Clear();
                    txtWord.Clear();
                    btnnext.Visible = false;
                    btnstart.Visible = true;
                    pb_switch.Visible = true;
                    txtmeaning.ReadOnly = true;
                    btnstart.Text = "✅Start✅";
                    txt_tow.ReadOnly = true;
                    btn_history.Visible = true;
                    string caption = "Số câu đúng:" + dem_dung + "  Số câu sai:" + dem_sai;
                    insert_history(dem_dung, dem_sai);
                    MessageBox.Show(caption, "Thống kê:");
                    id = 1;
                    dem_dung = 0;
                    dem_sai = 0;
                }


            }
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
            if (lbltxt1.Text == "English")
            {
                txtWord.Text = "";
                txtWord.Text = list.xuat_word(id-1);
                temp2 = txtWord.Text;
                temp = list.xuat_mean(id-1);
                temp3 = list.xuat_tow(id-1);
                temp = temp.ToLower();
            }
            else
            {
                txtWord.Text = "";
                txtWord.Text = list.xuat_mean(id-1);
                temp2 = txtWord.Text;
                temp3 = list.xuat_tow(id-1);
                temp = list.xuat_word(id-1);
                temp = temp.ToLower();
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
            if (lbl_answer.Text== "Statistics")
            {
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
                label6.Visible = false;
                label7.Visible = false;
                dataGridView2.Visible = false;
                dgv_Detail_word.Visible = false;
                lbl_answer.Text = "History";
                dataGridView1.Visible = true;
            }
            else
            {
                label6.Visible = true;
                label7.Visible = true;
                dataGridView2.Visible = true;
                lbl_answer.Text = "Statistics";
                dgv_Detail_word.Visible = true;
                dataGridView1.Visible = false;

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
           List_Word list = new List_Word(1);
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

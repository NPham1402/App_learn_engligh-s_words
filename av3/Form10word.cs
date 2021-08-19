using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;
namespace av3
{
    public partial class Form10word : Form
    {
      
        SpeechSynthesizer voice = new SpeechSynthesizer();
        String getdate = System.DateTime.Now.ToString("MM/dd/yyyy");
        public int numberrow = 0;
        int idadd = 0;
        bool checkkinhlup = false;
        bool checkshow = false;
        string[] cminsert = new string[10];
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CB0987P;Initial Catalog=developent;Integrated Security=True");
        SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-CB0987P;Initial Catalog=developent;Integrated Security=True");
        public Form10word()
        {
            InitializeComponent();
        }
        void select_date_add()
        {
            cb_date_add.Text = getdate;
            string cmtext2 = "select The_date_add from History_word group by The_date_add order by The_date_add";
            SqlCommand cm2 = new SqlCommand(cmtext2, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            while (dr2.Read())
            {
                string[] words = dr2["The_date_add"].ToString().Split(' ');
                cb_date_add.Items.Add(words[0]);
            }
            con2.Close();
            if (!cb_date_add.Items.Equals(getdate))
            {
                cb_date_add.Items.Add(getdate);
            }
        }
        private void Form10word_Load(object sender, EventArgs e)
        {
            select_date_add();
            voice.Volume = 100;
            voice.SelectVoiceByHints(VoiceGender.Male);
            //int Temp = adayword_check(getdate);
            //if (Temp < 10)
            //{
            //    MessageBox.Show("You don't add 10 word today", "ENTER WORD", MessageBoxButtons.OK);
            //}

            //else
            //{
            //    if (adaywordstudy_check(getdate) < 10)
            //    {
            //        MessageBox.Show("You don't study 10 word today", "STUDY WORD", MessageBoxButtons.OK);
            //    }
          
        }
        int adayword_check(string date)
        {
            string cmtext = "select COUNT(*) as count from [History_word] where The_date_add= '" + date+"'";
            SqlCommand cm2 = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            int temp = (int)dr2["count"];
            con2.Close();
            return temp;
        }
        int adaywordstudy_check(string date)
        {
            string cmtext = "select SUM( The_numer_Correct) as count from history_word where The_date_add= '" + date+"'";
            SqlCommand cm2 = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            int temp = (int)dr2["count"];
            con2.Close();
            return temp;
        }
        public void updatecol()
        {
            string cmtext2 = "select COUNT(*) as count from Word_study";
            SqlCommand cm2 = new SqlCommand(cmtext2, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            numberrow = (int)dr2["count"];
            con2.Close();
        }
        private void data_load()
        {
            string wordtemp;
            string meantemp;
            string[] Data_split = new string[2];
            string cmtext = "select TOP 1 * from AV ORDER BY Newid()";
            SqlCommand cm = new SqlCommand(cmtext, con2);
            con2.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                idadd = (int)dr["id"];
                wordtemp = (string)dr["word"];
                txtword.Text = wordtemp;
                meantemp = (string)dr["Meaning"];
                if (meantemp.Contains(":"))
                {
                    Data_split = meantemp.Split(':');

                    string a = Convert.ToString(Data_split[0]);
                    if (a == "danh từ")
                    {
                        txt_tow.Text = "N";
                    }
                    if (a == "tính từ")
                    {
                        txt_tow.Text = "ADJ";
                    }
                    if (a == "phó từ")
                    {
                        txt_tow.Text = "ADV";
                    }
                    if (a == "ngoại động từ" || a == "nội động từ")
                    {
                        txt_tow.Text = "V";
                    }
                    txt_mean.Text = Convert.ToString(Data_split[1]);
                    Array.Clear(Data_split, 0, 2);
                }
                else
                {
                    txt_tow.Text = "none";
                    txt_mean.Text = meantemp;

                }
            }
            con2.Close();
        }
        private void data_load_2( string a, string b)
        {
            txtword.Text = a;
            if (b.Contains(":"))
            {
               string [] Data_split = b.Split(':');

                string teamp = Convert.ToString(Data_split[0]);
                if (teamp == "danh từ")
                {
                    txt_tow.Text = "N";
                }
                if (teamp == "tính từ")
                {
                    txt_tow.Text = "ADJ";
                }
                if (teamp == "phó từ")
                {
                    txt_tow.Text = "ADV";
                }
                if (teamp == "ngoại động từ" || teamp == "nội động từ")
                {
                    txt_tow.Text = "V";
                }
                txt_mean.Text = Convert.ToString(Data_split[1]);
                Array.Clear(Data_split, 0, 2);
            }
            else
            {
                txt_tow.Text = "none";
                txt_mean.Text = b;

            }
        }
        void txt_clear()
        {

            txt_tow.Clear();
            txt_mean.Clear();
            txtword.Clear();
            
        }
        int checkid(string temp_check)
        {
            string cmtext2 = "select COUNT(*) as count from Word_study where Word='"+temp_check+"'";
            SqlCommand cm2 = new SqlCommand(cmtext2, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            int a = (int)dr2["count"];
            con2.Close();
            return a;
        }
        void btn_add_funtion()
        {
            if (checkshow == true)
            {
                if (checkid(txtword.Text) > 0)
                {
                    MessageBox.Show("Word already exsist in database", "ERROR", MessageBoxButtons.OK);
                    txt_clear();
                }
                else
                {
                    numberrow++;
                    if (txtword.Text == "" || txt_mean.Text == "" || txtword.Text == "" && txt_mean.Text == "")
                    {
                        String caption = "Take or enter new word";
                        MessageBox.Show(caption, "Ennor:", MessageBoxButtons.OK);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(txtword.Text);
                        item.SubItems.Add(txt_tow.Text);
                        item.SubItems.Add(txt_mean.Text);
                        con2.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Word_study values('" + txtword.Text + "','" + txt_tow.Text + "',N'" + txt_mean.Text + "'," + idadd + ")", con2);
                        cmd.ExecuteNonQuery();
                        con2.Close();
                        con2.Open();
                        SqlCommand cmd2 = new SqlCommand("INSERT INTO [History_word] values('" + getdate + "','" + getdate + "',0,0," + idadd + ")", con2);
                        cmd2.ExecuteNonQuery();
                        con2.Close();
                        txt_clear();
                    }
                    selectthemostbig();
                    showgrind(cb_sort.Text);
                }
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 1; i++)
            //{
                btn_add_funtion();
            //}
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_clear();
            data_load();
        }
        private void btn_change_Click(object sender, EventArgs e)
        {
            Test A = new Test();
            A.Show();
            this.Hide();
        }
        void  select_number_tof()
        {
            
            lbl_all.Text =Convert.ToString( dataGridView1.Rows.Count-1);
            int N = 0,adj=0,adv=0,v=0,none=0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
               if(Convert.ToString( dataGridView1.Rows[i].Cells[2].Value).ToUpper()=="N")
                {
                    N++;
                }
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value).ToUpper() == "ADJ")
                {
                    adj++;
                }
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value).ToUpper() == "ADV")
                {
                    adv++;
                }
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value).ToUpper() == "V")
                {
                    v++;
                }
                if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value).ToLower() == "none")
                {
                    none++;
                }
            }
            lbl_adv.Text = Convert.ToString(adv);
            lbl_adj.Text = Convert.ToString(adj);
            lbl_N.Text = Convert.ToString(N);
            lbl_v.Text = Convert.ToString(v);
            lbl_none.Text = Convert.ToString(none);
        }
        void showgrind(string a)//quan trong
        { 
            con2.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dsp;
            if (a== "All")
            {
                dsp = new SqlDataAdapter("select STT,Word,Type_of_word,Mean from Word_study,history_word where stt=id and  ID_ADD !=0 order by STT " , con2);
                dsp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
                con2.Close();
                changecellcolor();
            }
             if(a=="Date")
            {
                dsp = new SqlDataAdapter("select STT,Word,Type_of_word,Mean from Word_study,history_word where stt=id and the_date_add='"+ cb_date_add.Text+ "'order by STT", con2);
                dsp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
                con2.Close();
                changecellcolor();
            }
            if (a=="Find")
            {
                dsp = new SqlDataAdapter("select top 20 * from av where"+ /*id>"+check_min_find(txt_find.Text)+ "and id <"+check_max_find(txt_find.Text)+" and*/" word like '"+txt_find.Text+"%' order by word ", con2);
                dsp.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
                con2.Close();
                changecellcolor();
            }
            if (a == "STT")
            {

                try
                {
                    dsp = new SqlDataAdapter("select STT,Word,Type_of_word,Mean from Word_study,history_word where stt=id and stt>=" + txt_stt.Text + " and stt<=" + txtbig.Text+"order by STT", con2);
                    dsp.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Refresh();
                    con2.Close();
                    changecellcolor();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message, "ERROR");
                    con2.Close(); 
                    showgrind("All");
                }
            }
            if (a == "Find Word")
            {
                try
                {
                    dsp = new SqlDataAdapter(select_sqldaadater(cb_word_tof_mean.Text), con2);
                    dsp.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Refresh();
                    con2.Close();
                    changecellcolor();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "ERROR");
                    con2.Close();
                    txt_mean_word.Text = "";
                    showgrind("All");
                }
            }
          
            checkshow = true;
            select_number_tof();
        }
        void changecellcolor()
        {
             for (int i = 0; i<dataGridView1.Rows.Count; i++)
             {
                if (i%2==0)
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
             }
        }
        string select_sqldaadater(string a)
        {
            if (a=="Word")
            {
                if (txt_mean_word.Text=="")
                {
                    return "select top 20 STT,Word,Type_of_word,Mean from Word_study order by stt";
                }
                return "select top 20 STT,Word,Type_of_word,Mean from Word_study,history_word where stt = id and Word like '" + txt_mean_word.Text + "%'";
            }
            if (a == "STT")
            {
                if (txt_mean_word.Text == "")
                {
                    return "select top 20 STT,Word,Type_of_word,Mean from Word_study order by stt";
                }
                return "select top 1 STT,Word,Type_of_word,Mean from Word_study,history_word where stt = id and stt = " + txt_mean_word.Text;
            }
            if (a == "Type Of Word")
            {
                if (cb_type.Text == "")
                {
                    return "select top 20 STT,Word,Type_of_word,Mean from Word_study order by stt";
                }
                return "select STT,Word,Type_of_word,Mean from Word_study,history_word where stt = id and Type_of_word= '" + cb_type.Text + "'";
            }
            else
            {
                if (txt_mean_word.Text == "")
                {
                    return "select top 20 STT,Word,Type_of_word,Mean from Word_study order by stt";
                }
                return "select STT,Word,Type_of_word,Mean from Word_study,history_word where stt = id and mean like N'%" + txt_mean_word.Text + "%'";
            }
            
        }
        //void Comboboxshow()
        //{
        //    cbb_day.Items.Clear();
        //    string cm_string = "select distinct [Date add] from Word_study";
        //    SqlCommand cm_commbobox_show = new SqlCommand(cm_string, con2);
        //    con2.Open();
        //    SqlDataReader reader = cm_commbobox_show.ExecuteReader();
        //    cbb_day.Items.Add("All");
        //    while (reader.Read())
        //    {
        //        cbb_day.Items.Add(reader["Date add"]);
        //    }
        //    con2.Close();
        //}
        private void btn_speak_Click(object sender, EventArgs e)
        {
            if (txt_speak.Text == "")
                MessageBox.Show("No word in textbox", "ERROR");

            else
                speak(txt_speak.Text);
           
        }
        void speak(string a)
        {
            voice.SpeakAsync(a);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkkinhlup==false)
            {
                try
                {
                    int r = e.RowIndex;
                    speak(dataGridView1.Rows[r].Cells[1].Value.ToString());
                    txt_speak.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                try
                {
                    int r = e.RowIndex;
                    idadd = Convert.ToInt32(dataGridView1.Rows[r].Cells[0].Value.ToString());
                    txt_speak.Text = idadd.ToString();
                    data_load_2(dataGridView1.Rows[r].Cells[1].Value.ToString(), dataGridView1.Rows[r].Cells[2].Value.ToString());
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        private void trb_vol_Scroll(object sender, EventArgs e)
        {

            voice.Volume = Convert.ToInt32(trb_vol.Value.ToString());

        }
        private void ckb_male_Click(object sender, EventArgs e)
        {

            ckb_Female.Checked = false;
            ckb_male.Checked = true;
            voice.SelectVoiceByHints(VoiceGender.Male);
        }
        private void ckb_Female_Click(object sender, EventArgs e)
        {
            ckb_Female.Checked = true;
            ckb_male.Checked = false;
            voice.SelectVoiceByHints(VoiceGender.Female);
        }
        private void cb_sort_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_sort.Text== "All")
            {
                cb_date_add.Visible = false;
                txt_stt.Visible = false;
                txtbig.Visible = false;
                lbl_form.Visible = false;
                cb_word_tof_mean.Visible = false;
                lbl_to.Visible = false;
                lbl_keyword.Visible = false;
                cb_type.Visible = false;
                txt_mean_word.Visible = false;
                showgrind(cb_sort.Text);
            }
            if (cb_sort.Text == "Date")
            {
                cb_date_add.Visible = true;
                txtbig.Visible = false;
                txt_stt.Visible = false;
                lbl_form.Visible = true;
                cb_word_tof_mean.Visible = false;
                lbl_form.Text = "Date:";
                lbl_to.Visible = false;
                cb_type.Visible = false;
                lbl_keyword.Visible = false;
                txt_mean_word.Visible = false;
                showgrind(cb_sort.Text);
            }
         
            if (cb_sort.Text == "STT")
            {
                cb_date_add.Visible = false;
                txt_stt.Visible = true;
                txtbig.Visible = true;
                lbl_form.Visible = true;
                lbl_form.Text = "Form:";
                lbl_keyword.Visible = false;
                cb_word_tof_mean.Visible = false;
                lbl_to.Visible = true;
                txt_mean_word.Visible = false;
                selectthemostbig();
                cb_type.Visible = false;
                showgrind(cb_sort.Text);
            }
            if (cb_sort.Text=="Find Word")
            {
                cb_date_add.Visible = false;
                txt_stt.Visible = false;
                txtbig.Visible = false;
                lbl_form.Visible = false;
                lbl_to.Visible = false;
                cb_word_tof_mean.Visible = true;
                change_cb_findword(cb_word_tof_mean.Text);
                showgrind(cb_sort.Text);
            }

        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            voice.SpeakAsync(dataGridView1.Rows[r].Cells[1].Value.ToString());
            txt_speak.Text = dataGridView1.Rows[r].Cells[1].Value.ToString()+ r;

        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Space))
            {
                DataGridViewRow dtr = dataGridView1.CurrentRow;
                txt_speak.Text = dtr.Cells[1].Value.ToString() ;
                speak(dtr.Cells[1].Value.ToString());
                int r = dataGridView1.CurrentCell.RowIndex;
                int c = dataGridView1.CurrentCell.ColumnIndex;
                dataGridView1.CurrentCell = dataGridView1[c, r];
                e.Handled = true;
            }
        }
        private void cb_date_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            showgrind(cb_sort.Text);
        }
        private void trb_rate_Scroll(object sender, EventArgs e)
        {
            voice.Rate = trb_rate.Value;
        }
        private void trb_rate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Space))
            {
                trb_rate.Value = 0;
            }
            voice.Rate = trb_rate.Value;
        }
        private void trb_vol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.D1))
            {
                trb_vol.Value = 10;
            }
            if (e.KeyCode.Equals(Keys.D2))
            {
                trb_vol.Value = 20;
            }
            if (e.KeyCode.Equals(Keys.D3))
            {
                trb_vol.Value = 30;
            }
            if (e.KeyCode.Equals(Keys.D4))
            {
                trb_vol.Value = 40;
            }
            if (e.KeyCode.Equals(Keys.D5))
            {
                trb_vol.Value = 50;
            }
            if (e.KeyCode.Equals(Keys.D6))
            {
                trb_vol.Value = 60;
            }
            if (e.KeyCode.Equals(Keys.D7))
            {
                trb_vol.Value = 70;
            }
            if (e.KeyCode.Equals(Keys.D8))
            {
                trb_vol.Value = 80;
            }
            if (e.KeyCode.Equals(Keys.D9))
            {
                trb_vol.Value = 90;
            }
            if (e.KeyCode.Equals(Keys.D0))
            {
                trb_vol.Value = 100;
            }
            if (e.KeyCode.Equals(Keys.NumPad1))
            {
                trb_vol.Value = 10;
            }
            if (e.KeyCode.Equals(Keys.NumPad2))
            {
                trb_vol.Value = 20;
            }
            if (e.KeyCode.Equals(Keys.NumPad3))
            {
                trb_vol.Value = 30;
            }
            if (e.KeyCode.Equals(Keys.NumPad4))
            {
                trb_vol.Value = 40;
            }
            if (e.KeyCode.Equals(Keys.NumPad5))
            {
                trb_vol.Value = 50;
            }
            if (e.KeyCode.Equals(Keys.NumPad6))
            {
                trb_vol.Value = 60;
            }
            if (e.KeyCode.Equals(Keys.NumPad7))
            {
                trb_vol.Value = 70;
            }
            if (e.KeyCode.Equals(Keys.NumPad8))
            {
                trb_vol.Value = 80;
            }
            if (e.KeyCode.Equals(Keys.NumPad9))
            {
                trb_vol.Value = 90;
            }
            if (e.KeyCode.Equals(Keys.NumPad0))
            {
                trb_vol.Value = 100;
            }
            voice.Volume = trb_vol.Value;
        }     
        void selectthemostbig()
        {
            string cmtext2 = "select count( STT) as count from Word_study,history_word where stt=id and  ID_ADD !=0";
            SqlCommand cm2 = new SqlCommand(cmtext2, con2);
            con2.Open();
            SqlDataReader dr2 = cm2.ExecuteReader();
            dr2.Read();
            var  temp = ((int)dr2["count"]).ToString();
            con2.Close();
            txtbig.Text = temp;
        }
        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            showgrind(cb_sort.Text);
        }
        void change_cb_findword (string a)
        {
            if (a == "Word")
            {
                lbl_keyword.Visible = true;
                cb_type.Visible = false;
                txt_mean_word.Visible = true;
            }
            if(a == "Mean")
            {
                lbl_keyword.Visible = true;
                cb_type.Visible = false;
                txt_mean_word.Visible = true;
            }
            if (a == "Type Of Word")
            {
                lbl_keyword.Visible = false;
                txt_mean_word.Visible = false;
                cb_type.Visible = true;
            }
        }
        private void cb_word_tof_mean_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_cb_findword(cb_word_tof_mean.Text);
        }
        private void delete_funtion( int a)
        {
                con2.Open();
                int temp = a - 1;
                using (SqlCommand cmd = new SqlCommand("Delete from word_study where stt=" + a + "DBCC CHECKIDENT('Word_study', RESEED," + temp + ")",con2))
                { 
                    cmd.ExecuteNonQuery();
                }
                con2.Close();
                con2.Open();
                using (SqlCommand cmd2 = new SqlCommand("Delete from history_word where id=" + a + "DBCC CHECKIDENT('history_word', RESEED," + temp+ ")",con2))
                {
                    cmd2.ExecuteNonQuery();
                }
                con2.Close();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {

            updatecol();
            var a = numberrow;
            DialogResult re=  MessageBox.Show("Are you sure about word deletion at position "+a+" ?", "Select", MessageBoxButtons.YesNo);
            if (re==DialogResult.Yes)
            {
                delete_funtion(a);
                showgrind(cb_sort.Text);
            }
        }
        private void txt_mean_word_TextChanged(object sender, EventArgs e)
        {
            if (txt_mean_word.Text=="")
            {
                showgrind("All");
            }
            if (txt_mean_word.Text.Contains("="))
            {
                txt_mean_word.Text = "";
            }
            showgrind(cb_sort.Text);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtword.Text == "")
            {
                MessageBox.Show("Really???", ":-)");
            }
            else
                txt_clear();
        }
        private void txt_stt_TextChanged(object sender, EventArgs e)
        {
            if (txt_stt.Text!="")
            {
                showgrind(cb_sort.Text);
            }
            else
            {
                showgrind("All");
            }
            
        }
        private void txtbig_TextChanged(object sender, EventArgs e)
        {
            if (txtbig.Text != ""&& cb_sort.Text=="STT")
            {
                showgrind(cb_sort.Text);
            }

        }
        private void Form10word_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.A))
            {
                btn_add_funtion();
            }
            if (e.KeyCode.Equals(Keys.T))
            {
                txt_clear();
                data_load();
            }
        } 
        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            if (txt_find.Text == " ")
            {
                txt_find.Text = "";
            }
            if (txt_find.Text!="")
            {
                showgrind(cb_sort.Text);
            }
   
        }
        int check_min_find(string a)
        {
         
                string cmtext2 = "select min(id) as count from av where word like '" + a + "%'";
                SqlCommand cm2 = new SqlCommand(cmtext2, con);
                con.Open();
                SqlDataReader dr2 = cm2.ExecuteReader();
                dr2.Read();
                int temp = (int)dr2["count"];
                con.Close();
                return temp;
            

        }
        int check_max_find(string a)
        {
            string cmtext2 = "select max(id) as count from av where word like '" + a + "%'";
            SqlCommand cm3 = new SqlCommand(cmtext2, con);
            con.Open();
            SqlDataReader dr2 = cm3.ExecuteReader();
            dr2.Read();
            int temp = (int)dr2["count"];
            con.Close();
            return temp;
        }
        private void Form10word_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip3.Show(new Point(MousePosition.X,MousePosition.Y));
            }    
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cb_sort.Text = "All";
            dataGridView1.Visible = false;
            showgrind("All");

        }
        private void btn_find_Click(object sender, EventArgs e)
        {
            if (checkkinhlup == false)
            {
                cb_sort.Text = "Find";
                cb_date_add.Visible = false;
                txt_stt.Visible = false;
                txtbig.Visible = false;
                lbl_form.Visible = false;
                cb_word_tof_mean.Visible = false;
                lbl_to.Visible = false;
                lbl_keyword.Visible = false;
                cb_type.Visible = false;
                txt_mean_word.Visible = false;
                cb_sort.Visible = false;
                txt_find.Visible = true;
                lbl_keyword_2.Visible = true;
                btn_find.BackColor = Color.Red;
                checkkinhlup = true;
                txt_speak.Visible = true;
            }
            else
            {
                cb_sort.Text = "Date";
                cb_date_add.Visible = false;
                txt_stt.Visible = false;
                txtbig.Visible = false;
                lbl_form.Visible = false;
                cb_word_tof_mean.Visible = false;
                lbl_to.Visible = false;
                lbl_keyword.Visible = false;
                cb_type.Visible = false;
                txt_mean_word.Visible = false;
                showgrind(cb_sort.Text);
                lbl_form.Text = "Date:";
                lbl_form.Visible = true;
                cb_sort.Visible = true;
                txt_find.Visible = false;
                btn_find.BackColor = Color.Transparent;
                lbl_keyword_2.Visible = false;
                checkkinhlup = false;
                txt_speak.Visible = false;
                cb_date_add.Visible = true;
            }
        }
        private void txt_stt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtbig_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

}


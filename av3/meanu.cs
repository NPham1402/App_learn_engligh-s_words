using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace av3
{
    public partial class meanu : Form
    {
      
        Test c = new Test();
        bool dragging = false;
        Point stratpoint = new Point(0,0);
        Form10word b = new Form10word();
        public meanu()
        {
            InitializeComponent();
        }

        private void wordstudy1_Load(object sender, EventArgs e)
        {
            
        }

        private void meanu_Load(object sender, EventArgs e)
        {
            notice a = new notice();
            loading_show(a);
            pb_load.Hide();
        } 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void wordstudy1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel_move_2.Location.Y!=150)
            {
                panel_move_2.Location = new Point(0, 150);
                btn_menu.ForeColor = Color.Red;
                btn_word.ForeColor = Color.Black;
                btn_test.ForeColor = Color.Black;
                btn_menu.Font = new Font("Times New Roman", 30, FontStyle.Bold | FontStyle.Italic);
                btn_word.Font = new Font("Times New Roman", 24, FontStyle.Bold);
                btn_test.Font = new Font("Times New Roman", 24, FontStyle.Bold);
               btn_menu.BackColor = Color.FromArgb(2, 200, 252);
                btn_word.BackColor = Color.FromArgb(2, 217, 252);
                btn_test.BackColor = Color.FromArgb(2, 217, 252);
                lbl_header.Text = "Menu";
                if (pn_main.Controls.Count > 0)
                {
                    pn_main.Controls.Clear();
                }
                notice a = new notice();
                loading_show(a);
            }
            


        }


        private void btn_word_Click(object sender, EventArgs e)
        {
            if (panel_move_2.Location.Y != 150+133)
            {
                panel_move_2.Location = new Point(0, 150+133);
                btn_word.ForeColor = Color.Red;
                btn_menu.ForeColor = Color.Black;
                btn_test.ForeColor = Color.Black;
                btn_word.Font = new Font("Times New Roman", 30, FontStyle.Bold | FontStyle.Italic);
                btn_menu.Font = new Font("Times New Roman", 24, FontStyle.Bold);
                btn_test.Font = new Font("Times New Roman", 24, FontStyle.Bold);
                btn_word.BackColor = Color.FromArgb(2, 200, 252);
                btn_test.BackColor = Color.FromArgb(2, 217, 252);
                btn_menu.BackColor = Color.FromArgb(2, 217, 252);
                lbl_header.Text = "Word";
                if (pn_main.Controls.Count > 0)
                {
                    pn_main.Controls.Clear();
                }
                loading_show(b);
            }
        }



        private void word2_Load(object sender, EventArgs e)
        {

        }

        private void btn_signin1_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://phamnhuyenstore.000webhostapp.com/dangnhap.html";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void btn_signin2_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://drive.google.com/file/d/1_iSC0YB2_DaCUA8HGKC6dxBrais9wJjW/view?usp=sharing";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string targetURL = @"https://phamnhuyenstore.000webhostapp.com/dangnhap.html";
            System.Diagnostics.Process.Start(targetURL);
        }
        private void btn_test_Click(object sender, EventArgs e)
        {
            if (panel_move_2.Location.Y != 150 + 133+133)
            {
                panel_move_2.Location = new Point(0, 150 + 133+133);
                btn_test.ForeColor = Color.Red;
                btn_menu.ForeColor = Color.Black;
                btn_word.ForeColor = Color.Black;
                btn_test.Font = new Font("Times New Roman", 30, FontStyle.Bold | FontStyle.Italic);
                btn_menu.Font = new Font("Times New Roman", 24, FontStyle.Bold);
                btn_word.Font = new Font("Times New Roman", 24, FontStyle.Bold);
                btn_test.BackColor = Color.FromArgb(2, 200, 252);
                btn_word.BackColor = Color.FromArgb(2, 217, 252);
                btn_menu.BackColor = Color.FromArgb(2, 217, 252);
                lbl_header.Text = "Test";
                if (pn_main.Controls.Count > 0)
                {
                    pn_main.Controls.Clear();
                }
                loading_show(c);
              
            } 
        }
        void loading_show(Form form)
        {
            pb_load.Visible = true;
            form.TopLevel = false;
            form.Dock = DockStyle.Right;
            form.AutoScroll = false;
            pn_main.Controls.Add(form);
            timer1.Start();
            form.Show();
        }
     

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("No double", "ERROR");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pcb_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pcb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pn_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_load.Visible=false;
            timer1.Enabled = false;
        }

        private void pb_load_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            stratpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging==true)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - this.stratpoint.X, p.Y - this.stratpoint.Y);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void brn_spill_Click(object sender, EventArgs e)
        {
            if (pn_move.Width == 91)
            {
                pn_move.Width = 269;
                lbl_header.Location = new Point(484, 3);
                brn_spill.BackgroundImage = new Bitmap(@"C:\Users\09382\OneDrive\Hình ảnh\icon\1.png");
            }
            else
            {
                pn_move.Width = 91;
                lbl_header.Location = new Point(571, 3);
                brn_spill.BackgroundImage = new Bitmap(@"C:\Users\09382\OneDrive\Hình ảnh\icon\2.png");
            }
        }
    }
}

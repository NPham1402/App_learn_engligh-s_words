namespace av3
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.imlbutton = new System.Windows.Forms.ImageList(this.components);
            this.lbltxt2 = new System.Windows.Forms.Label();
            this.lbltxt1 = new System.Windows.Forms.Label();
            this.lblanswer = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtmeaning = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnstart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tow = new System.Windows.Forms.TextBox();
            this.btn_history = new System.Windows.Forms.Button();
            this.lbl_dapan = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_switch = new System.Windows.Forms.PictureBox();
            this.pn_history = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_option = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_speak = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_date = new System.Windows.Forms.CheckBox();
            this.cb_between = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.pn_between = new System.Windows.Forms.Panel();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.cb_date_add = new System.Windows.Forms.ComboBox();
            this.cb_speak = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ckb_random = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_switch)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pn_between.SuspendLayout();
            this.SuspendLayout();
            // 
            // imlbutton
            // 
            this.imlbutton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlbutton.ImageStream")));
            this.imlbutton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlbutton.Images.SetKeyName(0, "100313344-delete-icon-no-sign-close-symbol-vector-cancel-wrong-and-reject-illustr" +
        "ation-.ico");
            // 
            // lbltxt2
            // 
            this.lbltxt2.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt2.ForeColor = System.Drawing.Color.Red;
            this.lbltxt2.Location = new System.Drawing.Point(488, 88);
            this.lbltxt2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltxt2.Name = "lbltxt2";
            this.lbltxt2.Size = new System.Drawing.Size(230, 50);
            this.lbltxt2.TabIndex = 15;
            this.lbltxt2.Text = "Vietnamese";
            this.lbltxt2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltxt1
            // 
            this.lbltxt1.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt1.ForeColor = System.Drawing.Color.Red;
            this.lbltxt1.Location = new System.Drawing.Point(4, 88);
            this.lbltxt1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltxt1.Name = "lbltxt1";
            this.lbltxt1.Size = new System.Drawing.Size(204, 50);
            this.lbltxt1.TabIndex = 16;
            this.lbltxt1.Text = "English";
            // 
            // lblanswer
            // 
            this.lblanswer.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblanswer.ForeColor = System.Drawing.Color.Red;
            this.lblanswer.Location = new System.Drawing.Point(186, 346);
            this.lblanswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(313, 32);
            this.lblanswer.TabIndex = 6;
            this.lblanswer.Text = "Thống Kê:";
            this.lblanswer.Visible = false;
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.White;
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWord.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(3, 153);
            this.txtWord.Margin = new System.Windows.Forms.Padding(0);
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(205, 30);
            this.txtWord.TabIndex = 11;
            // 
            // txtmeaning
            // 
            this.txtmeaning.BackColor = System.Drawing.Color.White;
            this.txtmeaning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmeaning.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmeaning.Location = new System.Drawing.Point(487, 153);
            this.txtmeaning.Margin = new System.Windows.Forms.Padding(0);
            this.txtmeaning.Name = "txtmeaning";
            this.txtmeaning.ReadOnly = true;
            this.txtmeaning.Size = new System.Drawing.Size(232, 30);
            this.txtmeaning.TabIndex = 2;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(412, 245);
            this.btnnext.Margin = new System.Windows.Forms.Padding(2);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(179, 84);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Visible = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnstop
            // 
            this.btnstop.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnstop.Location = new System.Drawing.Point(101, 246);
            this.btnstop.Margin = new System.Windows.Forms.Padding(2);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(179, 84);
            this.btnstop.TabIndex = 9;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Visible = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(2, 472);
            this.btnstart.Margin = new System.Windows.Forms.Padding(0);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(172, 85);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(252, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Type of word";
            // 
            // txt_tow
            // 
            this.txt_tow.BackColor = System.Drawing.Color.White;
            this.txt_tow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tow.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.txt_tow.Location = new System.Drawing.Point(247, 153);
            this.txt_tow.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tow.Name = "txt_tow";
            this.txt_tow.ReadOnly = true;
            this.txt_tow.Size = new System.Drawing.Size(213, 30);
            this.txt_tow.TabIndex = 1;
            this.txt_tow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tow_KeyPress);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(590, 383);
            this.btn_history.Margin = new System.Windows.Forms.Padding(2);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(122, 73);
            this.btn_history.TabIndex = 17;
            this.btn_history.Text = "Open History";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // lbl_dapan
            // 
            this.lbl_dapan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dapan.ForeColor = System.Drawing.Color.Red;
            this.lbl_dapan.Location = new System.Drawing.Point(487, 193);
            this.lbl_dapan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dapan.Name = "lbl_dapan";
            this.lbl_dapan.Size = new System.Drawing.Size(232, 23);
            this.lbl_dapan.TabIndex = 6;
            this.lbl_dapan.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(-3, 82);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1239, 10);
            this.panel9.TabIndex = 38;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(177, 92);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 466);
            this.panel8.TabIndex = 36;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            // 
            // pb_switch
            // 
            this.pb_switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_switch.Image = ((System.Drawing.Image)(resources.GetObject("pb_switch.Image")));
            this.pb_switch.Location = new System.Drawing.Point(247, 194);
            this.pb_switch.Name = "pb_switch";
            this.pb_switch.Size = new System.Drawing.Size(213, 50);
            this.pb_switch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_switch.TabIndex = 39;
            this.pb_switch.TabStop = false;
            this.pb_switch.Click += new System.EventHandler(this.pb_switch_Click);
            // 
            // pn_history
            // 
            this.pn_history.Location = new System.Drawing.Point(912, 93);
            this.pn_history.Margin = new System.Windows.Forms.Padding(0);
            this.pn_history.Name = "pn_history";
            this.pn_history.Size = new System.Drawing.Size(319, 465);
            this.pn_history.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cb_option);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 82);
            this.panel2.TabIndex = 41;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1024, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 33);
            this.label3.TabIndex = 42;
            this.label3.Text = "History";
            // 
            // cb_option
            // 
            this.cb_option.AutoSize = true;
            this.cb_option.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_option.Location = new System.Drawing.Point(466, 38);
            this.cb_option.Name = "cb_option";
            this.cb_option.Size = new System.Drawing.Size(127, 33);
            this.cb_option.TabIndex = 42;
            this.cb_option.Text = "Test page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 33);
            this.label2.TabIndex = 42;
            this.label2.Text = "Select Option";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_speak);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lbltxt1);
            this.panel3.Controls.Add(this.pb_switch);
            this.panel3.Controls.Add(this.btnstop);
            this.panel3.Controls.Add(this.btnnext);
            this.panel3.Controls.Add(this.txtmeaning);
            this.panel3.Controls.Add(this.txtWord);
            this.panel3.Controls.Add(this.txt_tow);
            this.panel3.Controls.Add(this.btn_history);
            this.panel3.Controls.Add(this.lblanswer);
            this.panel3.Controls.Add(this.lbltxt2);
            this.panel3.Controls.Add(this.lbl_dapan);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(185, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 465);
            this.panel3.TabIndex = 0;
            // 
            // btn_speak
            // 
            this.btn_speak.Location = new System.Drawing.Point(3, 121);
            this.btn_speak.Name = "btn_speak";
            this.btn_speak.Size = new System.Drawing.Size(205, 64);
            this.btn_speak.TabIndex = 41;
            this.btn_speak.Text = "Speak";
            this.btn_speak.UseVisualStyleBackColor = true;
            this.btn_speak.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.OrangeRed;
            this.panel6.Location = new System.Drawing.Point(247, 185);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 5);
            this.panel6.TabIndex = 40;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.OrangeRed;
            this.panel5.Location = new System.Drawing.Point(491, 185);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(226, 5);
            this.panel5.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Location = new System.Drawing.Point(3, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 5);
            this.panel4.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(908, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 466);
            this.panel1.TabIndex = 36;
            // 
            // cb_date
            // 
            this.cb_date.AutoSize = true;
            this.cb_date.Location = new System.Drawing.Point(9, 155);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(49, 17);
            this.cb_date.TabIndex = 42;
            this.cb_date.Text = "Date";
            this.cb_date.UseVisualStyleBackColor = true;
            this.cb_date.CheckedChanged += new System.EventHandler(this.cb_date_CheckedChanged);
            // 
            // cb_between
            // 
            this.cb_between.AutoSize = true;
            this.cb_between.Location = new System.Drawing.Point(9, 213);
            this.cb_between.Name = "cb_between";
            this.cb_between.Size = new System.Drawing.Size(68, 17);
            this.cb_between.TabIndex = 42;
            this.cb_between.Text = "Between";
            this.cb_between.UseVisualStyleBackColor = true;
            this.cb_between.CheckedChanged += new System.EventHandler(this.cb_between_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Form";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "To";
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(49, 22);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(100, 20);
            this.txt_from.TabIndex = 40;
            this.txt_from.Text = "1";
            // 
            // pn_between
            // 
            this.pn_between.Controls.Add(this.label4);
            this.pn_between.Controls.Add(this.txt_to);
            this.pn_between.Controls.Add(this.txt_from);
            this.pn_between.Controls.Add(this.label5);
            this.pn_between.Location = new System.Drawing.Point(2, 233);
            this.pn_between.Name = "pn_between";
            this.pn_between.Size = new System.Drawing.Size(169, 100);
            this.pn_between.TabIndex = 44;
            this.pn_between.Visible = false;
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(49, 57);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(100, 20);
            this.txt_to.TabIndex = 40;
            // 
            // cb_date_add
            // 
            this.cb_date_add.FormattingEnabled = true;
            this.cb_date_add.Location = new System.Drawing.Point(9, 180);
            this.cb_date_add.Name = "cb_date_add";
            this.cb_date_add.Size = new System.Drawing.Size(142, 21);
            this.cb_date_add.TabIndex = 45;
            this.cb_date_add.Visible = false;
            // 
            // cb_speak
            // 
            this.cb_speak.AutoSize = true;
            this.cb_speak.Location = new System.Drawing.Point(9, 350);
            this.cb_speak.Name = "cb_speak";
            this.cb_speak.Size = new System.Drawing.Size(53, 17);
            this.cb_speak.TabIndex = 42;
            this.cb_speak.Text = "Voice";
            this.cb_speak.UseVisualStyleBackColor = true;
            this.cb_speak.CheckedChanged += new System.EventHandler(this.cb_speak_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ckb_random
            // 
            this.ckb_random.AutoSize = true;
            this.ckb_random.Location = new System.Drawing.Point(9, 403);
            this.ckb_random.Name = "ckb_random";
            this.ckb_random.Size = new System.Drawing.Size(66, 17);
            this.ckb_random.TabIndex = 46;
            this.ckb_random.Text = "Random";
            this.ckb_random.UseVisualStyleBackColor = true;
            this.ckb_random.CheckedChanged += new System.EventHandler(this.ckb_random_CheckedChanged);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 566);
            this.ControlBox = false;
            this.Controls.Add(this.ckb_random);
            this.Controls.Add(this.cb_date_add);
            this.Controls.Add(this.pn_between);
            this.Controls.Add(this.cb_speak);
            this.Controls.Add(this.cb_between);
            this.Controls.Add(this.cb_date);
            this.Controls.Add(this.pn_history);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_switch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pn_between.ResumeLayout(false);
            this.pn_between.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltxt2;
        private System.Windows.Forms.Label lbltxt1;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtmeaning;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ImageList imlbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tow;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Label lbl_dapan;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_switch;
        private System.Windows.Forms.Panel pn_history;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cb_option;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_date;
        private System.Windows.Forms.CheckBox cb_between;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.Panel pn_between;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.ComboBox cb_date_add;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cb_speak;
        private System.Windows.Forms.Button btn_speak;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox ckb_random;
    }
}


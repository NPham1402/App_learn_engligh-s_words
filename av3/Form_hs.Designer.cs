namespace av3
{
    partial class HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btntest = new System.Windows.Forms.Button();
            this.hocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoctuDataSet = new av3.hoctuDataSet();
            this.hocTableAdapter = new av3.hoctuDataSetTableAdapters.HocTableAdapter();
            this.txt_word1 = new System.Windows.Forms.TextBox();
            this.txt_tow1 = new System.Windows.Forms.TextBox();
            this.txt_mean1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_word2 = new System.Windows.Forms.TextBox();
            this.txt_tow = new System.Windows.Forms.TextBox();
            this.txt_mean2 = new System.Windows.Forms.TextBox();
            this.btnstar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoctuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Btntest
            // 
            this.Btntest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btntest.Location = new System.Drawing.Point(496, 310);
            this.Btntest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btntest.Name = "Btntest";
            this.Btntest.Size = new System.Drawing.Size(123, 49);
            this.Btntest.TabIndex = 0;
            this.Btntest.Text = "Test";
            this.Btntest.UseVisualStyleBackColor = true;
            this.Btntest.Click += new System.EventHandler(this.Btntest_Click);
            // 
            // hocBindingSource
            // 
            this.hocBindingSource.DataMember = "Hoc";
            this.hocBindingSource.DataSource = this.hoctuDataSet;
            // 
            // hoctuDataSet
            // 
            this.hoctuDataSet.DataSetName = "hoctuDataSet";
            this.hoctuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocTableAdapter
            // 
            this.hocTableAdapter.ClearBeforeFill = true;
            // 
            // txt_word1
            // 
            this.txt_word1.Location = new System.Drawing.Point(9, 110);
            this.txt_word1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_word1.Name = "txt_word1";
            this.txt_word1.ReadOnly = true;
            this.txt_word1.Size = new System.Drawing.Size(236, 20);
            this.txt_word1.TabIndex = 4;
            // 
            // txt_tow1
            // 
            this.txt_tow1.Location = new System.Drawing.Point(9, 162);
            this.txt_tow1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tow1.Name = "txt_tow1";
            this.txt_tow1.ReadOnly = true;
            this.txt_tow1.Size = new System.Drawing.Size(124, 20);
            this.txt_tow1.TabIndex = 4;
            
            // 
            // txt_mean1
            // 
            this.txt_mean1.Location = new System.Drawing.Point(9, 213);
            this.txt_mean1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_mean1.Name = "txt_mean1";
            this.txt_mean1.ReadOnly = true;
            this.txt_mean1.Size = new System.Drawing.Size(236, 20);
            this.txt_mean1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Word";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type of word";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Meaning";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          
            // 
            // txt_word2
            // 
            this.txt_word2.Location = new System.Drawing.Point(332, 110);
            this.txt_word2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_word2.Name = "txt_word2";
            this.txt_word2.Size = new System.Drawing.Size(236, 20);
            this.txt_word2.TabIndex = 4;
            // 
            // txt_tow
            // 
            this.txt_tow.Location = new System.Drawing.Point(332, 162);
            this.txt_tow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tow.Name = "txt_tow";
            this.txt_tow.Size = new System.Drawing.Size(124, 20);
            this.txt_tow.TabIndex = 4;
            // 
            // txt_mean2
            // 
            this.txt_mean2.Location = new System.Drawing.Point(332, 224);
            this.txt_mean2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_mean2.Name = "txt_mean2";
            this.txt_mean2.Size = new System.Drawing.Size(251, 20);
            this.txt_mean2.TabIndex = 4;
            // 
            // btnstar
            // 
            this.btnstar.Location = new System.Drawing.Point(13, 269);
            this.btnstar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnstar.Name = "btnstar";
            this.btnstar.Size = new System.Drawing.Size(76, 40);
            this.btnstar.TabIndex = 6;
            this.btnstar.Text = "Start";
            this.btnstar.UseVisualStyleBackColor = true;
        
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 37);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 410);
            this.ControlBox = false;
            this.Controls.Add(this.btnstar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mean2);
            this.Controls.Add(this.txt_tow);
            this.Controls.Add(this.txt_mean1);
            this.Controls.Add(this.txt_word2);
            this.Controls.Add(this.txt_tow1);
            this.Controls.Add(this.txt_word1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btntest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HOME";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.HOME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoctuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btntest;
        private hoctuDataSet hoctuDataSet;
        private System.Windows.Forms.BindingSource hocBindingSource;
        private hoctuDataSetTableAdapters.HocTableAdapter hocTableAdapter;
        private System.Windows.Forms.TextBox txt_word1;
        private System.Windows.Forms.TextBox txt_tow1;
        private System.Windows.Forms.TextBox txt_mean1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_word2;
        private System.Windows.Forms.TextBox txt_tow;
        private System.Windows.Forms.TextBox txt_mean2;
        private System.Windows.Forms.Button btnstar;
        private System.Windows.Forms.Label label1;
    }
}
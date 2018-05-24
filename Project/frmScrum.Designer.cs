namespace WindowsFormsApplication83
{
    partial class frmScrum
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
            this.gbNotStarted = new System.Windows.Forms.GroupBox();
            this.lbNotStarted4 = new System.Windows.Forms.ListBox();
            this.lbNotStarted3 = new System.Windows.Forms.ListBox();
            this.lbNotStarted2 = new System.Windows.Forms.ListBox();
            this.lbNotStarted1 = new System.Windows.Forms.ListBox();
            this.lbInProgress2 = new System.Windows.Forms.ListBox();
            this.gbInProgess = new System.Windows.Forms.GroupBox();
            this.lbInProgress4 = new System.Windows.Forms.ListBox();
            this.lbInProgress3 = new System.Windows.Forms.ListBox();
            this.lbInProgress1 = new System.Windows.Forms.ListBox();
            this.lbDone2 = new System.Windows.Forms.ListBox();
            this.lbDone1 = new System.Windows.Forms.ListBox();
            this.lbDone3 = new System.Windows.Forms.ListBox();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.cmbStory = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblStory = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblKisi = new System.Windows.Forms.Label();
            this.lbl_StoryIsmi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStoryBasligi = new System.Windows.Forms.TextBox();
            this.txtStoryAciklama = new System.Windows.Forms.TextBox();
            this.btnStoryEkle = new System.Windows.Forms.Button();
            this.gpDone = new System.Windows.Forms.GroupBox();
            this.lbDone4 = new System.Windows.Forms.ListBox();
            this.gpStoryEkle = new System.Windows.Forms.GroupBox();
            this.gpTaskEkle = new System.Windows.Forms.GroupBox();
            this.gbNotStarted.SuspendLayout();
            this.gbInProgess.SuspendLayout();
            this.gpDone.SuspendLayout();
            this.gpStoryEkle.SuspendLayout();
            this.gpTaskEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNotStarted
            // 
            this.gbNotStarted.Controls.Add(this.lbNotStarted4);
            this.gbNotStarted.Controls.Add(this.lbNotStarted3);
            this.gbNotStarted.Controls.Add(this.lbNotStarted2);
            this.gbNotStarted.Controls.Add(this.lbNotStarted1);
            this.gbNotStarted.Location = new System.Drawing.Point(494, 40);
            this.gbNotStarted.Name = "gbNotStarted";
            this.gbNotStarted.Size = new System.Drawing.Size(255, 606);
            this.gbNotStarted.TabIndex = 2;
            this.gbNotStarted.TabStop = false;
            this.gbNotStarted.Text = "NOT STARTED";
            // 
            // lbNotStarted4
            // 
            this.lbNotStarted4.AllowDrop = true;
            this.lbNotStarted4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNotStarted4.FormattingEnabled = true;
            this.lbNotStarted4.Location = new System.Drawing.Point(3, 444);
            this.lbNotStarted4.Name = "lbNotStarted4";
            this.lbNotStarted4.Size = new System.Drawing.Size(249, 147);
            this.lbNotStarted4.TabIndex = 3;
            this.lbNotStarted4.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox10_DragDrop);
            this.lbNotStarted4.DragLeave += new System.EventHandler(this.listBox10_DragLeave);
            this.lbNotStarted4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox10_MouseDown);
            // 
            // lbNotStarted3
            // 
            this.lbNotStarted3.AllowDrop = true;
            this.lbNotStarted3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNotStarted3.FormattingEnabled = true;
            this.lbNotStarted3.Location = new System.Drawing.Point(3, 297);
            this.lbNotStarted3.Name = "lbNotStarted3";
            this.lbNotStarted3.Size = new System.Drawing.Size(249, 147);
            this.lbNotStarted3.TabIndex = 2;
            this.lbNotStarted3.SelectedIndexChanged += new System.EventHandler(this.listBox7_SelectedIndexChanged);
            this.lbNotStarted3.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox7_DragDrop);
            this.lbNotStarted3.DragLeave += new System.EventHandler(this.listBox7_DragLeave);
            this.lbNotStarted3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox7_MouseDown);
            // 
            // lbNotStarted2
            // 
            this.lbNotStarted2.AllowDrop = true;
            this.lbNotStarted2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNotStarted2.FormattingEnabled = true;
            this.lbNotStarted2.Location = new System.Drawing.Point(3, 150);
            this.lbNotStarted2.Name = "lbNotStarted2";
            this.lbNotStarted2.Size = new System.Drawing.Size(249, 147);
            this.lbNotStarted2.TabIndex = 2;
            this.lbNotStarted2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox4_DragDrop);
            this.lbNotStarted2.DragLeave += new System.EventHandler(this.listBox4_DragLeave);
            this.lbNotStarted2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox4_MouseDown);
            // 
            // lbNotStarted1
            // 
            this.lbNotStarted1.AllowDrop = true;
            this.lbNotStarted1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNotStarted1.FormattingEnabled = true;
            this.lbNotStarted1.Location = new System.Drawing.Point(3, 16);
            this.lbNotStarted1.Name = "lbNotStarted1";
            this.lbNotStarted1.Size = new System.Drawing.Size(249, 134);
            this.lbNotStarted1.TabIndex = 0;
            this.lbNotStarted1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lbNotStarted1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.lbNotStarted1.DragLeave += new System.EventHandler(this.listBox1_DragLeave);
            this.lbNotStarted1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // lbInProgress2
            // 
            this.lbInProgress2.AllowDrop = true;
            this.lbInProgress2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInProgress2.FormattingEnabled = true;
            this.lbInProgress2.Location = new System.Drawing.Point(3, 150);
            this.lbInProgress2.Name = "lbInProgress2";
            this.lbInProgress2.Size = new System.Drawing.Size(266, 147);
            this.lbInProgress2.TabIndex = 2;
            this.lbInProgress2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox5_DragDrop);
            this.lbInProgress2.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox5_DragOver);
            this.lbInProgress2.DragLeave += new System.EventHandler(this.listBox5_DragLeave);
            this.lbInProgress2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox5_MouseDown);
            // 
            // gbInProgess
            // 
            this.gbInProgess.Controls.Add(this.lbInProgress4);
            this.gbInProgess.Controls.Add(this.lbInProgress3);
            this.gbInProgess.Controls.Add(this.lbInProgress2);
            this.gbInProgess.Controls.Add(this.lbInProgress1);
            this.gbInProgess.Location = new System.Drawing.Point(755, 40);
            this.gbInProgess.Name = "gbInProgess";
            this.gbInProgess.Size = new System.Drawing.Size(272, 606);
            this.gbInProgess.TabIndex = 5;
            this.gbInProgess.TabStop = false;
            this.gbInProgess.Text = "IN PROGRESS";
            // 
            // lbInProgress4
            // 
            this.lbInProgress4.AllowDrop = true;
            this.lbInProgress4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInProgress4.FormattingEnabled = true;
            this.lbInProgress4.Location = new System.Drawing.Point(3, 444);
            this.lbInProgress4.Name = "lbInProgress4";
            this.lbInProgress4.Size = new System.Drawing.Size(266, 147);
            this.lbInProgress4.TabIndex = 3;
            this.lbInProgress4.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox11_DragDrop);
            this.lbInProgress4.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox11_DragOver);
            this.lbInProgress4.DragLeave += new System.EventHandler(this.listBox11_DragLeave);
            this.lbInProgress4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox11_MouseDown);
            // 
            // lbInProgress3
            // 
            this.lbInProgress3.AllowDrop = true;
            this.lbInProgress3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInProgress3.FormattingEnabled = true;
            this.lbInProgress3.Location = new System.Drawing.Point(3, 297);
            this.lbInProgress3.Name = "lbInProgress3";
            this.lbInProgress3.Size = new System.Drawing.Size(266, 147);
            this.lbInProgress3.TabIndex = 2;
            this.lbInProgress3.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox8_DragDrop);
            this.lbInProgress3.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox8_DragOver);
            this.lbInProgress3.DragLeave += new System.EventHandler(this.listBox8_DragLeave);
            this.lbInProgress3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox8_MouseDown);
            // 
            // lbInProgress1
            // 
            this.lbInProgress1.AllowDrop = true;
            this.lbInProgress1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInProgress1.FormattingEnabled = true;
            this.lbInProgress1.Location = new System.Drawing.Point(3, 16);
            this.lbInProgress1.Name = "lbInProgress1";
            this.lbInProgress1.Size = new System.Drawing.Size(266, 134);
            this.lbInProgress1.TabIndex = 1;
            this.lbInProgress1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.lbInProgress1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox2_DragOver);
            this.lbInProgress1.DragLeave += new System.EventHandler(this.listBox2_DragLeave);
            this.lbInProgress1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // lbDone2
            // 
            this.lbDone2.AllowDrop = true;
            this.lbDone2.FormattingEnabled = true;
            this.lbDone2.Location = new System.Drawing.Point(3, 150);
            this.lbDone2.Name = "lbDone2";
            this.lbDone2.Size = new System.Drawing.Size(253, 147);
            this.lbDone2.TabIndex = 2;
            this.lbDone2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox6_DragEnter);
            // 
            // lbDone1
            // 
            this.lbDone1.AllowDrop = true;
            this.lbDone1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDone1.FormattingEnabled = true;
            this.lbDone1.Location = new System.Drawing.Point(3, 16);
            this.lbDone1.Name = "lbDone1";
            this.lbDone1.Size = new System.Drawing.Size(253, 134);
            this.lbDone1.TabIndex = 2;
            this.lbDone1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox3_DragEnter);
            // 
            // lbDone3
            // 
            this.lbDone3.AllowDrop = true;
            this.lbDone3.FormattingEnabled = true;
            this.lbDone3.Location = new System.Drawing.Point(4, 297);
            this.lbDone3.Name = "lbDone3";
            this.lbDone3.Size = new System.Drawing.Size(252, 147);
            this.lbDone3.TabIndex = 2;
            this.lbDone3.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox9_DragEnter);
            // 
            // txtKisi
            // 
            this.txtKisi.Location = new System.Drawing.Point(78, 90);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(149, 20);
            this.txtKisi.TabIndex = 10;
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Location = new System.Drawing.Point(0, 147);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(227, 52);
            this.btnTaskEkle.TabIndex = 11;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(96, 391);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(213, 115);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "story açıklaması";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(96, 519);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(213, 115);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "story açıklaması";
            // 
            // cmbStory
            // 
            this.cmbStory.FormattingEnabled = true;
            this.cmbStory.Location = new System.Drawing.Point(78, 27);
            this.cmbStory.Name = "cmbStory";
            this.cmbStory.Size = new System.Drawing.Size(149, 21);
            this.cmbStory.TabIndex = 13;
            this.cmbStory.SelectedIndexChanged += new System.EventHandler(this.cmbStory_SelectedIndexChanged);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(78, 54);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(149, 20);
            this.dtpTarih.TabIndex = 14;
            // 
            // lblStory
            // 
            this.lblStory.AutoSize = true;
            this.lblStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStory.Location = new System.Drawing.Point(6, 27);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(58, 15);
            this.lblStory.TabIndex = 15;
            this.lblStory.Text = "Story Seç";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(8, 51);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(35, 15);
            this.lblTarih.TabIndex = 16;
            this.lblTarih.Text = "Tarih";
            // 
            // lblKisi
            // 
            this.lblKisi.AutoSize = true;
            this.lblKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisi.Location = new System.Drawing.Point(8, 95);
            this.lblKisi.Name = "lblKisi";
            this.lblKisi.Size = new System.Drawing.Size(30, 15);
            this.lblKisi.TabIndex = 17;
            this.lblKisi.Text = "İsim";
            // 
            // lbl_StoryIsmi
            // 
            this.lbl_StoryIsmi.AutoSize = true;
            this.lbl_StoryIsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_StoryIsmi.Location = new System.Drawing.Point(6, 41);
            this.lbl_StoryIsmi.Name = "lbl_StoryIsmi";
            this.lbl_StoryIsmi.Size = new System.Drawing.Size(60, 15);
            this.lbl_StoryIsmi.TabIndex = 18;
            this.lbl_StoryIsmi.Text = "Story İsmi";
            this.lbl_StoryIsmi.Click += new System.EventHandler(this.lbl_StoryIsmi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Story Açıklaması";
            // 
            // txtStoryBasligi
            // 
            this.txtStoryBasligi.Location = new System.Drawing.Point(72, 40);
            this.txtStoryBasligi.Name = "txtStoryBasligi";
            this.txtStoryBasligi.Size = new System.Drawing.Size(158, 20);
            this.txtStoryBasligi.TabIndex = 20;
            // 
            // txtStoryAciklama
            // 
            this.txtStoryAciklama.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtStoryAciklama.Location = new System.Drawing.Point(3, 79);
            this.txtStoryAciklama.Multiline = true;
            this.txtStoryAciklama.Name = "txtStoryAciklama";
            this.txtStoryAciklama.Size = new System.Drawing.Size(230, 235);
            this.txtStoryAciklama.TabIndex = 21;
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.Location = new System.Drawing.Point(7, 348);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(236, 49);
            this.btnStoryEkle.TabIndex = 22;
            this.btnStoryEkle.Text = "Story Ekle";
            this.btnStoryEkle.UseVisualStyleBackColor = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // gpDone
            // 
            this.gpDone.Controls.Add(this.lbDone4);
            this.gpDone.Controls.Add(this.lbDone3);
            this.gpDone.Controls.Add(this.lbDone1);
            this.gpDone.Controls.Add(this.lbDone2);
            this.gpDone.Location = new System.Drawing.Point(1033, 40);
            this.gpDone.Name = "gpDone";
            this.gpDone.Size = new System.Drawing.Size(259, 606);
            this.gpDone.TabIndex = 23;
            this.gpDone.TabStop = false;
            this.gpDone.Text = "DONE";
            // 
            // lbDone4
            // 
            this.lbDone4.AllowDrop = true;
            this.lbDone4.FormattingEnabled = true;
            this.lbDone4.Location = new System.Drawing.Point(4, 442);
            this.lbDone4.Name = "lbDone4";
            this.lbDone4.Size = new System.Drawing.Size(252, 147);
            this.lbDone4.TabIndex = 4;
            this.lbDone4.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox12_DragEnter);
            // 
            // gpStoryEkle
            // 
            this.gpStoryEkle.Controls.Add(this.lbl_StoryIsmi);
            this.gpStoryEkle.Controls.Add(this.txtStoryBasligi);
            this.gpStoryEkle.Controls.Add(this.textBox6);
            this.gpStoryEkle.Controls.Add(this.txtStoryAciklama);
            this.gpStoryEkle.Controls.Add(this.textBox7);
            this.gpStoryEkle.Location = new System.Drawing.Point(4, 12);
            this.gpStoryEkle.Name = "gpStoryEkle";
            this.gpStoryEkle.Size = new System.Drawing.Size(236, 317);
            this.gpStoryEkle.TabIndex = 24;
            this.gpStoryEkle.TabStop = false;
            this.gpStoryEkle.Text = "Story Ekle";
            // 
            // gpTaskEkle
            // 
            this.gpTaskEkle.Controls.Add(this.lblStory);
            this.gpTaskEkle.Controls.Add(this.cmbStory);
            this.gpTaskEkle.Controls.Add(this.lblTarih);
            this.gpTaskEkle.Controls.Add(this.dtpTarih);
            this.gpTaskEkle.Controls.Add(this.lblKisi);
            this.gpTaskEkle.Controls.Add(this.txtKisi);
            this.gpTaskEkle.Controls.Add(this.btnTaskEkle);
            this.gpTaskEkle.Location = new System.Drawing.Point(4, 411);
            this.gpTaskEkle.Name = "gpTaskEkle";
            this.gpTaskEkle.Size = new System.Drawing.Size(233, 205);
            this.gpTaskEkle.TabIndex = 25;
            this.gpTaskEkle.TabStop = false;
            this.gpTaskEkle.Text = "Task Ekle";
            this.gpTaskEkle.Enter += new System.EventHandler(this.groupBox10_Enter);
            // 
            // frmScrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.gpTaskEkle);
            this.Controls.Add(this.gpStoryEkle);
            this.Controls.Add(this.gpDone);
            this.Controls.Add(this.btnStoryEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbInProgess);
            this.Controls.Add(this.gbNotStarted);
            this.Name = "frmScrum";
            this.Text = "SCRUM TAHTASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNotStarted.ResumeLayout(false);
            this.gbInProgess.ResumeLayout(false);
            this.gpDone.ResumeLayout(false);
            this.gpStoryEkle.ResumeLayout(false);
            this.gpStoryEkle.PerformLayout();
            this.gpTaskEkle.ResumeLayout(false);
            this.gpTaskEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbNotStarted;
        private System.Windows.Forms.ListBox lbNotStarted1;
        private System.Windows.Forms.ListBox lbNotStarted3;
        private System.Windows.Forms.ListBox lbInProgress2;
        private System.Windows.Forms.GroupBox gbInProgess;
        private System.Windows.Forms.ListBox lbInProgress1;
        private System.Windows.Forms.ListBox lbInProgress3;
        private System.Windows.Forms.ListBox lbDone2;
        private System.Windows.Forms.ListBox lbDone1;
        private System.Windows.Forms.ListBox lbDone3;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.ListBox lbNotStarted2;
        private System.Windows.Forms.ComboBox cmbStory;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblStory;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblKisi;
        private System.Windows.Forms.Label lbl_StoryIsmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStoryBasligi;
        private System.Windows.Forms.TextBox txtStoryAciklama;
        private System.Windows.Forms.ListBox lbNotStarted4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnStoryEkle;
        private System.Windows.Forms.ListBox lbInProgress4;
        private System.Windows.Forms.GroupBox gpDone;
        private System.Windows.Forms.ListBox lbDone4;
        private System.Windows.Forms.GroupBox gpStoryEkle;
        private System.Windows.Forms.GroupBox gpTaskEkle;
    }
}


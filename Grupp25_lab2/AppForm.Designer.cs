
namespace Grupp25_lab2
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.akademicentrumLabel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registreraNyLärareBTN = new System.Windows.Forms.Button();
            this.visaLärareBTN = new System.Windows.Forms.Button();
            this.lärareLabel = new System.Windows.Forms.Label();
            this.registreraNyStudentBTN = new System.Windows.Forms.Button();
            this.visaStudenterBTN = new System.Windows.Forms.Button();
            this.studentLabel = new System.Windows.Forms.Label();
            this.registreraNyKursBTN = new System.Windows.Forms.Button();
            this.visaKurserBTN = new System.Windows.Forms.Button();
            this.kurserLabel = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // akademicentrumLabel
            // 
            this.akademicentrumLabel.AutoSize = true;
            this.akademicentrumLabel.Font = new System.Drawing.Font("Roboto", 25F);
            this.akademicentrumLabel.ForeColor = System.Drawing.Color.Indigo;
            this.akademicentrumLabel.Location = new System.Drawing.Point(12, 9);
            this.akademicentrumLabel.Name = "akademicentrumLabel";
            this.akademicentrumLabel.Size = new System.Drawing.Size(278, 41);
            this.akademicentrumLabel.TabIndex = 1;
            this.akademicentrumLabel.Text = "Akademicentrum";
            // 
            // header
            // 
            this.header.AutoScroll = true;
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.panel2);
            this.header.Controls.Add(this.panel1);
            this.header.Controls.Add(this.registreraNyLärareBTN);
            this.header.Controls.Add(this.visaLärareBTN);
            this.header.Controls.Add(this.lärareLabel);
            this.header.Controls.Add(this.registreraNyStudentBTN);
            this.header.Controls.Add(this.visaStudenterBTN);
            this.header.Controls.Add(this.studentLabel);
            this.header.Controls.Add(this.registreraNyKursBTN);
            this.header.Controls.Add(this.visaKurserBTN);
            this.header.Controls.Add(this.kurserLabel);
            this.header.Controls.Add(this.akademicentrumLabel);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(550, 143);
            this.header.TabIndex = 2;
            this.header.Click += new System.EventHandler(this.VisaLärareBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(305, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 70);
            this.panel2.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(148, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 70);
            this.panel1.TabIndex = 0;
            // 
            // registreraNyLärareBTN
            // 
            this.registreraNyLärareBTN.Location = new System.Drawing.Point(328, 110);
            this.registreraNyLärareBTN.Name = "registreraNyLärareBTN";
            this.registreraNyLärareBTN.Size = new System.Drawing.Size(106, 23);
            this.registreraNyLärareBTN.TabIndex = 33;
            this.registreraNyLärareBTN.Text = "Registrera ny lärare";
            this.registreraNyLärareBTN.UseVisualStyleBackColor = true;
            this.registreraNyLärareBTN.Click += new System.EventHandler(this.RegistreraNyLärareBTN_Click);
            // 
            // visaLärareBTN
            // 
            this.visaLärareBTN.Location = new System.Drawing.Point(328, 81);
            this.visaLärareBTN.Name = "visaLärareBTN";
            this.visaLärareBTN.Size = new System.Drawing.Size(68, 23);
            this.visaLärareBTN.TabIndex = 32;
            this.visaLärareBTN.Text = "Visa Lärare";
            this.visaLärareBTN.UseVisualStyleBackColor = true;
            this.visaLärareBTN.Click += new System.EventHandler(this.VisaLärareBTN_Click);
            // 
            // lärareLabel
            // 
            this.lärareLabel.AutoSize = true;
            this.lärareLabel.Font = new System.Drawing.Font("Roboto", 12F);
            this.lärareLabel.ForeColor = System.Drawing.Color.Indigo;
            this.lärareLabel.Location = new System.Drawing.Point(324, 59);
            this.lärareLabel.Name = "lärareLabel";
            this.lärareLabel.Size = new System.Drawing.Size(58, 19);
            this.lärareLabel.TabIndex = 31;
            this.lärareLabel.Text = "Lärare:";
            // 
            // registreraNyStudentBTN
            // 
            this.registreraNyStudentBTN.Location = new System.Drawing.Point(162, 110);
            this.registreraNyStudentBTN.Name = "registreraNyStudentBTN";
            this.registreraNyStudentBTN.Size = new System.Drawing.Size(121, 23);
            this.registreraNyStudentBTN.TabIndex = 30;
            this.registreraNyStudentBTN.Text = "Registrera ny student";
            this.registreraNyStudentBTN.UseVisualStyleBackColor = true;
            this.registreraNyStudentBTN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegistreraNyStudentBTN_Click);
            // 
            // visaStudenterBTN
            // 
            this.visaStudenterBTN.Location = new System.Drawing.Point(162, 81);
            this.visaStudenterBTN.Name = "visaStudenterBTN";
            this.visaStudenterBTN.Size = new System.Drawing.Size(84, 23);
            this.visaStudenterBTN.TabIndex = 29;
            this.visaStudenterBTN.Text = "Visa Studenter";
            this.visaStudenterBTN.UseVisualStyleBackColor = true;
            this.visaStudenterBTN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VisaStudenterBTN_Click);
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Roboto", 12F);
            this.studentLabel.ForeColor = System.Drawing.Color.Indigo;
            this.studentLabel.Location = new System.Drawing.Point(158, 59);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(68, 19);
            this.studentLabel.TabIndex = 28;
            this.studentLabel.Text = "Student:";
            // 
            // registreraNyKursBTN
            // 
            this.registreraNyKursBTN.Location = new System.Drawing.Point(19, 110);
            this.registreraNyKursBTN.Name = "registreraNyKursBTN";
            this.registreraNyKursBTN.Size = new System.Drawing.Size(106, 23);
            this.registreraNyKursBTN.TabIndex = 27;
            this.registreraNyKursBTN.Text = "Registrera ny kurs";
            this.registreraNyKursBTN.UseVisualStyleBackColor = true;
            this.registreraNyKursBTN.Click += new System.EventHandler(this.RegistreraNyKursBTN_Click);
            // 
            // visaKurserBTN
            // 
            this.visaKurserBTN.Location = new System.Drawing.Point(19, 81);
            this.visaKurserBTN.Name = "visaKurserBTN";
            this.visaKurserBTN.Size = new System.Drawing.Size(68, 23);
            this.visaKurserBTN.TabIndex = 26;
            this.visaKurserBTN.Text = "Visa kurser";
            this.visaKurserBTN.UseVisualStyleBackColor = true;
            this.visaKurserBTN.Click += new System.EventHandler(this.VisaKurserBTN_Click);
            // 
            // kurserLabel
            // 
            this.kurserLabel.AutoSize = true;
            this.kurserLabel.Font = new System.Drawing.Font("Roboto", 12F);
            this.kurserLabel.ForeColor = System.Drawing.Color.Indigo;
            this.kurserLabel.Location = new System.Drawing.Point(15, 59);
            this.kurserLabel.Name = "kurserLabel";
            this.kurserLabel.Size = new System.Drawing.Size(58, 19);
            this.kurserLabel.TabIndex = 25;
            this.kurserLabel.Text = "Kurser:";
            // 
            // content
            // 
            this.content.AutoScroll = true;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 143);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(550, 307);
            this.content.TabIndex = 3;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.content);
            this.Controls.Add(this.header);
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label akademicentrumLabel;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Label kurserLabel;
        private System.Windows.Forms.Button visaKurserBTN;
        private System.Windows.Forms.Button registreraNyKursBTN;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Button visaStudenterBTN;
        private System.Windows.Forms.Button registreraNyStudentBTN;
        private System.Windows.Forms.Label lärareLabel;
        private System.Windows.Forms.Button visaLärareBTN;
        private System.Windows.Forms.Button registreraNyLärareBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
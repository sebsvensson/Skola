
namespace Grupp25_lab2
{
    partial class RedigeraKurs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.kursnamnTextbox = new System.Windows.Forms.TextBox();
            this.kurskodTextbox = new System.Windows.Forms.TextBox();
            this.startdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.slutdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sparaKurs = new System.Windows.Forms.Button();
            this.nyKursSkapadLabel = new System.Windows.Forms.Label();
            this.raderaKursBTN = new System.Windows.Forms.Button();
            this.lärareListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.hanteraLärareBTN = new System.Windows.Forms.Button();
            this.bytLärareVyBTN = new System.Windows.Forms.Button();
            this.bytStudentVyBTN = new System.Windows.Forms.Button();
            this.hanteraStudentBTN = new System.Windows.Forms.Button();
            this.visaUppgifterBTN = new System.Windows.Forms.Button();
            this.lärareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lärareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(13, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kursnamn:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(11, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 35);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(11, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 35);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(-39, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 35);
            this.panel3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(-33, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "<kurskod>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(-37, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kurskod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kurskod:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(11, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 35);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(-39, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 35);
            this.panel5.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(-33, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "<kurskod>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(-37, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kurskod:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(13, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Startdatum:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(11, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 35);
            this.panel6.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Indigo;
            this.panel7.Location = new System.Drawing.Point(-39, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 35);
            this.panel7.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(-33, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "<kurskod>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(-37, -1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Kurskod:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ForeColor = System.Drawing.Color.Indigo;
            this.label14.Location = new System.Drawing.Point(13, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Slutdatum:";
            // 
            // kursnamnTextbox
            // 
            this.kursnamnTextbox.Location = new System.Drawing.Point(17, 18);
            this.kursnamnTextbox.Name = "kursnamnTextbox";
            this.kursnamnTextbox.Size = new System.Drawing.Size(97, 20);
            this.kursnamnTextbox.TabIndex = 12;
            this.kursnamnTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // kurskodTextbox
            // 
            this.kurskodTextbox.Location = new System.Drawing.Point(17, 68);
            this.kurskodTextbox.Name = "kurskodTextbox";
            this.kurskodTextbox.Size = new System.Drawing.Size(97, 20);
            this.kurskodTextbox.TabIndex = 13;
            this.kurskodTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // startdatumDateTimePicker
            // 
            this.startdatumDateTimePicker.Location = new System.Drawing.Point(17, 116);
            this.startdatumDateTimePicker.Name = "startdatumDateTimePicker";
            this.startdatumDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.startdatumDateTimePicker.TabIndex = 14;
            this.startdatumDateTimePicker.ValueChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // slutdatumDateTimePicker
            // 
            this.slutdatumDateTimePicker.Location = new System.Drawing.Point(17, 167);
            this.slutdatumDateTimePicker.Name = "slutdatumDateTimePicker";
            this.slutdatumDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.slutdatumDateTimePicker.TabIndex = 15;
            this.slutdatumDateTimePicker.ValueChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // sparaKurs
            // 
            this.sparaKurs.Enabled = false;
            this.sparaKurs.Location = new System.Drawing.Point(11, 197);
            this.sparaKurs.Name = "sparaKurs";
            this.sparaKurs.Size = new System.Drawing.Size(75, 23);
            this.sparaKurs.TabIndex = 16;
            this.sparaKurs.Text = "Spara";
            this.sparaKurs.UseVisualStyleBackColor = true;
            this.sparaKurs.Click += new System.EventHandler(this.SparaKurs_Click);
            // 
            // nyKursSkapadLabel
            // 
            this.nyKursSkapadLabel.AutoSize = true;
            this.nyKursSkapadLabel.Location = new System.Drawing.Point(8, 223);
            this.nyKursSkapadLabel.Name = "nyKursSkapadLabel";
            this.nyKursSkapadLabel.Size = new System.Drawing.Size(66, 13);
            this.nyKursSkapadLabel.TabIndex = 17;
            this.nyKursSkapadLabel.Text = "Kurs sparad!";
            this.nyKursSkapadLabel.Visible = false;
            // 
            // raderaKursBTN
            // 
            this.raderaKursBTN.Location = new System.Drawing.Point(93, 197);
            this.raderaKursBTN.Name = "raderaKursBTN";
            this.raderaKursBTN.Size = new System.Drawing.Size(75, 23);
            this.raderaKursBTN.TabIndex = 18;
            this.raderaKursBTN.Text = "Radera kurs";
            this.raderaKursBTN.UseVisualStyleBackColor = true;
            this.raderaKursBTN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RaderaKurs_Click);
            // 
            // lärareListBox
            // 
            this.lärareListBox.FormattingEnabled = true;
            this.lärareListBox.HorizontalScrollbar = true;
            this.lärareListBox.Location = new System.Drawing.Point(196, 18);
            this.lärareListBox.Name = "lärareListBox";
            this.lärareListBox.Size = new System.Drawing.Size(150, 147);
            this.lärareListBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(192, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Lärare:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(358, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Studenter:";
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.HorizontalScrollbar = true;
            this.studentListBox.Location = new System.Drawing.Point(362, 18);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(150, 147);
            this.studentListBox.TabIndex = 23;
            // 
            // hanteraLärareBTN
            // 
            this.hanteraLärareBTN.Location = new System.Drawing.Point(196, 170);
            this.hanteraLärareBTN.Name = "hanteraLärareBTN";
            this.hanteraLärareBTN.Size = new System.Drawing.Size(150, 23);
            this.hanteraLärareBTN.TabIndex = 24;
            this.hanteraLärareBTN.Text = "Ta bort markerad lärare";
            this.hanteraLärareBTN.UseVisualStyleBackColor = true;
            this.hanteraLärareBTN.Click += new System.EventHandler(this.HanteraLärareBTN_Click);
            // 
            // bytLärareVyBTN
            // 
            this.bytLärareVyBTN.Location = new System.Drawing.Point(196, 197);
            this.bytLärareVyBTN.Name = "bytLärareVyBTN";
            this.bytLärareVyBTN.Size = new System.Drawing.Size(150, 36);
            this.bytLärareVyBTN.TabIndex = 25;
            this.bytLärareVyBTN.Text = "Visa icke-registrerade lärare";
            this.bytLärareVyBTN.UseVisualStyleBackColor = true;
            this.bytLärareVyBTN.Click += new System.EventHandler(this.BytLärareVyBTN_Click);
            // 
            // bytStudentVyBTN
            // 
            this.bytStudentVyBTN.Location = new System.Drawing.Point(362, 197);
            this.bytStudentVyBTN.Name = "bytStudentVyBTN";
            this.bytStudentVyBTN.Size = new System.Drawing.Size(150, 36);
            this.bytStudentVyBTN.TabIndex = 27;
            this.bytStudentVyBTN.Text = "Visa icke-registrerade studenter";
            this.bytStudentVyBTN.UseVisualStyleBackColor = true;
            this.bytStudentVyBTN.Click += new System.EventHandler(this.BytStudentVyBTN_Click);
            // 
            // hanteraStudentBTN
            // 
            this.hanteraStudentBTN.Location = new System.Drawing.Point(362, 170);
            this.hanteraStudentBTN.Name = "hanteraStudentBTN";
            this.hanteraStudentBTN.Size = new System.Drawing.Size(150, 23);
            this.hanteraStudentBTN.TabIndex = 26;
            this.hanteraStudentBTN.Text = "Ta bort markerad student";
            this.hanteraStudentBTN.UseVisualStyleBackColor = true;
            this.hanteraStudentBTN.Click += new System.EventHandler(this.HanteraStudentBTN_Click);
            // 
            // visaUppgifterBTN
            // 
            this.visaUppgifterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visaUppgifterBTN.Location = new System.Drawing.Point(196, 252);
            this.visaUppgifterBTN.Name = "visaUppgifterBTN";
            this.visaUppgifterBTN.Size = new System.Drawing.Size(316, 23);
            this.visaUppgifterBTN.TabIndex = 28;
            this.visaUppgifterBTN.Text = "Visa kursuppgifter";
            this.visaUppgifterBTN.UseVisualStyleBackColor = true;
            this.visaUppgifterBTN.Click += new System.EventHandler(this.VisaKursuppgifterBTN_Click);
            // 
            // lärareBindingSource
            // 
            this.lärareBindingSource.DataSource = typeof(Grupp25_lab2.Lärare);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Grupp25_lab2.Student);
            // 
            // RedigeraKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.visaUppgifterBTN);
            this.Controls.Add(this.bytStudentVyBTN);
            this.Controls.Add(this.hanteraStudentBTN);
            this.Controls.Add(this.bytLärareVyBTN);
            this.Controls.Add(this.hanteraLärareBTN);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lärareListBox);
            this.Controls.Add(this.raderaKursBTN);
            this.Controls.Add(this.nyKursSkapadLabel);
            this.Controls.Add(this.sparaKurs);
            this.Controls.Add(this.slutdatumDateTimePicker);
            this.Controls.Add(this.startdatumDateTimePicker);
            this.Controls.Add(this.kurskodTextbox);
            this.Controls.Add(this.kursnamnTextbox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "RedigeraKurs";
            this.Size = new System.Drawing.Size(527, 286);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lärareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox kursnamnTextbox;
        private System.Windows.Forms.TextBox kurskodTextbox;
        private System.Windows.Forms.DateTimePicker startdatumDateTimePicker;
        private System.Windows.Forms.DateTimePicker slutdatumDateTimePicker;
        private System.Windows.Forms.Button sparaKurs;
        private System.Windows.Forms.Label nyKursSkapadLabel;
        private System.Windows.Forms.Button raderaKursBTN;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource lärareBindingSource;
        private System.Windows.Forms.ListBox lärareListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Button hanteraLärareBTN;
        private System.Windows.Forms.Button bytLärareVyBTN;
        private System.Windows.Forms.Button bytStudentVyBTN;
        private System.Windows.Forms.Button hanteraStudentBTN;
        private System.Windows.Forms.Button visaUppgifterBTN;
    }
}


namespace Grupp25_lab2
{
    partial class registreraNyStudent
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
            this.nyStudentSkapadLabel = new System.Windows.Forms.Label();
            this.personnummerTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.efternamnTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.förnamnTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonnummerTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sparaStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nyStudentSkapadLabel
            // 
            this.nyStudentSkapadLabel.AutoSize = true;
            this.nyStudentSkapadLabel.Location = new System.Drawing.Point(11, 244);
            this.nyStudentSkapadLabel.Name = "nyStudentSkapadLabel";
            this.nyStudentSkapadLabel.Size = new System.Drawing.Size(99, 13);
            this.nyStudentSkapadLabel.TabIndex = 19;
            this.nyStudentSkapadLabel.Text = "Ny student skapad!";
            this.nyStudentSkapadLabel.Visible = false;
            // 
            // personnummerTextbox
            // 
            this.personnummerTextbox.Location = new System.Drawing.Point(11, 67);
            this.personnummerTextbox.Name = "personnummerTextbox";
            this.personnummerTextbox.Size = new System.Drawing.Size(100, 20);
            this.personnummerTextbox.TabIndex = 13;
            this.personnummerTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Personnummer:";
            // 
            // studentIDTextbox
            // 
            this.studentIDTextbox.Location = new System.Drawing.Point(11, 25);
            this.studentIDTextbox.Name = "studentIDTextbox";
            this.studentIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.studentIDTextbox.TabIndex = 11;
            this.studentIDTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student ID:";
            // 
            // efternamnTextbox
            // 
            this.efternamnTextbox.Location = new System.Drawing.Point(11, 148);
            this.efternamnTextbox.Name = "efternamnTextbox";
            this.efternamnTextbox.Size = new System.Drawing.Size(100, 20);
            this.efternamnTextbox.TabIndex = 23;
            this.efternamnTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Efternamn:";
            // 
            // förnamnTextbox
            // 
            this.förnamnTextbox.Location = new System.Drawing.Point(11, 106);
            this.förnamnTextbox.Name = "förnamnTextbox";
            this.förnamnTextbox.Size = new System.Drawing.Size(100, 20);
            this.förnamnTextbox.TabIndex = 21;
            this.förnamnTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Förnamn:";
            // 
            // telefonnummerTextbox
            // 
            this.telefonnummerTextbox.Location = new System.Drawing.Point(11, 188);
            this.telefonnummerTextbox.Name = "telefonnummerTextbox";
            this.telefonnummerTextbox.Size = new System.Drawing.Size(100, 20);
            this.telefonnummerTextbox.TabIndex = 25;
            this.telefonnummerTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefonnummer:";
            // 
            // sparaStudent
            // 
            this.sparaStudent.Enabled = false;
            this.sparaStudent.Location = new System.Drawing.Point(11, 215);
            this.sparaStudent.Name = "sparaStudent";
            this.sparaStudent.Size = new System.Drawing.Size(75, 23);
            this.sparaStudent.TabIndex = 26;
            this.sparaStudent.Text = "Spara student";
            this.sparaStudent.UseVisualStyleBackColor = true;
            this.sparaStudent.Click += new System.EventHandler(this.SparaStudent_Click);
            // 
            // registreraNyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.sparaStudent);
            this.Controls.Add(this.telefonnummerTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.efternamnTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.förnamnTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nyStudentSkapadLabel);
            this.Controls.Add(this.personnummerTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentIDTextbox);
            this.Controls.Add(this.label1);
            this.Name = "registreraNyStudent";
            this.Size = new System.Drawing.Size(127, 270);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nyStudentSkapadLabel;
        private System.Windows.Forms.TextBox personnummerTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentIDTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox efternamnTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox förnamnTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefonnummerTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sparaStudent;
    }
}

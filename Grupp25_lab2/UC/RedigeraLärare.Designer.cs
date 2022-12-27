
namespace Grupp25_lab2
{
    partial class RedigeraLärare
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
            this.raderaLärare = new System.Windows.Forms.Button();
            this.sparaLärare = new System.Windows.Forms.Button();
            this.telefonnummerTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.efternamnTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.förnamnTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.personnummerTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lärarIDTextbox = new System.Windows.Forms.TextBox();
            this.lärareSparadLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // raderaLärare
            // 
            this.raderaLärare.Location = new System.Drawing.Point(93, 252);
            this.raderaLärare.Name = "raderaLärare";
            this.raderaLärare.Size = new System.Drawing.Size(75, 23);
            this.raderaLärare.TabIndex = 65;
            this.raderaLärare.Text = "Radera";
            this.raderaLärare.UseVisualStyleBackColor = true;
            this.raderaLärare.Click += new System.EventHandler(this.RaderaLärareBTN_Click);
            // 
            // sparaLärare
            // 
            this.sparaLärare.Location = new System.Drawing.Point(6, 252);
            this.sparaLärare.Name = "sparaLärare";
            this.sparaLärare.Size = new System.Drawing.Size(75, 23);
            this.sparaLärare.TabIndex = 64;
            this.sparaLärare.Text = "Spara";
            this.sparaLärare.UseVisualStyleBackColor = true;
            this.sparaLärare.Click += new System.EventHandler(this.SparaLärare_Click);
            // 
            // telefonnummerTextBox
            // 
            this.telefonnummerTextBox.Location = new System.Drawing.Point(12, 225);
            this.telefonnummerTextBox.Name = "telefonnummerTextBox";
            this.telefonnummerTextBox.Size = new System.Drawing.Size(97, 20);
            this.telefonnummerTextBox.TabIndex = 63;
            this.telefonnummerTextBox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(6, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 35);
            this.panel5.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Telefonnummer:";
            // 
            // efternamnTextBox
            // 
            this.efternamnTextBox.Location = new System.Drawing.Point(12, 177);
            this.efternamnTextBox.Name = "efternamnTextBox";
            this.efternamnTextBox.Size = new System.Drawing.Size(97, 20);
            this.efternamnTextBox.TabIndex = 60;
            this.efternamnTextBox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(6, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 35);
            this.panel4.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(8, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Efternamn:";
            // 
            // förnamnTextBox
            // 
            this.förnamnTextBox.Location = new System.Drawing.Point(12, 124);
            this.förnamnTextBox.Name = "förnamnTextBox";
            this.förnamnTextBox.Size = new System.Drawing.Size(97, 20);
            this.förnamnTextBox.TabIndex = 57;
            this.förnamnTextBox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(6, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 35);
            this.panel3.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Förnamn:";
            // 
            // personnummerTextBox
            // 
            this.personnummerTextBox.Location = new System.Drawing.Point(12, 76);
            this.personnummerTextBox.Name = "personnummerTextBox";
            this.personnummerTextBox.Size = new System.Drawing.Size(97, 20);
            this.personnummerTextBox.TabIndex = 54;
            this.personnummerTextBox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(6, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 35);
            this.panel2.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Personnummer:";
            // 
            // lärarIDTextbox
            // 
            this.lärarIDTextbox.Location = new System.Drawing.Point(12, 26);
            this.lärarIDTextbox.Name = "lärarIDTextbox";
            this.lärarIDTextbox.Size = new System.Drawing.Size(97, 20);
            this.lärarIDTextbox.TabIndex = 50;
            this.lärarIDTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // lärareSparadLabel
            // 
            this.lärareSparadLabel.AutoSize = true;
            this.lärareSparadLabel.Location = new System.Drawing.Point(3, 282);
            this.lärareSparadLabel.Name = "lärareSparadLabel";
            this.lärareSparadLabel.Size = new System.Drawing.Size(75, 13);
            this.lärareSparadLabel.TabIndex = 51;
            this.lärareSparadLabel.Text = "Lärare sparad!";
            this.lärareSparadLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 35);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Lärar ID:";
            // 
            // RedigeraLärare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.raderaLärare);
            this.Controls.Add(this.sparaLärare);
            this.Controls.Add(this.telefonnummerTextBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.efternamnTextBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.förnamnTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.personnummerTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lärarIDTextbox);
            this.Controls.Add(this.lärareSparadLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "RedigeraLärare";
            this.Size = new System.Drawing.Size(178, 307);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button raderaLärare;
        private System.Windows.Forms.Button sparaLärare;
        private System.Windows.Forms.TextBox telefonnummerTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox efternamnTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox förnamnTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox personnummerTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lärarIDTextbox;
        private System.Windows.Forms.Label lärareSparadLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

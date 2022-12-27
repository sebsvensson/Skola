
namespace Grupp25_lab2
{
    partial class RegistreraNyLärare
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
            this.telefonnummerTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.efternamnTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.förnamnTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nyLärareSkapadLabel = new System.Windows.Forms.Label();
            this.personnummerTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lärarIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sparaLärare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // telefonnummerTextbox
            // 
            this.telefonnummerTextbox.Location = new System.Drawing.Point(13, 185);
            this.telefonnummerTextbox.Name = "telefonnummerTextbox";
            this.telefonnummerTextbox.Size = new System.Drawing.Size(100, 20);
            this.telefonnummerTextbox.TabIndex = 37;
            this.telefonnummerTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Telefonnummer:";
            // 
            // efternamnTextbox
            // 
            this.efternamnTextbox.Location = new System.Drawing.Point(13, 145);
            this.efternamnTextbox.Name = "efternamnTextbox";
            this.efternamnTextbox.Size = new System.Drawing.Size(100, 20);
            this.efternamnTextbox.TabIndex = 35;
            this.efternamnTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Efternamn:";
            // 
            // förnamnTextbox
            // 
            this.förnamnTextbox.Location = new System.Drawing.Point(13, 103);
            this.förnamnTextbox.Name = "förnamnTextbox";
            this.förnamnTextbox.Size = new System.Drawing.Size(100, 20);
            this.förnamnTextbox.TabIndex = 33;
            this.förnamnTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Förnamn:";
            // 
            // nyLärareSkapadLabel
            // 
            this.nyLärareSkapadLabel.AutoSize = true;
            this.nyLärareSkapadLabel.Location = new System.Drawing.Point(13, 241);
            this.nyLärareSkapadLabel.Name = "nyLärareSkapadLabel";
            this.nyLärareSkapadLabel.Size = new System.Drawing.Size(90, 13);
            this.nyLärareSkapadLabel.TabIndex = 31;
            this.nyLärareSkapadLabel.Text = "Ny lärare skapad!";
            this.nyLärareSkapadLabel.Visible = false;
            // 
            // personnummerTextbox
            // 
            this.personnummerTextbox.Location = new System.Drawing.Point(13, 64);
            this.personnummerTextbox.Name = "personnummerTextbox";
            this.personnummerTextbox.Size = new System.Drawing.Size(100, 20);
            this.personnummerTextbox.TabIndex = 29;
            this.personnummerTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Personnummer:";
            // 
            // lärarIDTextbox
            // 
            this.lärarIDTextbox.Location = new System.Drawing.Point(13, 22);
            this.lärarIDTextbox.Name = "lärarIDTextbox";
            this.lärarIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.lärarIDTextbox.TabIndex = 27;
            this.lärarIDTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Lärar ID:";
            // 
            // sparaLärare
            // 
            this.sparaLärare.Enabled = false;
            this.sparaLärare.Location = new System.Drawing.Point(13, 213);
            this.sparaLärare.Name = "sparaLärare";
            this.sparaLärare.Size = new System.Drawing.Size(75, 23);
            this.sparaLärare.TabIndex = 38;
            this.sparaLärare.Text = "Spara lärare";
            this.sparaLärare.UseVisualStyleBackColor = true;
            this.sparaLärare.Click += new System.EventHandler(this.SparaLärare_Click);
            // 
            // RegistreraNyLärare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.sparaLärare);
            this.Controls.Add(this.telefonnummerTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.efternamnTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.förnamnTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nyLärareSkapadLabel);
            this.Controls.Add(this.personnummerTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lärarIDTextbox);
            this.Controls.Add(this.label1);
            this.Name = "RegistreraNyLärare";
            this.Size = new System.Drawing.Size(141, 274);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telefonnummerTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox efternamnTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox förnamnTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nyLärareSkapadLabel;
        private System.Windows.Forms.TextBox personnummerTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lärarIDTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sparaLärare;
    }
}

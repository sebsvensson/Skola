
namespace Grupp25_lab2
{
    partial class RegistreraNyKurs
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
            this.label1 = new System.Windows.Forms.Label();
            this.kursnamnTextbox = new System.Windows.Forms.TextBox();
            this.kurskodTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.slutdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.sparaKurs = new System.Windows.Forms.Button();
            this.nyKursSkapadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kursnamn:";
            // 
            // kursnamnTextbox
            // 
            this.kursnamnTextbox.Location = new System.Drawing.Point(9, 24);
            this.kursnamnTextbox.Name = "kursnamnTextbox";
            this.kursnamnTextbox.Size = new System.Drawing.Size(100, 20);
            this.kursnamnTextbox.TabIndex = 1;
            this.kursnamnTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // kurskodTextbox
            // 
            this.kurskodTextbox.Location = new System.Drawing.Point(9, 66);
            this.kurskodTextbox.Name = "kurskodTextbox";
            this.kurskodTextbox.Size = new System.Drawing.Size(100, 20);
            this.kurskodTextbox.TabIndex = 3;
            this.kurskodTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kurskod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Startdatum:";
            // 
            // startdatumDateTimePicker
            // 
            this.startdatumDateTimePicker.Location = new System.Drawing.Point(9, 109);
            this.startdatumDateTimePicker.Name = "startdatumDateTimePicker";
            this.startdatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startdatumDateTimePicker.TabIndex = 5;
            this.startdatumDateTimePicker.ValueChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // slutdatumDateTimePicker
            // 
            this.slutdatumDateTimePicker.Location = new System.Drawing.Point(9, 157);
            this.slutdatumDateTimePicker.Name = "slutdatumDateTimePicker";
            this.slutdatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.slutdatumDateTimePicker.TabIndex = 7;
            this.slutdatumDateTimePicker.ValueChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Slutdatum:";
            // 
            // sparaKurs
            // 
            this.sparaKurs.Enabled = false;
            this.sparaKurs.Location = new System.Drawing.Point(9, 186);
            this.sparaKurs.Name = "sparaKurs";
            this.sparaKurs.Size = new System.Drawing.Size(75, 23);
            this.sparaKurs.TabIndex = 8;
            this.sparaKurs.Text = "Spara kurs";
            this.sparaKurs.UseVisualStyleBackColor = true;
            this.sparaKurs.Click += new System.EventHandler(this.SparaKurs_Click);
            // 
            // nyKursSkapadLabel
            // 
            this.nyKursSkapadLabel.AutoSize = true;
            this.nyKursSkapadLabel.Location = new System.Drawing.Point(9, 216);
            this.nyKursSkapadLabel.Name = "nyKursSkapadLabel";
            this.nyKursSkapadLabel.Size = new System.Drawing.Size(84, 13);
            this.nyKursSkapadLabel.TabIndex = 9;
            this.nyKursSkapadLabel.Text = "Ny kurs skapad!";
            this.nyKursSkapadLabel.Visible = false;
            // 
            // RegistreraNyKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.nyKursSkapadLabel);
            this.Controls.Add(this.sparaKurs);
            this.Controls.Add(this.slutdatumDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startdatumDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kurskodTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kursnamnTextbox);
            this.Controls.Add(this.label1);
            this.Name = "RegistreraNyKurs";
            this.Size = new System.Drawing.Size(223, 237);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kursnamnTextbox;
        private System.Windows.Forms.TextBox kurskodTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startdatumDateTimePicker;
        private System.Windows.Forms.DateTimePicker slutdatumDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sparaKurs;
        private System.Windows.Forms.Label nyKursSkapadLabel;
    }
}

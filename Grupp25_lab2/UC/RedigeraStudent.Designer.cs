
namespace Grupp25_lab2
{
    partial class RedigeraStudent
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
            this.studentIDTextbox = new System.Windows.Forms.TextBox();
            this.studentSkapadLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.personnummerTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.förnamnTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.efternamnTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.telefonnummerTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.sparaStudent = new System.Windows.Forms.Button();
            this.raderaStudent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.uppgifterDataGridView = new System.Windows.Forms.DataGridView();
            this.Betygsätt = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Betyg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kursnamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poängDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slutdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborationsuppgiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uppgifterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborationsuppgiftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIDTextbox
            // 
            this.studentIDTextbox.Location = new System.Drawing.Point(15, 25);
            this.studentIDTextbox.Name = "studentIDTextbox";
            this.studentIDTextbox.Size = new System.Drawing.Size(97, 20);
            this.studentIDTextbox.TabIndex = 27;
            this.studentIDTextbox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // studentSkapadLabel
            // 
            this.studentSkapadLabel.AutoSize = true;
            this.studentSkapadLabel.Location = new System.Drawing.Point(6, 281);
            this.studentSkapadLabel.Name = "studentSkapadLabel";
            this.studentSkapadLabel.Size = new System.Drawing.Size(82, 13);
            this.studentSkapadLabel.TabIndex = 32;
            this.studentSkapadLabel.Text = "Student sparad!";
            this.studentSkapadLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 35);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student ID:";
            // 
            // personnummerTextBox
            // 
            this.personnummerTextBox.Location = new System.Drawing.Point(15, 75);
            this.personnummerTextBox.Name = "personnummerTextBox";
            this.personnummerTextBox.Size = new System.Drawing.Size(97, 20);
            this.personnummerTextBox.TabIndex = 36;
            this.personnummerTextBox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(9, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 35);
            this.panel2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Personnummer:";
            // 
            // förnamnTextBox
            // 
            this.förnamnTextBox.Location = new System.Drawing.Point(15, 123);
            this.förnamnTextBox.Name = "förnamnTextBox";
            this.förnamnTextBox.Size = new System.Drawing.Size(97, 20);
            this.förnamnTextBox.TabIndex = 39;
            this.förnamnTextBox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(9, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 35);
            this.panel3.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Förnamn:";
            // 
            // efternamnTextBox
            // 
            this.efternamnTextBox.Location = new System.Drawing.Point(15, 176);
            this.efternamnTextBox.Name = "efternamnTextBox";
            this.efternamnTextBox.Size = new System.Drawing.Size(97, 20);
            this.efternamnTextBox.TabIndex = 42;
            this.efternamnTextBox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(9, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 35);
            this.panel4.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Efternamn:";
            // 
            // telefonnummerTextBox
            // 
            this.telefonnummerTextBox.Location = new System.Drawing.Point(15, 224);
            this.telefonnummerTextBox.Name = "telefonnummerTextBox";
            this.telefonnummerTextBox.Size = new System.Drawing.Size(97, 20);
            this.telefonnummerTextBox.TabIndex = 45;
            this.telefonnummerTextBox.TextChanged += new System.EventHandler(this.Värdeförändring);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(9, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 35);
            this.panel5.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(11, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Telefonnummer:";
            // 
            // sparaStudent
            // 
            this.sparaStudent.Location = new System.Drawing.Point(9, 251);
            this.sparaStudent.Name = "sparaStudent";
            this.sparaStudent.Size = new System.Drawing.Size(75, 23);
            this.sparaStudent.TabIndex = 46;
            this.sparaStudent.Text = "Spara";
            this.sparaStudent.UseVisualStyleBackColor = true;
            this.sparaStudent.Click += new System.EventHandler(this.SparaStudent_Click);
            // 
            // raderaStudent
            // 
            this.raderaStudent.Location = new System.Drawing.Point(96, 251);
            this.raderaStudent.Name = "raderaStudent";
            this.raderaStudent.Size = new System.Drawing.Size(75, 23);
            this.raderaStudent.TabIndex = 47;
            this.raderaStudent.Text = "Radera";
            this.raderaStudent.UseVisualStyleBackColor = true;
            this.raderaStudent.Click += new System.EventHandler(this.RaderaStudentBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(183, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Uppgifter:";
            // 
            // uppgifterDataGridView
            // 
            this.uppgifterDataGridView.AllowUserToAddRows = false;
            this.uppgifterDataGridView.AllowUserToDeleteRows = false;
            this.uppgifterDataGridView.AutoGenerateColumns = false;
            this.uppgifterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uppgifterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Betygsätt,
            this.Betyg,
            this.Kursnamn,
            this.namnDataGridViewTextBoxColumn,
            this.poängDataGridViewTextBoxColumn,
            this.startdatumDataGridViewTextBoxColumn,
            this.slutdatumDataGridViewTextBoxColumn});
            this.uppgifterDataGridView.DataSource = this.laborationsuppgiftBindingSource;
            this.uppgifterDataGridView.Location = new System.Drawing.Point(187, 29);
            this.uppgifterDataGridView.Name = "uppgifterDataGridView";
            this.uppgifterDataGridView.ReadOnly = true;
            this.uppgifterDataGridView.Size = new System.Drawing.Size(358, 150);
            this.uppgifterDataGridView.TabIndex = 49;
            this.uppgifterDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Uppgifter_CellContentClick);
            this.uppgifterDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Uppgifter_DataBindingComplete);
            // 
            // Betygsätt
            // 
            this.Betygsätt.HeaderText = "Betygsätt";
            this.Betygsätt.Name = "Betygsätt";
            this.Betygsätt.ReadOnly = true;
            this.Betygsätt.Text = "Betygsätt";
            this.Betygsätt.ToolTipText = "Betygsätt";
            this.Betygsätt.UseColumnTextForButtonValue = true;
            this.Betygsätt.Width = 60;
            // 
            // Betyg
            // 
            this.Betyg.HeaderText = "Betyg";
            this.Betyg.Name = "Betyg";
            this.Betyg.ReadOnly = true;
            this.Betyg.Width = 50;
            // 
            // Kursnamn
            // 
            this.Kursnamn.DataPropertyName = "Kursnamn";
            this.Kursnamn.HeaderText = "Kursnamn";
            this.Kursnamn.Name = "Kursnamn";
            this.Kursnamn.ReadOnly = true;
            // 
            // namnDataGridViewTextBoxColumn
            // 
            this.namnDataGridViewTextBoxColumn.DataPropertyName = "Namn";
            this.namnDataGridViewTextBoxColumn.HeaderText = "Namn";
            this.namnDataGridViewTextBoxColumn.Name = "namnDataGridViewTextBoxColumn";
            this.namnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poängDataGridViewTextBoxColumn
            // 
            this.poängDataGridViewTextBoxColumn.DataPropertyName = "Poäng";
            this.poängDataGridViewTextBoxColumn.HeaderText = "Poäng";
            this.poängDataGridViewTextBoxColumn.Name = "poängDataGridViewTextBoxColumn";
            this.poängDataGridViewTextBoxColumn.ReadOnly = true;
            this.poängDataGridViewTextBoxColumn.Width = 50;
            // 
            // startdatumDataGridViewTextBoxColumn
            // 
            this.startdatumDataGridViewTextBoxColumn.DataPropertyName = "Startdatum";
            this.startdatumDataGridViewTextBoxColumn.HeaderText = "Startdatum";
            this.startdatumDataGridViewTextBoxColumn.Name = "startdatumDataGridViewTextBoxColumn";
            this.startdatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slutdatumDataGridViewTextBoxColumn
            // 
            this.slutdatumDataGridViewTextBoxColumn.DataPropertyName = "Slutdatum";
            this.slutdatumDataGridViewTextBoxColumn.HeaderText = "Slutdatum";
            this.slutdatumDataGridViewTextBoxColumn.Name = "slutdatumDataGridViewTextBoxColumn";
            this.slutdatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laborationsuppgiftBindingSource
            // 
            this.laborationsuppgiftBindingSource.DataSource = typeof(Grupp25_lab2.Laborationsuppgift);
            // 
            // RedigeraStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.uppgifterDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.raderaStudent);
            this.Controls.Add(this.sparaStudent);
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
            this.Controls.Add(this.studentIDTextbox);
            this.Controls.Add(this.studentSkapadLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "RedigeraStudent";
            this.Size = new System.Drawing.Size(548, 306);
            ((System.ComponentModel.ISupportInitialize)(this.uppgifterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborationsuppgiftBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox studentIDTextbox;
        private System.Windows.Forms.Label studentSkapadLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personnummerTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox förnamnTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox efternamnTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefonnummerTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sparaStudent;
        private System.Windows.Forms.Button raderaStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource laborationsuppgiftBindingSource;
        private System.Windows.Forms.DataGridView uppgifterDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Betygsätt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Betyg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kursnamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poängDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slutdatumDataGridViewTextBoxColumn;
    }
}

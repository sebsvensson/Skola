
namespace Grupp25_lab2
{
    partial class VisaKursuppgifter
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
            this.kursuppgifterDataGridView = new System.Windows.Forms.DataGridView();
            this.Redigera = new System.Windows.Forms.DataGridViewButtonColumn();
            this.namnTextbox = new System.Windows.Forms.TextBox();
            this.poängTextbox = new System.Windows.Forms.TextBox();
            this.startdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.slutdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sparaNyUppgiftBTN = new System.Windows.Forms.Button();
            this.sparaRedigeradUppgiftBTN = new System.Windows.Forms.Button();
            this.raderaUppgiftBTN = new System.Windows.Forms.Button();
            this.visaKursBTN = new System.Windows.Forms.Button();
            this.namnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poängDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slutdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborationsuppgiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kursuppgifterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborationsuppgiftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kursuppgifterDataGridView
            // 
            this.kursuppgifterDataGridView.AllowUserToAddRows = false;
            this.kursuppgifterDataGridView.AllowUserToDeleteRows = false;
            this.kursuppgifterDataGridView.AutoGenerateColumns = false;
            this.kursuppgifterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kursuppgifterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Redigera,
            this.namnDataGridViewTextBoxColumn,
            this.poängDataGridViewTextBoxColumn,
            this.startdatumDataGridViewTextBoxColumn,
            this.slutdatumDataGridViewTextBoxColumn});
            this.kursuppgifterDataGridView.DataSource = this.laborationsuppgiftBindingSource;
            this.kursuppgifterDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.kursuppgifterDataGridView.Location = new System.Drawing.Point(0, 0);
            this.kursuppgifterDataGridView.Name = "kursuppgifterDataGridView";
            this.kursuppgifterDataGridView.ReadOnly = true;
            this.kursuppgifterDataGridView.Size = new System.Drawing.Size(507, 124);
            this.kursuppgifterDataGridView.TabIndex = 0;
            this.kursuppgifterDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Uppgiftslista_CellContentClick);
            // 
            // Redigera
            // 
            this.Redigera.HeaderText = "Redigera";
            this.Redigera.Name = "Redigera";
            this.Redigera.ReadOnly = true;
            this.Redigera.Text = "Redigera";
            this.Redigera.UseColumnTextForButtonValue = true;
            this.Redigera.Width = 60;
            // 
            // namnTextbox
            // 
            this.namnTextbox.Location = new System.Drawing.Point(7, 175);
            this.namnTextbox.Name = "namnTextbox";
            this.namnTextbox.Size = new System.Drawing.Size(133, 20);
            this.namnTextbox.TabIndex = 1;
            // 
            // poängTextbox
            // 
            this.poängTextbox.Location = new System.Drawing.Point(155, 175);
            this.poängTextbox.Name = "poängTextbox";
            this.poängTextbox.Size = new System.Drawing.Size(64, 20);
            this.poängTextbox.TabIndex = 2;
            // 
            // startdatumDateTimePicker
            // 
            this.startdatumDateTimePicker.Location = new System.Drawing.Point(7, 220);
            this.startdatumDateTimePicker.Name = "startdatumDateTimePicker";
            this.startdatumDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.startdatumDateTimePicker.TabIndex = 3;
            // 
            // slutdatumDateTimePicker
            // 
            this.slutdatumDateTimePicker.Location = new System.Drawing.Point(7, 268);
            this.slutdatumDateTimePicker.Name = "slutdatumDateTimePicker";
            this.slutdatumDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.slutdatumDateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(4, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(152, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Poäng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(4, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Startdatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(4, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Slutdatum";
            // 
            // sparaNyUppgiftBTN
            // 
            this.sparaNyUppgiftBTN.Location = new System.Drawing.Point(243, 175);
            this.sparaNyUppgiftBTN.Name = "sparaNyUppgiftBTN";
            this.sparaNyUppgiftBTN.Size = new System.Drawing.Size(132, 23);
            this.sparaNyUppgiftBTN.TabIndex = 9;
            this.sparaNyUppgiftBTN.Text = "Spara som ny uppgift";
            this.sparaNyUppgiftBTN.UseVisualStyleBackColor = true;
            this.sparaNyUppgiftBTN.Click += new System.EventHandler(this.SparaNyUppgiftBTN_Click);
            // 
            // sparaRedigeradUppgiftBTN
            // 
            this.sparaRedigeradUppgiftBTN.Enabled = false;
            this.sparaRedigeradUppgiftBTN.Location = new System.Drawing.Point(243, 221);
            this.sparaRedigeradUppgiftBTN.Name = "sparaRedigeradUppgiftBTN";
            this.sparaRedigeradUppgiftBTN.Size = new System.Drawing.Size(132, 23);
            this.sparaRedigeradUppgiftBTN.TabIndex = 10;
            this.sparaRedigeradUppgiftBTN.Text = "Spara uppgift";
            this.sparaRedigeradUppgiftBTN.UseVisualStyleBackColor = true;
            this.sparaRedigeradUppgiftBTN.Click += new System.EventHandler(this.SparaRedigeradUppgiftBTN_Click);
            // 
            // raderaUppgiftBTN
            // 
            this.raderaUppgiftBTN.Enabled = false;
            this.raderaUppgiftBTN.Location = new System.Drawing.Point(243, 265);
            this.raderaUppgiftBTN.Name = "raderaUppgiftBTN";
            this.raderaUppgiftBTN.Size = new System.Drawing.Size(132, 23);
            this.raderaUppgiftBTN.TabIndex = 11;
            this.raderaUppgiftBTN.Text = "Radera uppgift";
            this.raderaUppgiftBTN.UseVisualStyleBackColor = true;
            this.raderaUppgiftBTN.Click += new System.EventHandler(this.RaderaUppgiftBTN_Click);
            // 
            // visaKursBTN
            // 
            this.visaKursBTN.Location = new System.Drawing.Point(7, 129);
            this.visaKursBTN.Name = "visaKursBTN";
            this.visaKursBTN.Size = new System.Drawing.Size(92, 23);
            this.visaKursBTN.TabIndex = 12;
            this.visaKursBTN.Text = "Tillbaka till kurs";
            this.visaKursBTN.UseVisualStyleBackColor = true;
            this.visaKursBTN.Click += new System.EventHandler(this.VisaKursBTN_Click);
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
            // VisaKursuppgifter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.visaKursBTN);
            this.Controls.Add(this.raderaUppgiftBTN);
            this.Controls.Add(this.sparaRedigeradUppgiftBTN);
            this.Controls.Add(this.sparaNyUppgiftBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slutdatumDateTimePicker);
            this.Controls.Add(this.startdatumDateTimePicker);
            this.Controls.Add(this.poängTextbox);
            this.Controls.Add(this.namnTextbox);
            this.Controls.Add(this.kursuppgifterDataGridView);
            this.Name = "VisaKursuppgifter";
            this.Size = new System.Drawing.Size(507, 293);
            ((System.ComponentModel.ISupportInitialize)(this.kursuppgifterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborationsuppgiftBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kursuppgifterDataGridView;
        private System.Windows.Forms.BindingSource laborationsuppgiftBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn beskrivningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Redigera;
        private System.Windows.Forms.DataGridViewTextBoxColumn namnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poängDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slutdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox namnTextbox;
        private System.Windows.Forms.TextBox poängTextbox;
        private System.Windows.Forms.DateTimePicker startdatumDateTimePicker;
        private System.Windows.Forms.DateTimePicker slutdatumDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sparaNyUppgiftBTN;
        private System.Windows.Forms.Button sparaRedigeradUppgiftBTN;
        private System.Windows.Forms.Button raderaUppgiftBTN;
        private System.Windows.Forms.Button visaKursBTN;
    }
}

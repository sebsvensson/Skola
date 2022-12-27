
namespace Grupp25_lab2
{
    partial class VisaKurser
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
            this.kurslista = new System.Windows.Forms.DataGridView();
            this.Redigera = new System.Windows.Forms.DataGridViewButtonColumn();
            this.namnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurskodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slutdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kurslista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kurslista
            // 
            this.kurslista.AllowUserToAddRows = false;
            this.kurslista.AllowUserToDeleteRows = false;
            this.kurslista.AutoGenerateColumns = false;
            this.kurslista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kurslista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Redigera,
            this.namnDataGridViewTextBoxColumn,
            this.kurskodDataGridViewTextBoxColumn,
            this.startdatumDataGridViewTextBoxColumn,
            this.slutdatumDataGridViewTextBoxColumn});
            this.kurslista.DataSource = this.kursBindingSource;
            this.kurslista.Dock = System.Windows.Forms.DockStyle.Top;
            this.kurslista.Location = new System.Drawing.Point(0, 0);
            this.kurslista.Name = "kurslista";
            this.kurslista.ReadOnly = true;
            this.kurslista.Size = new System.Drawing.Size(523, 150);
            this.kurslista.TabIndex = 0;
            this.kurslista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Kurslista_CellContentClick);
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
            // namnDataGridViewTextBoxColumn
            // 
            this.namnDataGridViewTextBoxColumn.DataPropertyName = "Namn";
            this.namnDataGridViewTextBoxColumn.HeaderText = "Namn";
            this.namnDataGridViewTextBoxColumn.Name = "namnDataGridViewTextBoxColumn";
            this.namnDataGridViewTextBoxColumn.ReadOnly = true;
            this.namnDataGridViewTextBoxColumn.Width = 75;
            // 
            // kurskodDataGridViewTextBoxColumn
            // 
            this.kurskodDataGridViewTextBoxColumn.DataPropertyName = "Kurskod";
            this.kurskodDataGridViewTextBoxColumn.HeaderText = "Kurskod";
            this.kurskodDataGridViewTextBoxColumn.Name = "kurskodDataGridViewTextBoxColumn";
            this.kurskodDataGridViewTextBoxColumn.ReadOnly = true;
            this.kurskodDataGridViewTextBoxColumn.Width = 75;
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
            // kursBindingSource
            // 
            this.kursBindingSource.DataSource = typeof(Grupp25_lab2.Kurs);
            // 
            // VisaKurser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.kurslista);
            this.Name = "VisaKurser";
            this.Size = new System.Drawing.Size(523, 262);
            ((System.ComponentModel.ISupportInitialize)(this.kurslista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource kursBindingSource;
        private System.Windows.Forms.DataGridView kurslista;
        private System.Windows.Forms.DataGridViewButtonColumn Redigera;
        private System.Windows.Forms.DataGridViewTextBoxColumn namnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurskodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slutdatumDataGridViewTextBoxColumn;
    }
}

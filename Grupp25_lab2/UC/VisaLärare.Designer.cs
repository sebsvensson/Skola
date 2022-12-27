
namespace Grupp25_lab2
{
    partial class VisaLärare
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
            this.lärarelista = new System.Windows.Forms.DataGridView();
            this.Redigera = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lärarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.förnamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lärareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lärarelista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lärareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lärarelista
            // 
            this.lärarelista.AllowUserToAddRows = false;
            this.lärarelista.AllowUserToDeleteRows = false;
            this.lärarelista.AutoGenerateColumns = false;
            this.lärarelista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lärarelista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Redigera,
            this.lärarIDDataGridViewTextBoxColumn,
            this.personnummerDataGridViewTextBoxColumn,
            this.förnamnDataGridViewTextBoxColumn,
            this.efternamnDataGridViewTextBoxColumn,
            this.telefonnummerDataGridViewTextBoxColumn});
            this.lärarelista.DataSource = this.lärareBindingSource;
            this.lärarelista.Dock = System.Windows.Forms.DockStyle.Top;
            this.lärarelista.Location = new System.Drawing.Point(0, 0);
            this.lärarelista.Name = "lärarelista";
            this.lärarelista.ReadOnly = true;
            this.lärarelista.Size = new System.Drawing.Size(552, 150);
            this.lärarelista.TabIndex = 1;
            this.lärarelista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lärarelista_CellContentClick);
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
            // lärarIDDataGridViewTextBoxColumn
            // 
            this.lärarIDDataGridViewTextBoxColumn.DataPropertyName = "LärarID";
            this.lärarIDDataGridViewTextBoxColumn.HeaderText = "LärarID";
            this.lärarIDDataGridViewTextBoxColumn.Name = "lärarIDDataGridViewTextBoxColumn";
            this.lärarIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lärarIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // personnummerDataGridViewTextBoxColumn
            // 
            this.personnummerDataGridViewTextBoxColumn.DataPropertyName = "Personnummer";
            this.personnummerDataGridViewTextBoxColumn.HeaderText = "Personnummer";
            this.personnummerDataGridViewTextBoxColumn.Name = "personnummerDataGridViewTextBoxColumn";
            this.personnummerDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnummerDataGridViewTextBoxColumn.Width = 90;
            // 
            // förnamnDataGridViewTextBoxColumn
            // 
            this.förnamnDataGridViewTextBoxColumn.DataPropertyName = "Förnamn";
            this.förnamnDataGridViewTextBoxColumn.HeaderText = "Förnamn";
            this.förnamnDataGridViewTextBoxColumn.Name = "förnamnDataGridViewTextBoxColumn";
            this.förnamnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // efternamnDataGridViewTextBoxColumn
            // 
            this.efternamnDataGridViewTextBoxColumn.DataPropertyName = "Efternamn";
            this.efternamnDataGridViewTextBoxColumn.HeaderText = "Efternamn";
            this.efternamnDataGridViewTextBoxColumn.Name = "efternamnDataGridViewTextBoxColumn";
            this.efternamnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonnummerDataGridViewTextBoxColumn
            // 
            this.telefonnummerDataGridViewTextBoxColumn.DataPropertyName = "Telefonnummer";
            this.telefonnummerDataGridViewTextBoxColumn.HeaderText = "Telefonnummer";
            this.telefonnummerDataGridViewTextBoxColumn.Name = "telefonnummerDataGridViewTextBoxColumn";
            this.telefonnummerDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonnummerDataGridViewTextBoxColumn.Width = 85;
            // 
            // lärareBindingSource
            // 
            this.lärareBindingSource.DataSource = typeof(Grupp25_lab2.Lärare);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Grupp25_lab2.Student);
            // 
            // VisaLärare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.lärarelista);
            this.Name = "VisaLärare";
            this.Size = new System.Drawing.Size(552, 179);
            ((System.ComponentModel.ISupportInitialize)(this.lärarelista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lärareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lärarelista;
        private System.Windows.Forms.BindingSource lärareBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Redigera;
        private System.Windows.Forms.DataGridViewTextBoxColumn lärarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn förnamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnummerDataGridViewTextBoxColumn;
    }
}

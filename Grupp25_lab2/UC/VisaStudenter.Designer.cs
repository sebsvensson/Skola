
namespace Grupp25_lab2
{
    partial class VisaStudenter
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
            this.studentlista = new System.Windows.Forms.DataGridView();
            this.Redigera = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.förnamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentlista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentlista
            // 
            this.studentlista.AllowUserToAddRows = false;
            this.studentlista.AllowUserToDeleteRows = false;
            this.studentlista.AutoGenerateColumns = false;
            this.studentlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Redigera,
            this.studentIDDataGridViewTextBoxColumn,
            this.personnummerDataGridViewTextBoxColumn,
            this.förnamnDataGridViewTextBoxColumn,
            this.efternamnDataGridViewTextBoxColumn,
            this.telefonnummerDataGridViewTextBoxColumn});
            this.studentlista.DataSource = this.studentBindingSource;
            this.studentlista.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentlista.Location = new System.Drawing.Point(0, 0);
            this.studentlista.Name = "studentlista";
            this.studentlista.ReadOnly = true;
            this.studentlista.Size = new System.Drawing.Size(628, 150);
            this.studentlista.TabIndex = 1;
            this.studentlista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Studentlista_CellContentClick);
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
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 70;
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
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Grupp25_lab2.Student);
            // 
            // VisaStudenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.studentlista);
            this.Name = "VisaStudenter";
            this.Size = new System.Drawing.Size(628, 202);
            ((System.ComponentModel.ISupportInitialize)(this.studentlista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentlista;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Redigera;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn förnamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnummerDataGridViewTextBoxColumn;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupp25_lab2
{
    public partial class VisaLärare : UserControl
    {
        private readonly Databas databas = Databas.HämtaDatabas();
        public VisaLärare()
        {
            InitializeComponent();
            this.lärarelista.DataSource = databas.lärare;
        }

        private void Lärarelista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != this.lärarelista.Columns["Redigera"].Index || e.RowIndex == -1)
                return;

            Program.appform.VisaVy(new RedigeraLärare(e.RowIndex));
        }
    }
}

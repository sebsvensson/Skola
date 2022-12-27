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
    public partial class VisaKurser : UserControl
    {
        private readonly Databas databas = Databas.HämtaDatabas();
        public VisaKurser()
        {
            InitializeComponent();
            this.kurslista.DataSource = databas.kurser;
        }

        private void Kurslista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != kurslista.Columns["Redigera"].Index || e.RowIndex == -1)
                return;

            Program.appform.VisaVy(new RedigeraKurs(e.RowIndex));
        }
    }
}

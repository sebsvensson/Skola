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
    public partial class VisaStudenter : UserControl
    {
        private readonly Databas databas = Databas.HämtaDatabas();
        public VisaStudenter()
        {
            InitializeComponent();
            this.studentlista.DataSource = databas.studenter;
        }

        private void Studentlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != this.studentlista.Columns["Redigera"].Index || e.RowIndex == -1)
                return;

            Program.appform.VisaVy(new RedigeraStudent(e.RowIndex));
        }
    }
}

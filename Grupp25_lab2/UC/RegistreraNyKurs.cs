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
    public partial class RegistreraNyKurs : UserControl
    {
        public RegistreraNyKurs()
        {
            InitializeComponent();
        }

        private void Värdeförändring(object sender, EventArgs e)
        {
            this.sparaKurs.Enabled = true;
            this.nyKursSkapadLabel.Hide();
        }

        private void SparaKurs_Click(object sender, EventArgs e)
        {
            if (this.nyKursSkapadLabel.Visible)
                return;

            Kurs.SkapaKurs(this.kursnamnTextbox.Text, this.kurskodTextbox.Text, this.startdatumDateTimePicker.Value.Date, this.slutdatumDateTimePicker.Value.Date);
            this.sparaKurs.Enabled = false;
            this.nyKursSkapadLabel.Show();
        }
    }
}

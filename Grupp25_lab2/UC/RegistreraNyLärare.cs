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
    public partial class RegistreraNyLärare : UserControl
    {
        public RegistreraNyLärare()
        {
            InitializeComponent();
        }

        private void Värdeförändring(object sender, EventArgs e)
        {
            this.sparaLärare.Enabled = true;
            this.nyLärareSkapadLabel.Hide();
        }

        private void SparaLärare_Click(object sender, EventArgs e)
        {
            if (this.nyLärareSkapadLabel.Visible)
                return;

            Lärare.SkapaLärare(this.lärarIDTextbox.Text, this.personnummerTextbox.Text, this.förnamnTextbox.Text, this.efternamnTextbox.Text, this.telefonnummerTextbox.Text);
            this.sparaLärare.Enabled = false;
            this.nyLärareSkapadLabel.Show();
        }
    }
}

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
    public partial class RedigeraLärare : UserControl
    {
        private Databas databas = Databas.HämtaDatabas();

        private Lärare lärare;
        public RedigeraLärare(int lärarIndex)
        {
            InitializeComponent();
            this.lärare = databas.lärare[lärarIndex];
            UppdateraVy();
        }

        private void Värdeförändring(object sender, EventArgs e)
        {
            this.sparaLärare.Enabled = true;
            this.lärareSparadLabel.Hide();
        }

        private void SparaLärare_Click(object sender, EventArgs e)
        {
            if (this.lärareSparadLabel.Visible)
                return;

            this.lärare.LärarID = this.lärarIDTextbox.Text;
            this.lärare.Personnummer = this.personnummerTextBox.Text;
            this.lärare.Förnamn = this.förnamnTextBox.Text;
            this.lärare.Efternamn = this.efternamnTextBox.Text;
            this.lärare.Telefonnummer = this.telefonnummerTextBox.Text;

            this.sparaLärare.Enabled = false;
            this.lärareSparadLabel.Show();
        }

        private void UppdateraVy()
        {
            if (this.lärare == null)
                return;

            this.lärarIDTextbox.Text = this.lärare.LärarID;
            this.personnummerTextBox.Text = this.lärare.Personnummer;
            this.förnamnTextBox.Text = this.lärare.Förnamn;
            this.efternamnTextBox.Text = this.lärare.Efternamn;
            this.telefonnummerTextBox.Text = this.lärare.Telefonnummer;

            this.sparaLärare.Enabled = false;
        }

        private void RaderaLärareBTN_Click(object sender, EventArgs e)
        {
            this.lärare.Radera();
            Program.appform.VisaVy(new VisaLärare());
        }
    }
}

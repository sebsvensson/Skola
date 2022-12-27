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
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        public void VisaVy(UserControl vy)
        {
            content.Controls.Clear();
            vy.Dock = DockStyle.Fill;
            content.Controls.Add(vy);
            this.Refresh();
        }

        private void RegistreraNyKursBTN_Click(object sender, EventArgs e)
        {
            VisaVy(new RegistreraNyKurs());
        }

        private void VisaKurserBTN_Click(object sender, EventArgs e)
        {
            VisaVy(new VisaKurser());
        }

        private void VisaStudenterBTN_Click(object sender, MouseEventArgs e)
        {
            VisaVy(new VisaStudenter());
        }

        private void RegistreraNyStudentBTN_Click(object sender, MouseEventArgs e)
        {
            VisaVy(new registreraNyStudent());
        }

        private void VisaLärareBTN_Click(object sender, EventArgs e)
        {
            VisaVy(new VisaLärare());
        }

        private void RegistreraNyLärareBTN_Click(object sender, EventArgs e)
        {
            VisaVy(new RegistreraNyLärare());
        }
    }
}

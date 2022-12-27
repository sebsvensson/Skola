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
    public partial class registreraNyStudent : UserControl
    {
        public registreraNyStudent()
        {
            InitializeComponent();
        }

        private void Värdeförändring(object sender, EventArgs e)
        {
            this.sparaStudent.Enabled = true;
            this.nyStudentSkapadLabel.Hide();
        }

        private void SparaStudent_Click(object sender, EventArgs e)
        {
            if (this.nyStudentSkapadLabel.Visible)
                return;

            Student.SkapaStudent(this.studentIDTextbox.Text, this.personnummerTextbox.Text, this.förnamnTextbox.Text, this.efternamnTextbox.Text, this.telefonnummerTextbox.Text);
            this.sparaStudent.Enabled = false;
            this.nyStudentSkapadLabel.Show();
        }
    }
}

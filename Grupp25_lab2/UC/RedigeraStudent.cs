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
    public partial class RedigeraStudent : UserControl
    {
        private readonly Databas databas = Databas.HämtaDatabas();

        private Student student;
        public RedigeraStudent(int studentIndex)
        {
            InitializeComponent();
            this.student = databas.studenter[studentIndex];
            this.uppgifterDataGridView.DataSource = this.student.Uppgifter;
            UppdateraVy();
        }

        private void Värdeförändring(object sender, EventArgs e)
        {
            this.sparaStudent.Enabled = true;
            this.studentSkapadLabel.Hide();
        }

        private void SparaStudent_Click(object sender, EventArgs e)
        {
            if (this.studentSkapadLabel.Visible)
                return;

            this.student.StudentID = this.studentIDTextbox.Text;
            this.student.Personnummer = this.personnummerTextBox.Text;
            this.student.Förnamn = this.förnamnTextBox.Text;
            this.student.Efternamn = this.efternamnTextBox.Text;
            this.student.Telefonnummer = this.telefonnummerTextBox.Text;

            this.sparaStudent.Enabled = false;
            this.studentSkapadLabel.Show();
        }

        private void UppdateraVy()
        {
            if (this.student == null)
                return;

            this.studentIDTextbox.Text = this.student.StudentID;
            this.personnummerTextBox.Text = this.student.Personnummer;
            this.förnamnTextBox.Text = this.student.Förnamn;
            this.efternamnTextBox.Text = this.student.Efternamn;
            this.telefonnummerTextBox.Text = this.student.Telefonnummer;

            this.sparaStudent.Enabled = false;
        }

        private void RaderaStudentBTN_Click(object sender, EventArgs e)
        {
            this.student.TaBortStudent();
            Program.appform.VisaVy(new VisaStudenter());
        }

        private void Uppgifter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.uppgifterDataGridView.Columns["Betygsätt"].Index && e.RowIndex > -1)
            {
                Laborationsuppgift laborationsuppgift = (Laborationsuppgift)this.uppgifterDataGridView.Rows[e.RowIndex].DataBoundItem;
                Inlämning inlämning = laborationsuppgift.HittaInlämning(this.student, true);

                int inlämningsIndex = this.databas.inlämningar.IndexOf(inlämning);
                Program.appform.VisaVy(new RedigeraBetyg(inlämningsIndex));
            }
        }

        private void Uppgifter_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UppdateraBetyg();
        }

        private void UppdateraBetyg()
        {
            int cellIndex = this.uppgifterDataGridView.Columns["Betyg"].Index;
            for (int i = 0; i < this.uppgifterDataGridView.Rows.Count; i++)
            {
                Laborationsuppgift laborationsuppgift = (Laborationsuppgift)this.uppgifterDataGridView.Rows[i].DataBoundItem;
                Inlämning inlämning = laborationsuppgift.HittaInlämning(this.student, false);
                if (inlämning == null)
                    continue;
                this.uppgifterDataGridView[cellIndex, i].Value = inlämning.Betyg;
            }
        }
    }
}

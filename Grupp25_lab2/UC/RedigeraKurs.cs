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
    public partial class RedigeraKurs : UserControl
    {
        private Databas databas = Databas.HämtaDatabas();
        private Kurs kurs;
        private int kursIndex;

        private bool visaExisterandeLärare = true;
        private bool visaExisterandeStudenter = true;
        public RedigeraKurs(int kursIndex)
        {
            InitializeComponent();
            this.kursIndex = kursIndex;
            this.kurs = this.databas.kurser[kursIndex];

            VisaKursInfo();
            VisaLärare(visaExisterandeLärare);
            VisaStudenter(visaExisterandeStudenter);
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

            this.kurs.Namn = this.kursnamnTextbox.Text;
            this.kurs.Kurskod = this.kurskodTextbox.Text;
            this.kurs.Startdatum = this.startdatumDateTimePicker.Value.Date;
            this.kurs.Slutdatum = this.slutdatumDateTimePicker.Value.Date;

            this.sparaKurs.Enabled = false;
            this.nyKursSkapadLabel.Show();
        }

        private void VisaKursInfo()
        {
            if (this.kurs == null)
                return;

            this.kursnamnTextbox.Text = kurs.Namn;
            this.kurskodTextbox.Text = kurs.Kurskod;
            this.startdatumDateTimePicker.Value = kurs.Startdatum.Date;
            this.slutdatumDateTimePicker.Value = kurs.Slutdatum.Date;

            this.sparaKurs.Enabled = false;
        }

        private void VisaLärare(bool existerande)
        {
            if (existerande)
            {
                hanteraLärareBTN.Text = "Ta bort markerad lärare";
                bytLärareVyBTN.Text = "Visa icke-registrerade lärare";
            }
            else
            {
                hanteraLärareBTN.Text = "Lägg till markerad lärare";
                bytLärareVyBTN.Text = "Visa registrerade lärare";
            }

            this.lärareListBox.Items.Clear();

            foreach (Lärare lärare in databas.lärare)
            {
                if (kurs.LärareRegistrerad(lärare) == existerande)
                    this.lärareListBox.Items.Add(lärare);
            }
        }
        private void VisaStudenter(bool existerande)
        {
            if (existerande)
            {
                hanteraStudentBTN.Text = "Ta bort markerad student";
                bytStudentVyBTN.Text = "Visa icke-registrerade student";
            }
            else
            {
                hanteraStudentBTN.Text = "Lägg till markerad student";
                bytStudentVyBTN.Text = "Visa registrerade student";
            }

            this.studentListBox.Items.Clear();

            foreach (Student student in databas.studenter)
            {
                if (kurs.StudentRegistrerad(student) == existerande)
                    this.studentListBox.Items.Add(student);
            }
        }

        private void RaderaKurs_Click(object sender, MouseEventArgs e)
        {
            kurs.Radera();
            Program.appform.VisaVy(new VisaKurser());
        }

        private void HanteraLärareBTN_Click(object sender, EventArgs e)
        {
            if (this.lärareListBox.SelectedIndex == -1)
                return;

            Lärare valdLärare = (Lärare)this.lärareListBox.SelectedItem;

            if (this.visaExisterandeLärare)
                kurs.AvregistreraLärare(valdLärare);
            else
                kurs.RegistreraLärare(valdLärare);

            this.visaExisterandeLärare = true;
            VisaLärare(this.visaExisterandeLärare);
        }

        private void BytLärareVyBTN_Click(object sender, EventArgs e)
        {
            this.visaExisterandeLärare = this.visaExisterandeLärare ? false : true;
            VisaLärare(this.visaExisterandeLärare);
        }
        private void HanteraStudentBTN_Click(object sender, EventArgs e)
        {
            if (this.studentListBox.SelectedIndex == -1)
                return;

            Student valdStudent = (Student)this.studentListBox.SelectedItem;

            if (this.visaExisterandeStudenter)
                kurs.AvregistreraStudent(valdStudent);
            else
                kurs.RegistreraStudent(valdStudent);

            this.visaExisterandeStudenter = true;
            VisaStudenter(this.visaExisterandeStudenter);
        }

        private void BytStudentVyBTN_Click(object sender, EventArgs e)
        {
            this.visaExisterandeStudenter = this.visaExisterandeStudenter ? false : true;
            VisaStudenter(this.visaExisterandeStudenter);
        }

        private void VisaKursuppgifterBTN_Click(object sender, EventArgs e)
        {
            Program.appform.VisaVy(new VisaKursuppgifter(kursIndex));
        }
    }
}

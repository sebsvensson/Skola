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
    public partial class VisaKursuppgifter : UserControl
    {
        private int kursIndex;
        private Kurs kurs;
        private Laborationsuppgift redigeradUppgift;
        private Databas databas = Databas.HämtaDatabas();
        private BindingSource bindingSource = new BindingSource();
        public VisaKursuppgifter(int kursIndex)
        {
            InitializeComponent();
            this.kursIndex = kursIndex;
            this.kurs = databas.kurser[kursIndex];
            this.bindingSource.DataSource = kurs.laborationsuppgifter;
            this.kursuppgifterDataGridView.DataSource = this.bindingSource;
        }
        private void Uppgiftslista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != kursuppgifterDataGridView.Columns["Redigera"].Index || e.RowIndex == -1)
                return;

            this.redigeradUppgift = kurs.laborationsuppgifter[e.RowIndex];

            UppdateraFält();
        }
        private void UppdateraFält()
        {
            if (this.redigeradUppgift == null)
            {
                this.namnTextbox.Text = "";
                this.poängTextbox.Text = "";
                this.startdatumDateTimePicker.Value = DateTime.Today.Date;
                this.slutdatumDateTimePicker.Value = DateTime.Today.Date;
                this.sparaRedigeradUppgiftBTN.Enabled = false;
                this.raderaUppgiftBTN.Enabled = false;
            }
            else
            {
                this.namnTextbox.Text = this.redigeradUppgift.Namn;
                this.poängTextbox.Text = this.redigeradUppgift.Poäng.ToString();
                this.startdatumDateTimePicker.Value = this.redigeradUppgift.Startdatum.Date;
                this.slutdatumDateTimePicker.Value = this.redigeradUppgift.Slutdatum.Date;
                this.sparaRedigeradUppgiftBTN.Enabled = true;
                this.raderaUppgiftBTN.Enabled = true;
            }
            this.bindingSource.ResetBindings(false);
        }
        private void SparaNyUppgiftBTN_Click(object sender, EventArgs e)
        {
            double poäng;

            if (!double.TryParse(this.poängTextbox.Text, out poäng))
                return;

            kurs.RegistreraLaborationsuppgift(this.namnTextbox.Text, poäng, this.startdatumDateTimePicker.Value.Date, this.slutdatumDateTimePicker.Value.Date);
            
            this.redigeradUppgift = null;
            UppdateraFält();
        }
        private void SparaRedigeradUppgiftBTN_Click(object sender, EventArgs e)
        {
            if (this.redigeradUppgift == null)
                return;

            double poäng;

            if (!double.TryParse(this.poängTextbox.Text, out poäng))
                return;

            this.redigeradUppgift.Namn = this.namnTextbox.Text;
            this.redigeradUppgift.Poäng = poäng;
            this.redigeradUppgift.Startdatum = this.startdatumDateTimePicker.Value.Date;
            this.redigeradUppgift.Slutdatum = this.slutdatumDateTimePicker.Value.Date;

            this.redigeradUppgift = null;

            UppdateraFält();
        }

        private void RaderaUppgiftBTN_Click(object sender, EventArgs e)
        {
            kurs.AvregistreraLaborationsuppgift(this.redigeradUppgift);
            this.redigeradUppgift = null;

            UppdateraFält();
        }

        private void VisaKursBTN_Click(object sender, EventArgs e)
        {
            Program.appform.VisaVy(new RedigeraKurs(this.kursIndex));
        }
    }
}

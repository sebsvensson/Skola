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
    public partial class RedigeraBetyg : UserControl
    {
        private string valtBetyg;
        private readonly Databas databas = Databas.HämtaDatabas();
        private Inlämning inlämning;
        public RedigeraBetyg(int inlämningsIndex)
        {
            InitializeComponent();

            this.inlämning = this.databas.inlämningar[inlämningsIndex];

            this.studentIDLabel.Text = this.inlämning.Student.StudentID;
            this.studentnamnLabel.Text = $"{this.inlämning.Student.Förnamn} {this.inlämning.Student.Efternamn}";
            this.kurskodLabel.Text = this.inlämning.Laborationsuppgift_.Kurs_.Kurskod;
            this.kursnamnLabel.Text = this.inlämning.Laborationsuppgift_.Kurs_.Namn;
            this.laborationsuppgiftLabel.Text = this.inlämning.Laborationsuppgift_.Namn;
            this.inlämningstidLabel.Text = this.inlämning.Inlämningstid.ToString();
            this.betygComboBox.SelectedIndex = BetygTillIndex(this.inlämning.Betyg);
            this.sparaBetygBTN.Enabled = false;
        }

        private void Betyg_TextChanged(object sender, EventArgs e)
        {
            int betygIndex = BetygTillIndex(this.betygComboBox.Text);
            this.betygComboBox.SelectedIndex = betygIndex;

            if (betygIndex == -1)
                this.betygComboBox.Text = "";
            else
                this.betygComboBox.Text = (string)this.betygComboBox.Items[betygIndex];

            this.valtBetyg = (string)this.betygComboBox.SelectedItem;

            UppdateraSparaBetygKnapp();
        }

        private int BetygTillIndex(string betyg)
        {
            switch (betyg)
            {
                case "A":
                    return 0;
                case "B":
                    return 1;
                case "C":
                    return 2;
                case "D":
                    return 3;
                case "E":
                    return 4;
                case "F":
                    return 5;
                default:
                    return -1;
            }
        }

        private void UppdateraSparaBetygKnapp()
        {
            this.sparaBetygBTN.Enabled = this.valtBetyg != this.inlämning.Betyg;
        }

        private void SparaBetygBTN_Click(object sender, EventArgs e)
        {
            this.inlämning.Betyg = this.valtBetyg;
            this.sparaBetygBTN.Enabled = false;
        }

        private void TillbakaTillStudentBTN_Click(object sender, EventArgs e)
        {
            int studentIndex = this.databas.studenter.IndexOf(this.inlämning.Student);
            if (studentIndex == -1)
                return;
            Program.appform.VisaVy(new RedigeraStudent(studentIndex));
        }
    }
}

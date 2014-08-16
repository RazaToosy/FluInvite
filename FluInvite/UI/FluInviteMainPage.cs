using System;
using System.IO;
using System.Windows.Forms;
using FluInvite.Infrastructure.Data;
using FluInvite.Infrastructure.Operations;

namespace FluInvite.UI
{
    public partial class FluInviteMainPage : Form
    {
        public FluInviteMainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Repository context = new Repository(
                Int32.Parse(this.textBoxListSize.Text),
                Int32.Parse(this.textBoxTimeBetweenSessions.Text),
                Int32.Parse(this.textBoxMaxNoOfPatientsInSlot.Text),
                this.labelLocationOfSource.Text);

            context.CreateSession(this.textBoxSessionDateTimes.Text);

            context = new CreateTimes().ProcessRepo(context);

            new CsvExport(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                string.Format("PatientFluInvite.{0}.csv", DateTime.Now.ToString("dd.MM.yy"))), context.DtPatients);

            MessageBox.Show("Result on the Desktop", "Export Complete");

        }

        private void labelLocationOfSource_Click(object sender, System.EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                this.labelLocationOfSource.Text = file;
            }
        }
    }
}

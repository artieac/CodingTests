using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprivata
{
    public partial class TestForm : Form, IOutputLogger
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        public void WriteMessage(string message)
        {
            this.outputWindow.AppendText(message + "\n");
        }

        public void ClearLog()
        {
            this.outputWindow.Clear();
        }

        private void sortedMergeButton_Click(object sender, EventArgs e)
        {
            this.ClearLog();

            MergeArraysTask mergeArraysTask = new MergeArraysTask(this);
            mergeArraysTask.RunMergeArraysTask_Random();
            mergeArraysTask.RunMergeArraysTask_RandomSortedTwo();
            mergeArraysTask.RunMergeArraysTask_AlreadySorted();
            mergeArraysTask.RunMergeArraysTask_WorstCase();
        }

        private void pangramTestButton_Click(object sender, EventArgs e)
        {
            PangramTest pangramTest = new PangramTest(this);

            if (lstTestStrings.SelectedItem == null)
            {
                lstTestStrings.SelectedIndex = 0;
            }

            bool result = pangramTest.IsPangram(lstTestStrings.SelectedItem.ToString());
        }

        private void freeFormPangramButton_Click(object sender, EventArgs e)
        {
            PangramTest pangramTest = new PangramTest(this);
            bool result = pangramTest.IsPangram(this.freeFormInput.Text);
        }

        private void topmostStepButton_Click(object sender, EventArgs e)
        {
            TopmostStepTest stepTest = new TopmostStepTest(this);

            int topmostStep = stepTest.FindTopmostStep(2, 2);
            topmostStep = stepTest.FindTopmostStep(2, 1);
        }

        private void cityClinicsButton_Click(object sender, EventArgs e)
        {
            CityClinicsTest cityClinicsTest = new CityClinicsTest(this);
            int[] cityPopulations = { 200000, 500000 };
            cityClinicsTest.DeterminMaxVaccinationsInLargestClinic(2, 7, cityPopulations);

            cityClinicsTest.DeterminMaxVaccinationsInLargestClinic_Alt(2, 7, cityPopulations);

        }
    }
}

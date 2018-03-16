using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenThousEx
{
    public partial class OptionAndControlWindow : Form
    {
        readonly private RandList randomNumberListGenerator;
        private int lockedProgram = 1;

        public OptionAndControlWindow()
        {
            InitializeComponent();
            randomNumberListGenerator = new RandList();
        }

        private void produceFileOutputButton_Click(object sender, EventArgs e)
        {
            if (lockedProgram == 1)
            {
                lockedProgram = 0;
                Console.WriteLine("PRODUCE BUTTON PRESSED");
                int startingNumber = (int)this.selectStartingNumberOfRangeNumericUpDown.Value;
                int endingNumber = (int)this.selectEndingNumberOfRangeNumericUpDown.Value;
                int optionInclusiveExclusive = (int)this.selectInclusiveExclusiveOptionComboBox.SelectedIndex;

                if (startingNumber > endingNumber)
                {
                    Console.WriteLine("INVALID INPUT");
                }
                else
                {
                    Console.WriteLine("VALID INPUT RECEIVED");
                    Console.WriteLine(startingNumber + " ### " + endingNumber);
                    updateListVariablesPriorToExecution(startingNumber, endingNumber);
                    executeRandomListGenerator(optionInclusiveExclusive);
                }
            }
            else
            {
                Console.WriteLine("PROGRAM EXCUTING ---- LOCKED");
            }
        }

        private void selectStartingNumberOfRangeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("START NUMBER VALUE CHANGED");
            Console.WriteLine("S NUM: " + this.selectStartingNumberOfRangeNumericUpDown.Value);
        }

        private void selectEndingNumberOfRangeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("END NUMBER VALUE CHANGED");
            Console.WriteLine("E NUM: " + this.selectEndingNumberOfRangeNumericUpDown.Value);
        }

        private void selectInclusiveExclusiveOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("INCLUSICE EXCLUSIVE OPTION CHANGED");
            Console.WriteLine("INC/EXC OPTION: " + selectInclusiveExclusiveOptionComboBox.SelectedIndex + " ### " + selectInclusiveExclusiveOptionComboBox.SelectedItem);
        }

        private void updateListVariablesPriorToExecution(int startingNumber, int endingNumber)
        {
            Console.WriteLine("Updating Vars: " + startingNumber + " # " + endingNumber);
            randomNumberListGenerator.LowRangeNumber = startingNumber;
            randomNumberListGenerator.HighRangeNumber = endingNumber;
        }

        private void executeRandomListGenerator(int optionInclsuiveExclusive)
        {
            lockedProgram = randomNumberListGenerator.Runner(optionInclsuiveExclusive);
        }
    }
}

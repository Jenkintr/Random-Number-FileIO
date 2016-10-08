using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Random_Number_File_Writer
{
    public partial class RandomNumberGenerator : Form
    {
        public RandomNumberGenerator()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Verify that the user wants to exit the program.
            if (MessageBox.Show("Are You Sure To Exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void writeNumButton_Click(object sender, EventArgs e)
        {
            try
            {
                

                //Create Save File Dialog Box 
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = "DefaultOutputName.txt";
                saveFile.Filter = "Text File | *.txt";
               
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    //Declare a StreamWriter variable.
                    StreamWriter outputFile = new StreamWriter(saveFile.OpenFile());

                     //Create random object:
                     Random rand = new Random();

                     //Generate Random Number and Write to File.
                     int numsToWrite;
                     numsToWrite = Convert.ToInt32(amtNumsTextBox.Text);
                     numsToWrite = int.Parse(amtNumsTextBox.Text);

                     for (int i = 0; i < numsToWrite; i++)
                     {
                         int newNum = rand.Next(1, 100);
                         MessageBox.Show(newNum.ToString());
                        outputFile.WriteLine(newNum.ToString());
                     }

                    //Close File.
                    outputFile.Dispose();
                    outputFile.Close();

                    //Inform user the file was written
                    MessageBox.Show("Random numbers were written to the file.");
                }             
            }
            
            catch(Exception ex)
            {
                //Display an error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}

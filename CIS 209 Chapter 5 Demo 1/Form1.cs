using System;
using System.IO;
using System.Windows.Forms;

namespace CIS_209_Chapter_5_Demo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable for the flavor
                string flavor;

                // Open a file for reading
                StreamReader inputFile = File.OpenText("flavors.txt");

                // Read the file's contents
                while (!inputFile.EndOfStream)
                {
                    // Read the next line
                    flavor = inputFile.ReadLine();

                    // Add it to the list box
                    lbxChoices.Items.Add(flavor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "U-Sever Ice Cream Parlor",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void lbxChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = lbxChoices.SelectedItem.ToString();
            lblChoice.Text = "Enjoy your " + choice + " ice cream!";
        }
    }
}

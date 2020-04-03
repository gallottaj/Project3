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

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fruitName;
                StreamReader inputFile;
                inputFile = File.OpenText("fruitnames.txt");
                fruitsListBox.Items.Clear();
                
                while (!inputFile.EndOfStream)
                { fruitName = inputFile.ReadLine();
                    fruitsListBox.Items.Add(fruitName.ToLower());
                }

                inputFile.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string originalFruitName;
                StreamReader inputFile;
                inputFile = File.OpenText("fruitnames.txt");
                originalWordListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    originalFruitName = inputFile.ReadLine();
                    originalWordListBox.Items.Add(originalFruitName);
                }

                inputFile.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void originalWordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }
    }
}

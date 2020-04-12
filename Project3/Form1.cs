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
            //displays original words from text file

            int count = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\gallo\source\repos\Project3\Project3\bin\Debug\fruitnames.txt");
            List<string> list = new List<string>();

            while ((line = file.ReadLine()) != null)
            {
                originalWordListBox.Items.Add(line);
                list.Add(line);
                count++;
            }

            //put text from file into an array to sort by length using Linq; display longest word

            string[] fruits = list.ToArray();
            Array.Sort(fruits);

            foreach (string item in fruits)
            {
                sortedFruitListBox.Items.Add(item);
            }

            var sorted = fruits.OrderBy(n => n.Length);
            var shortest = sorted.FirstOrDefault();
            var longest = sorted.LastOrDefault();

            {
                longestWordListBox.Items.Add(longest);
                mostVowelsListBox.Items.Add(longest);
            }

            //read original input file and convert all to lower case using .ToLower()

            try
            {
                string fruitName;
                StreamReader inputFile;
                inputFile = File.OpenText("fruitnames.txt");
                fruitsListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    fruitName = inputFile.ReadLine();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            //add statistics to output file
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputFile = new StreamWriter("List.txt"))
            {
                try
                {
                    foreach (var item in originalWordListBox.Items)
                        foreach (var item2 in fruitsListBox.Items)
                            foreach (var item3 in sortedFruitListBox.Items)
                                foreach (var item4 in longestWordListBox.Items)
                                    foreach (var item5 in mostVowelsListBox.Items)
                                    {
                                        outputFile.WriteLine(item);
                                        outputFile.WriteLine(item2);
                                        outputFile.WriteLine(item3);
                                        outputFile.WriteLine(item4);
                                        outputFile.WriteLine(item5);
                                    }

                    outputFile.Close();
                    MessageBox.Show("The file has been saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
    






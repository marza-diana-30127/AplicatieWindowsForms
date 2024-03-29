using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("You choosed to go on: " + radioButton1.Text);
                StreamReader streamreader1 = new StreamReader(path: "Bontida.txt");
                {
                    List<string> lines = new List<string>();
                    string line;
                    while ((line = streamreader1.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    listBox1.DataSource = lines;
                }
                pictureBox1.Image = Properties.Resources.bontida;
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("You choosed to go on: " + radioButton2.Text);
                StreamReader streamreader2 = new StreamReader(path: "Horse.txt");
                {
                    List<string> lines = new List<string>();
                    string line;
                    while ((line = streamreader2.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    listBox1.DataSource = lines;
                }
                pictureBox1.Image = Properties.Resources.horse;
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("You choosed to go on: " + radioButton3.Text);
                StreamReader streamreader3 = new StreamReader(path: "Farmer.txt");
                {
                    List<string> lines = new List<string>();
                    string line;
                    while ((line = streamreader3.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    listBox1.DataSource = lines;
                }
                pictureBox1.Image = Properties.Resources.farmer;
            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show("You choosed to go on: " + radioButton4.Text);
                StreamReader streamreader4 = new StreamReader(path: "Apahida.txt");
                {
                    List<string> lines = new List<string>();
                    string line;
                    while ((line = streamreader4.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                    listBox1.DataSource = lines;
                }
                pictureBox1.Image = Properties.Resources.bee;
            }

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("feedback.txt", textBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

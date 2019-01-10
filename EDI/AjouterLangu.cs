using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDI
{
    public partial class AjouterLangu : Form
    {
        public int mod = -1;
        private string image;
        private bool good = true;
        public AjouterLangu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                good = false;
                textBox1.BackColor = Color.FromArgb(246, 154, 154);
            }
            else
            {
                good = true;
                textBox1.BackColor = Color.White;
            }
                
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = openFileDialog1.FileName;
                pictureBox1.BackgroundImage = Image.FromFile(@image);
                good = true;
            }
            else
            {
                pictureBox1.BackColor = Color.FromArgb(246, 154, 154); 
                good = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (good)
            {
                if (mod>=0)
                {
                    Form1.liste_language.ElementAt(mod).Nom = textBox1.Text;
                    Form1.liste_language.ElementAt(mod).Type = comboBox1.SelectedItem.ToString();
                    Form1.liste_language.ElementAt(mod).Duree = comboBox2.SelectedItem.ToString();
                    Form1.liste_language.ElementAt(mod).Image = image;
                    this.Close();
                }
                else
                {
                    Language l = new Language(comboBox1.SelectedItem.ToString(), textBox1.Text, comboBox2.SelectedItem.ToString(), image);
                    Form1.liste_language.Add(l);
                    this.Close();

                }

            }
            


        }

        private void AjouterLangu_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            if (mod >= 0)
            {
                textBox1.Text = Form1.liste_language.ElementAt(mod).Nom;
                comboBox1.SelectedItem = Form1.liste_language.ElementAt(mod).Type ;
                comboBox2.SelectedItem = Form1.liste_language.ElementAt(mod).Duree ;
                pictureBox1.BackgroundImage = Image.FromFile(@Form1.liste_language.ElementAt(mod).Image);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

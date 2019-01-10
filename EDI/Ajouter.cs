using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EDI
{
    public partial class Ajouter : Form
    {
        private bool good;
        private string image;
        private bool mouseDown;
        private Point lastLocation;
        public Ajouter()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Ajouter_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Ajouter_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = openFileDialog1.FileName;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(textBox1.Text, @"^[a-zA-Z]+$");
            if (!match.Success)
            {
                textBox1.BackColor = Color.FromArgb(246, 154, 154);
            }
            else
            {
                textBox1.BackColor = Color.White;
                good = true;
            }
                

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(textBox2.Text, @"^[a-zA-Z]+$");
            if (!match.Success)
            {
                textBox2.BackColor = Color.FromArgb(246, 154, 154);
            }
            else
            {
                textBox2.BackColor = Color.White;
                good = true;
            }
                
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(textBox3.Text, @"^[A-Z].\d");
            if (!match.Success)
            {
                textBox3.BackColor = Color.FromArgb(246, 154, 154);
            }
            else
            {
                textBox3.BackColor = Color.White;
                good = true;
            }
                
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

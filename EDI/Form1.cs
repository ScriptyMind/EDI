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
    public partial class Form1 : Form
    {
        public static List<Etudiant> liste_etudient = new List<Etudiant>();
        public static List<Professeur> liste_professeur = new List<Professeur>();
        public static List<Language> liste_language = new List<Language>();


        private bool mouseDown;
        private Point lastLocation;
        private bool t1 = false , t2 = false;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!t2)
            {
                textBox2.Clear();
                textBox2.PasswordChar = '*';
            }
            t2 = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.PasswordChar = char.MinValue;
            else
                textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Honey")
                textBox1.BackColor = Color.FromArgb(246, 154, 154);
            else
                textBox1.BackColor = Color.White;
            if (textBox2.Text != "Partner")
                textBox2.BackColor = Color.FromArgb(246, 154, 154);
            else
                textBox2.BackColor = Color.White;

            AdminPanel etudient = new AdminPanel();
            etudient.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(etudient);
            etudient.Dock = DockStyle.Fill;
            etudient.Show();
            panel1.Visible = true;
            



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(!t1)
                textBox1.Clear();
            t1 = true;
        }
    }
}

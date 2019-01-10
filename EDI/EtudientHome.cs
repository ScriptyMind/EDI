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
    public partial class EtudientHome : Form
    {
        public EtudientHome()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile prof = new Profile();
            prof.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(prof);
            prof.Dock = DockStyle.Fill;
            prof.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reclamation msg = new Reclamation();
            msg.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(msg);
            msg.Dock = DockStyle.Fill;
            msg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Recherche rech = new Recherche();
            rech.TopLevel = false; 
            panel3.Controls.Clear();
            panel3.Controls.Add(rech);
            rech.Dock = DockStyle.Fill;
            rech.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emploi emp = new Emploi();
            //emp.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(emp);
            emp.Dock = DockStyle.Fill;
            emp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(note);
            note.Dock = DockStyle.Fill;
            note.Show();
        }
    }
}

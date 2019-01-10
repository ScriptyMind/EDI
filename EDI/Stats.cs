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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Stats_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.liste_etudient.Count.ToString();
            label2.Text = Form1.liste_professeur.Count.ToString();
            label3.Text = Form1.liste_language.Count.ToString();

        }
    }
}

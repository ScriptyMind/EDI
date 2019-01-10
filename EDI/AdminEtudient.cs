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
    public partial class AdminEtudient : Form
    {
        public AdminEtudient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter ajou = new Ajouter();
            ajou.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminEtudient_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

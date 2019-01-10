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
    public partial class SupprimerConfirmation : Form
    {
        public int index;
        public SupprimerConfirmation()
        {
            InitializeComponent();
        }

        private void SupprimerConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.liste_language.RemoveAt(index);
            this.Close();

        }
    }
}

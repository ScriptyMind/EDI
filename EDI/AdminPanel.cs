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
    public partial class AdminPanel : Form
    {
        

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stats stat = new Stats();
            stat.TopLevel = false;
            panel4.Controls.Clear();
            panel4.Controls.Add(stat);
            stat.Dock = DockStyle.Fill;
            stat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminEtudient ad = new AdminEtudient();
            ad.TopLevel = false;
            panel4.Controls.Clear();
            panel4.Controls.Add(ad);
            ad.Dock = DockStyle.Fill;
            ad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminProf ad = new AdminProf();
            ad.TopLevel = false;
            panel4.Controls.Clear();
            panel4.Controls.Add(ad);
            ad.Dock = DockStyle.Fill;
            ad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminLang ad = new AdminLang();
            ad.TopLevel = false;
            panel4.Controls.Clear();
            panel4.Controls.Add(ad);
            ad.Dock = DockStyle.Fill;
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmploi ad = new AddEmploi();
            ad.TopLevel = false;
            panel4.Controls.Clear();
            panel4.Controls.Add(ad);
            ad.Dock = DockStyle.Fill;
            ad.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Mail ad = new Mail();
            ad.TopLevel = false;
            panel4.Controls.Clear();
            panel4.Controls.Add(ad);
            ad.Dock = DockStyle.Fill;
            ad.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

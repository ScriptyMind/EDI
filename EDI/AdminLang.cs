using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace EDI
{
    public partial class AdminLang : Form
    {
        
        public AdminLang()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterLangu ajou = new AjouterLangu();
            ajou.ShowDialog();
            dataGridView1.Rows.Clear();
            foreach (Language l in Form1.liste_language)
            {
                dataGridView1.Rows.Add(l.Nom, l.Duree, l.Type);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void AdminLang_Load(object sender, EventArgs e)
        {
            foreach (Language l in Form1.liste_language)
            {
                dataGridView1.Rows.Add(l.Nom, l.Duree, l.Type);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjouterLangu mod = new AjouterLangu();
            mod.button2.Text = "Modifier";
            mod.button1.Text = "Modifier Photo";
            mod.mod = dataGridView1.CurrentRow.Index;
            mod.ShowDialog();
            dataGridView1.Rows.Clear();
            foreach(Language l in Form1.liste_language)
            {
                dataGridView1.Rows.Add(l.Nom, l.Duree, l.Type);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupprimerConfirmation s = new SupprimerConfirmation();
            s.index = dataGridView1.CurrentRow.Index ;
            s.ShowDialog();
            dataGridView1.Rows.Clear();
            foreach (Language l in Form1.liste_language)
            {
                dataGridView1.Rows.Add(l.Nom, l.Duree, l.Type);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Language>));
            StreamWriter strw = new StreamWriter("D:\\liste_language.xml");
            serializer.Serialize(strw, Form1.liste_language);
            strw.Close();
            MessageBox.Show("Serialiser");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Language>));
                StreamReader strr = new StreamReader(openFileDialog1.FileName);
                Form1.liste_language = (List<Language>)serializer.Deserialize(strr);
                strr.Close();
                dataGridView1.Rows.Clear();
                foreach (Language l in Form1.liste_language)
                {
                    dataGridView1.Rows.Add(l.Nom, l.Duree, l.Type);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AjouterLangu mod = new AjouterLangu();
            mod.button2.Visible = false;
            mod.button1.Visible= false;
            mod.textBox1.ReadOnly = true;
            mod.comboBox1.Enabled = false;
            mod.comboBox2.Enabled = false;
            Language p = Form1.liste_language.ElementAt(dataGridView1.CurrentRow.Index);
            mod.textBox1.Text = p.Nom;
            mod.comboBox1.SelectedText = p.Type.ToString();
            mod.comboBox2.SelectedText = p.Duree.ToString();
            mod.pictureBox1.BackgroundImage = Image.FromFile(p.Image);
            mod.ShowDialog();
        }
    }
}

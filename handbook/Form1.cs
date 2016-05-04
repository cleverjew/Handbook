using handbook;
using handbook.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HandBook.View
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        } 
        public List<handbook.model.material> find;

        private void button1_Click(object sender, EventArgs e)
        {

            XmlDocument datab = new XmlDocument();
            datab.Load("database.xml");
            XmlNode xRoot = datab.DocumentElement;
            int i = 0;
            while (xRoot.ChildNodes[i] != null)
            {
                i++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MatList per1 = new MatList();
            
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            if (add.ShowDialog() == DialogResult.OK)
            {
                MatList pr1 = new MatList();
                resultBox1.Items.Add(pr1.pr[pr1.pr.Count - 1].ToString());
                add.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            /*handbook.model.material per = new handbook.model.material(name.Text, song.Text, disk.Text);
            MatList mat = new MatList();
            find = mat.Find(per);
            resultBox1.Items.Clear();
            if (ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < find.Count; i++)
                {
                    resultBox1.Items.Add(find[i].ToString());
                }
            } */
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поискToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Search ser = new Search();
            MatList ml = new MatList();
            if (ser.ShowDialog() == DialogResult.OK)
            {
                resultBox1.Items.Clear();
                for (int i = 0; i < ser.find.Count; i++)
                {
                   resultBox1.Items.Add(ser.find[i].ToString());
                }
            }
        }
    }
}
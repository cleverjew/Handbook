using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Handbook.Models;
using Handbook.Forms;

namespace Handbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List l = new List();
            foreach(Material m in l.lm)
            {
                listBox1.Items.Add(m.ToString());
            }
            foreach (Disk d in l.lcd)
            {
                ToolStripMenuItem it = new ToolStripMenuItem();
                it.Text = d.name;
                it.Click += It_Click;
                дискToolStripMenuItem.DropDownItems.Add(it);
            }
        }

        private void It_Click(object sender, EventArgs e)
        {
            List l = new List();
            listBox1.Items.Clear();
            foreach(Disk d in l.lcd)
            {
                if (sender.ToString() == d.name)
                {
                    foreach(Material m in d.ld)
                    {
                        listBox1.Items.Add(m.ToString());
                    }
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            List l = new List();
            if (add.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(l.lm[l.lm.Count - 1].ToString());
            }
            дискToolStripMenuItem.DropDownItems.Clear();
            listBox1.Items.Clear();
            Form1_Load(sender,e);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выебирите композицию для удаления!");
            }
            else
            {
                List l = new List();
                Del del = new Del(l.FindIndex(listBox1.SelectedItem.ToString()));
                if (del.ShowDialog() == DialogResult.Yes)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    дискToolStripMenuItem.DropDownItems.Clear();
                    listBox1.Items.Clear();
                    Form1_Load(sender, e);
                    del.Close();
                }
                else
                {
                    del.Close();
                }
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List l = new List();
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите композицию для изменения!");
            }
            else
            {
                Edit edit = new Edit(l.FindIndex(listBox1.SelectedItem.ToString()));
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    дискToolStripMenuItem.DropDownItems.Clear();
                    listBox1.Items.Clear();
                    Form1_Load(sender, e);
                }
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            List l = new List();
            if (s.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < s.fn.Count; i++)
                {
                    listBox1.Items.Add(s.fn[i].ToString());
                }
            }
        }

        private void показатьВсеКомпозицииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List l = new List();
            foreach (Material m in l.lm)
            {
                listBox1.Items.Add(m.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Handbook.Forms
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Material m = new Material(author.Text, song.Text, cd.Text);
            m.Add();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            List l = new List();
            foreach(Material m in l.lm)
            {
                if (cd.Items.IndexOf(m.cd) == -1)
                {
                    cd.Items.Add(m.cd);
                }
            }
        }

        private void cd_Click(object sender, EventArgs e)
        {

        }
    }
}

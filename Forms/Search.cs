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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        public List<Material> fn;
        private void button1_Click(object sender, EventArgs e)
        {
            fn = new List().Find(new Material(author.Text, song.Text, cd.Text));
            DialogResult = DialogResult.OK;
        }
    }
}

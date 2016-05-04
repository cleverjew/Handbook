using handbook.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace handbook
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        public List<handbook.model.material> find;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            handbook.model.material per = new handbook.model.material(name.Text, song.Text, disk.Text);
            MatList mat = new MatList();
            find = mat.Find(per);
        }
    }
}

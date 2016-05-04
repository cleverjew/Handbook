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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            handbook.model.material per = new handbook.model.material(name.Text, song.Text, disk.Text);
            per.Add();
            MatList pr1 = new MatList();
            pr1.pr.Add(per);
            this.DialogResult = DialogResult.OK;
        }
    }
}

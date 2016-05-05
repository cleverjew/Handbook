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
    public partial class Del : Form
    {
        private int el;
        public Del(int a)
        {
            InitializeComponent();
            el = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            List l = new List();
            l.Delete(el);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}

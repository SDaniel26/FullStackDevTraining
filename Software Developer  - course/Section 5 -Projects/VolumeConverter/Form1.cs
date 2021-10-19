using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            float cl;
            float l;
            cl = Convert.ToInt32(tbCL.Text);
            l = cl / 100;
            tbLitru.Text = (l.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCL.Clear();
            tbLitru.Clear();
        }
    }
}

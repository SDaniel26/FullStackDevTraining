using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conditional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int note = 59;

            if (note >= 75)
            {
                MessageBox.Show("you got First class");
            } else
            {
                MessageBox.Show("you got a second class");
            }
        }
    }
}

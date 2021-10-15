using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    MessageBox.Show("azi e luni");
                    break;
                case 2:
                    MessageBox.Show("azi e marti");
                    break;
                case 3:
                    MessageBox.Show("azi e miercuri");
                    break;
                case 4:
                    MessageBox.Show("azi e joi");
                    break;
                case 5:
                    MessageBox.Show("azi e vineri");
                    break;
                case 6:
                    MessageBox.Show("azi e sambata");
                    break;
                case 7:
                    MessageBox.Show("azi e Duminica");
                    break;

            }
        }
    }
}

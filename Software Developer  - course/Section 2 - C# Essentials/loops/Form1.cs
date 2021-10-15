using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 1;

            //for each loop
            string[] zile = { "Luni", "Marti", "Miercuri", "Joi", "Vineri", "Sambata", "Duminica"};
            foreach (string zi in zile)
            {
                MessageBox.Show("ziua este: " + zi);
            }


            /*
            // do while loop
            do
            {
                MessageBox.Show("Loops brother");
                count++;
            } while (count <= 4);


            
            //while loop
            while (count <=4)
            {
                MessageBox.Show("Valoare este " + count);
                count++;
            }*/
        }
    }
}

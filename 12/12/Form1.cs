using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            int[] siffra = new int[3];
            siffra[0] = int.Parse(textBox1.Text);
            siffra[1] = int.Parse(textBox3.Text);
            siffra[2] = int.Parse(textBox4.Text);

            if(siffra[2] > siffra[0])
            {
                int temp = siffra[0];
                siffra[0] = siffra[2];
                siffra[2] = temp;
            }

            if (siffra[1] > siffra[0])
            {
                int temp = siffra[0];
                siffra[0] = siffra[1];
                siffra[1] = temp;
            }

            if(siffra[2] > siffra[1])
            {
                int temp = siffra[1];
                siffra[1] = siffra[2];
                siffra[2] = temp;
            }


            for (int i=0; i<3; i++)
            {
                textBox2.Text += siffra[i] + "\r\n";
            }
        }
    }
}

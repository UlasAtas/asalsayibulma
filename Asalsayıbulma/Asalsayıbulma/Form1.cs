using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asalsayıbulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            uint adet = 0;

            for(ulong i = 2; i <= numericUpDown1.Value; i++)
            {
                uint sayac = 0;

                for(ulong j = 2; j<i; j++)
                {
                    if(i%j == 0)
                    {
                        sayac++;
                        break;
                    }
                }

                if(sayac == 0)
                {
                    listBox1.Items.Add(i);
                    adet++;                    
                }
                label1.Text = adet.ToString();
            }
        }
    }
}

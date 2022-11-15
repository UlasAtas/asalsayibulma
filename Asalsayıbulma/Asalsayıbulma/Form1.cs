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
            int adet = 0;

            for(int i = 2; i <= numericUpDown1.Value; i++)
            {
                int sayac = 0;

                for(int j = 2; j<i; j++)
                {
                    if(i%j == 0)
                    {
                        sayac++;                        
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

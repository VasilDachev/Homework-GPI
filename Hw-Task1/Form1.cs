using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_Task1
{
    public partial class Form1 : Form
    {
        int a;
        
    

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int r = rnd.Next(0, 256);
            int g = rnd.Next(0, 256);
            int b = rnd.Next(0, 256);
            a++;
            tbCouner.Text = a.ToString();
            
            if (a % 5 == 0)
            {
                this.BackColor = Color.FromArgb(r,g,b);
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            a = 0;
            tbCouner.Text = a.ToString();
        }
    }
}

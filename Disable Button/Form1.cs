using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Disable_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                if (button1.Enabled == true)
            {
                    button1.Enabled = false;
                button2.Enabled = true;
            }

          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Enabled == true)
            {
                button2.Enabled = false;
                button1.Enabled = true;
            
            }
        }
    }
}

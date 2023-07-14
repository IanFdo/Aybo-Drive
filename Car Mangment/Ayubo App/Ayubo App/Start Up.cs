using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int allawa = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            allawa++;
            if (allawa >= 100)
            {
                timer1.Enabled=false;
                this.Hide();
                Login frm = new Login();
                frm.Show();
            }
        }
    }
}

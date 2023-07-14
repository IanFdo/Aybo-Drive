using Ayubo_App.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_App
{
    public partial class RentHire : Form
    {
        public RentHire()
        {
            InitializeComponent();
        }

        private void Modeltimer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                Modeltimer.Stop();
            }
            else
            {
                Opacity += .03;
            }
        }

        int i;
        private void RentHire_Load(object sender, EventArgs e)
        {
            i = Dashboard.parentY - -150; 
            this.Location = new Point(Dashboard.parentX - -300, Dashboard.parentY - -150);
        }

        private void btnMClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMClose_MouseHover(object sender, EventArgs e)
        {
            btnMClose.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void btnMClose_MouseLeave(object sender, EventArgs e)
        {
            btnMClose.ForeColor = Color.White;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            this.Close();
            ChildForm.Rent frm = new ChildForm.Rent();
            frm.Show();
        }
        private void btnHire_Click(object sender, EventArgs e)
        {
            btnRent.Visible = false;
            btnHire.Visible = false;
            btnDay.Visible = true;
            btnLong.Visible = true;
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            this.Close();
            ChildForm.Long_Tour frm = new ChildForm.Long_Tour();
            frm.Show();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            this.Close();
            ChildForm.Day_Tour frm = new ChildForm.Day_Tour();
            frm.Show();
        }
    }
}

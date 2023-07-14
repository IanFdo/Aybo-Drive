using Ayubo_App.ChildForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ayubo_App
{
    public partial class Dashboard : Form
    {
        //fields
        private Button currentButton;
     
        public Dashboard()
        {
            InitializeComponent();
        }

        public void showchildform(Object Form)
        {
            if (this.pnlChildform.Controls.Count > 0)
            {
                this.pnlChildform.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnlChildform.Controls.Add(form);
            form.Show();
        }

        private void ActiveButton(Object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    btnBack.Visible = true;
                    currentButton = (Button)btnsender;
                    currentButton.ForeColor = Color.FromArgb(0, 126, 249);
                    currentButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in pnlButton.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.ForeColor = Color.White;
                    previousBtn.BackColor = Color.FromArgb(24, 30, 54);
                    previousBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showchildform(new ChildForm.Customer());
            btnBack.Visible = true;
            pnlNav.Visible = true;
            pnlNav.Height = btnCustomer.Height;
            pnlNav.Top = btnCustomer.Top;
            pnlNav.Left = btnCustomer.Left;
            lblDashboard.Text = btnCustomer.Text;
            btnCustomer.ForeColor = Color.FromArgb(0, 126, 249);
            btnCustomer.BackColor = Color.FromArgb(46, 51, 73);
            this.btnpackage.Image = global::Ayubo_App.Properties.Resources.icons8_list_view_24;
            this.btnCustomer.Image = global::Ayubo_App.Properties.Resources.icons8_customer_24;
            this.btnBooking.Image = global::Ayubo_App.Properties.Resources.icons8_storytelling_24__1_;
            this.btnVehicle.Image = global::Ayubo_App.Properties.Resources.icons8_car_24__1_;
            this.btnDriver.Image = global::Ayubo_App.Properties.Resources.icons8_driving_24;
            ActiveButton(sender);
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            showchildform(new ChildForm.Driver());
            btnBack.Visible = true;
            pnlNav.Visible = true;
            pnlNav.Height = btnDriver.Height;
            pnlNav.Top = btnDriver.Top;
            pnlNav.Left = btnDriver.Left;
            lblDashboard.Text = btnDriver.Text;
            btnDriver.ForeColor = Color.FromArgb(0, 126, 249);
            btnDriver.BackColor = Color.FromArgb(46, 51, 73);
            this.btnpackage.Image = global::Ayubo_App.Properties.Resources.icons8_list_view_24;
            this.btnCustomer.Image = global::Ayubo_App.Properties.Resources.icons8_customer_24__1_;
            this.btnBooking.Image = global::Ayubo_App.Properties.Resources.icons8_storytelling_24__1_;
            this.btnVehicle.Image = global::Ayubo_App.Properties.Resources.icons8_car_24__1_;
            this.btnDriver.Image = global::Ayubo_App.Properties.Resources.icons8_driving_24__1_;
            ActiveButton(sender);

        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            showchildform(new ChildForm.Vehicle());
            btnBack.Visible = true;
            pnlNav.Visible = true;
            pnlNav.Height = btnVehicle.Height;
            pnlNav.Top = btnVehicle.Top;
            pnlNav.Left = btnVehicle.Left;
            lblDashboard.Text = btnVehicle.Text;
            btnVehicle.ForeColor = Color.FromArgb(0, 126, 249);
            btnVehicle.BackColor = Color.FromArgb(46, 51, 73);
            this.btnpackage.Image = global::Ayubo_App.Properties.Resources.icons8_list_view_24;
            this.btnCustomer.Image = global::Ayubo_App.Properties.Resources.icons8_customer_24__1_;
            this.btnBooking.Image = global::Ayubo_App.Properties.Resources.icons8_storytelling_24__1_;
            this.btnVehicle.Image = global::Ayubo_App.Properties.Resources.icons8_car_24;
            this.btnDriver.Image = global::Ayubo_App.Properties.Resources.icons8_driving_24;
            ActiveButton(sender);
        }

        

        private void btnCustomer_Leave(object sender, EventArgs e)
        {
            btnCustomer.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDriver_Leave(object sender, EventArgs e)
        {
            btnDriver.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnVehicle_Leave(object sender, EventArgs e)
        {
            btnVehicle.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBooking_Leave(object sender, EventArgs e)
        {
            btnpackage.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }

        public static int parentX, parentY;
        private void btnBooking_Click_1(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            pnlNav.Visible = true;
            pnlNav.Height = btnBooking.Height;
            pnlNav.Top = btnBooking.Top;
            pnlNav.Left = btnBooking.Left;
            lblDashboard.Text = btnBooking.Text;
            btnpackage.ForeColor = Color.FromArgb(0, 126, 249);
            btnpackage.BackColor = Color.FromArgb(46, 51, 73);
            this.btnpackage.Image = global::Ayubo_App.Properties.Resources.icons8_list_view_24;
            this.btnCustomer.Image = global::Ayubo_App.Properties.Resources.icons8_customer_24__1_;
            this.btnBooking.Image = global::Ayubo_App.Properties.Resources.icons8_storytelling_24;
            this.btnVehicle.Image = global::Ayubo_App.Properties.Resources.icons8_car_24__1_;
            this.btnDriver.Image = global::Ayubo_App.Properties.Resources.icons8_driving_24;
            this.pnlChildform.Controls.Clear();
            ActiveButton(sender);


            Form modelbackground = new Form();
            using (RentHire frm = new RentHire())
            {
                modelbackground.StartPosition = FormStartPosition.Manual;
                modelbackground.FormBorderStyle = FormBorderStyle.None;
                modelbackground.Opacity = .500;
                modelbackground.BackColor = Color.Black;
                modelbackground.Size = this.Size;
                modelbackground.Location = this.Location;
                modelbackground.ShowInTaskbar = false;
                modelbackground.Show();
                frm.Owner = modelbackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                frm.ShowDialog();
                modelbackground.Dispose();
            }
        }

        private void btnpackage_Click(object sender, EventArgs e)
        {
            showchildform(new ChildForm.Package());
            btnBack.Visible = true;
            pnlNav.Visible = true;
            pnlNav.Height = btnpackage.Height;
            pnlNav.Top = btnpackage.Top;
            pnlNav.Left = btnpackage.Left;
            lblDashboard.Text = btnpackage.Text;
            btnpackage.ForeColor = Color.FromArgb(0, 126, 249);
            btnpackage.BackColor = Color.FromArgb(46, 51, 73);
            this.btnpackage.Image = global::Ayubo_App.Properties.Resources.icons8_list_view_24__2_;
            this.btnCustomer.Image = global::Ayubo_App.Properties.Resources.icons8_customer_24__1_;
            this.btnBooking.Image = global::Ayubo_App.Properties.Resources.icons8_storytelling_24__1_;
            this.btnVehicle.Image = global::Ayubo_App.Properties.Resources.icons8_car_24__1_;
            this.btnDriver.Image = global::Ayubo_App.Properties.Resources.icons8_driving_24;
            ActiveButton(sender);

        }

        private void btnpackage_Leave(object sender, EventArgs e)
        {
            btnpackage.BackColor = Color.FromArgb(24, 30, 54);
        }

        public void btnBack_Click(object sender, EventArgs e)
        {
            this.pnlChildform.Controls.Clear();
            DisableButton();
            pnlNav.Visible = false;
            btnBack.Visible = false;
            this.btnpackage.Image = global::Ayubo_App.Properties.Resources.icons8_list_view_24;
            this.btnCustomer.Image = global::Ayubo_App.Properties.Resources.icons8_customer_24__1_;
            this.btnBooking.Image = global::Ayubo_App.Properties.Resources.icons8_storytelling_24__1_;
            this.btnVehicle.Image = global::Ayubo_App.Properties.Resources.icons8_car_24__1_;
            this.btnDriver.Image = global::Ayubo_App.Properties.Resources.icons8_driving_24;
            lblDashboard.Text = "Dashboard";
        }
    }
}

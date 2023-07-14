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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void panelcolorRestore ()
        {
            panel1.BackColor = Color.FromArgb(2, 134, 250);
            panel2.BackColor = Color.FromArgb(2, 134, 250);
        }

        private void panelcolorChanged()
        {
            panel1.BackColor = Color.FromArgb(250, 2, 6);
            panel2.BackColor = Color.FromArgb(250, 2, 6);
        }

        private void Cleaing()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            MessageBox.Show("Clearing fields");
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            lblClear.ForeColor = Color.FromArgb(3, 86, 252);
        }

        private void lblClear_MouseLeave(object sender, EventArgs e)
        {
            lblClear.ForeColor = Color.FromArgb(94, 148, 255);
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.FromArgb(3, 86, 252);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.FromArgb(94, 148, 255);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                Dashboard frm = new Dashboard();
                MessageBox.Show("Login Successful");
                this.Hide();
                frm.Show();
            }
            else
            {
                panelcolorChanged();
                MessageBox.Show("Incorrect Username or Password Try Again!!");
                Cleaing();
                
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit");
            Application.Exit();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            Cleaing();
            panelcolorRestore();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_App.ChildForm
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        string Did = "";
        private void txtDFName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtDLName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDLName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtDAddress.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtDDriverLicense.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDNIC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtDContact.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnDSave.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnDSave_Click(object sender, EventArgs e)
        {
            SQLCOMMANDS commands = new SQLCOMMANDS();
            string commandinsert, commandid;
            commandid = "SELECT COUNT(Driver_ID),  MAX(Driver_ID) FROM Driver;";
            int installid = commands.generateid(commandid);

            commandinsert = "INSERT INTO Driver VALUES ('" + installid + "','" + txtDFName.Text + "', '" + txtDLName.Text + "', '" + txtDAddress.Text + "', '" + txtDDriverLicense.Text + "', '" + txtDContact.Text + "', '"+txtxDriverCost.Text+"')";
            commands.insert(commandinsert);
        }

        private void btnDUpdate_Click(object sender, EventArgs e)
        {
            SQLCOMMANDS commamds = new SQLCOMMANDS();
            string update;
            update = "UPDATE Driver set First_Name= '" + txtDFName.Text + "', Last_Name= '" + txtDLName.Text + "', Address= '" + txtDAddress.Text + "', Driver_license= '" + txtDDriverLicense.Text + "', ContactNumber= '" + txtDContact.Text + "', Driver_Cost= '"+txtxDriverCost.Text+"' where Driver_ID = '" + Did + "'";
            commamds.update(update);
        }

        private void btnDSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string[] values = new string[5];
                SQLCOMMANDS commamds = new SQLCOMMANDS();
                string search;
                search = "SELECT * FROM Driver WHERE ContactNumber = '" + txtDContact.Text + "'";
                values = commamds.search(search);
                Did = values[0].ToString();
                txtDFName.Text = values[1].ToString();
                txtDLName.Text = values[2].ToString();
                txtDAddress.Text = values[3].ToString();
                txtDDriverLicense.Text = values[4].ToString();
                txtxDriverCost.Text = values[6].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

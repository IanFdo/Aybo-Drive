using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ayubo_App.ChildForm
{
    public partial class Customer : Form 
    {
        string cuid = "";
        public Customer()
        {
            InitializeComponent();
        }

        private void txtFName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtLName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtLName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtAddress.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtNIC.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtNIC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtContact.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSave.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) 
        {
            SQLCOMMANDS commands = new SQLCOMMANDS();
            string commandinsert, commandid;
            commandid = "SELECT COUNT(Customer_ID),  MAX(Customer_ID) FROM Customer;";
            int installid = commands.generateid(commandid);

            commandinsert = "INSERT INTO Customer VALUES ('"+ installid + "','"+txtFName.Text+"', '"+txtLName.Text+"', '"+txtAddress.Text+"', '"+txtNIC.Text+"', '"+txtContact.Text+"')";
            commands.insert(commandinsert);
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SQLCOMMANDS commamds = new SQLCOMMANDS();
            string update;
            update = "UPDATE Customer set First_Name= '" + txtFName.Text + "', Last_Name= '"+txtLName.Text+"', Address= '"+txtAddress.Text+"', NIC= '"+txtNIC.Text+"', Contact_Number= '"+txtContact.Text+"' where Customer_ID = '"+cuid+"'";
            commamds.update(update);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string[] values = new string[5];
                SQLCOMMANDS commamds = new SQLCOMMANDS();
                string search;
                search = "SELECT * FROM Customer WHERE Contact_Number = '" + txtContact.Text + "'";
                values = commamds.search(search);
                cuid = values[0].ToString();
                txtFName.Text = values[1].ToString();
                txtLName.Text = values[2].ToString();
                txtAddress.Text = values[3].ToString();
                txtNIC.Text = values[4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
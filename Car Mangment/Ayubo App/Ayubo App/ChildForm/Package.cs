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
    public partial class Package : Form
    {
        public Package()
        {
            InitializeComponent();
        }

        string pacid = "";

        private void btnPSave_Click(object sender, EventArgs e)
        {
            SQLCOMMANDS commands = new SQLCOMMANDS();
            string commandinsert, commandid;
            commandid = "SELECT COUNT(Package_ID),  MAX(Package_ID) FROM Package;";
            int packid = commands.generateid(commandid);

            commandinsert = "INSERT INTO Package VALUES ('" + packid + "','" + txtPackageName.Text + "', '" + comPackageType.Text + "', '" + txtBaseCharge.Text + "', '"+txtExtraperkm.Text+"', '"+txtDailykmLimit.Text+"')";
            commands.insert(commandinsert);
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            SQLCOMMANDS commamds = new SQLCOMMANDS();
            string update;
            update = "UPDATE Package set Package_Name= '" + txtPackageName.Text + "', Package_Type= '" + comPackageType.Text + "', Base_Charge= '" + txtBaseCharge.Text + "', Per_km= '"+ txtExtraperkm.Text + "', Daily_kmLimit='"+ txtDailykmLimit.Text +"' where Package_ID = '" + pacid + "'";
            commamds.update(update);
        }

        private void btnPSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string[] values = new string[5];
                SQLCOMMANDS commamds = new SQLCOMMANDS();
                string search;
                search = "SELECT * FROM Package WHERE Package_Name = '" +txtPackageName.Text+"'";
                values = commamds.search(search);
                pacid = values.ToString();
                txtPackageName.Text = values[1].ToString();
                comPackageType.Text = values[2].ToString();
                txtBaseCharge.Text = values[3].ToString();
                txtExtraperkm.Text = values[4].ToString();
                txtDailykmLimit.Text = values[5].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

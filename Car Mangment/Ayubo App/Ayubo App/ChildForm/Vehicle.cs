using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_App.ChildForm
{
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }


        string Vid = "";
        private void btnDSave_Click(object sender, EventArgs e)
        {
            SQLCOMMANDS commands = new SQLCOMMANDS();
            string commandinsert, commandid;
            commandid = "SELECT COUNT(Vehicle_ID),  MAX(Vehicle_ID) FROM Vehicle;";
            int installid = commands.generateid(commandid);

            commandinsert = "INSERT INTO Vehicle VALUES ('" + installid + "','" + comVehicleType.Text + "', '" + txtVehicleModel.Text + "', '" + txtNumberplate.Text + "', '" + comFueltype.Text + "', '"+txtHireValue.Text+"', '"+txtPerday.Text+"', '"+txtPerWeek.Text+"', '"+txtPerMonth.Text+"', '"+txtPerkm.Text+"', '"+txtDailykmLimit.Text+"')";
            commands.insert(commandinsert);
        }

        private void btnDUpdate_Click(object sender, EventArgs e)
        {
            SQLCOMMANDS commamds = new SQLCOMMANDS();
            string update;
            update = "UPDATE Vehicle set Vehicle_Model= '" + txtVehicleModel.Text + "', Number_Plate= '" + txtNumberplate.Text + "', Fuel_Type= '" + comFueltype.Text + "', Vehicle_Type= '" + comVehicleType.Text + "', Hire_Charge= '"+txtHireValue.Text+ "',PerDay= '" + txtPerday.Text+ "', PerWeek= '" + txtPerWeek.Text+ "', PerMonth='" + txtPerMonth.Text+ "', Perkm= '" + txtPerkm.Text+ "', DailykmLimit='"+txtDailykmLimit.Text+"'  where Vehicle_ID = '" + Vid + "'";
            commamds.update(update);
        }

        private void btnVSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string[] values = new string[10];
                SQLCOMMANDS commamds = new SQLCOMMANDS();
                string search;
                search = "SELECT * FROM Vehicle WHERE Number_Plate = '" + txtNumberplate.Text + "'";
                values = commamds.search(search);
                Vid = values[0].ToString();
                comVehicleType.Text = values[1].ToString();
                txtVehicleModel.Text = values[2].ToString();
                comFueltype.Text = values[4].ToString();   
                txtHireValue.Text = values[5].ToString();  
                txtPerday.Text = values[6].ToString();    
                txtPerWeek.Text = values[7].ToString();
                txtPerMonth.Text = values[8].ToString();
                txtPerkm.Text = values[9].ToString();
                txtDailykmLimit.Text = values[10].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

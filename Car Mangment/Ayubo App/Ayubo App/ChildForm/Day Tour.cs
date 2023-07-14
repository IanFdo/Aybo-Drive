using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo_App.ChildForm
{
    public partial class Day_Tour : Form
    {
        string[] values = new string[50];
        string[] values2 = new string[50];
        string[] values3 = new string[50];

        int pacid = 0;
        int DriverID = 0;
        int VehicleID = 0;
        public Day_Tour()
        {
            InitializeComponent();

            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;

            autopac();
            autoDriver();
            autoVehicle();

            SQLCOMMANDS commands = new SQLCOMMANDS();
            string commandinsert, commandid;
            commandid = "SELECT COUNT(Booking_ID),  MAX(Booking_ID) FROM Booking;";
            txtBookingID.Text = Convert.ToString(commands.generateid(commandid));
        }

        public static int parentX, parentY;
        private void btnDTClose_Click(object sender, EventArgs e)
        {
            this.Close();

            Form modelbackground = new Form();
            using (RentHire ffm = new RentHire())
            {
                modelbackground.StartPosition = FormStartPosition.CenterScreen;
                modelbackground.FormBorderStyle = FormBorderStyle.None;
                modelbackground.BackColor = Color.Black;
                modelbackground.Opacity = .500;
                modelbackground.Size = this.Size;
                modelbackground.Location = this.Location;
                modelbackground.ShowInTaskbar = false;
                modelbackground.Show();
                ffm.Owner = modelbackground;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                ffm.ShowDialog();
                modelbackground.Dispose();
            }
        }

        private void btnDTClose_MouseHover(object sender, EventArgs e)
        {
            btnDTClose.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void btnDTClose_MouseLeave(object sender, EventArgs e)
        {
            btnDTClose.ForeColor = Color.White;
        }

        private void btnDTUpdate_Click(object sender, EventArgs e)
        {
            SQLCOMMANDS commamds = new SQLCOMMANDS();
            string update;
            update = "UPDATE Day_Tour set Package_type='" + comPackage.Text + "', Start_time='" + dateTimePicker3.Value + "', End_time= '" + dateTimePicker1.Value + "', Start_km= '" + txtStartkm.Text + "', End_Km= '" + txtEndkm.Text + "', Base_Hire_charge= '" + txtBaseHireCharge.Text + "', waiting_charge= '" + txtWaitingCharge.Text + "', Extra_km_Charge='"+txtExtrakmCharge.Text+ "', Hire_Value='"+txtHireValue.Text+ "', Driver_ID= '" + DriverID + "', Package_ID= '"+pacid+ "' WHERE Booking_ID = '"+txtBookingID.Text+"')";
            commamds.update(update);
        }

        private void cal()
        {
            int perkm = Convert.ToInt32(values[4]);
            int dailykmL = Convert.ToInt32(values[5]);

            int extra = 0;

            int startkm = Convert.ToInt32(txtStartkm.Text);
            int endkm = Convert.ToInt32(txtEndkm.Text);


            int totalkm = endkm - startkm;
            if (totalkm > dailykmL)
            {
                extra = perkm * (totalkm - dailykmL);
            }
            else
            {
                txtExtrakmCharge.Text = Convert.ToString(0);
            }

            int Drivercost = Convert.ToInt32(txtDrivercost.Text);
            int hirevalue = Convert.ToInt32(txtHireValue.Text);
            int Basehire = Convert.ToInt32(txtBaseHireCharge.Text);
            int WaitingCharge = Convert.ToInt32(txtWaitingCharge.Text);
            int extracharge = Convert.ToInt32(txtExtrakmCharge.Text);


            int total = Drivercost + hirevalue + Basehire + WaitingCharge + extracharge;
            txtPaymentamount.Text = Convert.ToString(total);

        }

        private void comDPackage_TextChanged_1(object sender, EventArgs e)
        {
            pacid = Convert.ToInt32(comPackage.SelectedValue);
            try
            {
                SQLCOMMANDS commamds = new SQLCOMMANDS();
                string search;
                search = "SELECT * FROM Package WHERE Package_ID = '" + pacid + "'";
                values = commamds.search(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtBaseHireCharge.Text = Convert.ToString(values[3]);
            cal();
        }

        private void autopac()
        {
            try
            {
                SQLCOMMANDS sql = new SQLCOMMANDS();
                string query = "select * from Package";
                SqlConnection databaseConnection = new SqlConnection(sql.connectionstring);
                databaseConnection.Open();
                SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                SqlDataAdapter sdr = new SqlDataAdapter(commandDatabase);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                comPackage.DisplayMember = "Package_Name";
                comPackage.ValueMember = "Package_ID";
                comPackage.DataSource = dt;
                comPackage.AutoCompleteMode = AutoCompleteMode.Suggest;
                comPackage.AutoCompleteSource = AutoCompleteSource.ListItems;
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comDriver_TextChanged(object sender, EventArgs e)
        {
            DriverID = Convert.ToInt32(comDriver.SelectedValue);

            try
            {
                SQLCOMMANDS commamds = new SQLCOMMANDS();
                string search;
                search = "SELECT Driver_ID, First_Name, Driver_Cost  FROM Driver WHERE Driver_ID = '" + DriverID + "'";
                values2 = commamds.search(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int drivercost = Convert.ToInt32(values2[2]);
            txtDrivercost.Text = Convert.ToString(drivercost);
        }

        private void autoDriver()
        {
            try
            {
                SQLCOMMANDS sql = new SQLCOMMANDS();
                string query = "select * from Driver";
                SqlConnection databaseConnection = new SqlConnection(sql.connectionstring);
                databaseConnection.Open();
                SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                SqlDataAdapter sdr = new SqlDataAdapter(commandDatabase);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                comDriver.DisplayMember = "First_Name";
                comDriver.ValueMember = "Driver_ID";
                comDriver.DataSource = dt;
                comDriver.AutoCompleteMode = AutoCompleteMode.Suggest;
                comDriver.AutoCompleteSource = AutoCompleteSource.ListItems;
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comVehicleNo_TextChanged(object sender, EventArgs e)
        {
            VehicleID = Convert.ToInt32(comVehicleNo.SelectedValue);
            try
            {
                SQLCOMMANDS commamds = new SQLCOMMANDS();
                string search;
                search = "SELECT * FROM Vehicle WHERE Vehicle_ID = '" + VehicleID + "'";
                values3 = commamds.search(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int hire = Convert.ToInt32(values3[5]);
            txtHireValue.Text = Convert.ToString(hire);

            cal();

        }

        private void txtDStartkm_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtEndkm_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void btnDTSave_Click(object sender, EventArgs e)
        {
            SQLCOMMANDS commands = new SQLCOMMANDS();
            string commandinsert, commandid;
            commandid = "SELECT COUNT(Customer_ID),  MAX(Customer_ID) FROM Customer;";
            int cuid = commands.generateid(commandid);

            commandid = "SELECT COUNT(Rent_ID),  MAX(Rent_ID) FROM Rent;";
            int DayTourID = commands.generateid(commandid);

            commandid = "SELECT COUNT(Payment_ID),  MAX(Payment_ID) FROM Payment;";
            int paymentid = commands.generateid(commandid);

            commandinsert = "INSERT INTO Customer VALUES ('" + cuid + "','" + txtFName.Text + "', '" + txtLName.Text + "', '" + txtAddress.Text + "', '" + txtNIC.Text + "', '" + txtContact.Text + "')"
                + "INSERT INTO Booking VALUES ('" + txtBookingID.Text + "','" + cuid + "', '" + VehicleID + "')"
                 + "INSERT INTO Day_Tour VALUES ('" + DayTourID + "','" + comPackage.Text + "', '" + dateTimePicker3.Value + "', '" + dateTimePicker1.Value + "','" + txtStartkm.Text + "', '" + txtEndkm.Text + "', '" + txtBaseHireCharge.Text + "','" + txtWaitingCharge.Text + "', '"+txtExtrakmCharge.Text+"', '"+txtHireValue.Text+"', '" + DriverID + "', '"+pacid+"', '" + txtBookingID.Text + "')"
                 + "INSERT INTO Payment VALUES ('" + paymentid + "', '" + comPaymentOption.Text + "','" + txtPaymentamount.Text + "', '" + txtBookingID.Text + "')";
            commands.insert(commandinsert);
        }

        private void btnDTSearch_Click(object sender, EventArgs e)
        {
            string[] values = new string[28];
            SQLCOMMANDS commamds = new SQLCOMMANDS();
            string search;

            search = "SELECT * FROM Customer INNER JOIN Booking ON  Customer.Customer_ID = Booking.Customer_ID WHERE Booking.Booking_ID = '" + txtBookingID.Text + "'";
            values = commamds.search(search);
            txtFName.Text = values[1].ToString();
            txtLName.Text = values[2].ToString();
            txtAddress.Text = values[3].ToString();
            txtNIC.Text = values[4].ToString();
            txtContact.Text = values[5].ToString();

            search = "SELECT * FROM Day_Tour INNER JOIN Booking ON Day_Tour.Booking_ID = Booking.Booking_ID WHERE Day_Tour.Booking_ID = '" + txtBookingID.Text + "'";
            values = commamds.search(search);
            comPackage.Text = values[1].ToString();
            dateTimePicker3.Text = values[2].ToString();
            dateTimePicker1.Text = values[3].ToString();
            txtStartkm.Text = values[4].ToString();
            txtEndkm.Text = values[5].ToString();
            txtBaseHireCharge.Text = values[6].ToString();
            txtWaitingCharge.Text = values[7].ToString();
            txtExtrakmCharge.Text = values[8].ToString();

            search = "SELECT * FROM Vehicle INNER JOIN Booking ON Vehicle.Vehicle_ID = Vehicle.Vehicle_ID WHERE Booking.Booking_ID = '" + txtBookingID.Text + "'";
            values = commamds.search(search);
            comVehicleNo.Text = values[3].ToString();
            txtHireValue.Text = values[5].ToString();

            search = "SELECT First_Name FROM Day_Tour INNER JOIN Driver ON Driver.Driver_ID = Day_Tour.Driver_ID  WHERE Day_Tour.Booking_ID = '" + txtBookingID.Text + "'";
            values = commamds.search(search);
            comDriver.Text = values[0].ToString();

        }

        private void txtDTWaitingCharge_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtDTDrivercost_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtDTHireValue_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtDTBaseHireCharge_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtExtrakmCharge_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void autoVehicle()
        {
            try
            {
                SQLCOMMANDS sql = new SQLCOMMANDS();
                string query = "select * from Vehicle";
                SqlConnection databaseConnection = new SqlConnection(sql.connectionstring);
                databaseConnection.Open();
                SqlCommand commandDatabase = new SqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                SqlDataAdapter sdr = new SqlDataAdapter(commandDatabase);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                comVehicleNo.DisplayMember = "Number_Plate";
                comVehicleNo.ValueMember = "Vehicle_ID";
                comVehicleNo.DataSource = dt;
                comVehicleNo.AutoCompleteMode = AutoCompleteMode.Suggest;
                comVehicleNo.AutoCompleteSource = AutoCompleteSource.ListItems;
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Ayubo_App.ChildForm
{
    public partial class Rent : Form
    {
        string[] values = new string[50];
        string[] values2 = new string[50];

        int DriverID = 0;
        int VehicleNumber = 0;
        public Rent()
        {
            InitializeComponent();
            autogen();
            autoday();
            SQLCOMMANDS commands = new SQLCOMMANDS();
            string commandinsert, commandid;
            commandid = "SELECT COUNT(Booking_ID),  MAX(Booking_ID) FROM Booking;";
            txtBookingID.Text = Convert.ToString(commands.generateid(commandid));
        }

        public static int parentX, parentY;
        private void btnRClose_Click(object sender, EventArgs e)
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
        private void btnRClose_MouseHover(object sender, EventArgs e)
        {
            btnRClose.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void btnRClose_MouseLeave(object sender, EventArgs e)
        {
            btnRClose.ForeColor = Color.White;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            cal();
        }

        private void cal()
        {
            int dayvalue = Convert.ToInt32(values[0]);
            int weekvalue = Convert.ToInt32(values[1]);
            int monthvalue = Convert.ToInt32(values[2]);
            int perkm = Convert.ToInt32(values[3]);
            int dailykmvalue = Convert.ToInt32(values[4]);
            int extrakcharge = 0;
            int totalrent = 0;
            int startkm = Convert.ToInt32(txtStartkm.Text);
            int endkm = Convert.ToInt32(txtEndkm.Text);

            if (checkBox1.Checked)
            {
                comDirver.Visible = true;
            }
            else
            {
                comDirver.Visible = false;
                txtRTdriver.Text = "0";
            }

            int date = ((TimeSpan)(dateTimePicker2.Value.Date - dateTimePicker1.Value.Date)).Days;

            if (date < 7)
            {
                totalrent = dayvalue * date;
                
            }
            else if (date < 30)
            {
                int weekcount = (date / 7);
                int exday = (date % 7);
                totalrent = (weekcount * weekvalue) + (exday * dayvalue);
            }
            else if (date >= 30)
            {
                int monthcount = (date / 30);
                int exmonth = (date % 30);
                if (exmonth < 30)
                {
                    int exmonthweekdays = (exmonth / 7);
                    int exmonthdays = (exmonth % 7);
                    totalrent = (monthcount * monthvalue) + (exmonthweekdays * weekvalue) + (exmonthdays * dayvalue);
                }  

            }
            int totalkm = endkm - startkm;
            int maxkm = date * dailykmvalue;
             if (totalkm > maxkm)
             {
                 extrakcharge = perkm * (totalkm - maxkm);
                 txtExtrakm.Text = Convert.ToString(extrakcharge);
             }
             else
            {
                txtExtrakm.Text = Convert.ToString(0);
            }
             txtRAmount.Text = Convert.ToString(totalrent);

            int Amount = Convert.ToInt32(txtRTdriver.Text) + extrakcharge + totalrent;
            txtRPaymentamount.Text = Convert.ToString(Amount);
        }
        private void comDirver_SelectedIndexChanged(object sender, EventArgs e)
        {

            DriverID = Convert.ToInt32(comDirver.SelectedValue);
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
            txtRTdriver.Text = Convert.ToString(drivercost);

            cal();
        }

        private void autogen()
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
                comDirver.DisplayMember = "First_Name";
                comDirver.ValueMember = "Driver_ID";
                comDirver.DataSource = dt;
                comDirver.AutoCompleteMode = AutoCompleteMode.Suggest;
                comDirver.AutoCompleteSource = AutoCompleteSource.ListItems;
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void autoday()
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cal();
        }
        private void txtStartkm_TextChanged(object sender, EventArgs e)
        {
            cal();
        }
        private void txtEndkm_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void btnLTSave_Click(object sender, EventArgs e)
        {

            string chk;

            if (checkBox1.Checked)
            {
                chk = "With Driver";
            }
            else
            {
                chk = "WithOut Driver";
            }

            SQLCOMMANDS commands = new SQLCOMMANDS();
            string commandinsert, commandid;
            commandid = "SELECT COUNT(Customer_ID),  MAX(Customer_ID) FROM Customer;";
            int cuid = commands.generateid(commandid);

            commandid = "SELECT COUNT(Rent_ID),  MAX(Rent_ID) FROM Rent;";
            int rentid = commands.generateid(commandid);

            commandid = "SELECT COUNT(Payment_ID),  MAX(Payment_ID) FROM Payment;";
            int paymentid = commands.generateid(commandid);

            commandinsert = "INSERT INTO Customer VALUES ('" + cuid + "','" + txtRFName.Text + "', '" + txtRLName.Text + "', '" + txtRAddress.Text + "', '" + txtRNIC.Text + "', '" + txtRContact.Text + "')"
                + "INSERT INTO Booking VALUES ('" + txtBookingID.Text + "','" + cuid + "', '" + VehicleNumber + "')"
                 + "INSERT INTO Rent VALUES ('" + rentid + "','" + chk + "', '" + dateTimePicker1.Value + "', '" + dateTimePicker2.Value + "','"+txtStartkm.Text+"', '"+txtEndkm.Text+"', '" + txtExtrakm.Text + "','"+ txtRAmount.Text+ "', '" + DriverID + "', '"+ txtBookingID.Text + "')" 
                 + "INSERT INTO Payment VALUES ('" + paymentid + "', '" + comPaymentOption.Text + "','"+ txtRPaymentamount.Text+ "', '"+ txtBookingID.Text + "')";
            commands.insert(commandinsert);
        }

        private void btnLTSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string[] values = new string[28];
                SQLCOMMANDS commamds = new SQLCOMMANDS();
                string search;
                search = "SELECT * FROM Customer INNER JOIN Booking ON  Customer.Customer_ID = Booking.Customer_ID WHERE Booking.Booking_ID = '" + txtBookingID.Text + "'";
                values = commamds.search(search);

                txtRFName.Text = values[1].ToString();
                txtRLName.Text = values[2].ToString();
                txtRAddress.Text = values[3].ToString();
                txtRNIC.Text = values[4].ToString();
                txtRContact.Text = values[5].ToString();

                search = "SELECT * FROM Booking INNER JOIN Rent ON  Booking.Booking_ID = Rent.Booking_ID WHERE Booking.Booking_ID = '" + txtBookingID.Text +"'";
                values = commamds.search(search);

                dateTimePicker1.Text = values[5].ToString();
                dateTimePicker2.Text = values[6].ToString();
                txtStartkm.Text = values[7].ToString();
                txtEndkm.Text = values[8].ToString();

                search = "SELECT * FROM Vehicle INNER JOIN Booking ON Vehicle.Vehicle_ID = Vehicle.Vehicle_ID WHERE Booking.Booking_ID = '" + txtBookingID.Text + "'";
                values = commamds.search(search);

                comVehicleNo.Text = values[3].ToString();

                search = "SELECT * FROM Rent INNER JOIN Driver ON Driver.Driver_ID = Rent.Driver_ID WHERE Rent.Booking_ID = '" + txtBookingID.Text + "'";
                values = commamds.search(search);

                comDirver.Text = values[11].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnLTUpdate_Click(object sender, EventArgs e)
        {
            string chk;

            if (checkBox1.Checked)
            {
                chk = "With Driver";
            }
            else
            {
                chk = "WithOut Driver";
            }

            SQLCOMMANDS commamds = new SQLCOMMANDS();
            string update;
            update = "UPDATE Rent set Driver_with_or_without='" + chk + "', Rented_date='" + dateTimePicker1.Value + "', Return_date= '" + dateTimePicker2.Value + "', Startkm= '" + txtStartkm.Text + "', Endkm= '" + txtEndkm.Text + "', Extra_km_Charge= '" + txtExtrakm.Text + "', Rent_value= '" + txtRAmount.Text + "', Driver_ID= '" + DriverID + "' WHERE Booking_ID= '"+txtBookingID.Text+"')";
            commamds.update(update);
        }

        private void comVehicleNo_TextChanged(object sender, EventArgs e)
        {
            VehicleNumber = Convert.ToInt32(comVehicleNo.SelectedValue);
            try
            {
                SQLCOMMANDS commamds = new SQLCOMMANDS();
                string search;
                search = "SELECT PerDay, PerWeek, PerMonth, Perkm, DailykmLimit FROM Vehicle WHERE Vehicle_ID = '" + VehicleNumber + "'";
                values = commamds.search(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cal();
        }
    }
}

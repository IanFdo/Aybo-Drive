using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using Ayubo_App.ChildForm;

namespace Ayubo_App
{
    public class SQLCOMMANDS
    {

        public string connectionstring = "Data Source=DESKTOP-0LG3QBJ\\SQLEXPRESS;Initial Catalog=AYUBOAPP;Integrated Security=True";

        public int generateid(string commandid)
        {
            int installid = 0;
            try
            {
                SqlConnection conn = new SqlConnection(connectionstring);
                SqlCommand comm = new SqlCommand(commandid, conn);
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    if ((int)reader[0] == 0)
                    {
                        installid = 1;
                    }
                    else
                    {
                        installid = (int)reader[1] + 1;
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return installid;


        }
        public void insert(string commandinsert)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionstring);
                SqlCommand comm = new SqlCommand(commandinsert, conn);
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Record Added Succesfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void update(string commandupdate)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionstring);
                SqlCommand comm = new SqlCommand(commandupdate, conn);
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string[] search(string search)
        {
            string[] results = new string[12];
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand comm = new SqlCommand(search, conn);
            SqlDataReader reader = null;
            try
            {
                conn.Open();
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results[i] = reader[i].ToString();
                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }

            return results;
        }
    }
}
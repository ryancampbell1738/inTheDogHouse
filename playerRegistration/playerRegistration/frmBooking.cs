﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace playerRegistration
{
    public partial class frmBooking : Form
    {
        SqlDataAdapter daNames, daCustomers, daDogs, daKennels, daBooking, daBookingDet, daBookedKennels;
        DataSet dsInTheDogHouse = new DataSet();
        SqlConnection conn;
        SqlCommand cmdCustomerDetails, cmdDogDetails, cmdKennelDetails;
        SqlCommandBuilder cmdBCustomer, cmdBBooking, cmdBBookingDet, cmdBBookedKennels;


        DataRow drCustomer;

        String sqlNames, sqlCustomerDetails, sqlDogDetails, sqlKennelDetails, sqlBooking, sqlBookingDet, sqlBookedKennels;
        String connStr;

        public frmBooking()
        {
            InitializeComponent();
        }

        public void frmBooking_Load(object sender, EventArgs e)
        {
            lblBookingDate.Text = DateTime.Now.ToShortDateString();
            dtpStartDate.MinDate = DateTime.Now;

            connStr = @"Data Source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";

            conn = new SqlConnection(connStr);

            sqlCustomerDetails = @"select * from Customer order by surname";
            daCustomers = new SqlDataAdapter(sqlCustomerDetails, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomers);
            daCustomers.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomers.Fill(dsInTheDogHouse, "Customer");

            populateCustomers();

            sqlDogDetails = @"select dogNo, name, breedNo, DOB, gender, colour, customerNo from dog where customerNo LIKE @CustNo order by dogNo";
            cmdDogDetails = new SqlCommand(sqlDogDetails, conn);
            cmdDogDetails.Parameters.Add("@CustNo", SqlDbType.Int);
            daDogs = new SqlDataAdapter(cmdDogDetails);
            daDogs.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");

            sqlBookedKennels = @"SELECT booking.bookingNo, dateStart, noDays, dogNo, kennelNo FROM booking JOIN bookingDetail ON booking.bookingNo = bookingDetail.bookingNo order by bookingNo";
            daBookedKennels = new SqlDataAdapter(sqlBookedKennels, conn);
            cmdBBookedKennels = new SqlCommandBuilder(daBookedKennels);
            daBookedKennels.FillSchema(dsInTheDogHouse, SchemaType.Source, "BookedKennels");
            daBookedKennels.Fill(dsInTheDogHouse, "BookedKennels");

        }

        private void populateCustomers()
        {
            int noRows = dsInTheDogHouse.Tables["Customer"].Rows.Count;

            cmbCustomerName.Items.Clear();

            foreach (DataRow dr in dsInTheDogHouse.Tables["Customer"].Rows)
            {
                cmbCustomerName.Items.Add(dr["Surname"].ToString() + ", " + dr["Forename"].ToString() + " (" + dr["CustomerNo"].ToString() + ")");
            }
        }

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CustNo = int.Parse(cmbCustomerName.Text.Substring(cmbCustomerName.Text.Length - 6, 5));
            drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(CustNo);

            lblStreet.Text = drCustomer["Street"].ToString();
            lblTown.Text = drCustomer["Town"].ToString();
            lblPostcode.Text = drCustomer["Postcode"].ToString();
            lblCounty.Text = drCustomer["County"].ToString();

            dtpStartDate.Enabled = true;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            cmbNoDays.Enabled = true;
        }

        private void cmbNoOfDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateDogs();
        }

        private void populateDogs()
        {
            bool ok;

            cmbDogName.Items.Clear();
            cmdDogDetails.Parameters["@CustNo"].Value = int.Parse(cmbCustomerName.Text.Substring(cmbCustomerName.Text.Length - 6, 5));

            daDogs.Fill(dsInTheDogHouse, "Dog");

            pnlDog.Enabled = true;

            DateTime currEndDate = DateTime.Parse(dtpStartDate.Text.Trim());
            currEndDate.AddDays(int.Parse(cmbNoDays.Text));
            
            foreach (DataRow drDog in dsInTheDogHouse.Tables["Dog"].Rows)
            {
                ok = true;

                foreach(DataRow dr in dsInTheDogHouse.Tables["BookedKennels"].Rows)
                {
                    DateTime bookedDate = DateTime.Parse(dr["dateStart"].ToString());
                    if(currEndDate>= bookedDate && currEndDate <= bookedDate.AddDays(int.Parse(dr["noDays"].ToString())))
                    {
                        {
                            if((dr["dogNo"].ToString()==drDog["dogNo"].ToString()))
                            {
                                ok = false;
                            }
                        }
                        if (!ok)
                            break;
                    }
                    if (ok)
                        cmbDogName.Items.Add(drDog["name"].ToString());
                }
            }         
        }

        private void cmbDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlKennel.Enabled = true;
        }
    }
}

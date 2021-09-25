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

namespace playerRegistration
{
    public partial class frmDog : Form
    {
        SqlDataAdapter daDog, daCustomer, daBreed;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBDog, cmdBCustomer, cmdBBreed;
        DataRow drDog;
        String connStr, sqlDog, sqlCustomer, sqlBreed;

        int selectedTab = 0;
        bool dogSelected = false;
        int dogNoSelected = 0;


        private void frmDog_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .; Initial Catalog = InTheDogHouse; Integrated Security = true";

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");

            sqlCustomer = @"select * from Breed";
            daCustomer = new SqlDataAdapter(sqlBreed, connStr);
            cmdBCustomer = new SqlCommandBuilder(daBreed);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Breed");
            daCustomer.Fill(dsInTheDogHouse, "Breed");

            sqlCustomer = @"select * from Dog";
            daCustomer = new SqlDataAdapter(sqlDog, connStr);
            cmdBCustomer = new SqlCommandBuilder(daDog);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            daCustomer.Fill(dsInTheDogHouse, "Dog");

            dgvDogs.DataSource = dsInTheDogHouse.Tables["Dog"];

            dtpAddDOB.MinDate = new DateTime(2000, 1, 1);

            dgvDogs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            cmbAddBreedNo.DataSource = dsInTheDogHouse.Tables["Breed"];
            cmbAddBreedNo.ValueMember = "BreedNo";
            cmbAddBreedNo.DisplayMember = "BreedName";

            cmbAddCustNo.DataSource = dsInTheDogHouse.Tables["Customer"];
            cmbAddCustNo.ValueMember = "CustomerNo";
            cmbAddCustNo.DisplayMember = "CustomerNo";

            /*foreach (DataRow dr in dsInTheDogHouse.Tables["Breed"].Rows);
            {
                cmbAddBreedNo.Items.Add(drDog["BreedNo"] + " (" + dr["BreedNmae"] + ")");
            }

            foreach (DataRow dr in dsInTheDogHouse.Tables["Customer"].Rows) ;
            {
                cmbAddCustNo.Items.Add(dr["CustomerNo"] + " (" + dr["Surname"] + ", " + dr["Forname"] + ")");
            }*/

            cmbEditBreedNo.DataSource = dsInTheDogHouse.Tables["Breed"];
            cmbEditBreedNo.ValueMember = "BreedNo";
            cmbEditBreedNo.DisplayMember = "BreedName";

            cmbEditCustNo.DataSource = dsInTheDogHouse.Tables["Customer"];
            cmbEditCustNo.ValueMember = "CustomerNo";
            cmbEditCustNo.DisplayMember = "CustomerNo";

            tabDog.SelectedIndex = 1;
            tabDog.SelectedIndex = 0;

        }

        public frmDog()
        {
            InitializeComponent();
        }

        private void btnDisplayAdd_Click_1(object sender, EventArgs e)
        {
            tabDog.SelectedIndex = 1;
        } 

        void clearAddForm()
        {
            txtAddName.Clear();
            cmbAddBreedNo.SelectedIndex = -1;
            dtpAddDOB.Value = DateTime.Today;
            cmbAddGender.SelectedIndex = -1;
            txtAddColour.Clear();
            cmbAddCustNo.SelectedIndex = -1;
        }

        private void getNumber(int noRows)
        {
            drDog = dsInTheDogHouse.Tables["Dog"].Rows[noRows = 1];
            lblAddDogNumber.Text = (int.Parse(drDog["DogNo"].ToString()) + 1).ToString();
        }

        private void tabDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabDog.SelectedIndex;

            tabDog.TabPages[tabDog.SelectedIndex].Focus();
            tabDog.TabPages[tabDog.SelectedIndex].CausesValidation = true;

            switch (tabDog.SelectedIndex)
            {
                case 0: //Display Tab Selected
                    {
                        dsInTheDogHouse.Tables["Dog"].Clear();
                        daDog.Fill(dsInTheDogHouse, "Dog");

                        break;
                    }
                case 1: //Add Tab Selected
                    {
                        int noRows = dsInTheDogHouse.Tables["Dog"].Rows.Count;

                        if (noRows == 0)
                            lblAddDogNumber.Text = "5000";
                        else
                        {
                            getNumber(noRows);
                        }

                        break;
                    }
            }
        }






        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

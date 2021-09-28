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

                        errP.Clear();
                        clearAddForm();
                        break;
                    }

                case 2:
                    {
                        if (dogNoSelected == 0)
                        {
                            tabDog.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            lblAddDogNumber.Text = dogNoSelected.ToString();

                            drDog = dsInTheDogHouse.Tables["Dog"].Rows.Find(lblAddDogNumber.Text);

                            if (drDog["Gender"].ToString() == "M")
                                cmbEditGender.SelectedIndex = 0;
                            if (drDog["Gender"].ToString() == "F")
                                cmbEditGender.SelectedIndex = 1;

                            txtEditName.Text = drDog["Name"].ToString();
                            txtEditColour.Text = drDog["Colour"].ToString();

                            cmbEditBreedNo.SelectedIndex = cmbEditBreedNo.FindStringExact(drDog["BreedNo"].ToString());
                            cmbEditBreedNo.Text = drDog["BreedNo"].ToString();
                            dtpAddDOB.Value = Convert.ToDateTime(drDog["DOB"].ToString());
                            cmbEditCustNo.SelectedIndex = cmbEditCustNo.FindStringExact(drDog["CustomerNo"].ToString());

                            break;
                        }
                    }
            }
        }

        private void btnDisplayEdit_Click_1(object sender, EventArgs e)
        {
            tabDog.SelectedIndex = 2;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Dog No: " + lblAddDogNumber.Text + "?", "Add Dog", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                tabDog.SelectedIndex = 0;
        }

        private void btnDisplayDelete_Click_1(object sender, EventArgs e)
        {
            //if(lstCustomers.selectedindices.Count == 0)
            if(dgvDogs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Dog from the list", "Select Dog");
                              
            }
            else
            {
                drDog = dsInTheDogHouse.Tables["Dog"].Rows.Find(dgvDogs.SelectedRows[0].Cells[0].Value);

                string tempName = drDog["Name"].ToString() + "#'S";

                if(MessageBox.Show("Are you sure you want to delete" + tempName + " details", "Add Dog", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drDog.Delete();
                    daDog.Update(dsInTheDogHouse, "Dog");
                }
            }
        }

        void AddTableValidate (object sender, EventArgs e)
        {
            if(dgvDogs.SelectedRows.Count == 0)
            {
                dogSelected = false;
                dogNoSelected = Convert.ToInt32(dgvDogs.SelectedRows[0].Cells[0].Value);
            }
        }

        void EditTabValidate(object sender, EventArgs e)
        {

        }


    }
}

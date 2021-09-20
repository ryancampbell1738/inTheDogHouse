
namespace playerRegistration
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.txtAddTelNo = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtAddPostcode = new System.Windows.Forms.TextBox();
            this.textPostcode = new System.Windows.Forms.TextBox();
            this.txtAddCounty = new System.Windows.Forms.TextBox();
            this.txtAddTown = new System.Windows.Forms.TextBox();
            this.txtAddStreet = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.txtAddForename = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCustmerNo = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnEdit2 = new System.Windows.Forms.Button();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAddCustNo = new System.Windows.Forms.Label();
            this.cmbAddTitle = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tabCustomer.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.tabDisplay);
            this.tabCustomer.Controls.Add(this.tabAdd);
            this.tabCustomer.Controls.Add(this.tabEdit);
            this.tabCustomer.Location = new System.Drawing.Point(16, 116);
            this.tabCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(1035, 548);
            this.tabCustomer.TabIndex = 0;
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.btnExit);
            this.tabDisplay.Controls.Add(this.btnDelete);
            this.tabDisplay.Controls.Add(this.btnEdit);
            this.tabDisplay.Controls.Add(this.btnAdd);
            this.tabDisplay.Controls.Add(this.dgvCustomers);
            this.tabDisplay.Location = new System.Drawing.Point(4, 25);
            this.tabDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDisplay.Size = new System.Drawing.Size(1027, 519);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "Display";
            this.tabDisplay.UseVisualStyleBackColor = true;
            this.tabDisplay.Click += new System.EventHandler(this.tabDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 5;
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(709, 208);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(309, 62);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(133)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(709, 142);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(309, 62);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 5;
            this.btnEdit.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(709, 74);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(309, 62);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(25)))), ((int)(((byte)(91)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 5;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(709, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(309, 62);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(8, 7);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.Size = new System.Drawing.Size(695, 501);
            this.dgvCustomers.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.cmbAddTitle);
            this.tabAdd.Controls.Add(this.lblAddCustNo);
            this.tabAdd.Controls.Add(this.txtAddTelNo);
            this.tabAdd.Controls.Add(this.txtTelephone);
            this.tabAdd.Controls.Add(this.txtAddPostcode);
            this.tabAdd.Controls.Add(this.textPostcode);
            this.tabAdd.Controls.Add(this.txtAddCounty);
            this.tabAdd.Controls.Add(this.txtAddTown);
            this.tabAdd.Controls.Add(this.txtAddStreet);
            this.tabAdd.Controls.Add(this.txtAddSurname);
            this.tabAdd.Controls.Add(this.txtAddForename);
            this.tabAdd.Controls.Add(this.textBox1);
            this.tabAdd.Controls.Add(this.txtCustmerNo);
            this.tabAdd.Controls.Add(this.txtCounty);
            this.tabAdd.Controls.Add(this.txtTown);
            this.tabAdd.Controls.Add(this.txtStreet);
            this.tabAdd.Controls.Add(this.txtSurname);
            this.tabAdd.Controls.Add(this.txtTitle);
            this.tabAdd.Controls.Add(this.txtForename);
            this.tabAdd.Controls.Add(this.btnCancelAdd);
            this.tabAdd.Controls.Add(this.btnAddAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 25);
            this.tabAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAdd.Size = new System.Drawing.Size(1027, 519);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // txtAddTelNo
            // 
            this.txtAddTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTelNo.Location = new System.Drawing.Point(239, 463);
            this.txtAddTelNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddTelNo.Name = "txtAddTelNo";
            this.txtAddTelNo.Size = new System.Drawing.Size(287, 45);
            this.txtAddTelNo.TabIndex = 8;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(7, 468);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(189, 38);
            this.txtTelephone.TabIndex = 7;
            this.txtTelephone.Text = "Telelphone";
            // 
            // txtAddPostcode
            // 
            this.txtAddPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPostcode.Location = new System.Drawing.Point(239, 405);
            this.txtAddPostcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddPostcode.Name = "txtAddPostcode";
            this.txtAddPostcode.Size = new System.Drawing.Size(287, 45);
            this.txtAddPostcode.TabIndex = 8;
            // 
            // textPostcode
            // 
            this.textPostcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPostcode.Location = new System.Drawing.Point(7, 410);
            this.textPostcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPostcode.Name = "textPostcode";
            this.textPostcode.Size = new System.Drawing.Size(168, 38);
            this.textPostcode.TabIndex = 7;
            this.textPostcode.Text = "Postcode";
            // 
            // txtAddCounty
            // 
            this.txtAddCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCounty.Location = new System.Drawing.Point(239, 342);
            this.txtAddCounty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddCounty.Name = "txtAddCounty";
            this.txtAddCounty.Size = new System.Drawing.Size(287, 45);
            this.txtAddCounty.TabIndex = 6;
            // 
            // txtAddTown
            // 
            this.txtAddTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTown.Location = new System.Drawing.Point(239, 279);
            this.txtAddTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddTown.Name = "txtAddTown";
            this.txtAddTown.Size = new System.Drawing.Size(287, 45);
            this.txtAddTown.TabIndex = 6;
            // 
            // txtAddStreet
            // 
            this.txtAddStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStreet.Location = new System.Drawing.Point(239, 217);
            this.txtAddStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddStreet.Name = "txtAddStreet";
            this.txtAddStreet.Size = new System.Drawing.Size(287, 45);
            this.txtAddStreet.TabIndex = 6;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSurname.Location = new System.Drawing.Point(239, 154);
            this.txtAddSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(287, 45);
            this.txtAddSurname.TabIndex = 6;
            // 
            // txtAddForename
            // 
            this.txtAddForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddForename.Location = new System.Drawing.Point(239, 90);
            this.txtAddForename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddForename.Name = "txtAddForename";
            this.txtAddForename.Size = new System.Drawing.Size(287, 45);
            this.txtAddForename.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(239, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 38);
            this.textBox1.TabIndex = 6;
            // 
            // txtCustmerNo
            // 
            this.txtCustmerNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustmerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustmerNo.Location = new System.Drawing.Point(7, 23);
            this.txtCustmerNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustmerNo.Name = "txtCustmerNo";
            this.txtCustmerNo.Size = new System.Drawing.Size(227, 38);
            this.txtCustmerNo.TabIndex = 4;
            this.txtCustmerNo.Text = "Customer No";
            // 
            // txtCounty
            // 
            this.txtCounty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(7, 347);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(168, 38);
            this.txtCounty.TabIndex = 4;
            this.txtCounty.Text = "County";
            this.txtCounty.TextChanged += new System.EventHandler(this.txtKitNumber_TextChanged);
            // 
            // txtTown
            // 
            this.txtTown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(7, 286);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(168, 38);
            this.txtTown.TabIndex = 4;
            this.txtTown.Text = "Town";
            // 
            // txtStreet
            // 
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(7, 224);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(168, 38);
            this.txtStreet.TabIndex = 4;
            this.txtStreet.Text = "Street";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(7, 154);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(168, 38);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.Text = "Surname";
            // 
            // txtForename
            // 
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(7, 90);
            this.txtForename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(168, 38);
            this.txtForename.TabIndex = 4;
            this.txtForename.Text = "Forename";
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancelAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelAdd.FlatAppearance.BorderSize = 5;
            this.btnCancelAdd.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCancelAdd.Location = new System.Drawing.Point(709, 74);
            this.btnCancelAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(309, 62);
            this.btnCancelAdd.TabIndex = 2;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(25)))), ((int)(((byte)(91)))));
            this.btnAddAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAdd.FlatAppearance.BorderSize = 5;
            this.btnAddAdd.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdd.ForeColor = System.Drawing.Color.White;
            this.btnAddAdd.Location = new System.Drawing.Point(709, 7);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(309, 62);
            this.btnAddAdd.TabIndex = 3;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = false;
            this.btnAddAdd.Click += new System.EventHandler(this.btnAddAdd_Click);
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.textBox26);
            this.tabEdit.Controls.Add(this.textBox27);
            this.tabEdit.Controls.Add(this.textBox7);
            this.tabEdit.Controls.Add(this.textBox8);
            this.tabEdit.Controls.Add(this.textBox9);
            this.tabEdit.Controls.Add(this.textBox10);
            this.tabEdit.Controls.Add(this.textBox11);
            this.tabEdit.Controls.Add(this.textBox12);
            this.tabEdit.Controls.Add(this.textBox13);
            this.tabEdit.Controls.Add(this.textBox14);
            this.tabEdit.Controls.Add(this.textBox15);
            this.tabEdit.Controls.Add(this.textBox16);
            this.tabEdit.Controls.Add(this.textBox17);
            this.tabEdit.Controls.Add(this.textBox18);
            this.tabEdit.Controls.Add(this.textBox21);
            this.tabEdit.Controls.Add(this.textBox22);
            this.tabEdit.Controls.Add(this.btnCancel2);
            this.tabEdit.Controls.Add(this.btnEdit2);
            this.tabEdit.Location = new System.Drawing.Point(4, 25);
            this.tabEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEdit.Size = new System.Drawing.Size(1027, 519);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            this.tabEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // textBox26
            // 
            this.textBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.Location = new System.Drawing.Point(241, 463);
            this.textBox26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(287, 45);
            this.textBox26.TabIndex = 24;
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox27.Location = new System.Drawing.Point(9, 468);
            this.textBox27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(189, 38);
            this.textBox27.TabIndex = 23;
            this.textBox27.Text = "Telelphone";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(241, 404);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(287, 45);
            this.textBox7.TabIndex = 22;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(9, 409);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(168, 38);
            this.textBox8.TabIndex = 21;
            this.textBox8.Text = "Postcode";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(241, 341);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(287, 45);
            this.textBox9.TabIndex = 15;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(241, 278);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(287, 45);
            this.textBox10.TabIndex = 16;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(241, 215);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(287, 45);
            this.textBox11.TabIndex = 17;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(241, 153);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(287, 45);
            this.textBox12.TabIndex = 18;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(241, 89);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(287, 45);
            this.textBox13.TabIndex = 19;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(241, 22);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(288, 38);
            this.textBox14.TabIndex = 20;
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(9, 22);
            this.textBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(227, 38);
            this.textBox15.TabIndex = 9;
            this.textBox15.Text = "Customer No";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(9, 346);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(168, 38);
            this.textBox16.TabIndex = 10;
            this.textBox16.Text = "County";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(9, 284);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(168, 38);
            this.textBox17.TabIndex = 11;
            this.textBox17.Text = "Town";
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(9, 223);
            this.textBox18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(168, 38);
            this.textBox18.TabIndex = 12;
            this.textBox18.Text = "Street";
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.Location = new System.Drawing.Point(9, 153);
            this.textBox21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(168, 38);
            this.textBox21.TabIndex = 13;
            this.textBox21.Text = "Surname";
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(9, 89);
            this.textBox22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(168, 38);
            this.textBox22.TabIndex = 14;
            this.textBox22.Text = "Forename";
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancel2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel2.FlatAppearance.BorderSize = 5;
            this.btnCancel2.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.ForeColor = System.Drawing.Color.Black;
            this.btnCancel2.Location = new System.Drawing.Point(709, 74);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(309, 62);
            this.btnCancel2.TabIndex = 4;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = false;
            // 
            // btnEdit2
            // 
            this.btnEdit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(25)))), ((int)(((byte)(91)))));
            this.btnEdit2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit2.FlatAppearance.BorderSize = 5;
            this.btnEdit2.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit2.ForeColor = System.Drawing.Color.White;
            this.btnEdit2.Location = new System.Drawing.Point(709, 7);
            this.btnEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(309, 62);
            this.btnEdit2.TabIndex = 5;
            this.btnEdit2.Text = "Edit";
            this.btnEdit2.UseVisualStyleBackColor = false;
            // 
            // txtHeading
            // 
            this.txtHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.Location = new System.Drawing.Point(167, 6);
            this.txtHeading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(739, 102);
            this.txtHeading.TabIndex = 9;
            this.txtHeading.Text = "In The Dog House";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // lblAddCustNo
            // 
            this.lblAddCustNo.AutoSize = true;
            this.lblAddCustNo.Location = new System.Drawing.Point(251, 40);
            this.lblAddCustNo.Name = "lblAddCustNo";
            this.lblAddCustNo.Size = new System.Drawing.Size(0, 17);
            this.lblAddCustNo.TabIndex = 9;
            // 
            // cmbAddTitle
            // 
            this.cmbAddTitle.FormattingEnabled = true;
            this.cmbAddTitle.Location = new System.Drawing.Point(743, 323);
            this.cmbAddTitle.Name = "cmbAddTitle";
            this.cmbAddTitle.Size = new System.Drawing.Size(121, 24);
            this.cmbAddTitle.TabIndex = 10;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(601, 308);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(168, 38);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "Title";
            this.txtTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::playerRegistration.Properties.Resources.premier_league_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 678);
            this.Controls.Add(this.tabCustomer);
            this.Controls.Add(this.txtHeading);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In The Dog House";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.tabCustomer.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnEdit2;
        private System.Windows.Forms.TextBox txtAddCounty;
        private System.Windows.Forms.TextBox txtAddTown;
        private System.Windows.Forms.TextBox txtAddStreet;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.TextBox txtAddForename;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCustmerNo;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtAddTelNo;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtAddPostcode;
        private System.Windows.Forms.TextBox textPostcode;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Label lblAddCustNo;
        private System.Windows.Forms.ComboBox cmbAddTitle;
        private System.Windows.Forms.TextBox txtTitle;
    }
}


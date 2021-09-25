
namespace playerRegistration
{
    partial class frmDog
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
            this.tabDog = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplayEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDogs = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.lblAddDogNumber = new System.Windows.Forms.Label();
            this.cmbAddCustNo = new System.Windows.Forms.ComboBox();
            this.dtpAddDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbAddGender = new System.Windows.Forms.ComboBox();
            this.cmbAddBreedNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddColour = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.txtaddBreed = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEditCustNo = new System.Windows.Forms.ComboBox();
            this.dtpEditDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbEditGender = new System.Windows.Forms.ComboBox();
            this.cmbEditBreedNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditColour = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditEdit = new System.Windows.Forms.Button();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabDog.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogs)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDog
            // 
            this.tabDog.Controls.Add(this.tabDisplay);
            this.tabDog.Controls.Add(this.tabAdd);
            this.tabDog.Controls.Add(this.tabEdit);
            this.tabDog.Location = new System.Drawing.Point(16, 113);
            this.tabDog.Margin = new System.Windows.Forms.Padding(4);
            this.tabDog.Name = "tabDog";
            this.tabDog.SelectedIndex = 0;
            this.tabDog.Size = new System.Drawing.Size(1024, 550);
            this.tabDog.TabIndex = 0;
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.btnExit);
            this.tabDisplay.Controls.Add(this.btnDelete);
            this.tabDisplay.Controls.Add(this.btnDisplayEdit);
            this.tabDisplay.Controls.Add(this.btnAdd);
            this.tabDisplay.Controls.Add(this.dgvDogs);
            this.tabDisplay.Location = new System.Drawing.Point(4, 25);
            this.tabDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(4);
            this.tabDisplay.Size = new System.Drawing.Size(1016, 521);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "Display";
            this.tabDisplay.UseVisualStyleBackColor = true;
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
            this.btnExit.Size = new System.Drawing.Size(297, 62);
            this.btnExit.TabIndex = 2;
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
            this.btnDelete.Size = new System.Drawing.Size(297, 62);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnDisplayEdit
            // 
            this.btnDisplayEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnDisplayEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDisplayEdit.FlatAppearance.BorderSize = 5;
            this.btnDisplayEdit.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayEdit.ForeColor = System.Drawing.Color.Black;
            this.btnDisplayEdit.Location = new System.Drawing.Point(709, 74);
            this.btnDisplayEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplayEdit.Name = "btnDisplayEdit";
            this.btnDisplayEdit.Size = new System.Drawing.Size(297, 62);
            this.btnDisplayEdit.TabIndex = 4;
            this.btnDisplayEdit.Text = "Edit";
            this.btnDisplayEdit.UseVisualStyleBackColor = false;
            this.btnDisplayEdit.Click += new System.EventHandler(this.btnDisplayEdit_Click_1);
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
            this.btnAdd.Size = new System.Drawing.Size(297, 62);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvDogs
            // 
            this.dgvDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogs.Location = new System.Drawing.Point(8, 7);
            this.dgvDogs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDogs.Name = "dgvDogs";
            this.dgvDogs.RowHeadersWidth = 51;
            this.dgvDogs.Size = new System.Drawing.Size(695, 501);
            this.dgvDogs.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.lblAddDogNumber);
            this.tabAdd.Controls.Add(this.cmbAddCustNo);
            this.tabAdd.Controls.Add(this.dtpAddDOB);
            this.tabAdd.Controls.Add(this.cmbAddGender);
            this.tabAdd.Controls.Add(this.cmbAddBreedNo);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.Controls.Add(this.txtAddColour);
            this.tabAdd.Controls.Add(this.txtAddName);
            this.tabAdd.Controls.Add(this.textBox11);
            this.tabAdd.Controls.Add(this.textBox12);
            this.tabAdd.Controls.Add(this.textBox13);
            this.tabAdd.Controls.Add(this.textBox14);
            this.tabAdd.Controls.Add(this.txtaddBreed);
            this.tabAdd.Controls.Add(this.textBox16);
            this.tabAdd.Controls.Add(this.textBox17);
            this.tabAdd.Controls.Add(this.btnCancelAdd);
            this.tabAdd.Controls.Add(this.btnAddAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 25);
            this.tabAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(4);
            this.tabAdd.Size = new System.Drawing.Size(1016, 521);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // lblAddDogNumber
            // 
            this.lblAddDogNumber.AutoSize = true;
            this.lblAddDogNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDogNumber.Location = new System.Drawing.Point(243, 9);
            this.lblAddDogNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddDogNumber.Name = "lblAddDogNumber";
            this.lblAddDogNumber.Size = new System.Drawing.Size(0, 29);
            this.lblAddDogNumber.TabIndex = 37;
            // 
            // cmbAddCustNo
            // 
            this.cmbAddCustNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddCustNo.FormattingEnabled = true;
            this.cmbAddCustNo.Location = new System.Drawing.Point(239, 258);
            this.cmbAddCustNo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAddCustNo.Name = "cmbAddCustNo";
            this.cmbAddCustNo.Size = new System.Drawing.Size(287, 34);
            this.cmbAddCustNo.TabIndex = 36;
            // 
            // dtpAddDOB
            // 
            this.dtpAddDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddDOB.Location = new System.Drawing.Point(239, 133);
            this.dtpAddDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAddDOB.Name = "dtpAddDOB";
            this.dtpAddDOB.Size = new System.Drawing.Size(287, 32);
            this.dtpAddDOB.TabIndex = 35;
            // 
            // cmbAddGender
            // 
            this.cmbAddGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddGender.FormattingEnabled = true;
            this.cmbAddGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbAddGender.Location = new System.Drawing.Point(239, 174);
            this.cmbAddGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAddGender.Name = "cmbAddGender";
            this.cmbAddGender.Size = new System.Drawing.Size(287, 34);
            this.cmbAddGender.TabIndex = 34;
            // 
            // cmbAddBreedNo
            // 
            this.cmbAddBreedNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddBreedNo.FormattingEnabled = true;
            this.cmbAddBreedNo.Items.AddRange(new object[] {
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211"});
            this.cmbAddBreedNo.Location = new System.Drawing.Point(239, 91);
            this.cmbAddBreedNo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAddBreedNo.Name = "cmbAddBreedNo";
            this.cmbAddBreedNo.Size = new System.Drawing.Size(287, 34);
            this.cmbAddBreedNo.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 33;
            // 
            // txtAddColour
            // 
            this.txtAddColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddColour.Location = new System.Drawing.Point(239, 215);
            this.txtAddColour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddColour.Name = "txtAddColour";
            this.txtAddColour.Size = new System.Drawing.Size(287, 36);
            this.txtAddColour.TabIndex = 28;
            // 
            // txtAddName
            // 
            this.txtAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddName.Location = new System.Drawing.Point(239, 48);
            this.txtAddName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(287, 36);
            this.txtAddName.TabIndex = 32;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(3, 257);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(231, 29);
            this.textBox11.TabIndex = 21;
            this.textBox11.Text = "Customer Number";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(3, 215);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(168, 29);
            this.textBox12.TabIndex = 22;
            this.textBox12.Text = "Colour";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(7, 174);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(168, 29);
            this.textBox13.TabIndex = 23;
            this.textBox13.Text = "Gender";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(7, 132);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(168, 29);
            this.textBox14.TabIndex = 24;
            this.textBox14.Text = "DOB";
            // 
            // txtaddBreed
            // 
            this.txtaddBreed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaddBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddBreed.Location = new System.Drawing.Point(7, 90);
            this.txtaddBreed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtaddBreed.Name = "txtaddBreed";
            this.txtaddBreed.Size = new System.Drawing.Size(168, 29);
            this.txtaddBreed.TabIndex = 25;
            this.txtaddBreed.Text = "BreedNo";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(7, 48);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(168, 29);
            this.textBox16.TabIndex = 26;
            this.textBox16.Text = "Name";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(7, 6);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(227, 29);
            this.textBox17.TabIndex = 20;
            this.textBox17.Text = "Dog Number";
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancelAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelAdd.FlatAppearance.BorderSize = 5;
            this.btnCancelAdd.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCancelAdd.Location = new System.Drawing.Point(697, 73);
            this.btnCancelAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(309, 62);
            this.btnCancelAdd.TabIndex = 4;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(25)))), ((int)(((byte)(91)))));
            this.btnAddAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAdd.FlatAppearance.BorderSize = 5;
            this.btnAddAdd.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdd.ForeColor = System.Drawing.Color.White;
            this.btnAddAdd.Location = new System.Drawing.Point(697, 6);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(309, 62);
            this.btnAddAdd.TabIndex = 5;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = false;
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.label2);
            this.tabEdit.Controls.Add(this.cmbEditCustNo);
            this.tabEdit.Controls.Add(this.dtpEditDOB);
            this.tabEdit.Controls.Add(this.cmbEditGender);
            this.tabEdit.Controls.Add(this.cmbEditBreedNo);
            this.tabEdit.Controls.Add(this.label3);
            this.tabEdit.Controls.Add(this.txtEditColour);
            this.tabEdit.Controls.Add(this.txtEditName);
            this.tabEdit.Controls.Add(this.textBox3);
            this.tabEdit.Controls.Add(this.textBox4);
            this.tabEdit.Controls.Add(this.textBox5);
            this.tabEdit.Controls.Add(this.textBox6);
            this.tabEdit.Controls.Add(this.textBox7);
            this.tabEdit.Controls.Add(this.textBox8);
            this.tabEdit.Controls.Add(this.textBox9);
            this.tabEdit.Controls.Add(this.btnEditCancel);
            this.tabEdit.Controls.Add(this.btnEditEdit);
            this.tabEdit.Location = new System.Drawing.Point(4, 25);
            this.tabEdit.Margin = new System.Windows.Forms.Padding(4);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(4);
            this.tabEdit.Size = new System.Drawing.Size(1016, 521);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 52;
            // 
            // cmbEditCustNo
            // 
            this.cmbEditCustNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditCustNo.FormattingEnabled = true;
            this.cmbEditCustNo.Location = new System.Drawing.Point(239, 258);
            this.cmbEditCustNo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEditCustNo.Name = "cmbEditCustNo";
            this.cmbEditCustNo.Size = new System.Drawing.Size(287, 34);
            this.cmbEditCustNo.TabIndex = 51;
            // 
            // dtpEditDOB
            // 
            this.dtpEditDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEditDOB.Location = new System.Drawing.Point(239, 133);
            this.dtpEditDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEditDOB.Name = "dtpEditDOB";
            this.dtpEditDOB.Size = new System.Drawing.Size(287, 32);
            this.dtpEditDOB.TabIndex = 50;
            // 
            // cmbEditGender
            // 
            this.cmbEditGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditGender.FormattingEnabled = true;
            this.cmbEditGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbEditGender.Location = new System.Drawing.Point(239, 174);
            this.cmbEditGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEditGender.Name = "cmbEditGender";
            this.cmbEditGender.Size = new System.Drawing.Size(287, 34);
            this.cmbEditGender.TabIndex = 48;
            // 
            // cmbEditBreedNo
            // 
            this.cmbEditBreedNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditBreedNo.FormattingEnabled = true;
            this.cmbEditBreedNo.Items.AddRange(new object[] {
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211"});
            this.cmbEditBreedNo.Location = new System.Drawing.Point(239, 91);
            this.cmbEditBreedNo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEditBreedNo.Name = "cmbEditBreedNo";
            this.cmbEditBreedNo.Size = new System.Drawing.Size(287, 34);
            this.cmbEditBreedNo.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 47;
            // 
            // txtEditColour
            // 
            this.txtEditColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditColour.Location = new System.Drawing.Point(239, 215);
            this.txtEditColour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditColour.Name = "txtEditColour";
            this.txtEditColour.Size = new System.Drawing.Size(287, 36);
            this.txtEditColour.TabIndex = 45;
            // 
            // txtEditName
            // 
            this.txtEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditName.Location = new System.Drawing.Point(239, 48);
            this.txtEditName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(287, 36);
            this.txtEditName.TabIndex = 46;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 257);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 29);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = "Customer Number";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(3, 215);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 29);
            this.textBox4.TabIndex = 40;
            this.textBox4.Text = "Colour";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(7, 174);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 29);
            this.textBox5.TabIndex = 41;
            this.textBox5.Text = "Gender";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(7, 132);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 29);
            this.textBox6.TabIndex = 42;
            this.textBox6.Text = "DOB";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(7, 90);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(168, 29);
            this.textBox7.TabIndex = 43;
            this.textBox7.Text = "Breed No";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(7, 48);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(168, 29);
            this.textBox8.TabIndex = 44;
            this.textBox8.Text = "Name";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(7, 6);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(227, 29);
            this.textBox9.TabIndex = 38;
            this.textBox9.Text = "Dog Number";
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnEditCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditCancel.FlatAppearance.BorderSize = 5;
            this.btnEditCancel.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.ForeColor = System.Drawing.Color.Black;
            this.btnEditCancel.Location = new System.Drawing.Point(697, 73);
            this.btnEditCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(309, 62);
            this.btnEditCancel.TabIndex = 6;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            // 
            // btnEditEdit
            // 
            this.btnEditEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(25)))), ((int)(((byte)(91)))));
            this.btnEditEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditEdit.FlatAppearance.BorderSize = 5;
            this.btnEditEdit.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEdit.ForeColor = System.Drawing.Color.White;
            this.btnEditEdit.Location = new System.Drawing.Point(697, 6);
            this.btnEditEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditEdit.Name = "btnEditEdit";
            this.btnEditEdit.Size = new System.Drawing.Size(309, 62);
            this.btnEditEdit.TabIndex = 7;
            this.btnEditEdit.Text = "Edit";
            this.btnEditEdit.UseVisualStyleBackColor = false;
            // 
            // txtHeading
            // 
            this.txtHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.Location = new System.Drawing.Point(167, 6);
            this.txtHeading.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(739, 102);
            this.txtHeading.TabIndex = 10;
            this.txtHeading.Text = "In The Dog House";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::playerRegistration.Properties.Resources.premier_league_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 678);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.tabDog);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDog";
            this.Text = "frmDog";
            this.Load += new System.EventHandler(this.frmDog_Load);
            this.tabDog.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogs)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabDog;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.DataGridView dgvDogs;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplayEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddColour;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox txtaddBreed;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.ComboBox cmbAddCustNo;
        private System.Windows.Forms.DateTimePicker dtpAddDOB;
        private System.Windows.Forms.ComboBox cmbAddGender;
        private System.Windows.Forms.ComboBox cmbAddBreedNo;
        private System.Windows.Forms.Label lblAddDogNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEditCustNo;
        private System.Windows.Forms.DateTimePicker dtpEditDOB;
        private System.Windows.Forms.ComboBox cmbEditGender;
        private System.Windows.Forms.ComboBox cmbEditBreedNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditColour;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
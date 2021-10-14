
namespace playerRegistration
{
    partial class frmBooking
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
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.cmbNoDays = new System.Windows.Forms.ComboBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDogName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlKennel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbKennelNo = new System.Windows.Forms.ComboBox();
            this.pnlDog = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvKennel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlKennel.SuspendLayout();
            this.pnlDog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKennel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHeading
            // 
            this.txtHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.Location = new System.Drawing.Point(125, 12);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(555, 83);
            this.txtHeading.TabIndex = 9;
            this.txtHeading.Text = "In The Dog House";
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblBookingDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblPostcode);
            this.panel1.Controls.Add(this.lblCounty);
            this.panel1.Controls.Add(this.lblTown);
            this.panel1.Controls.Add(this.lblStreet);
            this.panel1.Controls.Add(this.cmbNoDays);
            this.panel1.Controls.Add(this.cmbCustomerName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 215);
            this.panel1.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(503, 51);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(136, 20);
            this.dtpStartDate.TabIndex = 3;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(158, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(158, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "-";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(499, 19);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(0, 20);
            this.lblBookingDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "-";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(177, 113);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(0, 20);
            this.lblPostcode.TabIndex = 2;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(177, 93);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(0, 20);
            this.lblCounty.TabIndex = 2;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(177, 73);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(0, 20);
            this.lblTown.TabIndex = 2;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(177, 53);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(0, 20);
            this.lblStreet.TabIndex = 2;
            // 
            // cmbNoDays
            // 
            this.cmbNoDays.AllowDrop = true;
            this.cmbNoDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNoDays.FormattingEnabled = true;
            this.cmbNoDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbNoDays.Location = new System.Drawing.Point(503, 85);
            this.cmbNoDays.Name = "cmbNoDays";
            this.cmbNoDays.Size = new System.Drawing.Size(136, 24);
            this.cmbNoDays.TabIndex = 1;
            this.cmbNoDays.SelectedIndexChanged += new System.EventHandler(this.cmbNoOfDays_SelectedIndexChanged);
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(180, 17);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(169, 24);
            this.cmbCustomerName.TabIndex = 1;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(364, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "No of Days";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(364, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Start Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(364, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Booking Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // cmbDogName
            // 
            this.cmbDogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDogName.FormattingEnabled = true;
            this.cmbDogName.Location = new System.Drawing.Point(152, 19);
            this.cmbDogName.Name = "cmbDogName";
            this.cmbDogName.Size = new System.Drawing.Size(280, 24);
            this.cmbDogName.TabIndex = 1;
            this.cmbDogName.Click += new System.EventHandler(this.cmbDog_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Dog Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmbDogName);
            this.panel2.Location = new System.Drawing.Point(12, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 60);
            this.panel2.TabIndex = 11;
            // 
            // pnlKennel
            // 
            this.pnlKennel.BackColor = System.Drawing.Color.White;
            this.pnlKennel.Controls.Add(this.label14);
            this.pnlKennel.Controls.Add(this.cmbKennelNo);
            this.pnlKennel.Location = new System.Drawing.Point(12, 426);
            this.pnlKennel.Name = "pnlKennel";
            this.pnlKennel.Size = new System.Drawing.Size(668, 56);
            this.pnlKennel.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Kennel No";
            // 
            // cmbKennelNo
            // 
            this.cmbKennelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKennelNo.FormattingEnabled = true;
            this.cmbKennelNo.Location = new System.Drawing.Point(152, 19);
            this.cmbKennelNo.Name = "cmbKennelNo";
            this.cmbKennelNo.Size = new System.Drawing.Size(280, 24);
            this.cmbKennelNo.TabIndex = 1;
            // 
            // pnlDog
            // 
            this.pnlDog.BackColor = System.Drawing.Color.White;
            this.pnlDog.Controls.Add(this.btnAdd);
            this.pnlDog.Controls.Add(this.dgvKennel);
            this.pnlDog.Location = new System.Drawing.Point(12, 499);
            this.pnlDog.Name = "pnlDog";
            this.pnlDog.Size = new System.Drawing.Size(668, 182);
            this.pnlDog.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(463, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvKennel
            // 
            this.dgvKennel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKennel.Location = new System.Drawing.Point(4, 3);
            this.dgvKennel.Name = "dgvKennel";
            this.dgvKennel.Size = new System.Drawing.Size(428, 176);
            this.dgvKennel.TabIndex = 0;
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::playerRegistration.Properties.Resources.premier_league_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 693);
            this.Controls.Add(this.pnlDog);
            this.Controls.Add(this.pnlKennel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtHeading);
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In The Dog House";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlKennel.ResumeLayout(false);
            this.pnlKennel.PerformLayout();
            this.pnlDog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKennel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.ComboBox cmbNoDays;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlDog;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvKennel;
        private System.Windows.Forms.Panel pnlKennel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbKennelNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbDogName;
    }
}


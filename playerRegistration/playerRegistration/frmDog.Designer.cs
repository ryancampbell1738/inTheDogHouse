
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
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnEdit2 = new System.Windows.Forms.Button();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.txtAddBreedNo = new System.Windows.Forms.TextBox();
            this.txtBreedNo = new System.Windows.Forms.TextBox();
            this.txtAddSize = new System.Windows.Forms.TextBox();
            this.txtAddBreedName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtBreedName = new System.Windows.Forms.TextBox();
            this.txtEditSize = new System.Windows.Forms.TextBox();
            this.txtEditBreedName = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblEditBreedNo = new System.Windows.Forms.Label();
            this.tabView.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabDisplay);
            this.tabView.Controls.Add(this.tabAdd);
            this.tabView.Controls.Add(this.tabEdit);
            this.tabView.Location = new System.Drawing.Point(12, 92);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(768, 447);
            this.tabView.TabIndex = 0;
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.btnExit);
            this.tabDisplay.Controls.Add(this.btnDelete);
            this.tabDisplay.Controls.Add(this.btnEdit);
            this.tabDisplay.Controls.Add(this.btnAdd);
            this.tabDisplay.Controls.Add(this.dataGridView1);
            this.tabDisplay.Location = new System.Drawing.Point(4, 22);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(760, 421);
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
            this.btnExit.Location = new System.Drawing.Point(532, 169);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(133)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 5;
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(532, 115);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(223, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 5;
            this.btnEdit.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(532, 60);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(223, 50);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(25)))), ((int)(((byte)(91)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 5;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(532, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(223, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.txtAddSize);
            this.tabAdd.Controls.Add(this.txtAddBreedName);
            this.tabAdd.Controls.Add(this.txtSize);
            this.tabAdd.Controls.Add(this.txtBreedName);
            this.tabAdd.Controls.Add(this.txtAddBreedNo);
            this.tabAdd.Controls.Add(this.txtBreedNo);
            this.tabAdd.Controls.Add(this.btnCancelAdd);
            this.tabAdd.Controls.Add(this.btnAddAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(760, 421);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancelAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelAdd.FlatAppearance.BorderSize = 5;
            this.btnCancelAdd.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCancelAdd.Location = new System.Drawing.Point(523, 59);
            this.btnCancelAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(232, 50);
            this.btnCancelAdd.TabIndex = 4;
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
            this.btnAddAdd.Location = new System.Drawing.Point(523, 5);
            this.btnAddAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(232, 50);
            this.btnAddAdd.TabIndex = 5;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = false;
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.lblEditBreedNo);
            this.tabEdit.Controls.Add(this.txtEditSize);
            this.tabEdit.Controls.Add(this.txtEditBreedName);
            this.tabEdit.Controls.Add(this.textBox3);
            this.tabEdit.Controls.Add(this.textBox4);
            this.tabEdit.Controls.Add(this.textBox6);
            this.tabEdit.Controls.Add(this.btnCancel2);
            this.tabEdit.Controls.Add(this.btnEdit2);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(760, 421);
            this.tabEdit.TabIndex = 2;
            this.tabEdit.Text = "Edit";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancel2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel2.FlatAppearance.BorderSize = 5;
            this.btnCancel2.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.ForeColor = System.Drawing.Color.Black;
            this.btnCancel2.Location = new System.Drawing.Point(523, 59);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(232, 50);
            this.btnCancel2.TabIndex = 6;
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
            this.btnEdit2.Location = new System.Drawing.Point(523, 5);
            this.btnEdit2.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(232, 50);
            this.btnEdit2.TabIndex = 7;
            this.btnEdit2.Text = "Edit";
            this.btnEdit2.UseVisualStyleBackColor = false;
            // 
            // txtHeading
            // 
            this.txtHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.Location = new System.Drawing.Point(125, 5);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(555, 83);
            this.txtHeading.TabIndex = 10;
            this.txtHeading.Text = "In The Dog House";
            // 
            // txtAddBreedNo
            // 
            this.txtAddBreedNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddBreedNo.Location = new System.Drawing.Point(179, 5);
            this.txtAddBreedNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddBreedNo.Name = "txtAddBreedNo";
            this.txtAddBreedNo.Size = new System.Drawing.Size(216, 30);
            this.txtAddBreedNo.TabIndex = 8;
            // 
            // txtBreedNo
            // 
            this.txtBreedNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBreedNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreedNo.Location = new System.Drawing.Point(5, 5);
            this.txtBreedNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBreedNo.Name = "txtBreedNo";
            this.txtBreedNo.Size = new System.Drawing.Size(170, 23);
            this.txtBreedNo.TabIndex = 7;
            this.txtBreedNo.Text = "BreedNo";
            // 
            // txtAddSize
            // 
            this.txtAddSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSize.Location = new System.Drawing.Point(179, 73);
            this.txtAddSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddSize.Name = "txtAddSize";
            this.txtAddSize.Size = new System.Drawing.Size(216, 30);
            this.txtAddSize.TabIndex = 11;
            // 
            // txtAddBreedName
            // 
            this.txtAddBreedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddBreedName.Location = new System.Drawing.Point(179, 39);
            this.txtAddBreedName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddBreedName.Name = "txtAddBreedName";
            this.txtAddBreedName.Size = new System.Drawing.Size(216, 30);
            this.txtAddBreedName.TabIndex = 12;
            // 
            // txtSize
            // 
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(5, 73);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(126, 23);
            this.txtSize.TabIndex = 9;
            this.txtSize.Text = "Size";
            // 
            // txtBreedName
            // 
            this.txtBreedName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBreedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreedName.Location = new System.Drawing.Point(5, 39);
            this.txtBreedName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBreedName.Name = "txtBreedName";
            this.txtBreedName.Size = new System.Drawing.Size(126, 23);
            this.txtBreedName.TabIndex = 10;
            this.txtBreedName.Text = "Breed Name";
            // 
            // txtEditSize
            // 
            this.txtEditSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSize.Location = new System.Drawing.Point(179, 73);
            this.txtEditSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditSize.Name = "txtEditSize";
            this.txtEditSize.Size = new System.Drawing.Size(216, 30);
            this.txtEditSize.TabIndex = 17;
            // 
            // txtEditBreedName
            // 
            this.txtEditBreedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditBreedName.Location = new System.Drawing.Point(179, 39);
            this.txtEditBreedName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditBreedName.Name = "txtEditBreedName";
            this.txtEditBreedName.Size = new System.Drawing.Size(216, 30);
            this.txtEditBreedName.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(5, 73);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 23);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "Size";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(5, 39);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 23);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "Breed Name";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(5, 5);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(170, 23);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "BreedNo";
            // 
            // lblEditBreedNo
            // 
            this.lblEditBreedNo.AutoSize = true;
            this.lblEditBreedNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditBreedNo.Location = new System.Drawing.Point(180, 5);
            this.lblEditBreedNo.Name = "lblEditBreedNo";
            this.lblEditBreedNo.Size = new System.Drawing.Size(0, 25);
            this.lblEditBreedNo.TabIndex = 19;
            // 
            // frmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::playerRegistration.Properties.Resources.premier_league_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 551);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.tabView);
            this.Name = "frmDog";
            this.Text = "frmDog";
            this.tabView.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnEdit2;
        private System.Windows.Forms.TextBox txtAddBreedNo;
        private System.Windows.Forms.TextBox txtBreedNo;
        private System.Windows.Forms.TextBox txtAddSize;
        private System.Windows.Forms.TextBox txtAddBreedName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtBreedName;
        private System.Windows.Forms.Label lblEditBreedNo;
        private System.Windows.Forms.TextBox txtEditSize;
        private System.Windows.Forms.TextBox txtEditBreedName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
    }
}
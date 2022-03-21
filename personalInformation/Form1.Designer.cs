namespace personalInformation
{
    partial class frmPersonal_information
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCarBrand = new System.Windows.Forms.Label();
            this.cmbCarBrand = new System.Windows.Forms.ComboBox();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAgeDisplay = new System.Windows.Forms.Label();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.dtRentalDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblDepositDisplay = new System.Windows.Forms.Label();
            this.lblLateReturn = new System.Windows.Forms.Label();
            this.dtLateReturn = new System.Windows.Forms.DateTimePicker();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceDisplay = new System.Windows.Forms.Label();
            this.lblDollarSign2 = new System.Windows.Forms.Label();
            this.lblDollarSign = new System.Windows.Forms.Label();
            this.lblDollarSign3 = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(142, 34);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(142, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(44, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(41, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(41, 65);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.AutoSize = true;
            this.lblCarBrand.Location = new System.Drawing.Point(259, 34);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(67, 16);
            this.lblCarBrand.TabIndex = 5;
            this.lblCarBrand.Text = "Car Brand";
            // 
            // cmbCarBrand
            // 
            this.cmbCarBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarBrand.FormattingEnabled = true;
            this.cmbCarBrand.Items.AddRange(new object[] {
            "Toyota Carolla",
            "Honda Stream",
            "Nissan Sylphy",
            "Mazda Demio",
            "Subaru"});
            this.cmbCarBrand.Location = new System.Drawing.Point(374, 34);
            this.cmbCarBrand.Name = "cmbCarBrand";
            this.cmbCarBrand.Size = new System.Drawing.Size(200, 24);
            this.cmbCarBrand.TabIndex = 6;
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfBirth.Location = new System.Drawing.Point(374, 64);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.dtDateOfBirth.TabIndex = 7;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(259, 70);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(81, 16);
            this.lblDateOfBirth.TabIndex = 8;
            this.lblDateOfBirth.Text = "Date Of Birth";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(259, 99);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // lblAgeDisplay
            // 
            this.lblAgeDisplay.AutoSize = true;
            this.lblAgeDisplay.Location = new System.Drawing.Point(371, 99);
            this.lblAgeDisplay.Name = "lblAgeDisplay";
            this.lblAgeDisplay.Size = new System.Drawing.Size(81, 16);
            this.lblAgeDisplay.TabIndex = 12;
            this.lblAgeDisplay.Text = "Age Display";
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Location = new System.Drawing.Point(636, 37);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Size = new System.Drawing.Size(78, 16);
            this.lblRentalDate.TabIndex = 14;
            this.lblRentalDate.Text = "Rental Date";
            // 
            // dtRentalDate
            // 
            this.dtRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRentalDate.Location = new System.Drawing.Point(773, 34);
            this.dtRentalDate.Name = "dtRentalDate";
            this.dtRentalDate.Size = new System.Drawing.Size(200, 22);
            this.dtRentalDate.TabIndex = 13;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(636, 62);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(78, 16);
            this.lblReturnDate.TabIndex = 16;
            this.lblReturnDate.Text = "Return Date";
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReturnDate.Location = new System.Drawing.Point(773, 62);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(200, 22);
            this.dtReturnDate.TabIndex = 15;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplay.Location = new System.Drawing.Point(919, 323);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(54, 16);
            this.lblDisplay.TabIndex = 18;
            this.lblDisplay.Text = "Deposit";
            // 
            // lblDepositDisplay
            // 
            this.lblDepositDisplay.AutoSize = true;
            this.lblDepositDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDepositDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDepositDisplay.Location = new System.Drawing.Point(780, 323);
            this.lblDepositDisplay.Name = "lblDepositDisplay";
            this.lblDepositDisplay.Size = new System.Drawing.Size(61, 16);
            this.lblDepositDisplay.TabIndex = 17;
            this.lblDepositDisplay.Text = "Deposit";
            // 
            // lblLateReturn
            // 
            this.lblLateReturn.AutoSize = true;
            this.lblLateReturn.BackColor = System.Drawing.Color.Red;
            this.lblLateReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLateReturn.Location = new System.Drawing.Point(636, 93);
            this.lblLateReturn.Name = "lblLateReturn";
            this.lblLateReturn.Size = new System.Drawing.Size(95, 18);
            this.lblLateReturn.TabIndex = 20;
            this.lblLateReturn.Text = "Late Return";
            // 
            // dtLateReturn
            // 
            this.dtLateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLateReturn.Location = new System.Drawing.Point(773, 90);
            this.dtLateReturn.Name = "dtLateReturn";
            this.dtLateReturn.Size = new System.Drawing.Size(200, 22);
            this.dtLateReturn.TabIndex = 19;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Red;
            this.lblBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBalance.Location = new System.Drawing.Point(916, 352);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(57, 16);
            this.lblBalance.TabIndex = 22;
            this.lblBalance.Text = "Balance";
            // 
            // lblBalanceDisplay
            // 
            this.lblBalanceDisplay.AutoSize = true;
            this.lblBalanceDisplay.BackColor = System.Drawing.Color.Red;
            this.lblBalanceDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBalanceDisplay.Location = new System.Drawing.Point(777, 352);
            this.lblBalanceDisplay.Name = "lblBalanceDisplay";
            this.lblBalanceDisplay.Size = new System.Drawing.Size(68, 18);
            this.lblBalanceDisplay.TabIndex = 21;
            this.lblBalanceDisplay.Text = "Balance";
            // 
            // lblDollarSign2
            // 
            this.lblDollarSign2.AutoSize = true;
            this.lblDollarSign2.Location = new System.Drawing.Point(892, 323);
            this.lblDollarSign2.Name = "lblDollarSign2";
            this.lblDollarSign2.Size = new System.Drawing.Size(14, 16);
            this.lblDollarSign2.TabIndex = 23;
            this.lblDollarSign2.Text = "$";
            // 
            // lblDollarSign
            // 
            this.lblDollarSign.AutoSize = true;
            this.lblDollarSign.Location = new System.Drawing.Point(892, 352);
            this.lblDollarSign.Name = "lblDollarSign";
            this.lblDollarSign.Size = new System.Drawing.Size(14, 16);
            this.lblDollarSign.TabIndex = 24;
            this.lblDollarSign.Text = "$";
            // 
            // lblDollarSign3
            // 
            this.lblDollarSign3.AutoSize = true;
            this.lblDollarSign3.Location = new System.Drawing.Point(892, 385);
            this.lblDollarSign3.Name = "lblDollarSign3";
            this.lblDollarSign3.Size = new System.Drawing.Size(14, 16);
            this.lblDollarSign3.TabIndex = 27;
            this.lblDollarSign3.Text = "$";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.BackColor = System.Drawing.Color.Green;
            this.lblTotalPaid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPaid.Location = new System.Drawing.Point(916, 385);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(38, 16);
            this.lblTotalPaid.TabIndex = 26;
            this.lblTotalPaid.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.ForestGreen;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Location = new System.Drawing.Point(777, 385);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 18);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "TOTAL";
            // 
            // frmPersonal_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.lblDollarSign3);
            this.Controls.Add(this.lblTotalPaid);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDollarSign);
            this.Controls.Add(this.lblDollarSign2);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceDisplay);
            this.Controls.Add(this.lblLateReturn);
            this.Controls.Add(this.dtLateReturn);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblDepositDisplay);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.dtReturnDate);
            this.Controls.Add(this.lblRentalDate);
            this.Controls.Add(this.dtRentalDate);
            this.Controls.Add(this.lblAgeDisplay);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dtDateOfBirth);
            this.Controls.Add(this.cmbCarBrand);
            this.Controls.Add(this.lblCarBrand);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "frmPersonal_information";
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCarBrand;
        private System.Windows.Forms.ComboBox cmbCarBrand;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeDisplay;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.DateTimePicker dtRentalDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtReturnDate;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblDepositDisplay;
        private System.Windows.Forms.Label lblLateReturn;
        private System.Windows.Forms.DateTimePicker dtLateReturn;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceDisplay;
        private System.Windows.Forms.Label lblDollarSign2;
        private System.Windows.Forms.Label lblDollarSign;
        private System.Windows.Forms.Label lblDollarSign3;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblTotal;
    }
}


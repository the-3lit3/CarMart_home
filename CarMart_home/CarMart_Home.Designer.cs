namespace CarMart_home
{
    partial class CarMart_Home
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
            this.lblModel = new System.Windows.Forms.Label();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.dtDateOut = new System.Windows.Forms.DateTimePicker();
            this.dtExpReturn = new System.Windows.Forms.DateTimePicker();
            this.lblExpReturn = new System.Windows.Forms.Label();
            this.dtReturned = new System.Windows.Forms.DateTimePicker();
            this.lblActReturn = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(63, 69);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 16);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "Toyota ",
            "BMW",
            "Nissan",
            "Honda"});
            this.cbModel.Location = new System.Drawing.Point(178, 66);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 24);
            this.cbModel.TabIndex = 1;
            // 
            // cmbMake
            // 
            this.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Items.AddRange(new object[] {
            "Carolla",
            "Vitz",
            "Crown",
            "Altis",
            "Axio",
            "Mark X",
            "Stream",
            "Civic",
            "Fit",
            "Bluebird",
            "AD",
            "Note",
            "Sylphy",
            "3201",
            "X5",
            "X6"});
            this.cmbMake.Location = new System.Drawing.Point(178, 123);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(121, 24);
            this.cmbMake.TabIndex = 3;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(63, 126);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(41, 16);
            this.lblMake.TabIndex = 2;
            this.lblMake.Text = "Make";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmbYear.Location = new System.Drawing.Point(178, 182);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 5;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(63, 185);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 16);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Location = new System.Drawing.Point(63, 259);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(83, 16);
            this.lblAmountPaid.TabIndex = 6;
            this.lblAmountPaid.Text = "Amount Paid";
            // 
            // lblDateOut
            // 
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.Location = new System.Drawing.Point(368, 72);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(59, 16);
            this.lblDateOut.TabIndex = 8;
            this.lblDateOut.Text = "Date Out";
            // 
            // dtDateOut
            // 
            this.dtDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOut.Location = new System.Drawing.Point(483, 67);
            this.dtDateOut.Name = "dtDateOut";
            this.dtDateOut.Size = new System.Drawing.Size(200, 22);
            this.dtDateOut.TabIndex = 9;
            // 
            // dtExpReturn
            // 
            this.dtExpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpReturn.Location = new System.Drawing.Point(483, 129);
            this.dtExpReturn.Name = "dtExpReturn";
            this.dtExpReturn.Size = new System.Drawing.Size(200, 22);
            this.dtExpReturn.TabIndex = 11;
            // 
            // lblExpReturn
            // 
            this.lblExpReturn.AutoSize = true;
            this.lblExpReturn.Location = new System.Drawing.Point(368, 129);
            this.lblExpReturn.Name = "lblExpReturn";
            this.lblExpReturn.Size = new System.Drawing.Size(75, 16);
            this.lblExpReturn.TabIndex = 10;
            this.lblExpReturn.Text = "Epx. Return";
            // 
            // dtReturned
            // 
            this.dtReturned.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReturned.Location = new System.Drawing.Point(483, 200);
            this.dtReturned.Name = "dtReturned";
            this.dtReturned.Size = new System.Drawing.Size(200, 22);
            this.dtReturned.TabIndex = 13;
            // 
            // lblActReturn
            // 
            this.lblActReturn.AutoSize = true;
            this.lblActReturn.Location = new System.Drawing.Point(368, 200);
            this.lblActReturn.Name = "lblActReturn";
            this.lblActReturn.Size = new System.Drawing.Size(94, 16);
            this.lblActReturn.TabIndex = 12;
            this.lblActReturn.Text = "Date Returned";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(370, 259);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(57, 16);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.Text = "Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(626, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(216, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Amount Paid";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Location = new System.Drawing.Point(66, 370);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(352, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(608, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // CarMart_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.dtReturned);
            this.Controls.Add(this.lblActReturn);
            this.Controls.Add(this.dtExpReturn);
            this.Controls.Add(this.lblExpReturn);
            this.Controls.Add(this.dtDateOut);
            this.Controls.Add(this.lblDateOut);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.lblModel);
            this.Name = "CarMart_Home";
            this.Text = "SOF Car Rental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblDateOut;
        private System.Windows.Forms.DateTimePicker dtDateOut;
        private System.Windows.Forms.DateTimePicker dtExpReturn;
        private System.Windows.Forms.Label lblExpReturn;
        private System.Windows.Forms.DateTimePicker dtReturned;
        private System.Windows.Forms.Label lblActReturn;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}


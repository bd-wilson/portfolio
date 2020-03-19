namespace SportsPro
{
    partial class frmCustomerMaintenance
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
            this.cboCustSelectMenu = new System.Windows.Forms.ComboBox();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.custInfoBox = new System.Windows.Forms.GroupBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnSubmitCustChanges = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.custInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCustSelectMenu
            // 
            this.cboCustSelectMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustSelectMenu.FormattingEnabled = true;
            this.cboCustSelectMenu.Location = new System.Drawing.Point(165, 41);
            this.cboCustSelectMenu.Name = "cboCustSelectMenu";
            this.cboCustSelectMenu.Size = new System.Drawing.Size(335, 21);
            this.cboCustSelectMenu.TabIndex = 0;
            this.cboCustSelectMenu.SelectedIndexChanged += new System.EventHandler(this.cboCustSelectMenu_SelectedIndexChanged);
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(245, 68);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(184, 39);
            this.btnSelectCustomer.TabIndex = 1;
            this.btnSelectCustomer.Text = "Select Customer";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // custInfoBox
            // 
            this.custInfoBox.Controls.Add(this.lblCustomerID);
            this.custInfoBox.Controls.Add(this.btnSubmitCustChanges);
            this.custInfoBox.Controls.Add(this.txtPhone);
            this.custInfoBox.Controls.Add(this.txtEmail);
            this.custInfoBox.Controls.Add(this.txtZip);
            this.custInfoBox.Controls.Add(this.txtState);
            this.custInfoBox.Controls.Add(this.txtCity);
            this.custInfoBox.Controls.Add(this.txtAddress);
            this.custInfoBox.Controls.Add(this.txtName);
            this.custInfoBox.Controls.Add(this.lblPhone);
            this.custInfoBox.Controls.Add(this.lblEmail);
            this.custInfoBox.Controls.Add(this.lblZip);
            this.custInfoBox.Controls.Add(this.lblState);
            this.custInfoBox.Controls.Add(this.lblCity);
            this.custInfoBox.Controls.Add(this.lblAddress);
            this.custInfoBox.Controls.Add(this.lblName);
            this.custInfoBox.Location = new System.Drawing.Point(12, 129);
            this.custInfoBox.Name = "custInfoBox";
            this.custInfoBox.Size = new System.Drawing.Size(625, 382);
            this.custInfoBox.TabIndex = 2;
            this.custInfoBox.TabStop = false;
            this.custInfoBox.Text = "Customer Info";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(27, 23);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerID.TabIndex = 15;
            // 
            // btnSubmitCustChanges
            // 
            this.btnSubmitCustChanges.Location = new System.Drawing.Point(202, 303);
            this.btnSubmitCustChanges.Name = "btnSubmitCustChanges";
            this.btnSubmitCustChanges.Size = new System.Drawing.Size(253, 59);
            this.btnSubmitCustChanges.TabIndex = 14;
            this.btnSubmitCustChanges.Text = "Submit Customer Info Changes";
            this.btnSubmitCustChanges.UseVisualStyleBackColor = true;
            this.btnSubmitCustChanges.Click += new System.EventHandler(this.btnSubmitCustChanges_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(96, 267);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(492, 20);
            this.txtPhone.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(491, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(96, 193);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(491, 20);
            this.txtZip.TabIndex = 11;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(96, 155);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(492, 20);
            this.txtState.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(96, 122);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(492, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 86);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(492, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(492, 20);
            this.txtName.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(25, 268);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 235);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(25, 197);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(52, 13);
            this.lblZip.TabIndex = 4;
            this.lblZip.Text = "ZIP Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(25, 162);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(28, 125);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(25, 92);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // frmCustomerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 523);
            this.Controls.Add(this.custInfoBox);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.cboCustSelectMenu);
            this.Name = "frmCustomerMaintenance";
            this.Text = "SportsPro - Customer Maintenance";
            this.custInfoBox.ResumeLayout(false);
            this.custInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustSelectMenu;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.GroupBox custInfoBox;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSubmitCustChanges;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblCustomerID;
    }
}
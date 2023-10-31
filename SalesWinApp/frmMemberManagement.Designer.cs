namespace SalesWinApp
{
    partial class frmMemberManagement
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
            lbCompanyName = new Label();
            grFilter = new GroupBox();
            cboSearchCity = new ComboBox();
            lbSearchCity = new Label();
            cboCountry = new ComboBox();
            lbSearchCountry = new Label();
            grSearch = new GroupBox();
            radioByName = new RadioButton();
            radioByID = new RadioButton();
            txtSearchValue = new TextBox();
            btnSearch = new Button();
            lbSearch = new Label();
            dgvMemberList = new DataGridView();
            btnDelete = new Button();
            btnNew = new Button();
            btnLoad = new Button();
            txtCountry = new TextBox();
            lbCountry = new Label();
            txtCity = new TextBox();
            lbCity = new Label();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtCompanyName = new TextBox();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtMemberName = new TextBox();
            lbMemberName = new Label();
            txtMemberID = new TextBox();
            lbMemberID = new Label();
            grFilter.SuspendLayout();
            grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(57, 121);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(94, 15);
            lbCompanyName.TabIndex = 44;
            lbCompanyName.Text = "Company Name";
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cboSearchCity);
            grFilter.Controls.Add(lbSearchCity);
            grFilter.Controls.Add(cboCountry);
            grFilter.Controls.Add(lbSearchCountry);
            grFilter.Location = new Point(400, 191);
            grFilter.Name = "grFilter";
            grFilter.Size = new Size(260, 84);
            grFilter.TabIndex = 43;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // cboSearchCity
            // 
            cboSearchCity.Location = new Point(77, 53);
            cboSearchCity.Name = "cboSearchCity";
            cboSearchCity.Size = new Size(165, 23);
            cboSearchCity.TabIndex = 20;
            // 
            // lbSearchCity
            // 
            lbSearchCity.AutoSize = true;
            lbSearchCity.Location = new Point(32, 56);
            lbSearchCity.Name = "lbSearchCity";
            lbSearchCity.Size = new Size(28, 15);
            lbSearchCity.TabIndex = 19;
            lbSearchCity.Text = "City";
            // 
            // cboCountry
            // 
            cboCountry.Location = new Point(77, 18);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(165, 23);
            cboCountry.TabIndex = 0;
            // 
            // lbSearchCountry
            // 
            lbSearchCountry.AutoSize = true;
            lbSearchCountry.Location = new Point(27, 21);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new Size(50, 15);
            lbSearchCountry.TabIndex = 18;
            lbSearchCountry.Text = "Country";
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByName);
            grSearch.Controls.Add(radioByID);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Location = new Point(56, 187);
            grSearch.Name = "grSearch";
            grSearch.Size = new Size(289, 89);
            grSearch.TabIndex = 42;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new Point(202, 55);
            radioByName.Name = "radioByName";
            radioByName.Size = new Size(73, 19);
            radioByName.TabIndex = 23;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new Point(202, 25);
            radioByID.Name = "radioByID";
            radioByID.Size = new Size(52, 19);
            radioByID.TabIndex = 22;
            radioByID.TabStop = true;
            radioByID.Text = "By ID";
            radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(64, 21);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(118, 23);
            txtSearchValue.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(64, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(16, 24);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(38, 293);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(650, 258);
            dgvMemberList.TabIndex = 41;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(489, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 23);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(302, 158);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(109, 23);
            btnNew.TabIndex = 39;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(105, 158);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(109, 23);
            btnLoad.TabIndex = 38;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(477, 82);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(184, 23);
            txtCountry.TabIndex = 37;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(411, 85);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 36;
            lbCountry.Text = "Country";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(477, 41);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(184, 23);
            txtCity.TabIndex = 35;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(411, 44);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 34;
            lbCity.Text = "City";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(514, -50);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(184, 23);
            txtPassword.TabIndex = 33;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(448, -47);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 32;
            lbPassword.Text = "Password";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(161, 118);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(184, 23);
            txtCompanyName.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 82);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 30;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(57, 85);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 29;
            lbEmail.Text = "Email";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(161, 41);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(184, 23);
            txtMemberName.TabIndex = 28;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(57, 44);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(56, 15);
            lbMemberName.TabIndex = 27;
            lbMemberName.Text = "Fullname";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(198, -50);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(184, 23);
            txtMemberID.TabIndex = 26;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(94, -47);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(66, 15);
            lbMemberID.TabIndex = 25;
            lbMemberID.Text = "Member ID";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 605);
            Controls.Add(lbCompanyName);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemberName);
            Controls.Add(lbMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCompanyName;
        private GroupBox grFilter;
        private ComboBox cboSearchCity;
        private Label lbSearchCity;
        private ComboBox cboCountry;
        private Label lbSearchCountry;
        private GroupBox grSearch;
        private RadioButton radioByName;
        private RadioButton radioByID;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Label lbSearch;
        private DataGridView dgvMemberList;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private TextBox txtCountry;
        private Label lbCountry;
        private TextBox txtCity;
        private Label lbCity;
        private TextBox txtPassword;
        private Label lbPassword;
        private TextBox txtCompanyName;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtMemberName;
        private Label lbMemberName;
        private TextBox txtMemberID;
        private Label lbMemberID;
    }
}
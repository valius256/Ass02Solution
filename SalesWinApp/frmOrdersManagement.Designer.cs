namespace SalesWinApp
{
    partial class frmOrdersManagement
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
            btnExport = new Button();
            grSearch = new GroupBox();
            btnSearch = new Button();
            endDate = new DateTimePicker();
            lbEndDate = new Label();
            startDate = new DateTimePicker();
            lbStartDate = new Label();
            txtMemberName = new TextBox();
            lbMember = new Label();
            txtOrderTotal = new TextBox();
            lbOrderTotal = new Label();
            txtOrderDate = new TextBox();
            lbOrderDate = new Label();
            txtOrderID = new TextBox();
            lbOrderID = new Label();
            dgvOrderList = new DataGridView();
            grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // btnExport
            // 
            btnExport.Location = new Point(296, 577);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(139, 48);
            btnExport.TabIndex = 24;
            btnExport.Text = "Export Data";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(endDate);
            grSearch.Controls.Add(lbEndDate);
            grSearch.Controls.Add(startDate);
            grSearch.Controls.Add(lbStartDate);
            grSearch.Location = new Point(336, 19);
            grSearch.Margin = new Padding(3, 4, 3, 4);
            grSearch.Name = "grSearch";
            grSearch.Padding = new Padding(3, 4, 3, 4);
            grSearch.Size = new Size(410, 194);
            grSearch.TabIndex = 29;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(80, 123);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 43);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // endDate
            // 
            endDate.Location = new Point(80, 71);
            endDate.Margin = new Padding(3, 4, 3, 4);
            endDate.Name = "endDate";
            endDate.Size = new Size(239, 27);
            endDate.TabIndex = 3;
            endDate.Value = new DateTime(2021, 6, 29, 17, 4, 20, 0);
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(11, 79);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(70, 20);
            lbEndDate.TabIndex = 2;
            lbEndDate.Text = "End Date";
            // 
            // startDate
            // 
            startDate.Location = new Point(80, 19);
            startDate.Margin = new Padding(3, 4, 3, 4);
            startDate.Name = "startDate";
            startDate.Size = new Size(239, 27);
            startDate.TabIndex = 1;
            startDate.Value = new DateTime(2021, 6, 29, 17, 4, 20, 0);
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(7, 27);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(76, 20);
            lbStartDate.TabIndex = 0;
            lbStartDate.Text = "Start Date";
            // 
            // txtMemberName
            // 
            txtMemberName.Enabled = false;
            txtMemberName.Location = new Point(124, 150);
            txtMemberName.Margin = new Padding(3, 4, 3, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(193, 27);
            txtMemberName.TabIndex = 27;
            // 
            // lbMember
            // 
            lbMember.AutoSize = true;
            lbMember.Location = new Point(42, 154);
            lbMember.Name = "lbMember";
            lbMember.Size = new Size(65, 20);
            lbMember.TabIndex = 25;
            lbMember.Text = "Member";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Location = new Point(124, 112);
            txtOrderTotal.Margin = new Padding(3, 4, 3, 4);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(193, 27);
            txtOrderTotal.TabIndex = 28;
            // 
            // lbOrderTotal
            // 
            lbOrderTotal.AutoSize = true;
            lbOrderTotal.Location = new Point(42, 116);
            lbOrderTotal.Name = "lbOrderTotal";
            lbOrderTotal.Size = new Size(84, 20);
            lbOrderTotal.TabIndex = 26;
            lbOrderTotal.Text = "Order Total";
            // 
            // txtOrderDate
            // 
            txtOrderDate.Enabled = false;
            txtOrderDate.Location = new Point(124, 73);
            txtOrderDate.Margin = new Padding(3, 4, 3, 4);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(193, 27);
            txtOrderDate.TabIndex = 23;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(42, 77);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(83, 20);
            lbOrderDate.TabIndex = 22;
            lbOrderDate.Text = "Order Date";
            // 
            // txtOrderID
            // 
            txtOrderID.Enabled = false;
            txtOrderID.Location = new Point(124, 34);
            txtOrderID.Margin = new Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(193, 27);
            txtOrderID.TabIndex = 21;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(42, 38);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(66, 20);
            lbOrderID.TabIndex = 20;
            lbOrderID.Text = "Order ID";
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(42, 221);
            dgvOrderList.Margin = new Padding(3, 4, 3, 4);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 25;
            dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new Size(704, 336);
            dgvOrderList.TabIndex = 19;
            // 
            // frmOrdersManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 649);
            Controls.Add(btnExport);
            Controls.Add(grSearch);
            Controls.Add(txtMemberName);
            Controls.Add(lbMember);
            Controls.Add(txtOrderTotal);
            Controls.Add(lbOrderTotal);
            Controls.Add(txtOrderDate);
            Controls.Add(lbOrderDate);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderID);
            Controls.Add(dgvOrderList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrdersManagement";
            Text = "frmOrdersManagement";
            Load += frmOrdersManagement_Load;
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExport;
        private GroupBox grSearch;
        private Button btnSearch;
        private DateTimePicker endDate;
        private Label lbEndDate;
        private DateTimePicker startDate;
        private Label lbStartDate;
        private TextBox txtMemberName;
        private Label lbMember;
        private TextBox txtOrderTotal;
        private Label lbOrderTotal;
        private TextBox txtOrderDate;
        private Label lbOrderDate;
        private TextBox txtOrderID;
        private Label lbOrderID;
        private DataGridView dgvOrderList;
    }
}
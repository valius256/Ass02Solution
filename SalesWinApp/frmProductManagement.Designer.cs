namespace SalesWinApp
{
    partial class frmProductManagement
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
            txtUnitsInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtCategory = new TextBox();
            grFilter = new GroupBox();
            btnFilter = new Button();
            txtTo = new TextBox();
            lbTo = new Label();
            txtFrom = new TextBox();
            lbFrom = new Label();
            rdUnitsInStock = new RadioButton();
            rdUnitPrice = new RadioButton();
            grSearch = new GroupBox();
            radioByName = new RadioButton();
            radioByID = new RadioButton();
            txtSearchValue = new TextBox();
            btnSearch = new Button();
            lbSearch = new Label();
            dgvProductList = new DataGridView();
            btnDelete = new Button();
            btnNew = new Button();
            btnLoad = new Button();
            lbUnitsInStock = new Label();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            txtWeight = new TextBox();
            lbCategory = new Label();
            txtProductName = new TextBox();
            lbMemberName = new Label();
            txtProductID = new TextBox();
            lbProductID = new Label();
            grFilter.SuspendLayout();
            grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Enabled = false;
            txtUnitsInStock.Location = new Point(532, 110);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(184, 23);
            txtUnitsInStock.TabIndex = 49;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Location = new Point(532, 69);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(184, 23);
            txtUnitPrice.TabIndex = 48;
            // 
            // txtCategory
            // 
            txtCategory.Enabled = false;
            txtCategory.Location = new Point(189, 110);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(184, 23);
            txtCategory.TabIndex = 46;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(btnFilter);
            grFilter.Controls.Add(txtTo);
            grFilter.Controls.Add(lbTo);
            grFilter.Controls.Add(txtFrom);
            grFilter.Controls.Add(lbFrom);
            grFilter.Controls.Add(rdUnitsInStock);
            grFilter.Controls.Add(rdUnitPrice);
            grFilter.Enabled = false;
            grFilter.Location = new Point(380, 206);
            grFilter.Name = "grFilter";
            grFilter.Size = new Size(336, 89);
            grFilter.TabIndex = 61;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(238, 53);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(80, 23);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "&Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(218, 19);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(100, 23);
            txtTo.TabIndex = 15;
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Location = new Point(193, 23);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(19, 15);
            lbTo.TabIndex = 4;
            lbTo.Text = "To";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(55, 19);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(100, 23);
            txtFrom.TabIndex = 14;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Location = new Point(14, 22);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(35, 15);
            lbFrom.TabIndex = 2;
            lbFrom.Text = "From";
            // 
            // rdUnitsInStock
            // 
            rdUnitsInStock.AutoSize = true;
            rdUnitsInStock.Location = new Point(115, 55);
            rdUnitsInStock.Name = "rdUnitsInStock";
            rdUnitsInStock.Size = new Size(97, 19);
            rdUnitsInStock.TabIndex = 17;
            rdUnitsInStock.Text = "Units In Stock";
            rdUnitsInStock.UseVisualStyleBackColor = true;
            // 
            // rdUnitPrice
            // 
            rdUnitPrice.AutoSize = true;
            rdUnitPrice.Checked = true;
            rdUnitPrice.Location = new Point(14, 55);
            rdUnitPrice.Name = "rdUnitPrice";
            rdUnitPrice.Size = new Size(76, 19);
            rdUnitPrice.TabIndex = 16;
            rdUnitPrice.TabStop = true;
            rdUnitPrice.Text = "Unit Price";
            rdUnitPrice.UseVisualStyleBackColor = true;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(radioByName);
            grSearch.Controls.Add(radioByID);
            grSearch.Controls.Add(txtSearchValue);
            grSearch.Controls.Add(btnSearch);
            grSearch.Controls.Add(lbSearch);
            grSearch.Enabled = false;
            grSearch.Location = new Point(85, 206);
            grSearch.Name = "grSearch";
            grSearch.Size = new Size(289, 89);
            grSearch.TabIndex = 60;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Checked = true;
            radioByName.Location = new Point(215, 53);
            radioByName.Name = "radioByName";
            radioByName.Size = new Size(73, 19);
            radioByName.TabIndex = 12;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new Point(215, 23);
            radioByID.Name = "radioByID";
            radioByID.Size = new Size(52, 19);
            radioByID.TabIndex = 11;
            radioByID.TabStop = true;
            radioByID.Text = "By ID";
            radioByID.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(77, 19);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(118, 23);
            txtSearchValue.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(77, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(29, 22);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 16;
            lbSearch.Text = "Search";
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(84, 310);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowTemplate.Height = 25;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new Size(632, 257);
            dgvProductList.TabIndex = 59;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(519, 165);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 23);
            btnDelete.TabIndex = 52;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(332, 165);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(109, 23);
            btnNew.TabIndex = 51;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(135, 165);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(109, 23);
            btnLoad.TabIndex = 50;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(439, 113);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(79, 15);
            lbUnitsInStock.TabIndex = 58;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(439, 72);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(58, 15);
            lbUnitPrice.TabIndex = 57;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(439, 31);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(45, 15);
            lbWeight.TabIndex = 56;
            lbWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Enabled = false;
            txtWeight.Location = new Point(532, 28);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(184, 23);
            txtWeight.TabIndex = 47;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(85, 113);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(55, 15);
            lbCategory.TabIndex = 55;
            lbCategory.Text = "Category";
            // 
            // txtProductName
            // 
            txtProductName.Enabled = false;
            txtProductName.Location = new Point(189, 69);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(184, 23);
            txtProductName.TabIndex = 45;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(85, 72);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(84, 15);
            lbMemberName.TabIndex = 54;
            lbMemberName.Text = "Product Name";
            // 
            // txtProductID
            // 
            txtProductID.Enabled = false;
            txtProductID.Location = new Point(189, 28);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(184, 23);
            txtProductID.TabIndex = 44;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(85, 31);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(63, 15);
            lbProductID.TabIndex = 53;
            lbProductID.Text = "Product ID";
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 594);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCategory);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(dgvProductList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(txtWeight);
            Controls.Add(lbCategory);
            Controls.Add(txtProductName);
            Controls.Add(lbMemberName);
            Controls.Add(txtProductID);
            Controls.Add(lbProductID);
            Name = "frmProductManagement";
            Text = "Product Management";
            Load += frmProductManagement_Load;
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtCategory;
        private GroupBox grFilter;
        private Button btnFilter;
        private TextBox txtTo;
        private Label lbTo;
        private TextBox txtFrom;
        private Label lbFrom;
        private RadioButton rdUnitsInStock;
        private RadioButton rdUnitPrice;
        private GroupBox grSearch;
        private RadioButton radioByName;
        private RadioButton radioByID;
        private TextBox txtSearchValue;
        private Button btnSearch;
        private Label lbSearch;
        private DataGridView dgvProductList;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private TextBox txtWeight;
        private Label lbCategory;
        private TextBox txtProductName;
        private Label lbMemberName;
        private TextBox txtProductID;
        private Label lbProductID;
    }
}
namespace OtoStore
{
    partial class HomeCarStore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.cbDateOfFilter = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbPriceOfFilter = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelSort = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbDateOfSort = new System.Windows.Forms.ComboBox();
            this.cbPriceOfSort = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRdrToPageAdmin = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.panelPaging = new System.Windows.Forms.Panel();
            this.lbCountCar = new System.Windows.Forms.Label();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.lbPageIndex = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelPaging.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 66);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnFilter);
            this.panel4.Controls.Add(this.cbCompany);
            this.panel4.Controls.Add(this.cbDateOfFilter);
            this.panel4.Controls.Add(this.cbClass);
            this.panel4.Controls.Add(this.cbColor);
            this.panel4.Controls.Add(this.cbPriceOfFilter);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(218, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(624, 66);
            this.panel4.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancel.Location = new System.Drawing.Point(581, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(38, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFilter.Location = new System.Drawing.Point(538, 19);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(39, 23);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbCompany
            // 
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Items.AddRange(new object[] {
            "Toyota",
            "Huyndai",
            "Kia",
            "Honda",
            "Mazda",
            "Bmw",
            "Vinfast"});
            this.cbCompany.Location = new System.Drawing.Point(16, 21);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(80, 21);
            this.cbCompany.TabIndex = 1;
            this.cbCompany.Text = "Hãng xe";
            // 
            // cbDateOfFilter
            // 
            this.cbDateOfFilter.FormattingEnabled = true;
            this.cbDateOfFilter.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbDateOfFilter.Location = new System.Drawing.Point(445, 21);
            this.cbDateOfFilter.Name = "cbDateOfFilter";
            this.cbDateOfFilter.Size = new System.Drawing.Size(87, 21);
            this.cbDateOfFilter.TabIndex = 8;
            this.cbDateOfFilter.Text = "Năm sản xuất";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "S"});
            this.cbClass.Location = new System.Drawing.Point(116, 21);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(70, 21);
            this.cbClass.TabIndex = 2;
            this.cbClass.Text = "Hạng xe";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Đen",
            "Trắng",
            "Bạc",
            "Đỏ",
            "Xám"});
            this.cbColor.Location = new System.Drawing.Point(205, 21);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(81, 21);
            this.cbColor.TabIndex = 6;
            this.cbColor.Text = "Màu xe";
            // 
            // cbPriceOfFilter
            // 
            this.cbPriceOfFilter.FormattingEnabled = true;
            this.cbPriceOfFilter.Items.AddRange(new object[] {
            "Dưới 500 triệu",
            "500 triệu đến 1 tỷ",
            "Trên 1 tỷ"});
            this.cbPriceOfFilter.Location = new System.Drawing.Point(308, 21);
            this.cbPriceOfFilter.Name = "cbPriceOfFilter";
            this.cbPriceOfFilter.Size = new System.Drawing.Size(113, 21);
            this.cbPriceOfFilter.TabIndex = 7;
            this.cbPriceOfFilter.Text = "Mức giá";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnCancelSort);
            this.panel3.Controls.Add(this.btnSort);
            this.panel3.Controls.Add(this.cbDateOfSort);
            this.panel3.Controls.Add(this.cbPriceOfSort);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(842, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 66);
            this.panel3.TabIndex = 1;
            // 
            // btnCancelSort
            // 
            this.btnCancelSort.Location = new System.Drawing.Point(303, 19);
            this.btnCancelSort.Name = "btnCancelSort";
            this.btnCancelSort.Size = new System.Drawing.Size(46, 23);
            this.btnCancelSort.TabIndex = 3;
            this.btnCancelSort.Text = "Hủy";
            this.btnCancelSort.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(243, 19);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(54, 23);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbDateOfSort
            // 
            this.cbDateOfSort.FormattingEnabled = true;
            this.cbDateOfSort.Items.AddRange(new object[] {
            "Mặc định",
            "Tăng dần",
            "Giảm dần"});
            this.cbDateOfSort.Location = new System.Drawing.Point(134, 21);
            this.cbDateOfSort.Name = "cbDateOfSort";
            this.cbDateOfSort.Size = new System.Drawing.Size(93, 21);
            this.cbDateOfSort.TabIndex = 1;
            this.cbDateOfSort.Text = "Năm sản xuất";
            // 
            // cbPriceOfSort
            // 
            this.cbPriceOfSort.FormattingEnabled = true;
            this.cbPriceOfSort.Items.AddRange(new object[] {
            "Mặc định",
            "Tăng dần",
            "Giảm dần"});
            this.cbPriceOfSort.Location = new System.Drawing.Point(20, 22);
            this.cbPriceOfSort.Name = "cbPriceOfSort";
            this.cbPriceOfSort.Size = new System.Drawing.Size(90, 21);
            this.cbPriceOfSort.TabIndex = 0;
            this.cbPriceOfSort.Text = "Mức Giá";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 66);
            this.panel2.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(163, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(11, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRdrToPageAdmin);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 681);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1204, 34);
            this.panel5.TabIndex = 1;
            // 
            // btnRdrToPageAdmin
            // 
            this.btnRdrToPageAdmin.Location = new System.Drawing.Point(554, 5);
            this.btnRdrToPageAdmin.Name = "btnRdrToPageAdmin";
            this.btnRdrToPageAdmin.Size = new System.Drawing.Size(113, 23);
            this.btnRdrToPageAdmin.TabIndex = 0;
            this.btnRdrToPageAdmin.Text = "Trang quản trị";
            this.btnRdrToPageAdmin.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lvProduct);
            this.panel6.Controls.Add(this.panelPaging);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 72);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1204, 609);
            this.panel6.TabIndex = 2;
            // 
            // lvProduct
            // 
            this.lvProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lvProduct.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvProduct.AllowDrop = true;
            this.lvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(0, 0);
            this.lvProduct.Margin = new System.Windows.Forms.Padding(10);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(1202, 574);
            this.lvProduct.TabIndex = 1;
            this.lvProduct.TileSize = new System.Drawing.Size(10, 10);
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.SelectedIndexChanged += new System.EventHandler(this.lvProduct_SelectedIndexChanged);
            // 
            // panelPaging
            // 
            this.panelPaging.CausesValidation = false;
            this.panelPaging.Controls.Add(this.lbCountCar);
            this.panelPaging.Controls.Add(this.btnPreviousPage);
            this.panelPaging.Controls.Add(this.lbPageIndex);
            this.panelPaging.Controls.Add(this.btnLastPage);
            this.panelPaging.Controls.Add(this.btnNextPage);
            this.panelPaging.Controls.Add(this.btnPage2);
            this.panelPaging.Controls.Add(this.btnPage1);
            this.panelPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPaging.Location = new System.Drawing.Point(0, 574);
            this.panelPaging.Name = "panelPaging";
            this.panelPaging.Size = new System.Drawing.Size(1202, 33);
            this.panelPaging.TabIndex = 0;
            // 
            // lbCountCar
            // 
            this.lbCountCar.AutoSize = true;
            this.lbCountCar.Location = new System.Drawing.Point(420, 8);
            this.lbCountCar.Name = "lbCountCar";
            this.lbCountCar.Size = new System.Drawing.Size(0, 13);
            this.lbCountCar.TabIndex = 6;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(501, 3);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(54, 23);
            this.btnPreviousPage.TabIndex = 5;
            this.btnPreviousPage.Text = "<<";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // lbPageIndex
            // 
            this.lbPageIndex.AutoSize = true;
            this.lbPageIndex.Location = new System.Drawing.Point(795, 9);
            this.lbPageIndex.Name = "lbPageIndex";
            this.lbPageIndex.Size = new System.Drawing.Size(0, 13);
            this.lbPageIndex.TabIndex = 4;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(672, 4);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(79, 23);
            this.btnLastPage.TabIndex = 3;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(616, 4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(50, 23);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.Text = ">>";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPage2
            // 
            this.btnPage2.Location = new System.Drawing.Point(589, 4);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(21, 23);
            this.btnPage2.TabIndex = 1;
            this.btnPage2.Text = "2";
            this.btnPage2.UseVisualStyleBackColor = true;
            this.btnPage2.Click += new System.EventHandler(this.btnPage2_Click);
            // 
            // btnPage1
            // 
            this.btnPage1.Location = new System.Drawing.Point(561, 4);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(22, 23);
            this.btnPage1.TabIndex = 0;
            this.btnPage1.Text = "1";
            this.btnPage1.UseVisualStyleBackColor = true;
            this.btnPage1.Click += new System.EventHandler(this.btnPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm theo tên xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lọc theo Hãng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lọc theo hạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lọc theo màu ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lọc theo mức giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lọc theo năm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Xếp theo giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Xếp theo năm";
            // 
            // HomeCarStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 715);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "HomeCarStore";
            this.Text = "CarStore";
            this.Load += new System.EventHandler(this.HomeCarStore_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelPaging.ResumeLayout(false);
            this.panelPaging.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbDateOfFilter;
        private System.Windows.Forms.ComboBox cbPriceOfFilter;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbDateOfSort;
        private System.Windows.Forms.ComboBox cbPriceOfSort;
        private System.Windows.Forms.Button btnCancelSort;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRdrToPageAdmin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelPaging;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.Label lbPageIndex;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Label lbCountCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}


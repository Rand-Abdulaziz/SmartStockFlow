namespace OurSystemCode
{
    partial class InventoryMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMan));
            this.panel3 = new System.Windows.Forms.Panel();
            this.OBInvenPan = new System.Windows.Forms.Panel();
            this.OBlapelInven = new System.Windows.Forms.Label();
            this.tableLayoutFilterInven = new System.Windows.Forms.TableLayoutPanel();
            this.ProductStockBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ProductNameInsert = new System.Windows.Forms.TextBox();
            this.LocationNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductExpirationBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemID = new System.Windows.Forms.Label();
            this.OBbuttonInven = new System.Windows.Forms.Button();
            this.OBclose = new System.Windows.Forms.Button();
            this.InventoryView = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBoxInven = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSittings = new System.Windows.Forms.Button();
            this.btnEmployeeMang = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnEmployeesTasks = new System.Windows.Forms.Button();
            this.BtnInventoryMan = new System.Windows.Forms.Button();
            this.BtnSuoliers = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            this.BtnDataEntry = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userroleBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.OBInvenPan.SuspendLayout();
            this.tableLayoutFilterInven.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.OBInvenPan);
            this.panel3.Controls.Add(this.InventoryView);
            this.panel3.Location = new System.Drawing.Point(356, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1239, 792);
            this.panel3.TabIndex = 9;
            // 
            // OBInvenPan
            // 
            this.OBInvenPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.OBInvenPan.Controls.Add(this.OBlapelInven);
            this.OBInvenPan.Controls.Add(this.tableLayoutFilterInven);
            this.OBInvenPan.Controls.Add(this.OBbuttonInven);
            this.OBInvenPan.Controls.Add(this.OBclose);
            this.OBInvenPan.Location = new System.Drawing.Point(11, 588);
            this.OBInvenPan.Name = "OBInvenPan";
            this.OBInvenPan.Size = new System.Drawing.Size(1213, 197);
            this.OBInvenPan.TabIndex = 9;
            this.OBInvenPan.Visible = false;
            // 
            // OBlapelInven
            // 
            this.OBlapelInven.AutoSize = true;
            this.OBlapelInven.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.OBlapelInven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.OBlapelInven.Location = new System.Drawing.Point(3, 3);
            this.OBlapelInven.Name = "OBlapelInven";
            this.OBlapelInven.Size = new System.Drawing.Size(94, 25);
            this.OBlapelInven.TabIndex = 5;
            this.OBlapelInven.Text = "Add Item";
            // 
            // tableLayoutFilterInven
            // 
            this.tableLayoutFilterInven.AutoScroll = true;
            this.tableLayoutFilterInven.ColumnCount = 4;
            this.tableLayoutFilterInven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFilterInven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFilterInven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFilterInven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutFilterInven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFilterInven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFilterInven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFilterInven.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFilterInven.Controls.Add(this.label10, 3, 0);
            this.tableLayoutFilterInven.Controls.Add(this.ProductNameInsert, 0, 1);
            this.tableLayoutFilterInven.Controls.Add(this.LocationNameBox, 3, 1);
            this.tableLayoutFilterInven.Controls.Add(this.label2, 1, 0);
            this.tableLayoutFilterInven.Controls.Add(this.label5, 2, 0);
            this.tableLayoutFilterInven.Controls.Add(this.itemID, 0, 0);
            this.tableLayoutFilterInven.Controls.Add(this.ProductStockBox, 2, 1);
            this.tableLayoutFilterInven.Controls.Add(this.ProductExpirationBox, 1, 1);
            this.tableLayoutFilterInven.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutFilterInven.Name = "tableLayoutFilterInven";
            this.tableLayoutFilterInven.RowCount = 2;
            this.tableLayoutFilterInven.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFilterInven.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFilterInven.Size = new System.Drawing.Size(1213, 115);
            this.tableLayoutFilterInven.TabIndex = 9;
            this.tableLayoutFilterInven.Visible = false;
            // 
            // ProductStockBox
            // 
            this.ProductStockBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductStockBox.Location = new System.Drawing.Point(696, 69);
            this.ProductStockBox.Name = "ProductStockBox";
            this.ProductStockBox.Size = new System.Drawing.Size(123, 33);
            this.ProductStockBox.TabIndex = 31;
            this.ProductStockBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(1023, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "Location";
            // 
            // ProductNameInsert
            // 
            this.ProductNameInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductNameInsert.Location = new System.Drawing.Point(90, 69);
            this.ProductNameInsert.Name = "ProductNameInsert";
            this.ProductNameInsert.Size = new System.Drawing.Size(123, 33);
            this.ProductNameInsert.TabIndex = 26;
            this.ProductNameInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocationNameBox
            // 
            this.LocationNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationNameBox.Location = new System.Drawing.Point(999, 69);
            this.LocationNameBox.Name = "LocationNameBox";
            this.LocationNameBox.Size = new System.Drawing.Size(123, 33);
            this.LocationNameBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(352, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product State(Expiration)";
            // 
            // ProductExpirationBox
            // 
            this.ProductExpirationBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductExpirationBox.Location = new System.Drawing.Point(393, 69);
            this.ProductExpirationBox.Name = "ProductExpirationBox";
            this.ProductExpirationBox.Size = new System.Drawing.Size(123, 33);
            this.ProductExpirationBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(674, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Product State(Stock)";
            // 
            // itemID
            // 
            this.itemID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemID.AutoSize = true;
            this.itemID.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.itemID.Location = new System.Drawing.Point(91, 18);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(120, 21);
            this.itemID.TabIndex = 27;
            this.itemID.Text = "Product Name";
            this.itemID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OBbuttonInven
            // 
            this.OBbuttonInven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.OBbuttonInven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OBbuttonInven.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OBbuttonInven.FlatAppearance.BorderSize = 10;
            this.OBbuttonInven.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OBbuttonInven.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OBbuttonInven.ForeColor = System.Drawing.Color.White;
            this.OBbuttonInven.Location = new System.Drawing.Point(550, 159);
            this.OBbuttonInven.Name = "OBbuttonInven";
            this.OBbuttonInven.Size = new System.Drawing.Size(123, 35);
            this.OBbuttonInven.TabIndex = 24;
            this.OBbuttonInven.Text = "Add";
            this.OBbuttonInven.UseVisualStyleBackColor = false;
            this.OBbuttonInven.Click += new System.EventHandler(this.OBbuttonInven_Click);
            // 
            // OBclose
            // 
            this.OBclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.OBclose.FlatAppearance.BorderSize = 0;
            this.OBclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OBclose.Location = new System.Drawing.Point(1175, 3);
            this.OBclose.Name = "OBclose";
            this.OBclose.Size = new System.Drawing.Size(35, 39);
            this.OBclose.TabIndex = 4;
            this.OBclose.Text = "X";
            this.OBclose.UseVisualStyleBackColor = false;
            this.OBclose.Click += new System.EventHandler(this.OBclose_Click);
            // 
            // InventoryView
            // 
            this.InventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryView.Location = new System.Drawing.Point(0, 0);
            this.InventoryView.Name = "InventoryView";
            this.InventoryView.RowHeadersWidth = 82;
            this.InventoryView.RowTemplate.Height = 35;
            this.InventoryView.Size = new System.Drawing.Size(1236, 581);
            this.InventoryView.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1228, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 39);
            this.button8.TabIndex = 4;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(30, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "Invontry management";
            // 
            // SearchBoxInven
            // 
            this.SearchBoxInven.Location = new System.Drawing.Point(722, 48);
            this.SearchBoxInven.Name = "SearchBoxInven";
            this.SearchBoxInven.Size = new System.Drawing.Size(308, 33);
            this.SearchBoxInven.TabIndex = 6;
            this.SearchBoxInven.TextChanged += new System.EventHandler(this.SearchBoxInven_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1120, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1088, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.buttonMinimize);
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.SearchBoxInven);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Location = new System.Drawing.Point(340, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1269, 208);
            this.panel4.TabIndex = 8;
            this.panel4.Resize += new System.EventHandler(this.panel4_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.Location = new System.Drawing.Point(1155, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(35, 39);
            this.buttonMinimize.TabIndex = 10;
            this.buttonMinimize.Text = "-";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1196, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnSittings);
            this.panel1.Controls.Add(this.btnEmployeeMang);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnEmployeesTasks);
            this.panel1.Controls.Add(this.BtnInventoryMan);
            this.panel1.Controls.Add(this.BtnSuoliers);
            this.panel1.Controls.Add(this.BtnReports);
            this.panel1.Controls.Add(this.BtnDataEntry);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(330, 911);
            this.panel1.TabIndex = 14;
            // 
            // btnSittings
            // 
            this.btnSittings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSittings.FlatAppearance.BorderSize = 0;
            this.btnSittings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSittings.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSittings.Image = ((System.Drawing.Image)(resources.GetObject("btnSittings.Image")));
            this.btnSittings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSittings.Location = new System.Drawing.Point(5, 559);
            this.btnSittings.Margin = new System.Windows.Forms.Padding(10);
            this.btnSittings.Name = "btnSittings";
            this.btnSittings.Size = new System.Drawing.Size(320, 50);
            this.btnSittings.TabIndex = 3;
            this.btnSittings.Text = "Settings";
            this.btnSittings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSittings.UseVisualStyleBackColor = true;
            this.btnSittings.Click += new System.EventHandler(this.btnSittings_Click);
            // 
            // btnEmployeeMang
            // 
            this.btnEmployeeMang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeMang.FlatAppearance.BorderSize = 0;
            this.btnEmployeeMang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeMang.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEmployeeMang.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeMang.Image")));
            this.btnEmployeeMang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeMang.Location = new System.Drawing.Point(5, 509);
            this.btnEmployeeMang.Margin = new System.Windows.Forms.Padding(10);
            this.btnEmployeeMang.Name = "btnEmployeeMang";
            this.btnEmployeeMang.Size = new System.Drawing.Size(320, 50);
            this.btnEmployeeMang.TabIndex = 2;
            this.btnEmployeeMang.Text = "Employees management";
            this.btnEmployeeMang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeMang.UseVisualStyleBackColor = true;
            this.btnEmployeeMang.Click += new System.EventHandler(this.btnEmployeeMang_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(5, 856);
            this.button7.Margin = new System.Windows.Forms.Padding(10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(320, 50);
            this.button7.TabIndex = 1;
            this.button7.Text = "Logout";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnEmployeesTasks
            // 
            this.btnEmployeesTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeesTasks.FlatAppearance.BorderSize = 0;
            this.btnEmployeesTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesTasks.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEmployeesTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeesTasks.Image")));
            this.btnEmployeesTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeesTasks.Location = new System.Drawing.Point(5, 459);
            this.btnEmployeesTasks.Margin = new System.Windows.Forms.Padding(10);
            this.btnEmployeesTasks.Name = "btnEmployeesTasks";
            this.btnEmployeesTasks.Size = new System.Drawing.Size(320, 50);
            this.btnEmployeesTasks.TabIndex = 1;
            this.btnEmployeesTasks.Text = "Employees tasks";
            this.btnEmployeesTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeesTasks.UseVisualStyleBackColor = true;
            this.btnEmployeesTasks.Click += new System.EventHandler(this.btnEmployeesTasks_Click);
            // 
            // BtnInventoryMan
            // 
            this.BtnInventoryMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInventoryMan.FlatAppearance.BorderSize = 0;
            this.BtnInventoryMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventoryMan.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BtnInventoryMan.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventoryMan.Image")));
            this.BtnInventoryMan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventoryMan.Location = new System.Drawing.Point(5, 409);
            this.BtnInventoryMan.Margin = new System.Windows.Forms.Padding(10);
            this.BtnInventoryMan.Name = "BtnInventoryMan";
            this.BtnInventoryMan.Size = new System.Drawing.Size(320, 50);
            this.BtnInventoryMan.TabIndex = 1;
            this.BtnInventoryMan.Text = "Invontry management";
            this.BtnInventoryMan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInventoryMan.UseVisualStyleBackColor = true;
            this.BtnInventoryMan.Click += new System.EventHandler(this.BtnInventoryMan_Click);
            // 
            // BtnSuoliers
            // 
            this.BtnSuoliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSuoliers.FlatAppearance.BorderSize = 0;
            this.BtnSuoliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuoliers.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BtnSuoliers.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuoliers.Image")));
            this.BtnSuoliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSuoliers.Location = new System.Drawing.Point(5, 359);
            this.BtnSuoliers.Margin = new System.Windows.Forms.Padding(10);
            this.BtnSuoliers.Name = "BtnSuoliers";
            this.BtnSuoliers.Size = new System.Drawing.Size(320, 50);
            this.BtnSuoliers.TabIndex = 1;
            this.BtnSuoliers.Text = "Suppliers management";
            this.BtnSuoliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSuoliers.UseVisualStyleBackColor = true;
            this.BtnSuoliers.Click += new System.EventHandler(this.BtnSuoliers_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReports.FlatAppearance.BorderSize = 0;
            this.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReports.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BtnReports.Image = ((System.Drawing.Image)(resources.GetObject("BtnReports.Image")));
            this.BtnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReports.Location = new System.Drawing.Point(5, 309);
            this.BtnReports.Margin = new System.Windows.Forms.Padding(10);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(320, 50);
            this.BtnReports.TabIndex = 1;
            this.BtnReports.Text = "Reports";
            this.BtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReports.UseVisualStyleBackColor = true;
            this.BtnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // BtnDataEntry
            // 
            this.BtnDataEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDataEntry.FlatAppearance.BorderSize = 0;
            this.BtnDataEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDataEntry.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BtnDataEntry.Image = ((System.Drawing.Image)(resources.GetObject("BtnDataEntry.Image")));
            this.BtnDataEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDataEntry.Location = new System.Drawing.Point(5, 259);
            this.BtnDataEntry.Margin = new System.Windows.Forms.Padding(10);
            this.BtnDataEntry.Name = "BtnDataEntry";
            this.BtnDataEntry.Size = new System.Drawing.Size(320, 50);
            this.BtnDataEntry.TabIndex = 1;
            this.BtnDataEntry.Text = "Data Entry";
            this.BtnDataEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDataEntry.UseVisualStyleBackColor = true;
            this.BtnDataEntry.Click += new System.EventHandler(this.BtnDataEntry_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.Location = new System.Drawing.Point(5, 209);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(320, 50);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userroleBox);
            this.panel2.Controls.Add(this.usernameBox);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 204);
            this.panel2.TabIndex = 0;
            // 
            // userroleBox
            // 
            this.userroleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.userroleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userroleBox.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.userroleBox.Location = new System.Drawing.Point(108, 170);
            this.userroleBox.Name = "userroleBox";
            this.userroleBox.Size = new System.Drawing.Size(100, 22);
            this.userroleBox.TabIndex = 4;
            this.userroleBox.Text = "User name";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.usernameBox.Location = new System.Drawing.Point(107, 146);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 22);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.Text = "User name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InventoryMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 911);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryMan";
            this.Load += new System.EventHandler(this.InventoryMan_Load);
            this.panel3.ResumeLayout(false);
            this.OBInvenPan.ResumeLayout(false);
            this.OBInvenPan.PerformLayout();
            this.tableLayoutFilterInven.ResumeLayout(false);
            this.tableLayoutFilterInven.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBoxInven;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InventoryView;
        private System.Windows.Forms.Panel OBInvenPan;
        private System.Windows.Forms.Label OBlapelInven;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFilterInven;
        private System.Windows.Forms.TextBox ProductStockBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ProductNameInsert;
        private System.Windows.Forms.TextBox LocationNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductExpirationBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label itemID;
        private System.Windows.Forms.Button OBbuttonInven;
        private System.Windows.Forms.Button OBclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSittings;
        private System.Windows.Forms.Button btnEmployeeMang;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnEmployeesTasks;
        private System.Windows.Forms.Button BtnInventoryMan;
        private System.Windows.Forms.Button BtnSuoliers;
        private System.Windows.Forms.Button BtnReports;
        private System.Windows.Forms.Button BtnDataEntry;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox userroleBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
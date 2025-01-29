using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace OurSystemCode
{
    partial class RFIDConfigure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RFIDConfigure));
            this.gpb_rs232 = new System.Windows.Forms.GroupBox();
            this.btDisConnect232 = new System.Windows.Forms.Button();
            this.btConnect232 = new System.Windows.Forms.Button();
            this.ComboBox_baud2 = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.ComboBox_COM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRFIDConfigure = new System.Windows.Forms.Button();
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
            this.userroleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gpb_rs232.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_rs232
            // 
            this.gpb_rs232.Controls.Add(this.btDisConnect232);
            this.gpb_rs232.Controls.Add(this.btConnect232);
            this.gpb_rs232.Controls.Add(this.ComboBox_baud2);
            this.gpb_rs232.Controls.Add(this.label47);
            this.gpb_rs232.Controls.Add(this.ComboBox_COM);
            this.gpb_rs232.Controls.Add(this.label3);
            this.gpb_rs232.Location = new System.Drawing.Point(180, 32);
            this.gpb_rs232.Margin = new System.Windows.Forms.Padding(8);
            this.gpb_rs232.Name = "gpb_rs232";
            this.gpb_rs232.Padding = new System.Windows.Forms.Padding(8);
            this.gpb_rs232.Size = new System.Drawing.Size(914, 178);
            this.gpb_rs232.TabIndex = 4;
            this.gpb_rs232.TabStop = false;
            this.gpb_rs232.Text = "RS232";
            // 
            // btDisConnect232
            // 
            this.btDisConnect232.Enabled = false;
            this.btDisConnect232.Location = new System.Drawing.Point(624, 106);
            this.btDisConnect232.Margin = new System.Windows.Forms.Padding(8);
            this.btDisConnect232.Name = "btDisConnect232";
            this.btDisConnect232.Size = new System.Drawing.Size(240, 59);
            this.btDisConnect232.TabIndex = 20;
            this.btDisConnect232.Text = "Disconnect";
            this.btDisConnect232.UseVisualStyleBackColor = true;
            // 
            // btConnect232
            // 
            this.btConnect232.Location = new System.Drawing.Point(624, 33);
            this.btConnect232.Margin = new System.Windows.Forms.Padding(8);
            this.btConnect232.Name = "btConnect232";
            this.btConnect232.Size = new System.Drawing.Size(240, 59);
            this.btConnect232.TabIndex = 19;
            this.btConnect232.Text = "Connect";
            this.btConnect232.UseVisualStyleBackColor = true;
            // 
            // ComboBox_baud2
            // 
            this.ComboBox_baud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud2.FormattingEnabled = true;
            this.ComboBox_baud2.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud2.Location = new System.Drawing.Point(256, 109);
            this.ComboBox_baud2.Margin = new System.Windows.Forms.Padding(8);
            this.ComboBox_baud2.Name = "ComboBox_baud2";
            this.ComboBox_baud2.Size = new System.Drawing.Size(316, 33);
            this.ComboBox_baud2.TabIndex = 18;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(56, 123);
            this.label47.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(115, 27);
            this.label47.TabIndex = 17;
            this.label47.Text = "Baud rate:";
            // 
            // ComboBox_COM
            // 
            this.ComboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_COM.FormattingEnabled = true;
            this.ComboBox_COM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.ComboBox_COM.Location = new System.Drawing.Point(256, 39);
            this.ComboBox_COM.Margin = new System.Windows.Forms.Padding(8);
            this.ComboBox_COM.Name = "ComboBox_COM";
            this.ComboBox_COM.Size = new System.Drawing.Size(316, 33);
            this.ComboBox_COM.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Serial Port:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnRFIDConfigure);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Size = new System.Drawing.Size(330, 911);
            this.panel1.TabIndex = 14;
            // 
            // btnRFIDConfigure
            // 
            this.btnRFIDConfigure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRFIDConfigure.FlatAppearance.BorderSize = 0;
            this.btnRFIDConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRFIDConfigure.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRFIDConfigure.Image = ((System.Drawing.Image)(resources.GetObject("btnRFIDConfigure.Image")));
            this.btnRFIDConfigure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRFIDConfigure.Location = new System.Drawing.Point(4, 609);
            this.btnRFIDConfigure.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnRFIDConfigure.Name = "btnRFIDConfigure";
            this.btnRFIDConfigure.Size = new System.Drawing.Size(322, 53);
            this.btnRFIDConfigure.TabIndex = 4;
            this.btnRFIDConfigure.Text = "RFID Reader";
            this.btnRFIDConfigure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRFIDConfigure.UseVisualStyleBackColor = true;
            this.btnRFIDConfigure.Click += new System.EventHandler(this.btnRFIDConfigure_Click);
            // 
            // btnSittings
            // 
            this.btnSittings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSittings.FlatAppearance.BorderSize = 0;
            this.btnSittings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSittings.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSittings.Image = ((System.Drawing.Image)(resources.GetObject("btnSittings.Image")));
            this.btnSittings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSittings.Location = new System.Drawing.Point(4, 559);
            this.btnSittings.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSittings.Name = "btnSittings";
            this.btnSittings.Size = new System.Drawing.Size(322, 50);
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
            this.btnEmployeeMang.Location = new System.Drawing.Point(4, 509);
            this.btnEmployeeMang.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnEmployeeMang.Name = "btnEmployeeMang";
            this.btnEmployeeMang.Size = new System.Drawing.Size(322, 50);
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
            this.button7.Location = new System.Drawing.Point(4, 855);
            this.button7.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(322, 50);
            this.button7.TabIndex = 1;
            this.button7.Text = "Logout";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnEmployeesTasks
            // 
            this.btnEmployeesTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeesTasks.FlatAppearance.BorderSize = 0;
            this.btnEmployeesTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeesTasks.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEmployeesTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeesTasks.Image")));
            this.btnEmployeesTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeesTasks.Location = new System.Drawing.Point(4, 459);
            this.btnEmployeesTasks.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnEmployeesTasks.Name = "btnEmployeesTasks";
            this.btnEmployeesTasks.Size = new System.Drawing.Size(322, 50);
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
            this.BtnInventoryMan.Location = new System.Drawing.Point(4, 409);
            this.BtnInventoryMan.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BtnInventoryMan.Name = "BtnInventoryMan";
            this.BtnInventoryMan.Size = new System.Drawing.Size(322, 50);
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
            this.BtnSuoliers.Location = new System.Drawing.Point(4, 359);
            this.BtnSuoliers.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BtnSuoliers.Name = "BtnSuoliers";
            this.BtnSuoliers.Size = new System.Drawing.Size(322, 50);
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
            this.BtnReports.Location = new System.Drawing.Point(4, 309);
            this.BtnReports.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(322, 50);
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
            this.BtnDataEntry.Location = new System.Drawing.Point(4, 259);
            this.BtnDataEntry.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BtnDataEntry.Name = "BtnDataEntry";
            this.BtnDataEntry.Size = new System.Drawing.Size(322, 50);
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
            this.BtnDashboard.Location = new System.Drawing.Point(4, 209);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(322, 50);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userroleLabel);
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 203);
            this.panel2.TabIndex = 0;
            // 
            // userroleLabel
            // 
            this.userroleLabel.AutoSize = true;
            this.userroleLabel.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.userroleLabel.Location = new System.Drawing.Point(114, 169);
            this.userroleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userroleLabel.Name = "userroleLabel";
            this.userroleLabel.Size = new System.Drawing.Size(73, 21);
            this.userroleLabel.TabIndex = 8;
            this.userroleLabel.Text = "User role";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.Location = new System.Drawing.Point(108, 147);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 21);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "User name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.buttonMinimize);
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Location = new System.Drawing.Point(340, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1269, 208);
            this.panel4.TabIndex = 17;
            this.panel4.Resize += new System.EventHandler(this.panel4_Resize);
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
            this.buttonMinimize.TabIndex = 8;
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
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "RFID Reader";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.gpb_rs232);
            this.panel3.Location = new System.Drawing.Point(356, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1239, 792);
            this.panel3.TabIndex = 18;
            // 
            // RFIDConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 911);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RFIDConfigure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFIDConfigure";
            this.Load += new System.EventHandler(this.RFIDConfigure_Load);
            this.gpb_rs232.ResumeLayout(false);
            this.gpb_rs232.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_rs232;
        private System.Windows.Forms.Button btDisConnect232;
        private System.Windows.Forms.Button btConnect232;
        private System.Windows.Forms.ComboBox ComboBox_baud2;
        private System.Windows.Forms.Label label47;
        internal System.Windows.Forms.ComboBox ComboBox_COM;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRFIDConfigure;
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
        private System.Windows.Forms.Label userroleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Panel panel4;
        private Button buttonMinimize;
        private PictureBox pictureBox7;
        private Label label1;
        private Button button8;
        private Panel panel3;
    }
}
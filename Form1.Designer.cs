﻿namespace FinalHotelReservation
{
    partial class Form1
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label RoomType;
            System.Windows.Forms.Label EmailSearch;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuNavigate = new System.Windows.Forms.TabControl();
            this.NewGuestTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newGuestEmail = new System.Windows.Forms.TextBox();
            this.AddNewGuestBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.newGuestCountry = new System.Windows.Forms.TextBox();
            this.newGuestCity = new System.Windows.Forms.TextBox();
            this.newGuestAddress = new System.Windows.Forms.TextBox();
            this.newGuestSuite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newGuestTelephone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newGuestLastName = new System.Windows.Forms.TextBox();
            this.newGuestFirstName = new System.Windows.Forms.TextBox();
            this.rdNewGuestFemale = new System.Windows.Forms.RadioButton();
            this.rdNewGuestMale = new System.Windows.Forms.RadioButton();
            this.dobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewBookingTab = new System.Windows.Forms.TabPage();
            this.CheckOutPicker = new System.Windows.Forms.DateTimePicker();
            this.CheckinDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SelectedRoomOnBooking = new System.Windows.Forms.ComboBox();
            this.createNewBooking = new System.Windows.Forms.Button();
            this.SearchAvailableRoomsBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AvailableRoomsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EmailSearchTextBox = new System.Windows.Forms.TextBox();
            this.GuestSearchResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.LastNameSearch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.GuestSearchBtn = new System.Windows.Forms.Button();
            this.PhoneNumberSearch = new System.Windows.Forms.TextBox();
            this.FirstNameSearch = new System.Windows.Forms.TextBox();
            this.Pricing = new System.Windows.Forms.TabPage();
            this.TotalPriceBox = new System.Windows.Forms.TextBox();
            this.PromoDiscountPercentage = new System.Windows.Forms.TextBox();
            this.CalculatePricingButton = new System.Windows.Forms.Button();
            this.PricingCheckout = new System.Windows.Forms.DateTimePicker();
            this.PricingCheckin = new System.Windows.Forms.DateTimePicker();
            this.RoomIDBox = new System.Windows.Forms.TextBox();
            this.AdditionalChildrenLabel = new System.Windows.Forms.Label();
            this.AdditionalAdultsLabel = new System.Windows.Forms.Label();
            this.SelectedRoomLabel = new System.Windows.Forms.Label();
            this.SelectedRoomType = new System.Windows.Forms.TextBox();
            this.NumAdditionalChildren = new System.Windows.Forms.TextBox();
            this.NumAdditionalAdults = new System.Windows.Forms.TextBox();
            this.PromoCodeOutput = new System.Windows.Forms.TextBox();
            this.PromoCodeInput = new System.Windows.Forms.TextBox();
            this.PromoCodeApplyDiscount = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.BookingPricing = new System.Windows.Forms.GroupBox();
            this.PricingBox = new System.Windows.Forms.ListBox();
            this.CheckInTab = new System.Windows.Forms.TabPage();
            this.checkInPhoneTextBox = new System.Windows.Forms.TextBox();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.checkInBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SearchBookingsGridView = new System.Windows.Forms.DataGridView();
            this.CheckinLastNameTextBox = new System.Windows.Forms.TextBox();
            this.CheckinFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AllGuestsDataView = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteRow = new System.Windows.Forms.ToolStripButton();
            this.ConfirmBookingBtn = new System.Windows.Forms.Button();
            this.FilterCheckedInOnly = new System.Windows.Forms.Button();
            this.FilterByIncomingGuests = new System.Windows.Forms.Button();
            this.AllGuestsRefreshButton = new System.Windows.Forms.Button();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            emailLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            RoomType = new System.Windows.Forms.Label();
            EmailSearch = new System.Windows.Forms.Label();
            this.MenuNavigate.SuspendLayout();
            this.NewGuestTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.NewBookingTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableRoomsGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestSearchResultsDataGridView)).BeginInit();
            this.Pricing.SuspendLayout();
            this.BookingPricing.SuspendLayout();
            this.CheckInTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBookingsGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllGuestsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 42);
            emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(106, 25);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "First Name";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(6, 215);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(149, 25);
            phoneNumberLabel.TabIndex = 2;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // RoomType
            // 
            RoomType.AutoSize = true;
            RoomType.Location = new System.Drawing.Point(512, 127);
            RoomType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            RoomType.Name = "RoomType";
            RoomType.Size = new System.Drawing.Size(113, 25);
            RoomType.TabIndex = 6;
            RoomType.Text = "Room Type";
            // 
            // EmailSearch
            // 
            EmailSearch.AutoSize = true;
            EmailSearch.Location = new System.Drawing.Point(6, 142);
            EmailSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            EmailSearch.Name = "EmailSearch";
            EmailSearch.Size = new System.Drawing.Size(66, 25);
            EmailSearch.TabIndex = 12;
            EmailSearch.Text = "Email:";
            EmailSearch.Click += new System.EventHandler(this.label14_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1348, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "On";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Location = new System.Drawing.Point(11, 22);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(352, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuNavigate
            // 
            this.MenuNavigate.Controls.Add(this.NewGuestTab);
            this.MenuNavigate.Controls.Add(this.NewBookingTab);
            this.MenuNavigate.Controls.Add(this.Pricing);
            this.MenuNavigate.Controls.Add(this.CheckInTab);
            this.MenuNavigate.Controls.Add(this.tabPage1);
            this.MenuNavigate.Location = new System.Drawing.Point(22, 87);
            this.MenuNavigate.Margin = new System.Windows.Forms.Padding(6);
            this.MenuNavigate.Name = "MenuNavigate";
            this.MenuNavigate.SelectedIndex = 0;
            this.MenuNavigate.Size = new System.Drawing.Size(1423, 744);
            this.MenuNavigate.TabIndex = 4;
            // 
            // NewGuestTab
            // 
            this.NewGuestTab.Controls.Add(this.groupBox2);
            this.NewGuestTab.Controls.Add(this.groupBox1);
            this.NewGuestTab.Location = new System.Drawing.Point(4, 33);
            this.NewGuestTab.Margin = new System.Windows.Forms.Padding(6);
            this.NewGuestTab.Name = "NewGuestTab";
            this.NewGuestTab.Size = new System.Drawing.Size(1415, 707);
            this.NewGuestTab.TabIndex = 2;
            this.NewGuestTab.Text = "New Guest";
            this.NewGuestTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newGuestEmail);
            this.groupBox2.Controls.Add(this.AddNewGuestBtn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.newGuestCountry);
            this.groupBox2.Controls.Add(this.newGuestCity);
            this.groupBox2.Controls.Add(this.newGuestAddress);
            this.groupBox2.Controls.Add(this.newGuestSuite);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.newGuestTelephone);
            this.groupBox2.Location = new System.Drawing.Point(622, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(724, 617);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Contact Information";
            // 
            // newGuestEmail
            // 
            this.newGuestEmail.Location = new System.Drawing.Point(40, 161);
            this.newGuestEmail.Margin = new System.Windows.Forms.Padding(6);
            this.newGuestEmail.Name = "newGuestEmail";
            this.newGuestEmail.Size = new System.Drawing.Size(622, 29);
            this.newGuestEmail.TabIndex = 11;
            // 
            // AddNewGuestBtn
            // 
            this.AddNewGuestBtn.Location = new System.Drawing.Point(374, 545);
            this.AddNewGuestBtn.Margin = new System.Windows.Forms.Padding(6);
            this.AddNewGuestBtn.Name = "AddNewGuestBtn";
            this.AddNewGuestBtn.Size = new System.Drawing.Size(288, 61);
            this.AddNewGuestBtn.TabIndex = 5;
            this.AddNewGuestBtn.Text = "Add New Guest";
            this.AddNewGuestBtn.UseVisualStyleBackColor = true;
            this.AddNewGuestBtn.Click += new System.EventHandler(this.AddNewGuestBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Email";
            // 
            // newGuestCountry
            // 
            this.newGuestCountry.Location = new System.Drawing.Point(40, 502);
            this.newGuestCountry.Margin = new System.Windows.Forms.Padding(6);
            this.newGuestCountry.Name = "newGuestCountry";
            this.newGuestCountry.Size = new System.Drawing.Size(622, 29);
            this.newGuestCountry.TabIndex = 9;
            // 
            // newGuestCity
            // 
            this.newGuestCity.Location = new System.Drawing.Point(40, 412);
            this.newGuestCity.Margin = new System.Windows.Forms.Padding(6);
            this.newGuestCity.Name = "newGuestCity";
            this.newGuestCity.Size = new System.Drawing.Size(622, 29);
            this.newGuestCity.TabIndex = 8;
            // 
            // newGuestAddress
            // 
            this.newGuestAddress.Location = new System.Drawing.Point(40, 314);
            this.newGuestAddress.Margin = new System.Windows.Forms.Padding(6);
            this.newGuestAddress.Name = "newGuestAddress";
            this.newGuestAddress.Size = new System.Drawing.Size(622, 29);
            this.newGuestAddress.TabIndex = 7;
            // 
            // newGuestSuite
            // 
            this.newGuestSuite.Location = new System.Drawing.Point(40, 234);
            this.newGuestSuite.Margin = new System.Windows.Forms.Padding(6);
            this.newGuestSuite.Name = "newGuestSuite";
            this.newGuestSuite.Size = new System.Drawing.Size(622, 29);
            this.newGuestSuite.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 458);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 366);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Suite Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telephone Number";
            // 
            // newGuestTelephone
            // 
            this.newGuestTelephone.Location = new System.Drawing.Point(42, 87);
            this.newGuestTelephone.Margin = new System.Windows.Forms.Padding(6);
            this.newGuestTelephone.Name = "newGuestTelephone";
            this.newGuestTelephone.Size = new System.Drawing.Size(620, 29);
            this.newGuestTelephone.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.newGuestLastName);
            this.groupBox1.Controls.Add(this.newGuestFirstName);
            this.groupBox1.Controls.Add(this.rdNewGuestFemale);
            this.groupBox1.Controls.Add(this.rdNewGuestMale);
            this.groupBox1.Controls.Add(this.dobDatePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1095, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender";
            // 
            // newGuestLastName
            // 
            this.newGuestLastName.Location = new System.Drawing.Point(24, 190);
            this.newGuestLastName.Margin = new System.Windows.Forms.Padding(6);
            this.newGuestLastName.Name = "newGuestLastName";
            this.newGuestLastName.Size = new System.Drawing.Size(404, 29);
            this.newGuestLastName.TabIndex = 8;
            this.newGuestLastName.TextChanged += new System.EventHandler(this.newGuestLastName_TextChanged);
            // 
            // newGuestFirstName
            // 
            this.newGuestFirstName.Location = new System.Drawing.Point(20, 98);
            this.newGuestFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.newGuestFirstName.Name = "newGuestFirstName";
            this.newGuestFirstName.Size = new System.Drawing.Size(409, 29);
            this.newGuestFirstName.TabIndex = 7;
            this.newGuestFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdNewGuestFemale
            // 
            this.rdNewGuestFemale.AutoSize = true;
            this.rdNewGuestFemale.Location = new System.Drawing.Point(18, 469);
            this.rdNewGuestFemale.Margin = new System.Windows.Forms.Padding(6);
            this.rdNewGuestFemale.Name = "rdNewGuestFemale";
            this.rdNewGuestFemale.Size = new System.Drawing.Size(102, 29);
            this.rdNewGuestFemale.TabIndex = 5;
            this.rdNewGuestFemale.TabStop = true;
            this.rdNewGuestFemale.Text = "Female";
            this.rdNewGuestFemale.UseVisualStyleBackColor = true;
            // 
            // rdNewGuestMale
            // 
            this.rdNewGuestMale.AutoSize = true;
            this.rdNewGuestMale.Location = new System.Drawing.Point(18, 426);
            this.rdNewGuestMale.Margin = new System.Windows.Forms.Padding(6);
            this.rdNewGuestMale.Name = "rdNewGuestMale";
            this.rdNewGuestMale.Size = new System.Drawing.Size(80, 29);
            this.rdNewGuestMale.TabIndex = 4;
            this.rdNewGuestMale.TabStop = true;
            this.rdNewGuestMale.Text = "Male";
            this.rdNewGuestMale.UseVisualStyleBackColor = true;
            // 
            // dobDatePicker
            // 
            this.dobDatePicker.Location = new System.Drawing.Point(20, 299);
            this.dobDatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.dobDatePicker.Name = "dobDatePicker";
            this.dobDatePicker.Size = new System.Drawing.Size(374, 29);
            this.dobDatePicker.TabIndex = 3;
            this.dobDatePicker.ValueChanged += new System.EventHandler(this.dobDatePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // NewBookingTab
            // 
            this.NewBookingTab.Controls.Add(this.CheckOutPicker);
            this.NewBookingTab.Controls.Add(this.CheckinDatePicker);
            this.NewBookingTab.Controls.Add(this.SelectedRoomOnBooking);
            this.NewBookingTab.Controls.Add(this.createNewBooking);
            this.NewBookingTab.Controls.Add(this.SearchAvailableRoomsBtn);
            this.NewBookingTab.Controls.Add(RoomType);
            this.NewBookingTab.Controls.Add(this.groupBox4);
            this.NewBookingTab.Controls.Add(this.groupBox3);
            this.NewBookingTab.Location = new System.Drawing.Point(4, 33);
            this.NewBookingTab.Margin = new System.Windows.Forms.Padding(6);
            this.NewBookingTab.Name = "NewBookingTab";
            this.NewBookingTab.Padding = new System.Windows.Forms.Padding(6);
            this.NewBookingTab.Size = new System.Drawing.Size(1415, 707);
            this.NewBookingTab.TabIndex = 1;
            this.NewBookingTab.Text = "New Booking";
            this.NewBookingTab.UseVisualStyleBackColor = true;
            // 
            // CheckOutPicker
            // 
            this.CheckOutPicker.CustomFormat = "YYYYMMDD";
            this.CheckOutPicker.Location = new System.Drawing.Point(977, 88);
            this.CheckOutPicker.Name = "CheckOutPicker";
            this.CheckOutPicker.Size = new System.Drawing.Size(415, 29);
            this.CheckOutPicker.TabIndex = 16;
            // 
            // CheckinDatePicker
            // 
            this.CheckinDatePicker.CustomFormat = "YYYYMMDD";
            this.CheckinDatePicker.Location = new System.Drawing.Point(517, 88);
            this.CheckinDatePicker.Name = "CheckinDatePicker";
            this.CheckinDatePicker.Size = new System.Drawing.Size(420, 29);
            this.CheckinDatePicker.TabIndex = 15;
            // 
            // SelectedRoomOnBooking
            // 
            this.SelectedRoomOnBooking.FormattingEnabled = true;
            this.SelectedRoomOnBooking.Location = new System.Drawing.Point(517, 163);
            this.SelectedRoomOnBooking.Name = "SelectedRoomOnBooking";
            this.SelectedRoomOnBooking.Size = new System.Drawing.Size(420, 32);
            this.SelectedRoomOnBooking.TabIndex = 14;
            this.SelectedRoomOnBooking.SelectedIndexChanged += new System.EventHandler(this.SelectedRoomOnBooking_SelectedIndexChanged);
            // 
            // createNewBooking
            // 
            this.createNewBooking.Location = new System.Drawing.Point(512, 622);
            this.createNewBooking.Margin = new System.Windows.Forms.Padding(6);
            this.createNewBooking.Name = "createNewBooking";
            this.createNewBooking.Size = new System.Drawing.Size(880, 48);
            this.createNewBooking.TabIndex = 12;
            this.createNewBooking.Text = "Create New Booking";
            this.createNewBooking.UseVisualStyleBackColor = true;
            this.createNewBooking.Click += new System.EventHandler(this.createNewBooking_Click);
            // 
            // SearchAvailableRoomsBtn
            // 
            this.SearchAvailableRoomsBtn.Location = new System.Drawing.Point(1190, 157);
            this.SearchAvailableRoomsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SearchAvailableRoomsBtn.Name = "SearchAvailableRoomsBtn";
            this.SearchAvailableRoomsBtn.Size = new System.Drawing.Size(209, 42);
            this.SearchAvailableRoomsBtn.TabIndex = 7;
            this.SearchAvailableRoomsBtn.Text = "Search Rooms";
            this.SearchAvailableRoomsBtn.UseVisualStyleBackColor = true;
            this.SearchAvailableRoomsBtn.Click += new System.EventHandler(this.SearchAvailableRoomsBtnFunction);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AvailableRoomsGridView);
            this.groupBox4.Location = new System.Drawing.Point(512, 205);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(895, 406);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available Rooms";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // AvailableRoomsGridView
            // 
            this.AvailableRoomsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableRoomsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableRoomsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AvailableRoomsGridView.Location = new System.Drawing.Point(6, 28);
            this.AvailableRoomsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.AvailableRoomsGridView.Name = "AvailableRoomsGridView";
            this.AvailableRoomsGridView.RowHeadersWidth = 72;
            this.AvailableRoomsGridView.RowTemplate.Height = 31;
            this.AvailableRoomsGridView.Size = new System.Drawing.Size(883, 372);
            this.AvailableRoomsGridView.TabIndex = 0;
            this.AvailableRoomsGridView.SelectionChanged += new System.EventHandler(this.AvailableRoomSelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(EmailSearch);
            this.groupBox3.Controls.Add(this.EmailSearchTextBox);
            this.groupBox3.Controls.Add(this.GuestSearchResultsDataGridView);
            this.groupBox3.Controls.Add(this.LastNameSearch);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.GuestSearchBtn);
            this.groupBox3.Controls.Add(phoneNumberLabel);
            this.groupBox3.Controls.Add(this.PhoneNumberSearch);
            this.groupBox3.Controls.Add(emailLabel);
            this.groupBox3.Controls.Add(this.FirstNameSearch);
            this.groupBox3.Location = new System.Drawing.Point(39, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(462, 626);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guest Information";
            // 
            // EmailSearchTextBox
            // 
            this.EmailSearchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "PhoneNumber", true));
            this.EmailSearchTextBox.Location = new System.Drawing.Point(8, 173);
            this.EmailSearchTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.EmailSearchTextBox.Name = "EmailSearchTextBox";
            this.EmailSearchTextBox.Size = new System.Drawing.Size(422, 29);
            this.EmailSearchTextBox.TabIndex = 11;
            // 
            // GuestSearchResultsDataGridView
            // 
            this.GuestSearchResultsDataGridView.AllowUserToAddRows = false;
            this.GuestSearchResultsDataGridView.AllowUserToDeleteRows = false;
            this.GuestSearchResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestSearchResultsDataGridView.Location = new System.Drawing.Point(11, 370);
            this.GuestSearchResultsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.GuestSearchResultsDataGridView.Name = "GuestSearchResultsDataGridView";
            this.GuestSearchResultsDataGridView.ReadOnly = true;
            this.GuestSearchResultsDataGridView.RowHeadersWidth = 72;
            this.GuestSearchResultsDataGridView.Size = new System.Drawing.Size(422, 189);
            this.GuestSearchResultsDataGridView.TabIndex = 5;
            // 
            // LastNameSearch
            // 
            this.LastNameSearch.Location = new System.Drawing.Point(220, 81);
            this.LastNameSearch.Margin = new System.Windows.Forms.Padding(6);
            this.LastNameSearch.Name = "LastNameSearch";
            this.LastNameSearch.Size = new System.Drawing.Size(217, 29);
            this.LastNameSearch.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(220, 42);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 25);
            this.label17.TabIndex = 9;
            this.label17.Text = "Last Name";
            // 
            // GuestSearchBtn
            // 
            this.GuestSearchBtn.Location = new System.Drawing.Point(8, 306);
            this.GuestSearchBtn.Margin = new System.Windows.Forms.Padding(6);
            this.GuestSearchBtn.Name = "GuestSearchBtn";
            this.GuestSearchBtn.Size = new System.Drawing.Size(425, 41);
            this.GuestSearchBtn.TabIndex = 4;
            this.GuestSearchBtn.Text = "Search Guests";
            this.GuestSearchBtn.UseVisualStyleBackColor = true;
            this.GuestSearchBtn.Click += new System.EventHandler(this.GuestSearchBtn_Click);
            // 
            // PhoneNumberSearch
            // 
            this.PhoneNumberSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "PhoneNumber", true));
            this.PhoneNumberSearch.Location = new System.Drawing.Point(8, 246);
            this.PhoneNumberSearch.Margin = new System.Windows.Forms.Padding(6);
            this.PhoneNumberSearch.Name = "PhoneNumberSearch";
            this.PhoneNumberSearch.Size = new System.Drawing.Size(422, 29);
            this.PhoneNumberSearch.TabIndex = 3;
            // 
            // FirstNameSearch
            // 
            this.FirstNameSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestBindingSource, "Email", true));
            this.FirstNameSearch.Location = new System.Drawing.Point(11, 81);
            this.FirstNameSearch.Margin = new System.Windows.Forms.Padding(6);
            this.FirstNameSearch.Name = "FirstNameSearch";
            this.FirstNameSearch.Size = new System.Drawing.Size(186, 29);
            this.FirstNameSearch.TabIndex = 1;
            // 
            // Pricing
            // 
            this.Pricing.Controls.Add(this.ConfirmBookingBtn);
            this.Pricing.Controls.Add(this.TotalPriceBox);
            this.Pricing.Controls.Add(this.PromoDiscountPercentage);
            this.Pricing.Controls.Add(this.CalculatePricingButton);
            this.Pricing.Controls.Add(this.PricingCheckout);
            this.Pricing.Controls.Add(this.PricingCheckin);
            this.Pricing.Controls.Add(this.RoomIDBox);
            this.Pricing.Controls.Add(this.AdditionalChildrenLabel);
            this.Pricing.Controls.Add(this.AdditionalAdultsLabel);
            this.Pricing.Controls.Add(this.SelectedRoomLabel);
            this.Pricing.Controls.Add(this.SelectedRoomType);
            this.Pricing.Controls.Add(this.NumAdditionalChildren);
            this.Pricing.Controls.Add(this.NumAdditionalAdults);
            this.Pricing.Controls.Add(this.PromoCodeOutput);
            this.Pricing.Controls.Add(this.PromoCodeInput);
            this.Pricing.Controls.Add(this.PromoCodeApplyDiscount);
            this.Pricing.Controls.Add(this.label16);
            this.Pricing.Controls.Add(this.BookingPricing);
            this.Pricing.Location = new System.Drawing.Point(4, 33);
            this.Pricing.Name = "Pricing";
            this.Pricing.Padding = new System.Windows.Forms.Padding(3);
            this.Pricing.Size = new System.Drawing.Size(1415, 707);
            this.Pricing.TabIndex = 4;
            this.Pricing.Text = "Pricing";
            this.Pricing.UseVisualStyleBackColor = true;
            // 
            // TotalPriceBox
            // 
            this.TotalPriceBox.Location = new System.Drawing.Point(908, 558);
            this.TotalPriceBox.Name = "TotalPriceBox";
            this.TotalPriceBox.Size = new System.Drawing.Size(100, 29);
            this.TotalPriceBox.TabIndex = 29;
            this.TotalPriceBox.Visible = false;
            // 
            // PromoDiscountPercentage
            // 
            this.PromoDiscountPercentage.Location = new System.Drawing.Point(368, 520);
            this.PromoDiscountPercentage.Name = "PromoDiscountPercentage";
            this.PromoDiscountPercentage.Size = new System.Drawing.Size(100, 29);
            this.PromoDiscountPercentage.TabIndex = 28;
            this.PromoDiscountPercentage.Text = "0";
            this.PromoDiscountPercentage.Visible = false;
            // 
            // CalculatePricingButton
            // 
            this.CalculatePricingButton.Location = new System.Drawing.Point(655, 549);
            this.CalculatePricingButton.Name = "CalculatePricingButton";
            this.CalculatePricingButton.Size = new System.Drawing.Size(231, 57);
            this.CalculatePricingButton.TabIndex = 27;
            this.CalculatePricingButton.Text = "Calculate Pricing";
            this.CalculatePricingButton.UseVisualStyleBackColor = true;
            this.CalculatePricingButton.Click += new System.EventHandler(this.CalculatePricingButton_Click);
            // 
            // PricingCheckout
            // 
            this.PricingCheckout.CustomFormat = "YYYYMMDD";
            this.PricingCheckout.Location = new System.Drawing.Point(299, 177);
            this.PricingCheckout.Name = "PricingCheckout";
            this.PricingCheckout.Size = new System.Drawing.Size(169, 29);
            this.PricingCheckout.TabIndex = 26;
            // 
            // PricingCheckin
            // 
            this.PricingCheckin.CustomFormat = "YYYYMMDD";
            this.PricingCheckin.Location = new System.Drawing.Point(48, 177);
            this.PricingCheckin.Name = "PricingCheckin";
            this.PricingCheckin.Size = new System.Drawing.Size(174, 29);
            this.PricingCheckin.TabIndex = 25;
            // 
            // RoomIDBox
            // 
            this.RoomIDBox.Location = new System.Drawing.Point(368, 67);
            this.RoomIDBox.Name = "RoomIDBox";
            this.RoomIDBox.ReadOnly = true;
            this.RoomIDBox.Size = new System.Drawing.Size(100, 29);
            this.RoomIDBox.TabIndex = 24;
            // 
            // AdditionalChildrenLabel
            // 
            this.AdditionalChildrenLabel.AutoSize = true;
            this.AdditionalChildrenLabel.Location = new System.Drawing.Point(48, 324);
            this.AdditionalChildrenLabel.Name = "AdditionalChildrenLabel";
            this.AdditionalChildrenLabel.Size = new System.Drawing.Size(451, 25);
            this.AdditionalChildrenLabel.TabIndex = 23;
            this.AdditionalChildrenLabel.Text = "Number of Additional Children (under 12 years old)";
            // 
            // AdditionalAdultsLabel
            // 
            this.AdditionalAdultsLabel.AutoSize = true;
            this.AdditionalAdultsLabel.Location = new System.Drawing.Point(48, 234);
            this.AdditionalAdultsLabel.Name = "AdditionalAdultsLabel";
            this.AdditionalAdultsLabel.Size = new System.Drawing.Size(253, 25);
            this.AdditionalAdultsLabel.TabIndex = 22;
            this.AdditionalAdultsLabel.Text = "Number of Additional Adults";
            // 
            // SelectedRoomLabel
            // 
            this.SelectedRoomLabel.AutoSize = true;
            this.SelectedRoomLabel.Location = new System.Drawing.Point(48, 70);
            this.SelectedRoomLabel.Name = "SelectedRoomLabel";
            this.SelectedRoomLabel.Size = new System.Drawing.Size(145, 25);
            this.SelectedRoomLabel.TabIndex = 21;
            this.SelectedRoomLabel.Text = "Selected Room";
            // 
            // SelectedRoomType
            // 
            this.SelectedRoomType.Location = new System.Drawing.Point(48, 109);
            this.SelectedRoomType.Name = "SelectedRoomType";
            this.SelectedRoomType.Size = new System.Drawing.Size(420, 29);
            this.SelectedRoomType.TabIndex = 20;
            // 
            // NumAdditionalChildren
            // 
            this.NumAdditionalChildren.Location = new System.Drawing.Point(48, 355);
            this.NumAdditionalChildren.Name = "NumAdditionalChildren";
            this.NumAdditionalChildren.Size = new System.Drawing.Size(420, 29);
            this.NumAdditionalChildren.TabIndex = 19;
            // 
            // NumAdditionalAdults
            // 
            this.NumAdditionalAdults.Location = new System.Drawing.Point(48, 265);
            this.NumAdditionalAdults.Name = "NumAdditionalAdults";
            this.NumAdditionalAdults.Size = new System.Drawing.Size(420, 29);
            this.NumAdditionalAdults.TabIndex = 18;
            // 
            // PromoCodeOutput
            // 
            this.PromoCodeOutput.Location = new System.Drawing.Point(280, 481);
            this.PromoCodeOutput.Name = "PromoCodeOutput";
            this.PromoCodeOutput.ReadOnly = true;
            this.PromoCodeOutput.Size = new System.Drawing.Size(188, 29);
            this.PromoCodeOutput.TabIndex = 17;
            // 
            // PromoCodeInput
            // 
            this.PromoCodeInput.Location = new System.Drawing.Point(48, 481);
            this.PromoCodeInput.Name = "PromoCodeInput";
            this.PromoCodeInput.Size = new System.Drawing.Size(196, 29);
            this.PromoCodeInput.TabIndex = 16;
            // 
            // PromoCodeApplyDiscount
            // 
            this.PromoCodeApplyDiscount.Location = new System.Drawing.Point(48, 558);
            this.PromoCodeApplyDiscount.Margin = new System.Windows.Forms.Padding(6);
            this.PromoCodeApplyDiscount.Name = "PromoCodeApplyDiscount";
            this.PromoCodeApplyDiscount.Size = new System.Drawing.Size(431, 48);
            this.PromoCodeApplyDiscount.TabIndex = 15;
            this.PromoCodeApplyDiscount.Text = "Add Discount";
            this.PromoCodeApplyDiscount.UseVisualStyleBackColor = true;
            this.PromoCodeApplyDiscount.Click += new System.EventHandler(this.PromoCodeApplyDiscount_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 453);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "Add Promotion";
            // 
            // BookingPricing
            // 
            this.BookingPricing.Controls.Add(this.PricingBox);
            this.BookingPricing.Location = new System.Drawing.Point(655, 70);
            this.BookingPricing.Name = "BookingPricing";
            this.BookingPricing.Size = new System.Drawing.Size(691, 440);
            this.BookingPricing.TabIndex = 0;
            this.BookingPricing.TabStop = false;
            this.BookingPricing.Text = "Pricing";
            // 
            // PricingBox
            // 
            this.PricingBox.FormattingEnabled = true;
            this.PricingBox.ItemHeight = 24;
            this.PricingBox.Location = new System.Drawing.Point(6, 46);
            this.PricingBox.Name = "PricingBox";
            this.PricingBox.Size = new System.Drawing.Size(679, 388);
            this.PricingBox.TabIndex = 0;
            // 
            // CheckInTab
            // 
            this.CheckInTab.Controls.Add(this.checkInPhoneTextBox);
            this.CheckInTab.Controls.Add(this.checkOutBtn);
            this.CheckInTab.Controls.Add(this.label18);
            this.CheckInTab.Controls.Add(this.checkInBtn);
            this.CheckInTab.Controls.Add(this.button5);
            this.CheckInTab.Controls.Add(this.groupBox5);
            this.CheckInTab.Controls.Add(this.CheckinLastNameTextBox);
            this.CheckInTab.Controls.Add(this.CheckinFirstName);
            this.CheckInTab.Controls.Add(this.label13);
            this.CheckInTab.Controls.Add(this.label12);
            this.CheckInTab.Controls.Add(this.label11);
            this.CheckInTab.Location = new System.Drawing.Point(4, 33);
            this.CheckInTab.Margin = new System.Windows.Forms.Padding(6);
            this.CheckInTab.Name = "CheckInTab";
            this.CheckInTab.Padding = new System.Windows.Forms.Padding(6);
            this.CheckInTab.Size = new System.Drawing.Size(1415, 707);
            this.CheckInTab.TabIndex = 0;
            this.CheckInTab.Text = "Check - In";
            this.CheckInTab.UseVisualStyleBackColor = true;
            this.CheckInTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // checkInPhoneTextBox
            // 
            this.checkInPhoneTextBox.Location = new System.Drawing.Point(33, 395);
            this.checkInPhoneTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.checkInPhoneTextBox.Name = "checkInPhoneTextBox";
            this.checkInPhoneTextBox.Size = new System.Drawing.Size(294, 29);
            this.checkInPhoneTextBox.TabIndex = 8;
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Location = new System.Drawing.Point(1164, 617);
            this.checkOutBtn.Margin = new System.Windows.Forms.Padding(6);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(124, 43);
            this.checkOutBtn.TabIndex = 1;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 366);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(180, 25);
            this.label18.TabIndex = 7;
            this.label18.Text = "Telephone Number";
            // 
            // checkInBtn
            // 
            this.checkInBtn.Location = new System.Drawing.Point(733, 617);
            this.checkInBtn.Margin = new System.Windows.Forms.Padding(6);
            this.checkInBtn.Name = "checkInBtn";
            this.checkInBtn.Size = new System.Drawing.Size(126, 43);
            this.checkInBtn.TabIndex = 0;
            this.checkInBtn.Text = "Check In";
            this.checkInBtn.UseVisualStyleBackColor = true;
            this.checkInBtn.Click += new System.EventHandler(this.checkInBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(190, 229);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 40);
            this.button5.TabIndex = 6;
            this.button5.Text = "Search For Bookings";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SearchBookingsGridView);
            this.groupBox5.Location = new System.Drawing.Point(644, 30);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(734, 533);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Booking";
            // 
            // SearchBookingsGridView
            // 
            this.SearchBookingsGridView.AllowUserToAddRows = false;
            this.SearchBookingsGridView.AllowUserToDeleteRows = false;
            this.SearchBookingsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchBookingsGridView.Location = new System.Drawing.Point(0, 26);
            this.SearchBookingsGridView.Name = "SearchBookingsGridView";
            this.SearchBookingsGridView.ReadOnly = true;
            this.SearchBookingsGridView.RowHeadersWidth = 72;
            this.SearchBookingsGridView.Size = new System.Drawing.Size(730, 507);
            this.SearchBookingsGridView.TabIndex = 2;
            // 
            // CheckinLastNameTextBox
            // 
            this.CheckinLastNameTextBox.Location = new System.Drawing.Point(18, 151);
            this.CheckinLastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CheckinLastNameTextBox.Name = "CheckinLastNameTextBox";
            this.CheckinLastNameTextBox.Size = new System.Drawing.Size(309, 29);
            this.CheckinLastNameTextBox.TabIndex = 4;
            // 
            // CheckinFirstName
            // 
            this.CheckinFirstName.Location = new System.Drawing.Point(18, 80);
            this.CheckinFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.CheckinFirstName.Name = "CheckinFirstName";
            this.CheckinFirstName.Size = new System.Drawing.Size(309, 29);
            this.CheckinFirstName.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Last Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 56);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Guest Information";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AllGuestsDataView);
            this.tabPage1.Controls.Add(this.FilterByIncomingGuests);
            this.tabPage1.Controls.Add(this.AllGuestsRefreshButton);
            this.tabPage1.Controls.Add(this.FilterCheckedInOnly);
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1415, 707);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "All Guests";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AllGuestsDataView
            // 
            this.AllGuestsDataView.AllowUserToAddRows = false;
            this.AllGuestsDataView.AutoGenerateColumns = false;
            this.AllGuestsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllGuestsDataView.DataSource = this.bindingSource1;
            this.AllGuestsDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllGuestsDataView.Location = new System.Drawing.Point(0, 38);
            this.AllGuestsDataView.Margin = new System.Windows.Forms.Padding(6);
            this.AllGuestsDataView.Name = "AllGuestsDataView";
            this.AllGuestsDataView.RowHeadersWidth = 72;
            this.AllGuestsDataView.Size = new System.Drawing.Size(1415, 669);
            this.AllGuestsDataView.TabIndex = 1;
            this.AllGuestsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.deleteRow});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1415, 38);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(88, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // deleteRow
            // 
            this.deleteRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteRow.Image = global::FinalHotelReservation.Properties.Resources.download;
            this.deleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(40, 32);
            this.deleteRow.Text = "Delete";
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // ConfirmBookingBtn
            // 
            this.ConfirmBookingBtn.Location = new System.Drawing.Point(1090, 549);
            this.ConfirmBookingBtn.Name = "ConfirmBookingBtn";
            this.ConfirmBookingBtn.Size = new System.Drawing.Size(256, 57);
            this.ConfirmBookingBtn.TabIndex = 30;
            this.ConfirmBookingBtn.Text = "Confirm Booking";
            this.ConfirmBookingBtn.UseVisualStyleBackColor = true;
            this.ConfirmBookingBtn.Click += new System.EventHandler(this.ConfirmBookingBtn_Click);
            // 
            // FilterCheckedInOnly
            // 
            this.FilterCheckedInOnly.Location = new System.Drawing.Point(863, 0);
            this.FilterCheckedInOnly.Name = "FilterCheckedInOnly";
            this.FilterCheckedInOnly.Size = new System.Drawing.Size(255, 38);
            this.FilterCheckedInOnly.TabIndex = 5;
            this.FilterCheckedInOnly.Text = "Filter By Checked-in Only";
            this.FilterCheckedInOnly.UseVisualStyleBackColor = true;
            this.FilterCheckedInOnly.Click += new System.EventHandler(this.FilterCheckedInOnly_Click);
            // 
            // FilterByIncomingGuests
            // 
            this.FilterByIncomingGuests.Location = new System.Drawing.Point(1140, 0);
            this.FilterByIncomingGuests.Name = "FilterByIncomingGuests";
            this.FilterByIncomingGuests.Size = new System.Drawing.Size(254, 38);
            this.FilterByIncomingGuests.TabIndex = 6;
            this.FilterByIncomingGuests.Text = "Filter By Incoming Guests";
            this.FilterByIncomingGuests.UseVisualStyleBackColor = true;
            this.FilterByIncomingGuests.Click += new System.EventHandler(this.FilterByIncomingGuests_Click);
            // 
            // AllGuestsRefreshButton
            // 
            this.AllGuestsRefreshButton.Location = new System.Drawing.Point(709, 0);
            this.AllGuestsRefreshButton.Name = "AllGuestsRefreshButton";
            this.AllGuestsRefreshButton.Size = new System.Drawing.Size(122, 38);
            this.AllGuestsRefreshButton.TabIndex = 7;
            this.AllGuestsRefreshButton.Text = "All Guests";
            this.AllGuestsRefreshButton.UseVisualStyleBackColor = true;
            this.AllGuestsRefreshButton.Click += new System.EventHandler(this.AllGuestsRefreshButton_Click);
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataSource = typeof(FinalHotelReservation.Data.Guest);
            // 
            // guestBindingSource1
            // 
            this.guestBindingSource1.DataSource = typeof(FinalHotelReservation.Data.Guest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 947);
            this.Controls.Add(this.MenuNavigate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.MenuNavigate.ResumeLayout(false);
            this.NewGuestTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.NewBookingTab.ResumeLayout(false);
            this.NewBookingTab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableRoomsGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GuestSearchResultsDataGridView)).EndInit();
            this.Pricing.ResumeLayout(false);
            this.Pricing.PerformLayout();
            this.BookingPricing.ResumeLayout(false);
            this.CheckInTab.ResumeLayout(false);
            this.CheckInTab.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchBookingsGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllGuestsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl MenuNavigate;
        private System.Windows.Forms.TabPage CheckInTab;
        private System.Windows.Forms.TabPage NewBookingTab;
        private System.Windows.Forms.TabPage NewGuestTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox newGuestCountry;
        private System.Windows.Forms.TextBox newGuestCity;
        private System.Windows.Forms.TextBox newGuestAddress;
        private System.Windows.Forms.TextBox newGuestSuite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newGuestTelephone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newGuestLastName;
        private System.Windows.Forms.TextBox newGuestFirstName;
        private System.Windows.Forms.RadioButton rdNewGuestFemale;
        private System.Windows.Forms.RadioButton rdNewGuestMale;
        private System.Windows.Forms.DateTimePicker dobDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewGuestBtn;
        private System.Windows.Forms.TextBox newGuestEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private System.Windows.Forms.DataGridView AllGuestsDataView;
        private System.Windows.Forms.BindingSource guestBindingSource1;
        private System.Windows.Forms.ToolStripButton deleteRow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button GuestSearchBtn;
        private System.Windows.Forms.TextBox PhoneNumberSearch;
        private System.Windows.Forms.TextBox FirstNameSearch;
        private System.Windows.Forms.DataGridView AvailableRoomsGridView;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView SearchBookingsGridView;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.Button checkInBtn;
        private System.Windows.Forms.TextBox CheckinLastNameTextBox;
        private System.Windows.Forms.TextBox CheckinFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SearchAvailableRoomsBtn;
        private System.Windows.Forms.DataGridView GuestSearchResultsDataGridView;
        private System.Windows.Forms.Button createNewBooking;
        private System.Windows.Forms.TextBox LastNameSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox checkInPhoneTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox SelectedRoomOnBooking;
        private System.Windows.Forms.DateTimePicker CheckOutPicker;
        private System.Windows.Forms.DateTimePicker CheckinDatePicker;
        private System.Windows.Forms.TabPage Pricing;
        private System.Windows.Forms.GroupBox BookingPricing;
        private System.Windows.Forms.TextBox PromoCodeOutput;
        private System.Windows.Forms.TextBox PromoCodeInput;
        private System.Windows.Forms.Button PromoCodeApplyDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label AdditionalChildrenLabel;
        private System.Windows.Forms.Label AdditionalAdultsLabel;
        private System.Windows.Forms.Label SelectedRoomLabel;
        private System.Windows.Forms.TextBox SelectedRoomType;
        private System.Windows.Forms.TextBox NumAdditionalChildren;
        private System.Windows.Forms.TextBox NumAdditionalAdults;
        private System.Windows.Forms.TextBox RoomIDBox;
        private System.Windows.Forms.DateTimePicker PricingCheckout;
        private System.Windows.Forms.DateTimePicker PricingCheckin;
        private System.Windows.Forms.Button CalculatePricingButton;
        private System.Windows.Forms.TextBox PromoDiscountPercentage;
        private System.Windows.Forms.ListBox PricingBox;
        private System.Windows.Forms.TextBox TotalPriceBox;
        private System.Windows.Forms.TextBox EmailSearchTextBox;
        private System.Windows.Forms.Button ConfirmBookingBtn;
        private System.Windows.Forms.Button FilterCheckedInOnly;
        private System.Windows.Forms.Button FilterByIncomingGuests;
        private System.Windows.Forms.Button AllGuestsRefreshButton;
    }
}


namespace Computing_Coursework
{
    partial class FrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.GrpBxDistricts = new System.Windows.Forms.GroupBox();
            this.listViewDISTRICT = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewNEIGHB = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewPROP = new System.Windows.Forms.ListBox();
            this.btnADDDIST = new System.Windows.Forms.Button();
            this.btnADDNEIGHB = new System.Windows.Forms.Button();
            this.btnADDPROP = new System.Windows.Forms.Button();
            this.btnEDITDIST = new System.Windows.Forms.Button();
            this.btnEDITNEIGHB = new System.Windows.Forms.Button();
            this.btnEDITPROP = new System.Windows.Forms.Button();
            this.btnDELPROP = new System.Windows.Forms.Button();
            this.TXTBoxsearch = new System.Windows.Forms.TextBox();
            this.lstboxDisplay = new System.Windows.Forms.ListBox();
            this.GrpBxDistricts.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBxDistricts
            // 
            this.GrpBxDistricts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.GrpBxDistricts.Controls.Add(this.listViewDISTRICT);
            this.GrpBxDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBxDistricts.ForeColor = System.Drawing.Color.Purple;
            this.GrpBxDistricts.Location = new System.Drawing.Point(12, 12);
            this.GrpBxDistricts.Name = "GrpBxDistricts";
            this.GrpBxDistricts.Size = new System.Drawing.Size(419, 170);
            this.GrpBxDistricts.TabIndex = 0;
            this.GrpBxDistricts.TabStop = false;
            this.GrpBxDistricts.Text = "District";
            // 
            // listViewDISTRICT
            // 
            this.listViewDISTRICT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.listViewDISTRICT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDISTRICT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDISTRICT.ForeColor = System.Drawing.Color.Purple;
            this.listViewDISTRICT.FormattingEnabled = true;
            this.listViewDISTRICT.ItemHeight = 22;
            this.listViewDISTRICT.Location = new System.Drawing.Point(6, 25);
            this.listViewDISTRICT.Name = "listViewDISTRICT";
            this.listViewDISTRICT.Size = new System.Drawing.Size(407, 132);
            this.listViewDISTRICT.TabIndex = 2;
            this.listViewDISTRICT.SelectedIndexChanged += new System.EventHandler(this.listViewDISTRICT_SelectIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.listViewNEIGHB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neighbourhood";
            // 
            // listViewNEIGHB
            // 
            this.listViewNEIGHB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.listViewNEIGHB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewNEIGHB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewNEIGHB.ForeColor = System.Drawing.Color.Purple;
            this.listViewNEIGHB.FormattingEnabled = true;
            this.listViewNEIGHB.ItemHeight = 22;
            this.listViewNEIGHB.Location = new System.Drawing.Point(6, 25);
            this.listViewNEIGHB.Name = "listViewNEIGHB";
            this.listViewNEIGHB.Size = new System.Drawing.Size(407, 132);
            this.listViewNEIGHB.TabIndex = 0;
            this.listViewNEIGHB.SelectedIndexChanged += new System.EventHandler(this.listViewNEIGHB_SelectIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.listViewPROP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Purple;
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 189);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Property";
            // 
            // listViewPROP
            // 
            this.listViewPROP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.listViewPROP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPROP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPROP.ForeColor = System.Drawing.Color.Purple;
            this.listViewPROP.FormattingEnabled = true;
            this.listViewPROP.ItemHeight = 22;
            this.listViewPROP.Location = new System.Drawing.Point(6, 29);
            this.listViewPROP.Name = "listViewPROP";
            this.listViewPROP.Size = new System.Drawing.Size(407, 154);
            this.listViewPROP.TabIndex = 1;
            this.listViewPROP.SelectedIndexChanged += new System.EventHandler(this.listViewPROP_SelectedIndexChanged);
            // 
            // btnADDDIST
            // 
            this.btnADDDIST.BackColor = System.Drawing.Color.Purple;
            this.btnADDDIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDDIST.ForeColor = System.Drawing.Color.White;
            this.btnADDDIST.Location = new System.Drawing.Point(437, 138);
            this.btnADDDIST.Name = "btnADDDIST";
            this.btnADDDIST.Size = new System.Drawing.Size(85, 37);
            this.btnADDDIST.TabIndex = 2;
            this.btnADDDIST.Text = "ADD";
            this.btnADDDIST.UseVisualStyleBackColor = false;
            this.btnADDDIST.Click += new System.EventHandler(this.btnADDDIST_Click);
            // 
            // btnADDNEIGHB
            // 
            this.btnADDNEIGHB.BackColor = System.Drawing.Color.Purple;
            this.btnADDNEIGHB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDNEIGHB.ForeColor = System.Drawing.Color.White;
            this.btnADDNEIGHB.Location = new System.Drawing.Point(437, 324);
            this.btnADDNEIGHB.Name = "btnADDNEIGHB";
            this.btnADDNEIGHB.Size = new System.Drawing.Size(85, 37);
            this.btnADDNEIGHB.TabIndex = 3;
            this.btnADDNEIGHB.Text = "ADD";
            this.btnADDNEIGHB.UseVisualStyleBackColor = false;
            this.btnADDNEIGHB.Click += new System.EventHandler(this.btnADDNEIGHB_Click);
            // 
            // btnADDPROP
            // 
            this.btnADDPROP.BackColor = System.Drawing.Color.Purple;
            this.btnADDPROP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDPROP.ForeColor = System.Drawing.Color.White;
            this.btnADDPROP.Location = new System.Drawing.Point(437, 513);
            this.btnADDPROP.Name = "btnADDPROP";
            this.btnADDPROP.Size = new System.Drawing.Size(85, 37);
            this.btnADDPROP.TabIndex = 4;
            this.btnADDPROP.Text = "ADD";
            this.btnADDPROP.UseVisualStyleBackColor = false;
            this.btnADDPROP.Click += new System.EventHandler(this.btnADDPROP_Click);
            // 
            // btnEDITDIST
            // 
            this.btnEDITDIST.BackColor = System.Drawing.Color.Purple;
            this.btnEDITDIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDITDIST.ForeColor = System.Drawing.Color.White;
            this.btnEDITDIST.Location = new System.Drawing.Point(437, 95);
            this.btnEDITDIST.Name = "btnEDITDIST";
            this.btnEDITDIST.Size = new System.Drawing.Size(85, 37);
            this.btnEDITDIST.TabIndex = 5;
            this.btnEDITDIST.Text = "EDIT";
            this.btnEDITDIST.UseVisualStyleBackColor = false;
            this.btnEDITDIST.Click += new System.EventHandler(this.btnEDITDIST_Click);
            // 
            // btnEDITNEIGHB
            // 
            this.btnEDITNEIGHB.BackColor = System.Drawing.Color.Purple;
            this.btnEDITNEIGHB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDITNEIGHB.ForeColor = System.Drawing.Color.White;
            this.btnEDITNEIGHB.Location = new System.Drawing.Point(437, 281);
            this.btnEDITNEIGHB.Name = "btnEDITNEIGHB";
            this.btnEDITNEIGHB.Size = new System.Drawing.Size(85, 37);
            this.btnEDITNEIGHB.TabIndex = 6;
            this.btnEDITNEIGHB.Text = "EDIT";
            this.btnEDITNEIGHB.UseVisualStyleBackColor = false;
            this.btnEDITNEIGHB.Click += new System.EventHandler(this.btnEDITNEIGHB_Click);
            // 
            // btnEDITPROP
            // 
            this.btnEDITPROP.BackColor = System.Drawing.Color.Purple;
            this.btnEDITPROP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDITPROP.ForeColor = System.Drawing.Color.White;
            this.btnEDITPROP.Location = new System.Drawing.Point(437, 470);
            this.btnEDITPROP.Name = "btnEDITPROP";
            this.btnEDITPROP.Size = new System.Drawing.Size(85, 37);
            this.btnEDITPROP.TabIndex = 7;
            this.btnEDITPROP.Text = "EDIT";
            this.btnEDITPROP.UseVisualStyleBackColor = false;
            this.btnEDITPROP.Click += new System.EventHandler(this.btnEDITPROP_Click);
            // 
            // btnDELPROP
            // 
            this.btnDELPROP.BackColor = System.Drawing.Color.Purple;
            this.btnDELPROP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELPROP.ForeColor = System.Drawing.Color.White;
            this.btnDELPROP.Location = new System.Drawing.Point(437, 427);
            this.btnDELPROP.Name = "btnDELPROP";
            this.btnDELPROP.Size = new System.Drawing.Size(85, 37);
            this.btnDELPROP.TabIndex = 8;
            this.btnDELPROP.Text = "DELETE";
            this.btnDELPROP.UseVisualStyleBackColor = false;
            this.btnDELPROP.Click += new System.EventHandler(this.btnDELPROP_Click);
            // 
            // TXTBoxsearch
            // 
            this.TXTBoxsearch.AllowDrop = true;
            this.TXTBoxsearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Bronx",
            "Brooklyn",
            "Manhattan",
            "Queens",
            "Staten Island",
            "Allerton",
            "Baychester",
            "Belmont",
            "Bronxdale",
            "Castle Hill",
            "City Island",
            "Claremont Village",
            "Clason Point",
            "Concourse",
            "Concourse Village",
            "Co-op City",
            "East Morrisania",
            "Eastchester",
            "Edenwald",
            "Fieldston",
            "Fordham",
            "Highbridge",
            "Hunts Point",
            "Kingsbridge",
            "A PRIVATE FLAT / APARTMENT- $SPECIAL$",
            "Hi Traveler.. welcome",
            "2 Beds/Queen & Full Beautiful Room 40 minsT.Square",
            "PRIVATE BATH/TONS OF SUNLIGHT/SAFE",
            "Nice beautiful room In the Bronx",
            "Awesome Deal NYC",
            "Sunny Private Room",
            "Retreat Room",
            "Twin  room",
            "Modern/Spacious 4BR +Tent Perfect for LARGE groups",
            "Room in Private House(Queen Bed) by Montefiore-NYC",
            "Spacious & Sunny Room Perfect for Medical Students",
            "Entire Home in NYC- 1 bedroom/ Private Entrance",
            "Live, Love, Stay in the Bronx!",
            "Spacious Garden Apartment Private Entrance",
            "Clean-N-Comfy Bronx Pad",
            "Clean, spacious and comfortable room at Bronx",
            "THE PERFECT QUIET ATMOSPHERE  WHEN HOME",
            "Luxury Tiny house � Ohka",
            "A Piece of mind in the city",
            "Spacious 2 level home for Groups sleeps upto 12",
            "Hi�roglyphe",
            "??? Entire House with Backyard & Superfast WiFi???",
            "*NYC Flat Cold Cozy Private Room w/ Blazin\' WiFi*",
            "\"Beautiful NYC Private Room/Bath, Late Check-In OK\"",
            "\"== Modern A/C Easy Check-in / Book Instantly ==\"",
            "\"?? Beautiful, Bright Room - Late Self Check-In  ??\"",
            "Private Room",
            "Jay\'s Studio Apartment",
            "Sunlit Backyard in NYC + Walk to Zoo and Gardens!",
            "Entire floor (private entrance) w/ 1 BR in NYC",
            "Entire Spacious Apt. with Comfy Queen Bed & WiFi",
            "Relax De Dios",
            "\"Quiet, serene Holiday getaway in the Bronx\"",
            "Spacious sun-filled bedroom near Botanical Garden",
            "E community that is commercially (Website hidden by Airbnb) smoke",
            "RV camper for the outdoor lovers",
            "Place to be Private room 2",
            "Private room 1",
            "Place to be( 3bedroom apartment)",
            "The Place to be private room 3",
            "Stylish 2 Beds Apartment with Private Parking",
            "Allerton",
            "Baychester",
            "Belmont",
            "Bronxdale",
            "Castle Hill",
            "City Island",
            "Claremont Village",
            "Clason Point",
            "Concourse",
            "Concourse Village",
            "Co-op City",
            "East Morrisania",
            "Eastchester",
            "Edenwald",
            "Fieldston",
            "Fordham",
            "Highbridge",
            "Hunts Point",
            "Kingsbridge",
            "A PRIVATE FLAT / APARTMENT- $SPECIAL$",
            "Hi Traveler.. welcome",
            "2 Beds/Queen & Full Beautiful Room 40 minsT.Square",
            "PRIVATE BATH/TONS OF SUNLIGHT/SAFE",
            "Nice beautiful room In the Bronx",
            "Awesome Deal NYC",
            "Sunny Private Room",
            "Retreat Room",
            "Twin  room",
            "Modern/Spacious 4BR +Tent Perfect for LARGE groups",
            "Room in Private House(Queen Bed) by Montefiore-NYC",
            "Spacious & Sunny Room Perfect for Medical Students",
            "Entire Home in NYC- 1 bedroom/ Private Entrance",
            "Live, Love, Stay in the Bronx!",
            "Spacious Garden Apartment Private Entrance",
            "Clean-N-Comfy Bronx Pad",
            "Clean, spacious and comfortable room at Bronx",
            "THE PERFECT QUIET ATMOSPHERE  WHEN HOME",
            "Luxury Tiny house � Ohka",
            "A Piece of mind in the city",
            "Spacious 2 level home for Groups sleeps upto 12",
            "Hi�roglyphe",
            "??? Entire House with Backyard & Superfast WiFi???",
            "*NYC Flat Cold Cozy Private Room w/ Blazin\' WiFi*",
            "\"Beautiful NYC Private Room/Bath, Late Check-In OK\"",
            "\"== Modern A/C Easy Check-in / Book Instantly ==\"",
            "\"?? Beautiful, Bright Room - Late Self Check-In  ??\"",
            "Private Room",
            "Jay\'s Studio Apartment",
            "Sunlit Backyard in NYC + Walk to Zoo and Gardens!",
            "Entire floor (private entrance) w/ 1 BR in NYC",
            "Entire Spacious Apt. with Comfy Queen Bed & WiFi",
            "Relax De Dios",
            "\"Quiet, serene Holiday getaway in the Bronx\"",
            "Spacious sun-filled bedroom near Botanical Garden",
            "E community that is commercially (Website hidden by Airbnb) smoke",
            "RV camper for the outdoor lovers",
            "Place to be Private room 2",
            "Private room 1",
            "Place to be( 3bedroom apartment)",
            "The Place to be private room 3",
            "Stylish 2 Beds Apartment with Private Parking",
            "A PRIVATE FLAT / APARTMENT- $SPECIAL$",
            "Hi Traveler.. welcome",
            "2 Beds/Queen & Full Beautiful Room 40 minsT.Square",
            "PRIVATE BATH/TONS OF SUNLIGHT/SAFE",
            "Nice beautiful room In the Bronx",
            "Awesome Deal NYC",
            "Sunny Private Room",
            "Retreat Room",
            "Twin  room",
            "Modern/Spacious 4BR +Tent Perfect for LARGE groups",
            "Room in Private House(Queen Bed) by Montefiore-NYC",
            "Spacious & Sunny Room Perfect for Medical Students",
            "Entire Home in NYC- 1 bedroom/ Private Entrance",
            "Live, Love, Stay in the Bronx!",
            "Spacious Garden Apartment Private Entrance",
            "Clean-N-Comfy Bronx Pad",
            "Clean, spacious and comfortable room at Bronx",
            "THE PERFECT QUIET ATMOSPHERE  WHEN HOME",
            "Luxury Tiny house � Ohka",
            "A Piece of mind in the city",
            "Spacious 2 level home for Groups sleeps upto 12",
            "Hi�roglyphe",
            "??? Entire House with Backyard & Superfast WiFi???",
            "*NYC Flat Cold Cozy Private Room w/ Blazin\' WiFi*",
            "\"Beautiful NYC Private Room/Bath, Late Check-In OK\"",
            "\"== Modern A/C Easy Check-in / Book Instantly ==\"",
            "\"?? Beautiful, Bright Room - Late Self Check-In  ??\"",
            "Private Room",
            "Jay\'s Studio Apartment",
            "Sunlit Backyard in NYC + Walk to Zoo and Gardens!",
            "Entire floor (private entrance) w/ 1 BR in NYC",
            "Entire Spacious Apt. with Comfy Queen Bed & WiFi",
            "Relax De Dios",
            "\"Quiet, serene Holiday getaway in the Bronx\"",
            "Spacious sun-filled bedroom near Botanical Garden",
            "E community that is commercially (Website hidden by Airbnb) smoke",
            "RV camper for the outdoor lovers",
            "Place to be Private room 2",
            "Private room 1",
            "Place to be( 3bedroom apartment)",
            "The Place to be private room 3",
            "Stylish 2 Beds Apartment with Private Parking",
            "\'Computing Coursework.exe\' (CLR v4.0.30319: Computing Coursework.exe): Loaded \'C:" +
                "\\Windows\\Microsoft.Net\\assembly\\GAC_MSIL\\Accessibility\\v4.0_4.0.0.0__b03f5f7f11d" +
                "50a3a\\Accessibility.dll\'. ",
            "A PRIVATE FLAT / APARTMENT- $SPECIAL$",
            "Hi Traveler.. welcome",
            "2 Beds/Queen & Full Beautiful Room 40 minsT.Square",
            "PRIVATE BATH/TONS OF SUNLIGHT/SAFE",
            "Nice beautiful room In the Bronx",
            "Awesome Deal NYC",
            "Sunny Private Room",
            "Retreat Room",
            "Twin  room",
            "Modern/Spacious 4BR +Tent Perfect for LARGE groups",
            "Room in Private House(Queen Bed) by Montefiore-NYC",
            "Spacious & Sunny Room Perfect for Medical Students",
            "Entire Home in NYC- 1 bedroom/ Private Entrance",
            "Live, Love, Stay in the Bronx!",
            "Spacious Garden Apartment Private Entrance",
            "Clean-N-Comfy Bronx Pad",
            "Clean, spacious and comfortable room at Bronx",
            "THE PERFECT QUIET ATMOSPHERE  WHEN HOME",
            "Luxury Tiny house � Ohka",
            "A Piece of mind in the city",
            "Spacious 2 level home for Groups sleeps upto 12",
            "Hi�roglyphe",
            "??? Entire House with Backyard & Superfast WiFi???",
            "*NYC Flat Cold Cozy Private Room w/ Blazin\' WiFi*",
            "\"Beautiful NYC Private Room/Bath, Late Check-In OK\"",
            "\"== Modern A/C Easy Check-in / Book Instantly ==\"",
            "\"?? Beautiful, Bright Room - Late Self Check-In  ??\"",
            "Private Room",
            "Jay\'s Studio Apartment",
            "Sunlit Backyard in NYC + Walk to Zoo and Gardens!",
            "Entire floor (private entrance) w/ 1 BR in NYC",
            "Entire Spacious Apt. with Comfy Queen Bed & WiFi",
            "Relax De Dios",
            "\"Quiet, serene Holiday getaway in the Bronx\"",
            "Spacious sun-filled bedroom near Botanical Garden",
            "E community that is commercially (Website hidden by Airbnb) smoke",
            "RV camper for the outdoor lovers",
            "Place to be Private room 2",
            "Private room 1",
            "Place to be( 3bedroom apartment)",
            "The Place to be private room 3",
            "Stylish 2 Beds Apartment with Private Parking",
            "Luxurious  one bedroom apartment in a quiet area.",
            "Bronx Apartment",
            "PEACE AND TRANQUILITY",
            "Elegant  Studio in a great cottage",
            "Warm and Friendly Bronx Home",
            "Comfortable Place with Dimple",
            "Spacious 2 bedroom apt in quiet area",
            "Light Room In Little Italy",
            "Room in Bronx Little Italy",
            "Fm",
            "Arthur Ave 2BDR sleeps 6! (15 mins from Manhattan)",
            "Bronx room",
            "BEST BRONX ROOM!!!",
            "5 STAR COZY ROOM",
            "Comfortable air bed near bronx zoo and sbh",
            "New York room",
            "Minimalistic private room w twin bed in the Bronx",
            "\"\"\"Sweet Home near to Bronx Zoo in Little Italy \"\"\"",
            "Akouaba",
            "\"\"\"MI Casa es su Casa \"\"\"",
            "Room in Home with Backyard in Bronx Little Italy",
            "private room for WOMEN ONLY near BX Little Italy",
            "Book NOW this New 3br Home with lots of space.",
            "Book TODAY! Large 3br with lots of space in the BX",
            "conveniet access to NYC",
            "Mi casa es tu casa! Cozy & comfortable!",
            "\"Bronx, Little Italy, Arthur Ave, Fordham, Yanks.\"",
            "Sunny & Spacious Room",
            "Two private rooms",
            "Cozy Room in Gorgeous Home in Bronx Little Italy",
            "\"Bronx, Little Italy, Arthur Ave, Fordham, Yanks.\"",
            "Large 1 bedroom apartment (shared)",
            "Gorgeous and Sunlit 1 BR 31/1-3/1",
            "Cozy and bright bedroom with a queen size bed.",
            "Cozy private room near the Bronx Zoo",
            "Bright 1 Bedroom Apt Near Attractions and Transit",
            "Comfy Private Room w/ Big TV",
            "Beautiful Large Room",
            "Cozy bed in private living room",
            "RJ\'s",
            "Wonderful room for rent in the Bronx",
            "SweetSpot in Pelham Pkwy S.E. Bronx NY 5 Star stay",
            "New York City (Downtown) accessibly sleeps 6",
            "Christina�s home",
            "Pelham south",
            "Sunny 1 bedroom w/private half bath!",
            "Spacious 1-bedroom apartment in Pelham Parkway",
            "\"Sunlight filled, large one-bedroom, apartment.\"",
            "?Official & Only 6?Star Airbnb w/ TempurPedic Bed",
            "The Emperors Den",
            "Bronx Bed and Breakfast",
            "\"Bronx Haven : Near water, accessible to transit\"",
            "Spacious brand new 2 bedrooms apartment ##2",
            "\"Cozy brand new 3 bedrooms apartment, HugeSpace ##3\"",
            "Cozy Spacious Queens Private Room #1",
            "Get Away NYC Queens Bedroom #2",
            "NYC Traveler Get Away Private ROOM #3",
            "Spacious brand new room getaway traveler  NYC #4",
            "Brand New Privated Room for NYC Traveler",
            "Great 1BD waterfront City Island NY",
            "Great 1BD waterfront City Island NY",
            "City Island Sanctuary BR & Pvt Bath � la fran�aise",
            "Cozy City Island Cottage",
            "Cozy 1 BR Basement Apartment",
            "CITY ISLAND VACATION HOME NEAR THE BEACH",
            "\"Peaceful Private Attic Bedroom, Living Room & Bath\"",
            "Quiet house on City Island",
            "City Island Seaview Apartment",
            "Island with City Benefits",
            "City Island studio apartment retreat",
            "Jackie Kennedy\'s Nook",
            "\"Tranquil, Cozy, Comfy Cottage.\"",
            "2 Bedroom Refuge with Private Bath & Living Room",
            "Quaint City Island.Come and enjoy our home",
            "Home away from home",
            "VJ\'S 5 HOUR YACHT TOUR",
            "ROMANTIC SUNSET YACHT CRUISE & FIREWORKS",
            "\"Priv. Room in a House, 15min, Manhatt\"",
            "Cheerful & Practical Garden Apartment Near Subway",
            "\"Big 4 Bedroom Apartment near Subway, All Renovated\"",
            "Call it Home.",
            "\"Huge Apartment Near Subway, Quiet and Sunny!\"",
            "Enormous apartment with everything you need",
            "Big 3 Bedroom Garden Level Apartment Near Subway",
            "Comfy room with great bed and private bathroom",
            "Cozy room in lovely apartment close to subway",
            "Huge private & cozy room in the Bronx!",
            "Spacious and close to everything",
            "Bronx Apartment College Ave",
            "Studio-like bedroom with private entrance and bath",
            "Large 1920s home W/Parking | 20 mins from Midtown.",
            "Private Studio 25 Minutes from Midtown",
            "Nice Quite place",
            "Private cozy room By Yankee stadium",
            "Close to the city and Bronx Lebanon hospital",
            "1B. Studio & Stay 30 minutes to Midtown Manhattan",
            "Great bedroom near yankee stadium",
            "across from crotona Park pool down the block",
            "�Bright and Cozy room in an elegant apartment�",
            "Master Room 315-B",
            "AUC Stay Room 315-3",
            "The Game Room",
            "The Game Room Place",
            "Best room in nyc",
            "Cute double room for the perfect Yankee fan",
            "LL3",
            "Hamiltons Hideway Lower Level Apt NYC",
            "LL2",
            "M1 Twin couch bed sleeps 1 guest",
            "M3 Hamilton\'s Hideaway Studio",
            "Garden House in the East Bronx",
            "Cozy Living Environment",
            "Chic Clason Point Condo",
            "private room in the Bronx",
            "Welcome to a beautiful House in Quiet Bronx",
            "Single private Bedroom in a beautiful House",
            "Lovely Shared Space in the Bronx",
            "M2 A cozy well lit room sleeps 2 on  2 single beds",
            "U2 comfortable double bed sleeps 2 guests",
            "Resort style living. Ferry to city 5 min walk.",
            "Sams place",
            "Peaceful 2 Bedroom apartment in a private house",
            "Private room in gated community: walk to ferry!",
            "A beautiful Gem",
            "Comfortable!  2 Bed Rm Apt. in House~20 min to NYC",
            "Dream House",
            "Bay Ridge",
            "Bedford-Stuyvesant",
            "SPACIOUS PRIVATE ROOM IN TRENDY BAY RIDGE BROOKLYN",
            "Old World Charm in the Heart of Brooklyn R2",
            "Old World Charm in the Heart of Brooklyn R1",
            "\"Spacious,convenient, and affordable!\"",
            "\"Huge, New and Green Oasis in Brooklyn\"",
            "Surburban Home Near The Pier",
            "Super cozy private room in artist\'s apartment",
            "Renovated Studio Apt! Walk to the Subway & Ferry!",
            "bayroom",
            "Cozy 1-Bedroom Apartment 2 Blocks from the Subway",
            "Spacious and Sunny Studio",
            "\"Bayridge Clean, Beautiful, Spacious Room\"",
            "Bright and Spacious Apartment",
            "King Sized Room; Bay Ridge",
            "The Best apartment in Bayridge",
            "Best Apartment in Bay Ridge",
            "\"Bay Ridge,Vista Place\"",
            "Bay Ridge Bklyn entire spacious Basement Apartment",
            "Superior Studio with Balcony",
            "ParkView Modern Design New 4 Bedrooms Apartment",
            "NEAR 5th AVE RENOVATED STUDIO IN BROOKLYN",
            "Farm house style in Bay Ridge (A)",
            "Farm house style home in Bay Ridge (B)",
            "Farm house style home in Bay Ridge (C)",
            "Gorgeous Big 2 BedRoom Apt in Brooklyn Brownstone",
            "LUXURY Brooklyn Brownstone 1 block from train",
            "Designer\'s Two Floors New Deluxe Apartment in NYC",
            "cozy artsy cool",
            "Private Bedroom - King Size Bed",
            "Awesome space on your own floor with a PrivateBath",
            "Cozy Artsy Room 2nd",
            "Luxury Bay Ridge Rentals",
            "Brooklyn apartment 20 min away from Manhattan",
            "Farm house style Bay Ridge (private D)",
            "Private Rooms in Brooklyn",
            "Private Room in Two-Bedroom Brooklyn Apartment",
            "Brooklyn the the way it should be",
            "Bright Spacious 2Bedrooms private Apt in Bay Ridge",
            "Cozy room in a area with everything.female only pl",
            "Bay Ridge House near park and water",
            "NYC - PRIVATE room in Bay Ridge.",
            "Water Front Duplex with Amazing Views and Parking.",
            "Bay Ridge(guys only)",
            "\"Cozy, Confortable and Nice place in Bay Ridge\"",
            "Modern & Cozy 2 BR Private Apartment in Brooklyn",
            "Large Studio close to everything",
            "Big room with king bed",
            "Alexander Hamilton( For Guys ONLY)",
            "Immaculate Private Bedroom & Bathroom (Room A)",
            "Cozy Room with Private Bath in Bay Ridge (Room B)",
            "Comfy Room w Private Bath in Bay Ridge (Room C)",
            "\"Bay Ridge is rated Convenient, safe neighborhood\"",
            "\"Cozy, peaceful, and cute.\"",
            "A.Hamilton(for GUYS only)",
            "\"B Hamilton( For GUYS ONLY)\"",
            "Nice bedroom with comfy Simmons bed -1min to train",
            "Cozy bedroom with Comfy Simmons bed -1min to train",
            "Sun-filled gem near the water and transportation",
            "Mini mansion",
            "Bay Ridge private house",
            "Modern renovated private Apt/Washer & dryer.",
            "NEAR 5th AVE RENOVATED STUDIO IN BROOKLYN",
            "bay ridge & sunset park furnished apartment",
            "entire apartment for rent",
            "2  Big Rooms in Brooklyn NY 1 block  from Subway!",
            "Sleep in large quiet bedroom with sunny garden",
            "Sleep in quiet bedroom with sunny garden",
            "\"Cozy Room,  kitchen bathroom & Patio Brooklyn NY\"",
            "\"2 Rooms in Brooklyn NY, 1 block from Subway!\"",
            "Live like a local!",
            "Bayridge Brooklyn NYC!Beautiful Space",
            "Private Large Bedroom Apt w/ Bathroom (NO KITCHEN)",
            "Luxury Hi-End Brooklyn Brownstone with backyard",
            "Classic Brooklyn Apartment",
            "A homey home.",
            "Best location in Bay Ridge. Cozy and private room.",
            "BlissArtsSpace!",
            "\"MAISON DES SIRENES1, bohemian apartment\"",
            "Large B&B Style rooms",
            "Clean and Quiet in Brooklyn",
            "Charming Brownstone 3 - Near PRATT",
            "bright and stylish duplex",
            "Blue Room for 2 in Brownstone for $1350 monthly",
            "The Stuydio Modern and Light Filled",
            "Large 2 Bedroom Great for Groups!",
            "B & B Room 1",
            "FLAT MACDONOUGH",
            "FLAT MACDONOUGH GARDEN",
            "\"Private, Large & Sunny 1BR w/W&D\"",
            "SAFE  AND BEAUTIFUL ACCOMODATION",
            "\"LARGE, COMFY 1BDR W/CHARACTER!!!\"",
            "Big Room/Washer-Dryer/Wifi/AC/JMZ",
            "Modern comfort in art infused landmark Brownstone",
            "\"Private, Large & Sunny Top Floor Apt  w/W&D\"",
            "BEDROOM1 FOR RENT 10min from Manhan",
            "BEDROOM2 FOR RENT  10min from Manh",
            "Share a HOME - $75 for 1 bdrm/++ for 2 - Brooklyn",
            "The Cozy Brownstone Inn (discount)!",
            "BEAUTIFUL 2 BEDROOM APARTMENT",
            "\"WONDERFUL, COMFORTABLE STUDIO\"",
            "MAISON DES SIRENES 2",
            "The Vernon On Greene",
            "Spacious Loft in Clinton Hill",
            "Tree lined block modern apartment",
            "Style in Stuyvesant Heights",
            "Authentic New York City Living ",
            "Large  Loft Style  Studio  Space",
            "Hancock Town House!-Stuyvesant Mews",
            "Purple Room for 2/3 in brownstone $1450 per month",
            "Red Room for two in Brownstone for $1355/mo",
            "Warehouse Loft with Garden view",
            "Historic Brooklyn Studio Apartment",
            "Chateau Style Brooklyn Loft for Singles or Couples",
            "2 Beds over Bed-Stuy",
            "\"Comfy, Cozy, Brooklyn close to Manhattan\"",
            "Cozy and spacious - rare for NYC!",
            "Ideal Brooklyn Brownstone Apartment",
            "Welcome to Brooklyn! Bed-Stuy",
            "\"Sunny, calm room in Victorian home\"",
            "Lovely HUGE Master Bed + Study",
            "Charming room in Victorian home",
            "ROOM WITH KITCHENETTE #2",
            "\"Your Haven Awaits At \"\"Emma\'s Place\"\"\"",
            "Beautiful Brownstone",
            "Apt with EmpireState view-Subway around the corner",
            "\"Lovely pied-�-terre, in an historic building\"",
            "Clinton Hill 1 Bed Bright Loft Apartment",
            "2BR  Apt - 20min to Soho",
            "Brooklyn Brownstone apartment",
            "HANCOCK VERY SMALL ROOM",
            "Cozy 2 Bedroom 20 Min from City",
            "Sunny! 2br Steps to train/restaurants - 15 to NYC",
            "Cozy Artist Duplex **Bedstuy Charm**",
            "Bed-stuy Royal Room",
            "Tranquil in the heart of Brooklyn 2",
            "Tranquil in the heart of Brooklyn 1",
            "Lovely 2 bedroom apartment with backyard access",
            "#1 Yellow Block BnB/see at Net Flix Show Stay Here",
            "Cozy Brownstone Inn I(studio)",
            "\"Own Room & Bath, Sunny Town House, 18\"\" to Wall St\"",
            "Bed Stuy Pride! Welcome to Brooklyn",
            "HOT SPOT FOR 20 AND 30 SOMETHING\'S",
            "\"Cozy Corner, Bedford Ave  Brooklyn!\"",
            "Large Double Room  Queenbed Wifi",
            "Clinton Hill Duplex near Pratt w/Balcony!",
            "Historic Brooklyn 2-Bedroom Apt",
            "Sunny Retreat with Roof Garden",
            "\"Morocco in Brooklyn with the flyest loft, Amazing!\"",
            "Stylish Loft w/Lovely Backyard",
            "Garden - Brownstone Experience",
            "Upper Duplex in Brooklyn Brownstone",
            "Large Room w/ Private Entrance",
            "Large Room w/ Private Entrance",
            "\"Bright, Bedstuy Gem\"",
            "Gorgeous Summer Duplex/Yard sublet",
            "Best double Room all included wifi",
            "BEAUTIFUL ROOM IN BKLYN BROWNSTONE",
            "Charming & Spacious One Bedroom",
            "Ready private furnished room w/Wifi",
            "Brownstone Beauty with Deck",
            "3 bedroom duplex apt with backyard",
            "Sunny 2 Bedroom Duplex with Garden",
            "Bright friendly room in Brooklyn",
            "Entire 1 Bedroom Apartment Flat Historic Bedstuy",
            "Beautiful Garden Duplex in Brooklyn",
            "Luminous Modern Apt Share for Young Professionals",
            "Adorable 1 Bedroom",
            "Beautiful Bedroom in Brooklyn",
            "Historic Brownstone Parlor & Garden",
            "Sal\'s bnb",
            "Up Among the Trees 2",
            "Lofted Bed in a Funky Family Loft!!",
            "Secret Garden",
            "Secret Garden Big and Comfortable",
            "Sunny Elegant and Big Room!",
            "\"LARGE PRIVATE FLOOR IN BROOKLYN, NY\"",
            "Airy Bed Sty Restoration",
            "Room in Clinton Hill Brooklyn Loft",
            "Large Private Room in Clinton Hill Brooklyn Loft",
            "\"Lovely, Sunny 1-Bedroom Apt with Kitcat\"",
            "\"Historic Mansion Comfortable Room\"",
            "Mitchell Manor",
            "Elegant Stuyvesant Heights Retreat",
            "Zen Holiday Getaway",
            "Great spot in Brooklyn",
            "Gorgeous Brooklyn Getaway",
            "Cozy apartment steps to subway",
            "\"New Flat, Great Light, Unique Brooklyn Bungalow\"",
            "Historic Brownstone Private Garden",
            "Hancock Town House!-Stuyvesant Mews",
            "Private Townhouse Guest Suite",
            "DEBBIE\'S COZY RETREAT",
            "\"Home away from home, clean and cozy.\"",
            "Dreamy Private Room in  Super Cool Bedstuy Apt.",
            "Cute Room in Artist/Designers\' Flat",
            "??Feel@HOME Brooklyn Clinton Hill ??",
            "New York City Dream Apartment",
            "Great light-filled 1BR in Brooklyn",
            "Comfortable Modern Room in Bed-Stuy",
            "Full Bedroom in Bed-Stuy",
            "1-bedroom apt in Clinton Hill",
            "Spacious Comfy Bedroom in Bed-Stuy",
            "World Travelers to Couchcrash in BK",
            "Enjoy Brownstone Brooklyn!",
            "Boldera: Your Home Away From Home",
            "Brooklyn-Bedstuy-Studio",
            "Room in cool Bushwick loft!",
            "Backyard BBQ in Brooklyn Brownstone",
            "Cosmopolitan Brownstone Sanctuary",
            "\"Sunny, private room in Brooklyn!\"",
            "\"Bright, airy room share in Brooklyn\"",
            "Stylish Room-Artist/Designers\' Flat",
            "Brooklyn Fashionista 1Bdr Loft",
            "Charming Apt. In Brooklyn Townhouse",
            "Cute Bedroom in Clinton Hill",
            "Spacious 1bd Near Trendy Neighborhoods And City",
            "\"Entire Spaceous, Sunny, Loft in Clinton Hill\"",
            "Furnished BrownStone Apartment",
            "Sunny Brownstone  Attic",
            "Huge Sunny Loft w Patio + Charm",
            "\"Verna\'s Brownstone  (no stove no gatherings)\"",
            "Private Entrance - Backyard Summer Dining - Enjoy",
            "THE PUTNAM",
            "Chic Brooklyn Apt.- Private Room",
            "Beautiful new one bedroom apartment",
            "ART HOUSE VAULT",
            "Quiet and Cozy Brooklyn Brownstone Apartment",
            "ART HOUSE BIGGIE SMALL",
            "Family Owned & Operated Brownstone",
            "Fresh and modern 1BR in Bed-Stuy",
            "Steps to Subway! Entire apt! 20 min to Manhattan!",
            "Cozy 1 Bedroom in Clinton Hill",
            "Authentic NYC Living 2",
            "\"Cozy, friendly,  3 min from subway.\"",
            "Private bedroom (15 min Manhattan).",
            "Stuyvesant Heights Apt mins 2 City",
            "Cozy Huge Brownstone in Bedstuy",
            "SPACE FOR 8",
            "nice room in bedstuy N",
            "Cozy Brownstone Living in Brooklyn",
            "nice room in bedstuy I",
            "Clean & Sunny Clinton Hill/Bed room",
            "1 Bedroom avail in BK 3BD w/ porch",
            "nice room in bedstuy H",
            "nice room in bedstuy M",
            "Deep House in Bed Stuy",
            "nice room in bedstuy K",
            "\"Modern, Steps to Subway - Sleeps 4\"",
            "\"Cozy, friendly, 3 min from subway!\"",
            "ARTSY & CONVENIENT in Williamsburg.",
            "nice room in bedstuy J",
            "Chez Humphries",
            "3 bedroom duplex Brooklyn townhouse",
            "English Basement Studio Apartment / private entry",
            "Great Flat in Historic Brownstone",
            "Gorgeous spacious. 2 subways close",
            "Sunny Brooklyn Artists\' Enclave! *huge room!*",
            "\"Verna\'s Brownstone Suite (no stove no gatherings)\"",
            "A Nest in Brooklyn",
            "Jazz it Up in Brooklyn",
            " A charming Space in Brooklyn ",
            "BROOKLYN\'S FAVORITE BROWNSTONE in HIPSTER BED-STUY",
            "Charming private room & sunny deck!",
            "Private Room Private Restroom tons Natural Light",
            "The Lavender Suite on Greene",
            "Cozy & Private 1 Bedroom Garden Level Apartment",
            "Saratoga Park Suite",
            "Beautiful Brooklyn Brownstone Apt",
            "Bedford Stuyvesant Urban Hang Suite",
            "Sunny Apartment in Clinton Hill",
            "small room in bedstuy P",
            "Relax at our duplex + backyard",
            "Elegant modern 1-bedroom in Bed-Stuy",
            "BedStuy with a View",
            "HUGE 2BR+1BA Apt For Group Only 15 Min To NYCity",
            "Private Room in Brooklyn Brownstone",
            "Stuyvesant Heights Townhouse",
            "nice room in bedstuy L",
            "Gorgeous & Spacious Full 1 BR Apt",
            "Rooftop Oasis in Brooklyn for Shoots & Gigs",
            "An artist place in Bedstuy",
            "Smart Family 1BD Retreat in Bedstuy",
            "Lovely Brownstone-- Close to Subway",
            "Truly A Sweet Home away from Home.",
            "Beautiful Home Away From Home!",
            "Amazing Spacious Room",
            "Large Charming 1 BR + Den  in  Brownstone Apt",
            "Cozy room in bed-stuy",
            "Art House Suite",
            "Classic Brownstone private suite",
            "Sunny Spacious Retro 1 Bedroom",
            "One very large room two beds",
            "Lovely Suite in Historic Brownstone near Subway",
            "\"Modern, Sunny Duplex PENTHOUSE  w/ BALCONY\"",
            "\"Sunny Room, Only 1 Block to Subway!\"",
            "Sweet Apartment on Quiet Block",
            "LOFT Private Room - MOVIE THEATER/GYM/LAUNDRY/ROOF",
            "1800sf Urban Goddess Brooklyn Loft",
            "CHIC NEW YORK OASIS WITH ROOF DECK!",
            "nice room in bedstuy B",
            "Queen size room in Brooklyn",
            "Invitation to travelers",
            "Private room in sunny Bedstuy apartment",
            "\"Lovely Bedroom - Bed Stuy, Brooklyn\"",
            "Bushwick / Bed Sty Retreat",
            "Self contained ground level apt",
            "Beautiful warm duplex apartment",
            "Luxurious Brownstone Duplex w Outdoor Space",
            "Studio in the Family Brownstone",
            "2nd@THROOP MANSION ",
            "Cozy apartment available!",
            "Penthouse in Bedford Stuyvesant ",
            "\"Private, Spacious Garden Apartment\"",
            "\"Stylish, Sunny, spacious luxury loft\"",
            "Large Studio apartment",
            "Clinton Hill 1BR in charming 2BR",
            "The Spencer",
            "A room with private bathroom",
            "\"Comfy, Spacious, Modern, Sweet Home\"",
            "Private 2 BR APT: Free WIFI & JACUZZI",
            "Modern Bright Loft in Clinton Hill",
            "Sunny Room near all",
            "Lovely & Large Private Queen Bedroom",
            "nice room in bedstuy A",
            "Cozy 2BD APT close to subway",
            "Bed Stuy Apartment One Bedroom",
            "Cozy Room in Family Home..BKLYN!!!",
            "New 1BR + 1BA with Private Entrance",
            "Delicious & Airy Apt in Landmark Brownstone",
            "\"Charming, sunny oasis\"",
            "Spacious 3BD/2BA - Parking Included",
            "Live like a native",
            "Private Single Room Steps to Subway",
            "\"No security req, great price, new queen bed!\"",
            "Artistic Studio Apartment",
            "Private room with bathroom and balcony.",
            "A Beautiful Brownstone",
            "Newly renovated house",
            "\"Brooklyn Charm, Close to Manhattan (30+ Days Only)\"",
            "Cozy Brownstone Suite",
            "\"BIG, BRIGHT STYLISH + CONVENIENT\"",
            "Herkimer House",
            "BEDROOM WITH PRIVATE BATHROOM",
            "Sunny Brooklyn Home",
            "Artist owned brownstone apartment",
            "Spacious Duplex Apt in Brooklyn",
            "Gorgeous 1400 Sq Ft Artist\'s Loft",
            "\"Stylish Affordable & Private Room\"",
            "URBAN CHIC VIDEO/PHOTO SHOOTS ONLY",
            "Entire 1400 sq ft Artist Loft - FOUR Private Rooms",
            "\"The center of NYC Brooklyn!\"",
            "\"Bright Airy Room Share for 2\"",
            "Private room in Clinton Hill",
            "Bright new apt in a luxury building",
            "Lovely Lofted Artist\'s Room",
            "Private room in Bed Stuy brownstone",
            "Christmas and New Years in NYC",
            "Beautiful Room...15 min to NYC",
            "Private room in HUGE Apartment!",
            "Private bdrm in bedstuy brownstone",
            "Beautiful large bedroom in Brooklyn",
            "Classic Brooklyn Charm",
            "1 BR Artist\'s Haven in Bed-Stuy",
            "Private room in bright apartment!",
            "large room in 3 bedroom apartment",
            "\"Cozy Room  Huge Yard Trendy Brooklyn\"",
            "Beautiful/Comfy 1BR Brownstone",
            "Bright & Sunny 2-Bed - Bushwick/Bed-Stuy Border!",
            "Cozy Room in Cozy Apartment",
            "Bright Brooklyn Apartment",
            "Beautiful 1 bedroom apt in Bedstuy",
            "Calm and Comfy room in Brooklyn",
            "Big Bright 1BR Bed-Stuy Brownstone",
            "A TASTE OF BROOKLYN",
            "Private Room + Office in Duplex",
            "Small Cozy Studio - Brownstone",
            "Beautiful stylish Brooklyn apartmen",
            "Luxury Apartment w/ Rooftop Patio",
            "Sunny Cozy Room in Lovely Bed-Stuy",
            "Get cozy on a historic Brooklyn St",
            "Creative Bed-Stuy Brownstone",
            "Gigantic private room in BedStuy",
            "Bright Studio Loft Bed Stuy",
            "Artsy 2-bdrm apartment Sleeps 6. 1 min from Subway",
            "Clean and Cozy BedStuy Apt",
            "Modern Brooklyn Duplex",
            "Bright and stylish BR in trendy Brooklyn. Yard!",
            "Lovely Private Browstone Apt",
            "Artist Escape With Private Terrace",
            "Spacious Private Brownstone Apt | 2 Bedroom",
            "BEDROOM3 FOR RENT  10min from Manh",
            "Sunny Modern Beauty with Deck",
            "Artistic! Sunny! 1BR Brownstone Apt",
            "Charming and CLEAN Room!!",
            "My Artsy Haven in Bed Stuy",
            "Sunny room in a great new Apt",
            "A Large Room in a Huge Apartment",
            "Garden level apt w Bocci court/grill in backyard",
            "Private Bedroom in Bedstuy!",
            "Spacious room in Beautiful Bedstuy",
            "Cozy bedroom in beautiful apartment",
            "Beautiful Brooklyn Apartment!",
            "Sweet and affordable nook in bk",
            "OPEN LOFT WITH PRIVATE BACKYARD",
            "Newly Renovated Carriage House",
            "Cozy apartment in Brooklyn",
            "Large room with private bath in Brooklyn home",
            "restfully space",
            "Peaceful Artist Bedroom�Just 30 Min to Manhattan!",
            "Hip Trendy and Convenient!",
            "Elegant and Comfortable Stay",
            "Your NYC Home!",
            "Queen Bed/Private Room w/ Backyard",
            "Spacious 2 bdr Bed-Stuy Brownstone",
            "Cozy Private Garden Apartment",
            "Simple Affordable Room in Brooklyn",
            "private modern room (long term 1 month or more)",
            "Lovely Light Filled Room in BedStuy",
            "3 BEDROOMS BROOKLYN - NEW YORK CITY",
            "Private Room/Private Bath in Gorgeous Brooklyn 2BR",
            "Art Inspired One Bedroom Apt in Bedford Stuyvesant",
            "Private Room in Brooklyn Artist Apt",
            "Sunlit & Spacious 2 Bedroom Brooklyn Apt",
            "Sunny & Bright Private Room",
            "Spacious Bedroom in the heart of Bedstuy",
            "Private room available for summer",
            "\"Sunny couple-friendly BedStuy Apartment\"",
            "Beautiful light and lots of space",
            "391 Hancock Street",
            "2 Bedroom/2 Bath Luxury Apartment With Terrace",
            "Feel at Home",
            "Spacious 1 BR Apartment w/ private backyard",
            "Sunny and spacious 1 bedroom Brooklyn apartment",
            "Brooklyn room in a New Bldg - 20mns from Manhattan",
            "Gramercy",
            "Greenwich Village",
            "Quiet 1 Bedroom near Union Square",
            "Artsy and Cozy 1b. - Walk Everywhere!",
            "Perfect 1BD in Gramercy/Union Sq",
            "Charming East Village/Gramercy Park Studio",
            "Penthouse on Park Ave",
            "Funky Union Square Apartment",
            "Gramercy Park View Pied A Terre",
            "Charming 1BR near Union Square",
            "Great Gramercy Share Apt",
            "\"A BETTA share -Low maintanence guests e20\'s  NYC!\"",
            "Charming 1-BR in Gramercy",
            "Homey Well-Located Apartment!",
            "Winter Deal! Cosy room available in East Village",
            "Sun-filled bedroom in East Village / Gramercy NYC",
            "Luxurious Designer 2 Bedm Union Square/Gramercy",
            "Oversized 1BR~Union square~Sleeps 4~Best Value",
            "Spacious Gramercy Penthouse Studio",
            "Best location in NYC!",
            "Steps from Gramercy Park",
            "Classic Parlor Level Brownstone",
            "Immaculate Gramercy One-Bedroom",
            "Gramercy Studio w/ Private Garden",
            "Summer in Gramercy Park. New York",
            "Furnished BR in a 2BR apt Gramercy",
            "Comfy room in Gramercy Park",
            "1 BR in a shared flat East Village",
            "Private Cozy Bedroom w Divider Wall",
            "2Br~Union square~Newly furnished",
            "Large Bedroom in Kips Bay/Gramercy",
            "Union Square/Gramercy Apartment",
            "Clean Cozy & Comfy Apartment!",
            "Gorgeous Pre War Sanctuary - 1 block from Union Sq",
            "Cute East Village Room for 1",
            "Cosy clean modern apartment",
            "Convenient full 1 bdrm + loft apt",
            "Artist 1.5 bedroom WHOLE apartment!",
            "Gramercy Park Studio by Manhattan",
            "Central & Cute Studio by Union Sq!",
            "Classic NY Apartment. Prime Manhattan Location",
            "Stylish One-Bedroom in Gramercy!",
            "Beautiful modern room with private bathroom",
            "Gramercy & Madison Park CONDO 3 BED 2BATH",
            "The BEST LOCATION in MANHATTAN!",
            "Charming Union Sq Studio w/Elevator",
            "Charming Gramercy Studio Furnished",
            "Private Room in Gramercy Park",
            "Private Cozy BR near Union Square - FEMALE only",
            "Comfy Space in Gramercy/Manhattan",
            "Downtown Manhattan Modern Gem!!",
            "Two Large Rooms in Union Sq Duplex",
            "��BEST Manhattan Downtown Location!��",
            "Chill Gramercy Flat",
            "Irving place -Elevator  Doorman 1 bed - 5152",
            "Sunny Winter Union Square Sublet",
            "Doorman One bedroom Laundry!5128",
            "Cozy East Village Brownstone",
            "GRAMERCY 1 BD APARTMENT - CENTRAL!!",
            "Modern & Sun Filled 1BR in Gramercy",
            "NYC: AMAZING Gramercy Cool Triplex",
            "Comfy Spacious room/Lower Manhattan - East Side",
            "Artist Studio in Central Manhattan!",
            "One Bedroom - Gramery Park",
            "1 Bedroom in HUGE Full Floored Apt.",
            "Charming Bedroom in Gramercy",
            "*Chic Oasis in Trendy Union Square*",
            "Quiet 1 Bedroom near Union Square",
            "Artsy and Cozy 1b. - Walk Everywhere!",
            "Perfect 1BD in Gramercy/Union Sq",
            "Charming East Village/Gramercy Park Studio",
            "Penthouse on Park Ave",
            "Funky Union Square Apartment",
            "Gramercy Park View Pied A Terre",
            "Charming 1BR near Union Square",
            "Great Gramercy Share Apt",
            "\"A BETTA share -Low maintanence guests e20\'s  NYC!\"",
            "Charming 1-BR in Gramercy",
            "Homey Well-Located Apartment!",
            "Winter Deal! Cosy room available in East Village",
            "Sun-filled bedroom in East Village / Gramercy NYC",
            "Luxurious Designer 2 Bedm Union Square/Gramercy",
            "Oversized 1BR~Union square~Sleeps 4~Best Value",
            "Spacious Gramercy Penthouse Studio",
            "Best location in NYC!",
            "Steps from Gramercy Park",
            "Classic Parlor Level Brownstone",
            "Immaculate Gramercy One-Bedroom",
            "Gramercy Studio w/ Private Garden",
            "Summer in Gramercy Park. New York",
            "Furnished BR in a 2BR apt Gramercy",
            "Comfy room in Gramercy Park",
            "1 BR in a shared flat East Village",
            "Private Cozy Bedroom w Divider Wall",
            "2Br~Union square~Newly furnished",
            "Large Bedroom in Kips Bay/Gramercy",
            "Union Square/Gramercy Apartment",
            "Clean Cozy & Comfy Apartment!",
            "Gorgeous Pre War Sanctuary - 1 block from Union Sq",
            "Cute East Village Room for 1",
            "Cosy clean modern apartment",
            "Convenient full 1 bdrm + loft apt",
            "Artist 1.5 bedroom WHOLE apartment!",
            "Gramercy Park Studio by Manhattan",
            "Central & Cute Studio by Union Sq!",
            "Classic NY Apartment. Prime Manhattan Location",
            "Stylish One-Bedroom in Gramercy!",
            "Beautiful modern room with private bathroom",
            "Gramercy & Madison Park CONDO 3 BED 2BATH",
            "The BEST LOCATION in MANHATTAN!",
            "Charming Union Sq Studio w/Elevator",
            "Charming Gramercy Studio Furnished",
            "Private Room in Gramercy Park",
            "Private Cozy BR near Union Square - FEMALE only",
            "Comfy Space in Gramercy/Manhattan",
            "Downtown Manhattan Modern Gem!!",
            "Two Large Rooms in Union Sq Duplex",
            "��BEST Manhattan Downtown Location!��",
            "Chill Gramercy Flat",
            "Irving place -Elevator  Doorman 1 bed - 5152",
            "Sunny Winter Union Square Sublet",
            "Doorman One bedroom Laundry!5128",
            "Cozy East Village Brownstone",
            "GRAMERCY 1 BD APARTMENT - CENTRAL!!",
            "Modern & Sun Filled 1BR in Gramercy",
            "NYC: AMAZING Gramercy Cool Triplex",
            "Comfy Spacious room/Lower Manhattan - East Side",
            "Artist Studio in Central Manhattan!",
            "One Bedroom - Gramery Park",
            "1 Bedroom in HUGE Full Floored Apt.",
            "Charming Bedroom in Gramercy",
            "*Chic Oasis in Trendy Union Square*",
            "Cozy apartment in Greenwich Village",
            "LOFT#1 - Broadway Av. Amazing Location! SoHo",
            "Private Two Bedroom Apartment in Greenwich Village",
            "Greenwich Village Gem at Washington Sq Park!",
            "Private Room in Shared Apt in Greenwich Village",
            "KING SIZED BEDROOM in SoHo",
            "Excellent for Vacation or Business - Heart of NYC",
            "\"Bright spacious loft in the heart of Soho\"",
            "Greenwich Village Master Bedroom!",
            "Astoria",
            "Far Rockaway",
            "Flushing",
            "ASTORIA APARTMENT AVAILABLE",
            "\"Lovely kitschy 1BR + Foldout Couch\"",
            "Comfortable 1B in hot-spot Queens",
            "\"A Gem Studio Apartment Astoria NYC\"",
            "Huge 1 BR entire apt",
            "Cherry Blossom Apartment",
            "Cozy and Comfortable",
            "Cozy Room 4 stops from 5 avenue",
            "Stunning apartment with view only 5 min from metro",
            "Cozy 1 bedroom apt Prime Location!!",
            "\"Full Bedroom Avaliable Astoria\"",
            "Presidential Comfort",
            "Modern private studio in rockaway",
            "Cozy studio near the beach and St. John�s hospital",
            "Cozy private bedroom",
            "Relaxing private bedroom",
            "Comfy private bedroom",
            "Nelson-Hamilton Family",
            "Charming entire house",
            "Frum kosher house for rent",
            "Beach suite",
            "\"Jfk min away. Welcome to the beach! Fun sand surf\"",
            "\"Penthouse on the beach 3 floors of art fun surf\"",
            "Fully Furnished Basement Apartment",
            "My Little Guest Room in Flus"});
            this.TXTBoxsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TXTBoxsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.TXTBoxsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.TXTBoxsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBoxsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBoxsearch.ForeColor = System.Drawing.Color.Purple;
            this.TXTBoxsearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TXTBoxsearch.Location = new System.Drawing.Point(528, 11);
            this.TXTBoxsearch.Multiline = true;
            this.TXTBoxsearch.Name = "TXTBoxsearch";
            this.TXTBoxsearch.Size = new System.Drawing.Size(447, 35);
            this.TXTBoxsearch.TabIndex = 10;
            this.TXTBoxsearch.TextChanged += new System.EventHandler(this.TXTBoxsearch_TextChanged);
            // 
            // lstboxDisplay
            // 
            this.lstboxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lstboxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstboxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxDisplay.ForeColor = System.Drawing.Color.Purple;
            this.lstboxDisplay.FormattingEnabled = true;
            this.lstboxDisplay.ItemHeight = 22;
            this.lstboxDisplay.Location = new System.Drawing.Point(528, 62);
            this.lstboxDisplay.Name = "lstboxDisplay";
            this.lstboxDisplay.Size = new System.Drawing.Size(447, 178);
            this.lstboxDisplay.TabIndex = 11;
            this.lstboxDisplay.SelectedIndexChanged += new System.EventHandler(this.lstboxDisplay_SelectedIndexChanged);
            // 
            // FrontPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(987, 568);
            this.Controls.Add(this.lstboxDisplay);
            this.Controls.Add(this.TXTBoxsearch);
            this.Controls.Add(this.btnDELPROP);
            this.Controls.Add(this.btnEDITPROP);
            this.Controls.Add(this.btnEDITNEIGHB);
            this.Controls.Add(this.btnEDITDIST);
            this.Controls.Add(this.btnADDPROP);
            this.Controls.Add(this.btnADDNEIGHB);
            this.Controls.Add(this.btnADDDIST);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrpBxDistricts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrontPage_Activated);
            this.Load += new System.EventHandler(this.FrontPage_Load);
            this.GrpBxDistricts.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBxDistricts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnADDDIST;
        private System.Windows.Forms.Button btnADDNEIGHB;
        private System.Windows.Forms.Button btnADDPROP;
        private System.Windows.Forms.Button btnEDITDIST;
        private System.Windows.Forms.Button btnEDITNEIGHB;
        private System.Windows.Forms.Button btnEDITPROP;
        private System.Windows.Forms.Button btnDELPROP;
        private System.Windows.Forms.ListBox listViewDISTRICT;
        private System.Windows.Forms.ListBox listViewNEIGHB;
        private System.Windows.Forms.ListBox listViewPROP;
        private System.Windows.Forms.TextBox TXTBoxsearch;
        private System.Windows.Forms.ListBox lstboxDisplay;
    }
}
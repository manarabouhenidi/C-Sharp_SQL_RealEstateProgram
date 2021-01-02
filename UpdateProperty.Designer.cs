namespace RealEstateDB
{
    partial class UpdateProperty
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
            this.labelType = new System.Windows.Forms.Label();
            this.PNO = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.ZipCode = new System.Windows.Forms.Label();
            this.County = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.OwnerSSN = new System.Windows.Forms.Label();
            this.comboPno = new System.Windows.Forms.ComboBox();
            this.pnobox = new System.Windows.Forms.TextBox();
            this.Addressbox = new System.Windows.Forms.TextBox();
            this.citybox = new System.Windows.Forms.TextBox();
            this.zipbox = new System.Windows.Forms.TextBox();
            this.countybox = new System.Windows.Forms.TextBox();
            this.areabox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.taxbox = new System.Windows.Forms.TextBox();
            this.yearbuiltbox = new System.Windows.Forms.TextBox();
            this.onerssnbox = new System.Windows.Forms.TextBox();
            this.statebox = new System.Windows.Forms.ComboBox();
            this.combostatus = new System.Windows.Forms.ComboBox();
            this.Update = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(40, 50);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(44, 19);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            // 
            // PNO
            // 
            this.PNO.AutoSize = true;
            this.PNO.Location = new System.Drawing.Point(40, 126);
            this.PNO.Name = "PNO";
            this.PNO.Size = new System.Drawing.Size(41, 19);
            this.PNO.TabIndex = 1;
            this.PNO.Text = "PNO";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(40, 190);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(112, 19);
            this.Address.TabIndex = 2;
            this.Address.Text = "Street Address";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(40, 306);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(36, 19);
            this.City.TabIndex = 3;
            this.City.Text = "City";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(40, 408);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(44, 19);
            this.State.TabIndex = 4;
            this.State.Text = "State";
            // 
            // ZipCode
            // 
            this.ZipCode.AutoSize = true;
            this.ZipCode.Location = new System.Drawing.Point(45, 507);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.Size = new System.Drawing.Size(31, 19);
            this.ZipCode.TabIndex = 5;
            this.ZipCode.Text = "Zip";
            this.ZipCode.Click += new System.EventHandler(this.ZipCode_Click);
            // 
            // County
            // 
            this.County.AutoSize = true;
            this.County.Location = new System.Drawing.Point(30, 604);
            this.County.Name = "County";
            this.County.Size = new System.Drawing.Size(59, 19);
            this.County.TabIndex = 6;
            this.County.Text = "County";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(626, 47);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(52, 19);
            this.Status.TabIndex = 7;
            this.Status.Text = "Status";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(626, 126);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(42, 19);
            this.Area.TabIndex = 8;
            this.Area.Text = "Area";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(626, 219);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(43, 19);
            this.Price.TabIndex = 9;
            this.Price.Text = "Price";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(626, 311);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(35, 19);
            this.Tax.TabIndex = 10;
            this.Tax.Text = "Tax";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(603, 408);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(77, 19);
            this.Year.TabIndex = 11;
            this.Year.Text = "Year Built";
            // 
            // OwnerSSN
            // 
            this.OwnerSSN.AutoSize = true;
            this.OwnerSSN.Location = new System.Drawing.Point(601, 504);
            this.OwnerSSN.Name = "OwnerSSN";
            this.OwnerSSN.Size = new System.Drawing.Size(79, 19);
            this.OwnerSSN.TabIndex = 12;
            this.OwnerSSN.Text = "Ownerssn";
            // 
            // comboPno
            // 
            this.comboPno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPno.FormattingEnabled = true;
            this.comboPno.Items.AddRange(new object[] {
            "Houses",
            "Apartment",
            "Co-op/Condos",
            "Townhome",
            "Manufactured"});
            this.comboPno.Location = new System.Drawing.Point(95, 47);
            this.comboPno.Name = "comboPno";
            this.comboPno.Size = new System.Drawing.Size(195, 27);
            this.comboPno.TabIndex = 13;
            this.comboPno.SelectedIndexChanged += new System.EventHandler(this.comboPno_SelectedIndexChanged);
            // 
            // pnobox
            // 
            this.pnobox.Location = new System.Drawing.Point(95, 123);
            this.pnobox.Name = "pnobox";
            this.pnobox.ReadOnly = true;
            this.pnobox.Size = new System.Drawing.Size(195, 27);
            this.pnobox.TabIndex = 14;
            // 
            // Addressbox
            // 
            this.Addressbox.Location = new System.Drawing.Point(95, 224);
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.Size = new System.Drawing.Size(195, 27);
            this.Addressbox.TabIndex = 15;
            // 
            // citybox
            // 
            this.citybox.Location = new System.Drawing.Point(95, 303);
            this.citybox.Name = "citybox";
            this.citybox.Size = new System.Drawing.Size(195, 27);
            this.citybox.TabIndex = 16;
            // 
            // zipbox
            // 
            this.zipbox.Location = new System.Drawing.Point(95, 504);
            this.zipbox.MaxLength = 5;
            this.zipbox.Name = "zipbox";
            this.zipbox.Size = new System.Drawing.Size(195, 27);
            this.zipbox.TabIndex = 17;
            // 
            // countybox
            // 
            this.countybox.Location = new System.Drawing.Point(95, 601);
            this.countybox.Name = "countybox";
            this.countybox.Size = new System.Drawing.Size(195, 27);
            this.countybox.TabIndex = 18;
            // 
            // areabox
            // 
            this.areabox.Location = new System.Drawing.Point(697, 126);
            this.areabox.Name = "areabox";
            this.areabox.Size = new System.Drawing.Size(179, 27);
            this.areabox.TabIndex = 19;
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(697, 219);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(179, 27);
            this.pricebox.TabIndex = 20;
            // 
            // taxbox
            // 
            this.taxbox.Location = new System.Drawing.Point(697, 306);
            this.taxbox.Name = "taxbox";
            this.taxbox.Size = new System.Drawing.Size(179, 27);
            this.taxbox.TabIndex = 21;
            // 
            // yearbuiltbox
            // 
            this.yearbuiltbox.Location = new System.Drawing.Point(697, 408);
            this.yearbuiltbox.MaxLength = 4;
            this.yearbuiltbox.Name = "yearbuiltbox";
            this.yearbuiltbox.Size = new System.Drawing.Size(179, 27);
            this.yearbuiltbox.TabIndex = 22;
            // 
            // onerssnbox
            // 
            this.onerssnbox.Location = new System.Drawing.Point(697, 501);
            this.onerssnbox.MaxLength = 9;
            this.onerssnbox.Name = "onerssnbox";
            this.onerssnbox.Size = new System.Drawing.Size(179, 27);
            this.onerssnbox.TabIndex = 23;
            // 
            // statebox
            // 
            this.statebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statebox.FormattingEnabled = true;
            this.statebox.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.statebox.Location = new System.Drawing.Point(95, 408);
            this.statebox.Name = "statebox";
            this.statebox.Size = new System.Drawing.Size(195, 27);
            this.statebox.TabIndex = 24;
            // 
            // combostatus
            // 
            this.combostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combostatus.FormattingEnabled = true;
            this.combostatus.Items.AddRange(new object[] {
            "Available",
            "SOLD"});
            this.combostatus.Location = new System.Drawing.Point(697, 47);
            this.combostatus.Name = "combostatus";
            this.combostatus.Size = new System.Drawing.Size(179, 27);
            this.combostatus.TabIndex = 25;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(964, 601);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(153, 39);
            this.Update.TabIndex = 26;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(964, 40);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(153, 39);
            this.Backbutton.TabIndex = 27;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(964, 126);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(153, 39);
            this.Home.TabIndex = 28;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // UpdateProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 652);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.combostatus);
            this.Controls.Add(this.statebox);
            this.Controls.Add(this.onerssnbox);
            this.Controls.Add(this.yearbuiltbox);
            this.Controls.Add(this.taxbox);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.areabox);
            this.Controls.Add(this.countybox);
            this.Controls.Add(this.zipbox);
            this.Controls.Add(this.citybox);
            this.Controls.Add(this.Addressbox);
            this.Controls.Add(this.pnobox);
            this.Controls.Add(this.comboPno);
            this.Controls.Add(this.OwnerSSN);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.County);
            this.Controls.Add(this.ZipCode);
            this.Controls.Add(this.State);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PNO);
            this.Controls.Add(this.labelType);
            this.Name = "UpdateProperty";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label PNO;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label ZipCode;
        private System.Windows.Forms.Label County;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label OwnerSSN;

        public System.Windows.Forms.ComboBox comboPno;
        public System.Windows.Forms.TextBox pnobox;
        public System.Windows.Forms.TextBox Addressbox;
        public System.Windows.Forms.TextBox citybox;
        public System.Windows.Forms.TextBox zipbox;
        public System.Windows.Forms.TextBox countybox;
        public System.Windows.Forms.TextBox areabox;
        public System.Windows.Forms.TextBox pricebox;
        public System.Windows.Forms.TextBox taxbox;
        public System.Windows.Forms.TextBox yearbuiltbox;
        public System.Windows.Forms.TextBox onerssnbox;
        public System.Windows.Forms.ComboBox statebox;
        public System.Windows.Forms.ComboBox combostatus;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Home;
    }
}
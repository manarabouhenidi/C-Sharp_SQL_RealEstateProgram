namespace RealEstateDB
{
    partial class AddBuyerSeller
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
            this.button1 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Mname = new System.Windows.Forms.TextBox();
            this.SSNText = new System.Windows.Forms.TextBox();
            this.StrAdd = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Zip = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.ComboBox();
            this.City = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(713, 375);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add ";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(75, 14);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(101, 20);
            this.Fname.TabIndex = 2;
            this.Fname.TextChanged += new System.EventHandler(this.Fname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Middle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SSN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Street Adress";
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(77, 117);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(82, 20);
            this.Lname.TabIndex = 8;
            this.Lname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Mname
            // 
            this.Mname.Location = new System.Drawing.Point(56, 67);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(103, 20);
            this.Mname.TabIndex = 9;
            // 
            // SSNText
            // 
            this.SSNText.Location = new System.Drawing.Point(51, 165);
            this.SSNText.MaxLength = 9;
            this.SSNText.Name = "SSNText";
            this.SSNText.Size = new System.Drawing.Size(95, 20);
            this.SSNText.TabIndex = 10;
            this.SSNText.TextChanged += new System.EventHandler(this.SSNText_TextChanged);
            // 
            // StrAdd
            // 
            this.StrAdd.Location = new System.Drawing.Point(90, 217);
            this.StrAdd.Name = "StrAdd";
            this.StrAdd.Size = new System.Drawing.Size(125, 20);
            this.StrAdd.TabIndex = 11;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Buyer",
            "Seller"});
            this.Type.Location = new System.Drawing.Point(362, 14);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 21);
            this.Type.TabIndex = 12;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "State";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Zip";
            // 
            // Zip
            // 
            this.Zip.Location = new System.Drawing.Point(40, 372);
            this.Zip.MaxLength = 5;
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(125, 20);
            this.Zip.TabIndex = 19;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(362, 67);
            this.Phone.MaxLength = 10;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(125, 20);
            this.Phone.TabIndex = 20;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(362, 117);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(125, 20);
            this.Email.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "E-mail";
            // 
            // State
            // 
            this.State.FormattingEnabled = true;
            this.State.Items.AddRange(new object[] {
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
            this.State.Location = new System.Drawing.Point(56, 316);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(121, 21);
            this.State.TabIndex = 24;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(51, 270);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(125, 20);
            this.City.TabIndex = 25;
            this.City.TextChanged += new System.EventHandler(this.City_TextChanged);
            // 
            // AddBuyerSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.City);
            this.Controls.Add(this.State);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.StrAdd);
            this.Controls.Add(this.SSNText);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.button1);
            this.Name = "AddBuyerSeller";
            this.Text = "AddBuyerSeller";
            this.Load += new System.EventHandler(this.AddBuyerSeller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Lname;
        public System.Windows.Forms.TextBox Mname;
        public System.Windows.Forms.TextBox SSNText;
        public System.Windows.Forms.TextBox StrAdd;
        public System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox Zip;
        public System.Windows.Forms.TextBox Phone;
        public System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox State;
        public System.Windows.Forms.TextBox City;
    }
}
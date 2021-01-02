namespace RealEstateDB
{
    partial class ViewAgents
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
            this.AgentIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.Lastnamebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Agentgrid = new System.Windows.Forms.DataGridView();
            this.SearchAgent = new System.Windows.Forms.Button();
            this.DOBdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SDdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.combostatus = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Agentgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AgentIDBox
            // 
            this.AgentIDBox.Location = new System.Drawing.Point(104, 79);
            this.AgentIDBox.Name = "AgentIDBox";
            this.AgentIDBox.Size = new System.Drawing.Size(152, 27);
            this.AgentIDBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(104, 136);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(152, 27);
            this.FirstNameBox.TabIndex = 4;
            // 
            // Lastnamebox
            // 
            this.Lastnamebox.Location = new System.Drawing.Point(374, 141);
            this.Lastnamebox.Name = "Lastnamebox";
            this.Lastnamebox.Size = new System.Drawing.Size(152, 27);
            this.Lastnamebox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOB";
            // 
            // startdate
            // 
            this.startdate.AutoSize = true;
            this.startdate.Location = new System.Drawing.Point(563, 79);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(79, 19);
            this.startdate.TabIndex = 8;
            this.startdate.Text = "Start Date";
            this.startdate.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status";
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(886, 25);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(155, 37);
            this.Home.TabIndex = 12;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(886, 112);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(155, 37);
            this.Search.TabIndex = 13;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agentgrid
            // 
            this.Agentgrid.AllowUserToAddRows = false;
            this.Agentgrid.AllowUserToDeleteRows = false;
            this.Agentgrid.AllowUserToResizeColumns = false;
            this.Agentgrid.AllowUserToResizeRows = false;
            this.Agentgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Agentgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Agentgrid.Location = new System.Drawing.Point(17, 310);
            this.Agentgrid.Name = "Agentgrid";
            this.Agentgrid.ReadOnly = true;
            this.Agentgrid.RowTemplate.Height = 29;
            this.Agentgrid.Size = new System.Drawing.Size(1018, 332);
            this.Agentgrid.TabIndex = 14;
            this.Agentgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchAgent
            // 
            this.SearchAgent.Location = new System.Drawing.Point(886, 256);
            this.SearchAgent.Name = "SearchAgent";
            this.SearchAgent.Size = new System.Drawing.Size(155, 37);
            this.SearchAgent.TabIndex = 15;
            this.SearchAgent.Text = "Add a new Agent";
            this.SearchAgent.UseVisualStyleBackColor = true;
            this.SearchAgent.Click += new System.EventHandler(this.SearchAgent_Click);
            // 
            // DOBdateTimePicker
            // 
            this.DOBdateTimePicker.CustomFormat = " ";
            this.DOBdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBdateTimePicker.Location = new System.Drawing.Point(374, 79);
            this.DOBdateTimePicker.Name = "DOBdateTimePicker";
            this.DOBdateTimePicker.Size = new System.Drawing.Size(152, 27);
            this.DOBdateTimePicker.TabIndex = 16;
            this.DOBdateTimePicker.Value = new System.DateTime(2018, 11, 18, 0, 0, 0, 0);
            this.DOBdateTimePicker.ValueChanged += new System.EventHandler(this.DOBdateTimePicker_ValueChanged);
            // 
            // SDdateTimePicker
            // 
            this.SDdateTimePicker.CustomFormat = " ";
            this.SDdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SDdateTimePicker.Location = new System.Drawing.Point(661, 76);
            this.SDdateTimePicker.Name = "SDdateTimePicker";
            this.SDdateTimePicker.Size = new System.Drawing.Size(152, 27);
            this.SDdateTimePicker.TabIndex = 17;
            this.SDdateTimePicker.ValueChanged += new System.EventHandler(this.SDdateTimePicker_ValueChanged);
            // 
            // combostatus
            // 
            this.combostatus.FormattingEnabled = true;
            this.combostatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.combostatus.Location = new System.Drawing.Point(661, 144);
            this.combostatus.Name = "combostatus";
            this.combostatus.Size = new System.Drawing.Size(152, 27);
            this.combostatus.TabIndex = 19;
            this.combostatus.SelectedIndexChanged += new System.EventHandler(this.combostatus_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(886, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ViewAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 654);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.combostatus);
            this.Controls.Add(this.SDdateTimePicker);
            this.Controls.Add(this.DOBdateTimePicker);
            this.Controls.Add(this.SearchAgent);
            this.Controls.Add(this.Agentgrid);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lastnamebox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgentIDBox);
            this.Name = "ViewAgents";
            this.Text = "View Agents";
            this.Load += new System.EventHandler(this.ViewAgents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Agentgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox AgentIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox FirstNameBox;
        public System.Windows.Forms.TextBox Lastnamebox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label startdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView Agentgrid;
        public System.Windows.Forms.Button SearchAgent;
        public System.Windows.Forms.DateTimePicker DOBdateTimePicker;
        public System.Windows.Forms.DateTimePicker SDdateTimePicker;
        public System.Windows.Forms.ComboBox combostatus;
        private System.Windows.Forms.Button button2;
    }
}
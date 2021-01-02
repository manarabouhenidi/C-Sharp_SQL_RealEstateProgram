namespace RealEstateDB
{
    partial class ViewTransactions
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
            this.newtransaction = new System.Windows.Forms.Button();
            this.bssn1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.trandate = new System.Windows.Forms.TextBox();
            this.numprop = new System.Windows.Forms.TextBox();
            this.typeprop = new System.Windows.Forms.TextBox();
            this.sssn1 = new System.Windows.Forms.TextBox();
            this.numtrans = new System.Windows.Forms.TextBox();
            this.BSSN = new System.Windows.Forms.Label();
            this.SSSN = new System.Windows.Forms.Label();
            this.Tranum = new System.Windows.Forms.Label();
            this.Propnum = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.datetran = new System.Windows.Forms.Label();
            this.agentid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(974, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newtransaction
            // 
            this.newtransaction.Location = new System.Drawing.Point(973, 261);
            this.newtransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newtransaction.Name = "newtransaction";
            this.newtransaction.Size = new System.Drawing.Size(190, 32);
            this.newtransaction.TabIndex = 2;
            this.newtransaction.Text = "New Transaction";
            this.newtransaction.UseVisualStyleBackColor = true;
            this.newtransaction.Click += new System.EventHandler(this.button2_Click);
            // 
            // bssn1
            // 
            this.bssn1.Location = new System.Drawing.Point(36, 35);
            this.bssn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bssn1.MaxLength = 9;
            this.bssn1.Name = "bssn1";
            this.bssn1.Size = new System.Drawing.Size(290, 27);
            this.bssn1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(974, 185);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 312);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 332);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tansactions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trandate
            // 
            this.trandate.Location = new System.Drawing.Point(421, 163);
            this.trandate.Name = "trandate";
            this.trandate.Size = new System.Drawing.Size(290, 27);
            this.trandate.TabIndex = 7;
            this.trandate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numprop
            // 
            this.numprop.Location = new System.Drawing.Point(421, 104);
            this.numprop.MaxLength = 9;
            this.numprop.Name = "numprop";
            this.numprop.Size = new System.Drawing.Size(290, 27);
            this.numprop.TabIndex = 8;
            // 
            // typeprop
            // 
            this.typeprop.Location = new System.Drawing.Point(36, 163);
            this.typeprop.Name = "typeprop";
            this.typeprop.Size = new System.Drawing.Size(281, 27);
            this.typeprop.TabIndex = 9;
            // 
            // sssn1
            // 
            this.sssn1.Location = new System.Drawing.Point(421, 35);
            this.sssn1.MaxLength = 9;
            this.sssn1.Name = "sssn1";
            this.sssn1.Size = new System.Drawing.Size(290, 27);
            this.sssn1.TabIndex = 11;
            // 
            // numtrans
            // 
            this.numtrans.Location = new System.Drawing.Point(36, 104);
            this.numtrans.MaxLength = 14;
            this.numtrans.Name = "numtrans";
            this.numtrans.Size = new System.Drawing.Size(281, 27);
            this.numtrans.TabIndex = 12;
            // 
            // BSSN
            // 
            this.BSSN.AutoSize = true;
            this.BSSN.Location = new System.Drawing.Point(32, 11);
            this.BSSN.Name = "BSSN";
            this.BSSN.Size = new System.Drawing.Size(47, 19);
            this.BSSN.TabIndex = 13;
            this.BSSN.Text = "BSSN";
            this.BSSN.Click += new System.EventHandler(this.label2_Click);
            // 
            // SSSN
            // 
            this.SSSN.AutoSize = true;
            this.SSSN.Location = new System.Drawing.Point(417, 13);
            this.SSSN.Name = "SSSN";
            this.SSSN.Size = new System.Drawing.Size(47, 19);
            this.SSSN.TabIndex = 14;
            this.SSSN.Text = "SSSN";
            // 
            // Tranum
            // 
            this.Tranum.AutoSize = true;
            this.Tranum.Location = new System.Drawing.Point(32, 74);
            this.Tranum.Name = "Tranum";
            this.Tranum.Size = new System.Drawing.Size(153, 19);
            this.Tranum.TabIndex = 15;
            this.Tranum.Text = "Transaction Number";
            // 
            // Propnum
            // 
            this.Propnum.AutoSize = true;
            this.Propnum.Location = new System.Drawing.Point(417, 82);
            this.Propnum.Name = "Propnum";
            this.Propnum.Size = new System.Drawing.Size(131, 19);
            this.Propnum.TabIndex = 16;
            this.Propnum.Text = "Property Number";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(32, 141);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(109, 19);
            this.city.TabIndex = 17;
            this.city.Text = "Property Type";
            // 
            // datetran
            // 
            this.datetran.AutoSize = true;
            this.datetran.Location = new System.Drawing.Point(417, 140);
            this.datetran.Name = "datetran";
            this.datetran.Size = new System.Drawing.Size(41, 19);
            this.datetran.TabIndex = 18;
            this.datetran.Text = "Date";
            // 
            // agentid
            // 
            this.agentid.Location = new System.Drawing.Point(36, 231);
            this.agentid.MaxLength = 9;
            this.agentid.Name = "agentid";
            this.agentid.Size = new System.Drawing.Size(281, 27);
            this.agentid.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Agent ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(974, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 32);
            this.button2.TabIndex = 23;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 657);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.agentid);
            this.Controls.Add(this.datetran);
            this.Controls.Add(this.city);
            this.Controls.Add(this.Propnum);
            this.Controls.Add(this.Tranum);
            this.Controls.Add(this.SSSN);
            this.Controls.Add(this.BSSN);
            this.Controls.Add(this.numtrans);
            this.Controls.Add(this.sssn1);
            this.Controls.Add(this.typeprop);
            this.Controls.Add(this.numprop);
            this.Controls.Add(this.trandate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bssn1);
            this.Controls.Add(this.newtransaction);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewTransactions";
            this.Text = "ViewTransactions";
            this.Load += new System.EventHandler(this.ViewTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newtransaction;
        private System.Windows.Forms.TextBox bssn1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trandate;
        private System.Windows.Forms.TextBox numprop;
        private System.Windows.Forms.TextBox typeprop;
        private System.Windows.Forms.TextBox sssn1;
        private System.Windows.Forms.TextBox numtrans;
        private System.Windows.Forms.Label BSSN;
        private System.Windows.Forms.Label SSSN;
        private System.Windows.Forms.Label Tranum;
        private System.Windows.Forms.Label Propnum;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label datetran;
        private System.Windows.Forms.TextBox agentid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
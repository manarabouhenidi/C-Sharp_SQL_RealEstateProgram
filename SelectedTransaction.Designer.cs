﻿namespace RealEstateDB
{
    partial class SelectedTransaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.transnum = new System.Windows.Forms.TextBox();
            this.transdate = new System.Windows.Forms.TextBox();
            this.sssnselect = new System.Windows.Forms.TextBox();
            this.bssnselect = new System.Windows.Forms.TextBox();
            this.selectpno = new System.Windows.Forms.TextBox();
            this.selectptype = new System.Windows.Forms.TextBox();
            this.selectprofit = new System.Windows.Forms.TextBox();
            this.Deletetrans = new System.Windows.Forms.Button();
            this.selectprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.agentid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1032, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 428);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of Transaction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "SSSN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "BSSN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 438);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Property Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Property Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Transaction Profit";
            // 
            // transnum
            // 
            this.transnum.Location = new System.Drawing.Point(22, 60);
            this.transnum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transnum.Name = "transnum";
            this.transnum.Size = new System.Drawing.Size(172, 27);
            this.transnum.TabIndex = 8;
            this.transnum.TextChanged += new System.EventHandler(this.transnum_TextChanged);
            // 
            // transdate
            // 
            this.transdate.Location = new System.Drawing.Point(610, 462);
            this.transdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transdate.Name = "transdate";
            this.transdate.Size = new System.Drawing.Size(172, 27);
            this.transdate.TabIndex = 9;
            this.transdate.TextChanged += new System.EventHandler(this.transdate_TextChanged);
            // 
            // sssnselect
            // 
            this.sssnselect.Location = new System.Drawing.Point(22, 254);
            this.sssnselect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sssnselect.Name = "sssnselect";
            this.sssnselect.Size = new System.Drawing.Size(172, 27);
            this.sssnselect.TabIndex = 10;
            this.sssnselect.TextChanged += new System.EventHandler(this.sssnselect_TextChanged);
            // 
            // bssnselect
            // 
            this.bssnselect.Location = new System.Drawing.Point(22, 462);
            this.bssnselect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bssnselect.Name = "bssnselect";
            this.bssnselect.Size = new System.Drawing.Size(172, 27);
            this.bssnselect.TabIndex = 11;
            this.bssnselect.TextChanged += new System.EventHandler(this.bssnselect_TextChanged);
            // 
            // selectpno
            // 
            this.selectpno.Location = new System.Drawing.Point(328, 462);
            this.selectpno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectpno.Name = "selectpno";
            this.selectpno.Size = new System.Drawing.Size(172, 27);
            this.selectpno.TabIndex = 12;
            this.selectpno.TextChanged += new System.EventHandler(this.selectpno_TextChanged);
            // 
            // selectptype
            // 
            this.selectptype.Location = new System.Drawing.Point(610, 254);
            this.selectptype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectptype.Name = "selectptype";
            this.selectptype.Size = new System.Drawing.Size(172, 27);
            this.selectptype.TabIndex = 13;
            this.selectptype.TextChanged += new System.EventHandler(this.selectptype_TextChanged);
            // 
            // selectprofit
            // 
            this.selectprofit.Location = new System.Drawing.Point(610, 60);
            this.selectprofit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectprofit.Name = "selectprofit";
            this.selectprofit.Size = new System.Drawing.Size(172, 27);
            this.selectprofit.TabIndex = 14;
            this.selectprofit.TextChanged += new System.EventHandler(this.selectprofit_TextChanged);
            // 
            // Deletetrans
            // 
            this.Deletetrans.Location = new System.Drawing.Point(22, 576);
            this.Deletetrans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Deletetrans.Name = "Deletetrans";
            this.Deletetrans.Size = new System.Drawing.Size(310, 36);
            this.Deletetrans.TabIndex = 15;
            this.Deletetrans.Text = "Delete Transaction Record ";
            this.Deletetrans.UseVisualStyleBackColor = true;
            this.Deletetrans.Click += new System.EventHandler(this.Deletetrans_Click);
            // 
            // selectprice
            // 
            this.selectprice.Location = new System.Drawing.Point(326, 254);
            this.selectprice.Name = "selectprice";
            this.selectprice.Size = new System.Drawing.Size(174, 27);
            this.selectprice.TabIndex = 16;
            this.selectprice.TextChanged += new System.EventHandler(this.selectprice_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Price";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(1038, 576);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(150, 41);
            this.Edit.TabIndex = 18;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // agentid
            // 
            this.agentid.Location = new System.Drawing.Point(328, 60);
            this.agentid.Name = "agentid";
            this.agentid.Size = new System.Drawing.Size(144, 27);
            this.agentid.TabIndex = 19;
            this.agentid.TextChanged += new System.EventHandler(this.agentid_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Agent ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1032, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 38);
            this.button2.TabIndex = 21;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectedTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 657);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.agentid);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectprice);
            this.Controls.Add(this.Deletetrans);
            this.Controls.Add(this.selectprofit);
            this.Controls.Add(this.selectptype);
            this.Controls.Add(this.selectpno);
            this.Controls.Add(this.bssnselect);
            this.Controls.Add(this.sssnselect);
            this.Controls.Add(this.transdate);
            this.Controls.Add(this.transnum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectedTransaction";
            this.Text = "SelectedTransaction";
            this.Load += new System.EventHandler(this.SelectedTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox transnum;
        public System.Windows.Forms.TextBox transdate;
        public System.Windows.Forms.TextBox sssnselect;
        public System.Windows.Forms.TextBox bssnselect;
        public System.Windows.Forms.TextBox selectpno;
        public System.Windows.Forms.TextBox selectptype;
        public System.Windows.Forms.TextBox selectprofit;
        private System.Windows.Forms.Button Deletetrans;
        public System.Windows.Forms.TextBox selectprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Edit;
        public System.Windows.Forms.TextBox agentid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}
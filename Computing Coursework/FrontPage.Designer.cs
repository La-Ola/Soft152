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
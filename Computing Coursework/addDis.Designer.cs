namespace Computing_Coursework
{
    partial class AddDis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDis));
            this.TXTdistname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTNsubName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTDistNeighbs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXTdistname
            // 
            this.TXTdistname.AutoSize = true;
            this.TXTdistname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.TXTdistname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTdistname.Location = new System.Drawing.Point(12, 37);
            this.TXTdistname.Name = "TXTdistname";
            this.TXTdistname.Size = new System.Drawing.Size(197, 22);
            this.TXTdistname.TabIndex = 0;
            this.TXTdistname.Text = "        District Name        ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(240, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TXTdistname_TextChanged);
            // 
            // BTNsubName
            // 
            this.BTNsubName.BackColor = System.Drawing.Color.Purple;
            this.BTNsubName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNsubName.ForeColor = System.Drawing.Color.White;
            this.BTNsubName.Location = new System.Drawing.Point(205, 152);
            this.BTNsubName.Name = "BTNsubName";
            this.BTNsubName.Size = new System.Drawing.Size(85, 37);
            this.BTNsubName.TabIndex = 6;
            this.BTNsubName.Text = "ENTER";
            this.BTNsubName.UseVisualStyleBackColor = false;
            this.BTNsubName.Click += new System.EventHandler(this.BTNsubName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Neighbourhoods Within";
            // 
            // TXTDistNeighbs
            // 
            this.TXTDistNeighbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.TXTDistNeighbs.Location = new System.Drawing.Point(240, 87);
            this.TXTDistNeighbs.Name = "TXTDistNeighbs";
            this.TXTDistNeighbs.Size = new System.Drawing.Size(240, 26);
            this.TXTDistNeighbs.TabIndex = 8;
            this.TXTDistNeighbs.Text = "0";
            this.TXTDistNeighbs.TextChanged += new System.EventHandler(this.TXTDistNeighbs_TextChanged);
            // 
            // addDis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(492, 201);
            this.Controls.Add(this.TXTDistNeighbs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNsubName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TXTdistname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addDis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.addDis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TXTdistname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTNsubName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTDistNeighbs;
    }
}
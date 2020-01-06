using System;

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
            this.TXTdistrict = new System.Windows.Forms.Label();
            this.TXTDist = new System.Windows.Forms.TextBox();
            this.BTNsubName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTdistname
            // 
            this.TXTdistrict.AutoSize = true;
            this.TXTdistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.TXTdistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTdistrict.Location = new System.Drawing.Point(12, 37);
            this.TXTdistrict.Name = "TXTdistrict";
            this.TXTdistrict.Size = new System.Drawing.Size(197, 22);
            this.TXTdistrict.TabIndex = 0;
            this.TXTdistrict.Text = "        District Name        ";
            // 
            // TXTDist
            // 
            this.TXTDist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.TXTDist.Location = new System.Drawing.Point(240, 37);
            this.TXTDist.Name = "TXTDist";
            this.TXTDist.Size = new System.Drawing.Size(240, 26);
            this.TXTDist.TabIndex = 1;
            this.TXTDist.TextChanged += new System.EventHandler(this.TXTDist_TextChanged);
            // 
            // BTNsubName
            // 
            this.BTNsubName.BackColor = System.Drawing.Color.Purple;
            this.BTNsubName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNsubName.ForeColor = System.Drawing.Color.White;
            this.BTNsubName.Location = new System.Drawing.Point(202, 101);
            this.BTNsubName.Name = "BTNsubName";
            this.BTNsubName.Size = new System.Drawing.Size(85, 37);
            this.BTNsubName.TabIndex = 6;
            this.BTNsubName.Text = "ENTER";
            this.BTNsubName.UseVisualStyleBackColor = false;
            this.BTNsubName.Click += new System.EventHandler(this.BTNsubName_Click);
            // 
            // AddDis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(492, 158);
            this.Controls.Add(this.BTNsubName);
            this.Controls.Add(this.TXTDist);
            this.Controls.Add(this.TXTdistrict);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.addDis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TXTDist_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label TXTdistrict;
        private System.Windows.Forms.TextBox TXTDist;
        private System.Windows.Forms.Button BTNsubName;
    }
}
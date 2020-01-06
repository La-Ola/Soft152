using System;

namespace Computing_Coursework
{
    partial class AddNeighb
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
            this.TXTdistname = new System.Windows.Forms.Label();
            this.TXTDisName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTnewNeighbName = new System.Windows.Forms.TextBox();
            this.BTNsubName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTdistname
            // 
            this.TXTdistname.AutoSize = true;
            this.TXTdistname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.TXTdistname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTdistname.Location = new System.Drawing.Point(12, 29);
            this.TXTdistname.Name = "TXTdistname";
            this.TXTdistname.Size = new System.Drawing.Size(197, 22);
            this.TXTdistname.TabIndex = 1;
            this.TXTdistname.Text = "        District Name        ";
            // 
            // TXTDisName
            // 
            this.TXTDisName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.TXTDisName.Location = new System.Drawing.Point(234, 29);
            this.TXTDisName.Name = "TXTDisName";
            this.TXTDisName.Size = new System.Drawing.Size(240, 26);
            this.TXTDisName.TabIndex = 2;
            this.TXTDisName.TextChanged += new System.EventHandler(this.TXTDistName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = " Neighbourhood Name ";
            // 
            // TXTnewNeighbName
            // 
            this.TXTnewNeighbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.TXTnewNeighbName.Location = new System.Drawing.Point(234, 79);
            this.TXTnewNeighbName.Name = "TXTnewNeighbName";
            this.TXTnewNeighbName.Size = new System.Drawing.Size(240, 26);
            this.TXTnewNeighbName.TabIndex = 6;
            this.TXTnewNeighbName.TextChanged += new System.EventHandler(this.TXTnewNeighbName_TextChanged);
            // 
            // BTNsubName
            // 
            this.BTNsubName.BackColor = System.Drawing.Color.Purple;
            this.BTNsubName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNsubName.ForeColor = System.Drawing.Color.White;
            this.BTNsubName.Location = new System.Drawing.Point(202, 129);
            this.BTNsubName.Name = "BTNsubName";
            this.BTNsubName.Size = new System.Drawing.Size(85, 37);
            this.BTNsubName.TabIndex = 7;
            this.BTNsubName.Text = "ENTER";
            this.BTNsubName.UseVisualStyleBackColor = false;
            this.BTNsubName.Click += new System.EventHandler(this.BTNsubName_Click);
            // 
            // AddNeighb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(488, 184);
            this.Controls.Add(this.BTNsubName);
            this.Controls.Add(this.TXTnewNeighbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTDisName);
            this.Controls.Add(this.TXTdistname);
            this.Name = "AddNeighb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNeighb";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TXTDistName_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label TXTdistname;
        private System.Windows.Forms.TextBox TXTDisName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTnewNeighbName;
        private System.Windows.Forms.Button BTNsubName;
    }
}
namespace WinFormsApp1
{
    partial class FORM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GRPBX1 = new System.Windows.Forms.GroupBox();
            this.CKBX4 = new System.Windows.Forms.CheckBox();
            this.CKBX3 = new System.Windows.Forms.CheckBox();
            this.CKBX2 = new System.Windows.Forms.CheckBox();
            this.CKBX1 = new System.Windows.Forms.CheckBox();
            this.BTN1 = new System.Windows.Forms.Button();
            this.TXTBX2 = new System.Windows.Forms.TextBox();
            this.GRPBX2 = new System.Windows.Forms.GroupBox();
            this.CKBX7 = new System.Windows.Forms.CheckBox();
            this.CKBX6 = new System.Windows.Forms.CheckBox();
            this.CKBX5 = new System.Windows.Forms.CheckBox();
            this.TXTBX1 = new System.Windows.Forms.TextBox();
            this.LBL1 = new System.Windows.Forms.Label();
            this.GRPBX1.SuspendLayout();
            this.GRPBX2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRPBX1
            // 
            this.GRPBX1.Controls.Add(this.CKBX4);
            this.GRPBX1.Controls.Add(this.CKBX3);
            this.GRPBX1.Controls.Add(this.CKBX2);
            this.GRPBX1.Controls.Add(this.CKBX1);
            this.GRPBX1.Location = new System.Drawing.Point(19, 22);
            this.GRPBX1.Name = "GRPBX1";
            this.GRPBX1.Size = new System.Drawing.Size(302, 190);
            this.GRPBX1.TabIndex = 0;
            this.GRPBX1.TabStop = false;
            this.GRPBX1.Text = "Settings";
            // 
            // CKBX4
            // 
            this.CKBX4.AutoSize = true;
            this.CKBX4.Location = new System.Drawing.Point(21, 136);
            this.CKBX4.Name = "CKBX4";
            this.CKBX4.Size = new System.Drawing.Size(146, 24);
            this.CKBX4.TabIndex = 3;
            this.CKBX4.Text = "Hardware Details";
            this.CKBX4.UseVisualStyleBackColor = true;
            // 
            // CKBX3
            // 
            this.CKBX3.AutoSize = true;
            this.CKBX3.Location = new System.Drawing.Point(21, 106);
            this.CKBX3.Name = "CKBX3";
            this.CKBX3.Size = new System.Drawing.Size(66, 24);
            this.CKBX3.TabIndex = 2;
            this.CKBX3.Text = "Users";
            this.CKBX3.UseVisualStyleBackColor = true;
            // 
            // CKBX2
            // 
            this.CKBX2.AutoSize = true;
            this.CKBX2.Location = new System.Drawing.Point(20, 76);
            this.CKBX2.Name = "CKBX2";
            this.CKBX2.Size = new System.Drawing.Size(108, 24);
            this.CKBX2.TabIndex = 1;
            this.CKBX2.Text = "Networking";
            this.CKBX2.UseVisualStyleBackColor = true;
            // 
            // CKBX1
            // 
            this.CKBX1.AutoSize = true;
            this.CKBX1.Location = new System.Drawing.Point(20, 46);
            this.CKBX1.Name = "CKBX1";
            this.CKBX1.Size = new System.Drawing.Size(149, 24);
            this.CKBX1.TabIndex = 0;
            this.CKBX1.Text = "Operating System";
            this.CKBX1.UseVisualStyleBackColor = true;
            this.CKBX1.Click += new System.EventHandler(this.CKBX1_Click);
            // 
            // BTN1
            // 
            this.BTN1.Location = new System.Drawing.Point(474, 370);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(189, 45);
            this.BTN1.TabIndex = 1;
            this.BTN1.Text = "RUN";
            this.BTN1.UseVisualStyleBackColor = true;
            // 
            // TXTBX2
            // 
            this.TXTBX2.Location = new System.Drawing.Point(359, 45);
            this.TXTBX2.Multiline = true;
            this.TXTBX2.Name = "TXTBX2";
            this.TXTBX2.Size = new System.Drawing.Size(408, 302);
            this.TXTBX2.TabIndex = 2;
            // 
            // GRPBX2
            // 
            this.GRPBX2.Controls.Add(this.CKBX7);
            this.GRPBX2.Controls.Add(this.CKBX6);
            this.GRPBX2.Controls.Add(this.CKBX5);
            this.GRPBX2.Controls.Add(this.TXTBX1);
            this.GRPBX2.Controls.Add(this.LBL1);
            this.GRPBX2.Location = new System.Drawing.Point(22, 243);
            this.GRPBX2.Name = "GRPBX2";
            this.GRPBX2.Size = new System.Drawing.Size(293, 190);
            this.GRPBX2.TabIndex = 3;
            this.GRPBX2.TabStop = false;
            this.GRPBX2.Text = "Export";
            // 
            // CKBX7
            // 
            this.CKBX7.AutoSize = true;
            this.CKBX7.Location = new System.Drawing.Point(24, 127);
            this.CKBX7.Name = "CKBX7";
            this.CKBX7.Size = new System.Drawing.Size(66, 24);
            this.CKBX7.TabIndex = 4;
            this.CKBX7.Text = "JSON";
            this.CKBX7.UseVisualStyleBackColor = true;
            // 
            // CKBX6
            // 
            this.CKBX6.AutoSize = true;
            this.CKBX6.Location = new System.Drawing.Point(24, 97);
            this.CKBX6.Name = "CKBX6";
            this.CKBX6.Size = new System.Drawing.Size(60, 24);
            this.CKBX6.TabIndex = 3;
            this.CKBX6.Text = "XML";
            this.CKBX6.UseVisualStyleBackColor = true;
            // 
            // CKBX5
            // 
            this.CKBX5.AutoSize = true;
            this.CKBX5.Location = new System.Drawing.Point(24, 67);
            this.CKBX5.Name = "CKBX5";
            this.CKBX5.Size = new System.Drawing.Size(72, 24);
            this.CKBX5.TabIndex = 2;
            this.CKBX5.Text = "Binary";
            this.CKBX5.UseVisualStyleBackColor = true;
            // 
            // TXTBX1
            // 
            this.TXTBX1.Location = new System.Drawing.Point(67, 29);
            this.TXTBX1.Name = "TXTBX1";
            this.TXTBX1.Size = new System.Drawing.Size(201, 27);
            this.TXTBX1.TabIndex = 1;
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(17, 32);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(44, 20);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "Path: ";
            // 
            // FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GRPBX2);
            this.Controls.Add(this.TXTBX2);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.GRPBX1);
            this.Name = "FORM";
            this.Text = "Unit Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRPBX1.ResumeLayout(false);
            this.GRPBX1.PerformLayout();
            this.GRPBX2.ResumeLayout(false);
            this.GRPBX2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPBX1;
        private System.Windows.Forms.CheckBox CKBX4;
        private System.Windows.Forms.CheckBox CKBX3;
        private System.Windows.Forms.CheckBox CKBX2;
        private System.Windows.Forms.CheckBox CKBX1;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.TextBox TXTBX2;
        private System.Windows.Forms.GroupBox GRPBX2;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.CheckBox CKBX7;
        private System.Windows.Forms.CheckBox CKBX6;
        private System.Windows.Forms.CheckBox CKBX5;
        private System.Windows.Forms.TextBox TXTBX1;
    }
}

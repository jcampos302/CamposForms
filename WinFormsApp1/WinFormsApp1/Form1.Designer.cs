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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM));
            this.GRPBX1 = new System.Windows.Forms.GroupBox();
            this.CKBX3 = new System.Windows.Forms.CheckBox();
            this.CKBX2 = new System.Windows.Forms.CheckBox();
            this.CKBX1 = new System.Windows.Forms.CheckBox();
            this.BTN1 = new System.Windows.Forms.Button();
            this.RTXTBX1 = new System.Windows.Forms.RichTextBox();
            this.GRPBX1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRPBX1
            // 
            this.GRPBX1.Controls.Add(this.CKBX3);
            this.GRPBX1.Controls.Add(this.CKBX2);
            this.GRPBX1.Controls.Add(this.CKBX1);
            this.GRPBX1.Location = new System.Drawing.Point(19, 45);
            this.GRPBX1.Name = "GRPBX1";
            this.GRPBX1.Size = new System.Drawing.Size(311, 167);
            this.GRPBX1.TabIndex = 0;
            this.GRPBX1.TabStop = false;
            this.GRPBX1.Text = "Settings";
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
            // 
            // BTN1
            // 
            this.BTN1.Location = new System.Drawing.Point(19, 530);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(302, 45);
            this.BTN1.TabIndex = 1;
            this.BTN1.Text = "RUN";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // RTXTBX1
            // 
            this.RTXTBX1.BackColor = System.Drawing.SystemColors.Window;
            this.RTXTBX1.Location = new System.Drawing.Point(19, 236);
            this.RTXTBX1.Name = "RTXTBX1";
            this.RTXTBX1.Size = new System.Drawing.Size(311, 271);
            this.RTXTBX1.TabIndex = 4;
            this.RTXTBX1.Text = "";
            // 
            // FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(351, 587);
            this.Controls.Add(this.RTXTBX1);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.GRPBX1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM";
            this.Text = "Unit Details";
            this.GRPBX1.ResumeLayout(false);
            this.GRPBX1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRPBX1;
        private System.Windows.Forms.CheckBox CKBX3;
        private System.Windows.Forms.CheckBox CKBX2;
        private System.Windows.Forms.CheckBox CKBX1;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.RichTextBox RTXTBX1;
    }
}

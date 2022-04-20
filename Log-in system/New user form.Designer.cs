namespace Log_in_system
{
    partial class New_user_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_user_form));
            this.label1 = new System.Windows.Forms.Label();
            this.newUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confPass = new System.Windows.Forms.TextBox();
            this.createAccButt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(32, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thank you for creating an account with us!\r\nPlease enter the username you will be" +
    " using,\r\nthen enter and confirm your password\r\n";
            // 
            // newUsername
            // 
            this.newUsername.Location = new System.Drawing.Point(36, 285);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(279, 26);
            this.newUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(36, 357);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(275, 26);
            this.newPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password:";
            // 
            // confPass
            // 
            this.confPass.Location = new System.Drawing.Point(36, 433);
            this.confPass.Name = "confPass";
            this.confPass.Size = new System.Drawing.Size(275, 26);
            this.confPass.TabIndex = 7;
            // 
            // createAccButt
            // 
            this.createAccButt.Location = new System.Drawing.Point(36, 490);
            this.createAccButt.Name = "createAccButt";
            this.createAccButt.Size = new System.Drawing.Size(137, 29);
            this.createAccButt.TabIndex = 8;
            this.createAccButt.Text = "Create Account";
            this.createAccButt.UseVisualStyleBackColor = true;
            this.createAccButt.Click += new System.EventHandler(this.createAccButt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // errorBox
            // 
            this.errorBox.AutoSize = true;
            this.errorBox.Location = new System.Drawing.Point(32, 167);
            this.errorBox.MinimumSize = new System.Drawing.Size(276, 26);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(276, 26);
            this.errorBox.TabIndex = 10;
            // 
            // New_user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 655);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createAccButt);
            this.Controls.Add(this.confPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newUsername);
            this.Controls.Add(this.label1);
            this.Name = "New_user_form";
            this.Text = "New_user_form";
            this.Load += new System.EventHandler(this.New_user_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confPass;
        private System.Windows.Forms.Button createAccButt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label errorBox;
    }
}
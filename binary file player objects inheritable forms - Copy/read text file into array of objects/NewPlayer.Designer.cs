namespace read_text_file_into_array_of_objects
{
    partial class NewPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlayer));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.imgAvatar1 = new System.Windows.Forms.PictureBox();
            this.imgAvatar2 = new System.Windows.Forms.PictureBox();
            this.btnWriteToBinaryFile = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(9, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatar.Location = new System.Drawing.Point(116, 73);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(147, 16);
            this.lblAvatar.TabIndex = 2;
            this.lblAvatar.Text = "Choose your avatar:";
            // 
            // imgAvatar1
            // 
            this.imgAvatar1.Image = ((System.Drawing.Image)(resources.GetObject("imgAvatar1.Image")));
            this.imgAvatar1.Location = new System.Drawing.Point(93, 108);
            this.imgAvatar1.Name = "imgAvatar1";
            this.imgAvatar1.Size = new System.Drawing.Size(75, 81);
            this.imgAvatar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAvatar1.TabIndex = 4;
            this.imgAvatar1.TabStop = false;
            this.imgAvatar1.Click += new System.EventHandler(this.imgAvatar1_Click);
            // 
            // imgAvatar2
            // 
            this.imgAvatar2.Image = ((System.Drawing.Image)(resources.GetObject("imgAvatar2.Image")));
            this.imgAvatar2.Location = new System.Drawing.Point(211, 108);
            this.imgAvatar2.Name = "imgAvatar2";
            this.imgAvatar2.Size = new System.Drawing.Size(85, 81);
            this.imgAvatar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAvatar2.TabIndex = 5;
            this.imgAvatar2.TabStop = false;
            this.imgAvatar2.Click += new System.EventHandler(this.imgAvatar2_Click);
            // 
            // btnWriteToBinaryFile
            // 
            this.btnWriteToBinaryFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteToBinaryFile.Location = new System.Drawing.Point(93, 225);
            this.btnWriteToBinaryFile.Name = "btnWriteToBinaryFile";
            this.btnWriteToBinaryFile.Size = new System.Drawing.Size(203, 63);
            this.btnWriteToBinaryFile.TabIndex = 6;
            this.btnWriteToBinaryFile.Text = "Register";
            this.btnWriteToBinaryFile.UseVisualStyleBackColor = true;
            this.btnWriteToBinaryFile.Click += new System.EventHandler(this.btnWriteToBinaryFile_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(351, 19);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 51);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(7, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 16);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password;";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 20);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 372);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnWriteToBinaryFile);
            this.Controls.Add(this.imgAvatar2);
            this.Controls.Add(this.imgAvatar1);
            this.Controls.Add(this.lblAvatar);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "NewPlayer";
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.PictureBox imgAvatar1;
        private System.Windows.Forms.PictureBox imgAvatar2;
        private System.Windows.Forms.Button btnWriteToBinaryFile;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
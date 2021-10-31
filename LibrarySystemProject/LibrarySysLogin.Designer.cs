namespace LibrarySystemProject
{
    partial class LibrarySysLogin
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarySysLogin));
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.TextUsername = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureLogin
            // 
            this.pictureLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogin.Image")));
            this.pictureLogin.Location = new System.Drawing.Point(12, 12);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(371, 143);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogin.TabIndex = 0;
            this.pictureLogin.TabStop = false;
            // 
            // TextUsername
            // 
            this.TextUsername.AutoSize = true;
            this.TextUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextUsername.Location = new System.Drawing.Point(260, 198);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(123, 24);
            this.TextUsername.TabIndex = 1;
            this.TextUsername.Text = "Username : ";
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextPassword.Location = new System.Drawing.Point(260, 231);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(124, 24);
            this.TextPassword.TabIndex = 2;
            this.TextPassword.Text = "Password  : ";
            // 
            // UsernameInput
            // 
            this.UsernameInput.AccessibleName = "UsernameInput";
            this.UsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsernameInput.Location = new System.Drawing.Point(389, 193);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(160, 29);
            this.UsernameInput.TabIndex = 3;
            // 
            // PasswordInput
            // 
            this.PasswordInput.AccessibleName = "PasswordInput";
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordInput.Location = new System.Drawing.Point(390, 228);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(160, 29);
            this.PasswordInput.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(415, 263);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(109, 36);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LibrarySysLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.pictureLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibrarySysLogin";
            this.Text = "LibrarySysLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.Label TextUsername;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Button LoginButton;
    }
}


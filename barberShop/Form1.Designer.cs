
namespace barberShop
{
    partial class Logon
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
            this.txtbxUser = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserpassword = new System.Windows.Forms.Label();
            this.bttnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxUser
            // 
            this.txtbxUser.Location = new System.Drawing.Point(282, 132);
            this.txtbxUser.Name = "txtbxUser";
            this.txtbxUser.Size = new System.Drawing.Size(166, 23);
            this.txtbxUser.TabIndex = 0;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(246, 187);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(238, 23);
            this.txtbxPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(324, 114);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 15);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Nome usuário";
            // 
            // lblUserpassword
            // 
            this.lblUserpassword.AutoSize = true;
            this.lblUserpassword.Location = new System.Drawing.Point(346, 169);
            this.lblUserpassword.Name = "lblUserpassword";
            this.lblUserpassword.Size = new System.Drawing.Size(39, 15);
            this.lblUserpassword.TabIndex = 3;
            this.lblUserpassword.Text = "Senha";
            // 
            // bttnEnter
            // 
            this.bttnEnter.Location = new System.Drawing.Point(320, 266);
            this.bttnEnter.Name = "bttnEnter";
            this.bttnEnter.Size = new System.Drawing.Size(90, 31);
            this.bttnEnter.TabIndex = 4;
            this.bttnEnter.Text = "Entrar";
            this.bttnEnter.UseVisualStyleBackColor = true;
            // 
            // Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bttnEnter);
            this.Controls.Add(this.lblUserpassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUser);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxUser;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserpassword;
        private System.Windows.Forms.Button bttnEnter;
    }
}


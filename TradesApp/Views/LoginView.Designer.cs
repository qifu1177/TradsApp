namespace TradesApp.Views
{
    partial class LoginView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            btLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            tbUserName = new TextBox();
            tbPassword = new TextBox();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.AccessibleRole = AccessibleRole.None;
            btLogin.Location = new Point(183, 152);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(94, 29);
            btLogin.TabIndex = 0;
            btLogin.Text = "Anmelden";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 51);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Benutzer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 99);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Passwort";
            // 
            // tbUserName
            // 
            tbUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbUserName.Location = new Point(187, 48);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(294, 27);
            tbUserName.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(182, 96);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(294, 27);
            tbPassword.TabIndex = 4;
           
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbPassword);
            Controls.Add(tbUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btLogin);
            Name = "LoginView";
            Size = new Size(519, 251);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogin;
        private Label label1;
        private Label label2;
        private TextBox tbUserName;
        private TextBox tbPassword;
    }
}

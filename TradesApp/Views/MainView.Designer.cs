namespace TradesApp.Views
{
    partial class MainView
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
            btLogout = new Button();
            pnView = new Panel();
            label1 = new Label();
            lbUser = new Label();
            listViewNavi = new ListBox();
            SuspendLayout();
            // 
            // btLogout
            // 
            btLogout.Location = new Point(20, 73);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(221, 29);
            btLogout.TabIndex = 1;
            btLogout.Text = "Abmelden";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // pnView
            // 
            pnView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnView.Location = new Point(266, 0);
            pnView.Name = "pnView";
            pnView.Size = new Size(332, 283);
            pnView.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Benutzer:";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(20, 41);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(50, 20);
            lbUser.TabIndex = 4;
            lbUser.Text = "label2";
            // 
            // listViewNavi
            // 
            listViewNavi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listViewNavi.BorderStyle = BorderStyle.None;
            listViewNavi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listViewNavi.FormattingEnabled = true;
            listViewNavi.ItemHeight = 25;
            listViewNavi.Location = new Point(20, 108);
            listViewNavi.Name = "listViewNavi";
            listViewNavi.Size = new Size(221, 150);
            listViewNavi.TabIndex = 5;
            listViewNavi.SelectedValueChanged += listViewNavi_SelectedValueChanged;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listViewNavi);
            Controls.Add(lbUser);
            Controls.Add(label1);
            Controls.Add(pnView);
            Controls.Add(btLogout);
            Name = "MainView";
            Size = new Size(609, 290);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btLogout;
        private Panel pnView;
        private Label label1;
        private Label lbUser;
        private ListBox listViewNavi;
    }
}

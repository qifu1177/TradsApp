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
            listViewNavi = new ListView();
            btLogout = new Button();
            SuspendLayout();
            // 
            // listViewNavi
            // 
            listViewNavi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listViewNavi.Location = new Point(0, 48);
            listViewNavi.Name = "listViewNavi";
            listViewNavi.Size = new Size(260, 361);
            listViewNavi.TabIndex = 0;
            listViewNavi.UseCompatibleStateImageBehavior = false;
            // 
            // btLogout
            // 
            btLogout.Location = new Point(21, 13);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(221, 29);
            btLogout.TabIndex = 1;
            btLogout.Text = "Abmelden";
            btLogout.UseVisualStyleBackColor = true;
            btLogout.Click += btLogout_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btLogout);
            Controls.Add(listViewNavi);
            Name = "MainView";
            Size = new Size(738, 416);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewNavi;
        private Button btLogout;
    }
}

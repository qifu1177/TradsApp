namespace TradesApp.Dialogs
{
    partial class EmployeeTradeInputDialog
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbUser = new TextBox();
            tbISIN = new TextBox();
            tbVolum = new NumericUpDown();
            cbArt = new ComboBox();
            btSave = new Button();
            lbErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)tbVolum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(77, 42);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Benutzer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(107, 92);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "ISIN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(72, 138);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Stückzahl:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(54, 192);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "Geschäftsart:";
            // 
            // tbUser
            // 
            tbUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbUser.Location = new Point(159, 43);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(446, 27);
            tbUser.TabIndex = 4;
            // 
            // tbISIN
            // 
            tbISIN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbISIN.Location = new Point(158, 92);
            tbISIN.Name = "tbISIN";
            tbISIN.Size = new Size(446, 27);
            tbISIN.TabIndex = 5;
            // 
            // tbVolum
            // 
            tbVolum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbVolum.Location = new Point(159, 141);
            tbVolum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            tbVolum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tbVolum.Name = "tbVolum";
            tbVolum.Size = new Size(445, 27);
            tbVolum.TabIndex = 6;
            tbVolum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbArt
            // 
            cbArt.FormattingEnabled = true;
            cbArt.Location = new Point(158, 189);
            cbArt.Name = "cbArt";
            cbArt.Size = new Size(252, 28);
            cbArt.TabIndex = 7;
            // 
            // btSave
            // 
            btSave.ForeColor = Color.Black;
            btSave.Location = new Point(158, 237);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 8;
            btSave.Text = "Speichern";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // lbErrorMessage
            // 
            lbErrorMessage.AutoSize = true;
            lbErrorMessage.Location = new Point(161, 284);
            lbErrorMessage.Name = "lbErrorMessage";
            lbErrorMessage.Size = new Size(0, 20);
            lbErrorMessage.TabIndex = 9;
            // 
            // EmployeeTradeInputDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 354);
            Controls.Add(lbErrorMessage);
            Controls.Add(btSave);
            Controls.Add(cbArt);
            Controls.Add(tbVolum);
            Controls.Add(tbISIN);
            Controls.Add(tbUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Red;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeTradeInputDialog";
            Text = "Erstellung von Employee TradeI ";
            Load += EmployeeTradeInputDialog_Load;
            ((System.ComponentModel.ISupportInitialize)tbVolum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbUser;
        private TextBox tbISIN;
        private NumericUpDown tbVolum;
        private ComboBox cbArt;
        private Button btSave;
        private Label lbErrorMessage;
    }
}
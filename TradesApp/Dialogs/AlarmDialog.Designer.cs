namespace TradesApp.Dialogs
{
    partial class AlarmDialog
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
            dgView = new DataGridView();
            btOK = new Button();
            ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Auffällige Kursbewegungen";
            // 
            // dgView
            // 
            dgView.AllowUserToAddRows = false;
            dgView.AllowUserToDeleteRows = false;
            dgView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgView.Location = new Point(25, 47);
            dgView.Name = "dgView";
            dgView.RowHeadersWidth = 51;
            dgView.RowTemplate.Height = 29;
            dgView.Size = new Size(751, 349);
            dgView.TabIndex = 1;
            // 
            // btOK
            // 
            btOK.Location = new Point(23, 409);
            btOK.Name = "btOK";
            btOK.Size = new Size(94, 29);
            btOK.TabIndex = 2;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // AlarmDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btOK);
            Controls.Add(dgView);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AlarmDialog";
            Text = "Alarm";
            ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgView;
        private Button btOK;
    }
}
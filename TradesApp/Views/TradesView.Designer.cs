namespace TradesApp.Views
{
    partial class TradesView
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
            btUpdate = new Button();
            dgView = new DataGridView();
            dtTo = new DateTimePicker();
            label2 = new Label();
            dtFrom = new DateTimePicker();
            label1 = new Label();
            btImport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
            SuspendLayout();
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(21, 40);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 13;
            btUpdate.Text = "Aktualisieren";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // dgView
            // 
            dgView.AllowUserToAddRows = false;
            dgView.AllowUserToDeleteRows = false;
            dgView.AllowUserToOrderColumns = true;
            dgView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgView.Location = new Point(12, 88);
            dgView.Name = "dgView";
            dgView.RowHeadersWidth = 51;
            dgView.RowTemplate.Height = 29;
            dgView.Size = new Size(686, 212);
            dgView.TabIndex = 12;
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "dd.MM.yyyy HH:mm";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(184, 49);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(250, 27);
            dtTo.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 49);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 10;
            label2.Text = "bis:";
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(184, 10);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(250, 27);
            dtFrom.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 11);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 8;
            label1.Text = "Von:";
            // 
            // btImport
            // 
            btImport.Location = new Point(21, 5);
            btImport.Name = "btImport";
            btImport.Size = new Size(94, 29);
            btImport.TabIndex = 14;
            btImport.Text = "Import";
            btImport.UseVisualStyleBackColor = true;
            btImport.Click += btImport_Click;
            // 
            // TradesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btImport);
            Controls.Add(btUpdate);
            Controls.Add(dgView);
            Controls.Add(dtTo);
            Controls.Add(label2);
            Controls.Add(dtFrom);
            Controls.Add(label1);
            Name = "TradesView";
            Size = new Size(713, 317);
            ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btUpdate;
        private DataGridView dgView;
        private DateTimePicker dtTo;
        private Label label2;
        private DateTimePicker dtFrom;
        private Label label1;
        private Button btImport;
    }
}

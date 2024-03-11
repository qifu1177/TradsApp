namespace TradesApp.Views
{
    partial class EmployeeTradesView
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
            btCreate = new Button();
            label1 = new Label();
            dtFrom = new DateTimePicker();
            label2 = new Label();
            dtTo = new DateTimePicker();
            dgView = new DataGridView();
            btUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
            SuspendLayout();
            // 
            // btCreate
            // 
            btCreate.Location = new Point(24, 11);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(94, 29);
            btCreate.TabIndex = 0;
            btCreate.Text = "Erstellen";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 17);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 1;
            label1.Text = "Von:";
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(187, 16);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(250, 27);
            dtFrom.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 55);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 3;
            label2.Text = "bis:";
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "dd.MM.yyyy HH:mm";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(187, 55);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(250, 27);
            dtTo.TabIndex = 4;
            // 
            // dgView
            // 
            dgView.AllowUserToAddRows = false;
            dgView.AllowUserToDeleteRows = false;
            dgView.AllowUserToOrderColumns = true;
            dgView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgView.Location = new Point(15, 94);
            dgView.Name = "dgView";
            dgView.RowHeadersWidth = 51;
            dgView.RowTemplate.Height = 29;
            dgView.Size = new Size(757, 358);
            dgView.TabIndex = 5;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(24, 46);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 6;
            btUpdate.Text = "Aktualisieren";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // EmployeeTradesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btUpdate);
            Controls.Add(dgView);
            Controls.Add(dtTo);
            Controls.Add(label2);
            Controls.Add(dtFrom);
            Controls.Add(label1);
            Controls.Add(btCreate);
            Name = "EmployeeTradesView";
            Size = new Size(793, 464);
            ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCreate;
        private Label label1;
        private DateTimePicker dtFrom;
        private Label label2;
        private DateTimePicker dtTo;
        private DataGridView dgView;
        private Button btUpdate;
    }
}

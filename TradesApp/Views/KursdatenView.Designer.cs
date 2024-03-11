namespace TradesApp.Views
{
    partial class KursdatenView
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
            dtTo = new DateTimePicker();
            label2 = new Label();
            dtFrom = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(22, 42);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 18;
            btUpdate.Text = "Aktualisieren";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "dd.MM.yyyy HH:mm";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(185, 51);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(250, 27);
            dtTo.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 51);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 16;
            label2.Text = "bis:";
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(185, 12);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(250, 27);
            dtFrom.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 13);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 14;
            label1.Text = "Von:";
            // 
            // KursdatenView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btUpdate);
            Controls.Add(dtTo);
            Controls.Add(label2);
            Controls.Add(dtFrom);
            Controls.Add(label1);
            Name = "KursdatenView";
            Size = new Size(635, 391);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btUpdate;
        private DateTimePicker dtTo;
        private Label label2;
        private DateTimePicker dtFrom;
        private Label label1;
    }
}

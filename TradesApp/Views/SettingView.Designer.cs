namespace TradesApp.Views
{
    partial class SettingView
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
            label1 = new Label();
            tbAlarmChangePrice = new NumericUpDown();
            tbAlarmChangeVolumen = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbAlarmChangePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAlarmChangeVolumen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Alarm-Kursänderungen";
            // 
            // tbAlarmChangePrice
            // 
            tbAlarmChangePrice.Location = new Point(28, 54);
            tbAlarmChangePrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            tbAlarmChangePrice.Name = "tbAlarmChangePrice";
            tbAlarmChangePrice.Size = new Size(292, 27);
            tbAlarmChangePrice.TabIndex = 1;
            tbAlarmChangePrice.ValueChanged += tbAlarmChangePrice_ValueChanged;
            // 
            // tbAlarmChangeVolumen
            // 
            tbAlarmChangeVolumen.Location = new Point(28, 130);
            tbAlarmChangeVolumen.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            tbAlarmChangeVolumen.Name = "tbAlarmChangeVolumen";
            tbAlarmChangeVolumen.Size = new Size(292, 27);
            tbAlarmChangeVolumen.TabIndex = 3;
            tbAlarmChangeVolumen.ValueChanged += tbAlarmChangeVolumen_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 96);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 2;
            label2.Text = "Alarm-Volumen";
            // 
            // SettingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbAlarmChangeVolumen);
            Controls.Add(label2);
            Controls.Add(tbAlarmChangePrice);
            Controls.Add(label1);
            Name = "SettingView";
            Size = new Size(338, 170);
            ((System.ComponentModel.ISupportInitialize)tbAlarmChangePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAlarmChangeVolumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown tbAlarmChangePrice;
        private NumericUpDown tbAlarmChangeVolumen;
        private Label label2;
    }
}

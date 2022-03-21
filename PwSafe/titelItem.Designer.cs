namespace PwSafe
{
    partial class titelItem
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
            this.labelTitel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitel.Location = new System.Drawing.Point(89, 17);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(61, 24);
            this.labelTitel.TabIndex = 0;
            this.labelTitel.Text = "TITEL";
            this.labelTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitel.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.labelTitel.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            // 
            // titelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelTitel);
            this.Name = "titelItem";
            this.Size = new System.Drawing.Size(250, 60);
            this.Load += new System.EventHandler(this.TitelItem_Load);
            this.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTitel;
    }
}

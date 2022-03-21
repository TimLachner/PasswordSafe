namespace PwSafe
{
    partial class categoryItem
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
            this.labelCategoryTitel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCategoryTitel
            // 
            this.labelCategoryTitel.AutoSize = true;
            this.labelCategoryTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryTitel.Location = new System.Drawing.Point(48, 18);
            this.labelCategoryTitel.Name = "labelCategoryTitel";
            this.labelCategoryTitel.Size = new System.Drawing.Size(61, 24);
            this.labelCategoryTitel.TabIndex = 0;
            this.labelCategoryTitel.Text = "TITEL";
            // 
            // categoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelCategoryTitel);
            this.Name = "categoryItem";
            this.Size = new System.Drawing.Size(171, 60);
            this.Load += new System.EventHandler(this.CategoryItem_Load);
            this.MouseEnter += new System.EventHandler(this.Item_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Item_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelCategoryTitel;
    }
}

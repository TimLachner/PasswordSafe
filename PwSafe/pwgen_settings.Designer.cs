namespace PwSafe
{
    partial class pwgen_settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.pwset_cancelbttn = new System.Windows.Forms.Button();
            this.pwset_savebttn = new System.Windows.Forms.Button();
            this.pwset_specchar_checkbox = new System.Windows.Forms.CheckBox();
            this.pwset_uppercase_checkbox = new System.Windows.Forms.CheckBox();
            this.pwset_lengthselect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Settings";
            // 
            // pwset_cancelbttn
            // 
            this.pwset_cancelbttn.Location = new System.Drawing.Point(12, 283);
            this.pwset_cancelbttn.Name = "pwset_cancelbttn";
            this.pwset_cancelbttn.Size = new System.Drawing.Size(75, 23);
            this.pwset_cancelbttn.TabIndex = 1;
            this.pwset_cancelbttn.Text = "Cancel";
            this.pwset_cancelbttn.UseVisualStyleBackColor = true;
            this.pwset_cancelbttn.Click += new System.EventHandler(this.Pwset_cancelbttn_Click);
            // 
            // pwset_savebttn
            // 
            this.pwset_savebttn.Location = new System.Drawing.Point(283, 283);
            this.pwset_savebttn.Name = "pwset_savebttn";
            this.pwset_savebttn.Size = new System.Drawing.Size(75, 23);
            this.pwset_savebttn.TabIndex = 2;
            this.pwset_savebttn.Text = "Save";
            this.pwset_savebttn.UseVisualStyleBackColor = true;
            this.pwset_savebttn.Click += new System.EventHandler(this.Pwset_savebttn_Click);
            // 
            // pwset_specchar_checkbox
            // 
            this.pwset_specchar_checkbox.AutoSize = true;
            this.pwset_specchar_checkbox.Checked = true;
            this.pwset_specchar_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pwset_specchar_checkbox.Location = new System.Drawing.Point(180, 127);
            this.pwset_specchar_checkbox.Name = "pwset_specchar_checkbox";
            this.pwset_specchar_checkbox.Size = new System.Drawing.Size(110, 17);
            this.pwset_specchar_checkbox.TabIndex = 3;
            this.pwset_specchar_checkbox.Text = "Special Character";
            this.pwset_specchar_checkbox.UseVisualStyleBackColor = true;
            // 
            // pwset_uppercase_checkbox
            // 
            this.pwset_uppercase_checkbox.AutoSize = true;
            this.pwset_uppercase_checkbox.Checked = true;
            this.pwset_uppercase_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pwset_uppercase_checkbox.Location = new System.Drawing.Point(180, 104);
            this.pwset_uppercase_checkbox.Name = "pwset_uppercase_checkbox";
            this.pwset_uppercase_checkbox.Size = new System.Drawing.Size(78, 17);
            this.pwset_uppercase_checkbox.TabIndex = 4;
            this.pwset_uppercase_checkbox.Text = "Uppercase";
            this.pwset_uppercase_checkbox.UseVisualStyleBackColor = true;
            // 
            // pwset_lengthselect
            // 
            this.pwset_lengthselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pwset_lengthselect.FormattingEnabled = true;
            this.pwset_lengthselect.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.pwset_lengthselect.Location = new System.Drawing.Point(23, 123);
            this.pwset_lengthselect.Name = "pwset_lengthselect";
            this.pwset_lengthselect.Size = new System.Drawing.Size(121, 21);
            this.pwset_lengthselect.TabIndex = 5;
            this.pwset_lengthselect.SelectedIndexChanged += new System.EventHandler(this.pwset_lengthselect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password length";
            // 
            // pwgen_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwset_lengthselect);
            this.Controls.Add(this.pwset_uppercase_checkbox);
            this.Controls.Add(this.pwset_specchar_checkbox);
            this.Controls.Add(this.pwset_savebttn);
            this.Controls.Add(this.pwset_cancelbttn);
            this.Controls.Add(this.label1);
            this.Name = "pwgen_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.pwgen_settings_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pwset_cancelbttn;
        private System.Windows.Forms.Button pwset_savebttn;
        private System.Windows.Forms.CheckBox pwset_specchar_checkbox;
        private System.Windows.Forms.CheckBox pwset_uppercase_checkbox;
        private System.Windows.Forms.ComboBox pwset_lengthselect;
        private System.Windows.Forms.Label label2;
    }
}
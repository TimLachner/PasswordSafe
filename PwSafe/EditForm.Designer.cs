namespace PwSafe
{
    partial class EditForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editpw_rtextbox_info = new System.Windows.Forms.RichTextBox();
            this.editpw_textbox_website = new System.Windows.Forms.TextBox();
            this.editpw_gensetlinklable = new System.Windows.Forms.LinkLabel();
            this.editpw_genpwbttn = new System.Windows.Forms.Button();
            this.editpw_showpwbttn = new System.Windows.Forms.Button();
            this.addpw_conpw_lable = new System.Windows.Forms.Label();
            this.editpw_conpw_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addpw_pw_lable = new System.Windows.Forms.Label();
            this.addpw_username_lable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editpw_category_combobox = new System.Windows.Forms.ComboBox();
            this.editpw_titel_textbox = new System.Windows.Forms.TextBox();
            this.editpw_pw_textbox = new System.Windows.Forms.TextBox();
            this.editpw_username_textbox = new System.Windows.Forms.TextBox();
            this.addpw_savebttn = new System.Windows.Forms.Button();
            this.addpw_cancelbttn = new System.Windows.Forms.Button();
            this.addpw_ap_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Informationen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Website";
            // 
            // editpw_rtextbox_info
            // 
            this.editpw_rtextbox_info.Location = new System.Drawing.Point(459, 290);
            this.editpw_rtextbox_info.Name = "editpw_rtextbox_info";
            this.editpw_rtextbox_info.Size = new System.Drawing.Size(148, 101);
            this.editpw_rtextbox_info.TabIndex = 37;
            this.editpw_rtextbox_info.Text = "";
            // 
            // editpw_textbox_website
            // 
            this.editpw_textbox_website.Location = new System.Drawing.Point(459, 238);
            this.editpw_textbox_website.Name = "editpw_textbox_website";
            this.editpw_textbox_website.Size = new System.Drawing.Size(148, 20);
            this.editpw_textbox_website.TabIndex = 36;
            // 
            // editpw_gensetlinklable
            // 
            this.editpw_gensetlinklable.AutoSize = true;
            this.editpw_gensetlinklable.LinkColor = System.Drawing.Color.Black;
            this.editpw_gensetlinklable.Location = new System.Drawing.Point(490, 177);
            this.editpw_gensetlinklable.Name = "editpw_gensetlinklable";
            this.editpw_gensetlinklable.Size = new System.Drawing.Size(91, 13);
            this.editpw_gensetlinklable.TabIndex = 35;
            this.editpw_gensetlinklable.TabStop = true;
            this.editpw_gensetlinklable.Text = "generator settings";
            this.editpw_gensetlinklable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editpw_gensetlinklable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Editpw_gensetlinklable_LinkClicked);
            // 
            // editpw_genpwbttn
            // 
            this.editpw_genpwbttn.Location = new System.Drawing.Point(540, 140);
            this.editpw_genpwbttn.Name = "editpw_genpwbttn";
            this.editpw_genpwbttn.Size = new System.Drawing.Size(67, 23);
            this.editpw_genpwbttn.TabIndex = 32;
            this.editpw_genpwbttn.Text = "generate";
            this.editpw_genpwbttn.UseVisualStyleBackColor = true;
            this.editpw_genpwbttn.Click += new System.EventHandler(this.Editpw_genpwbttn_Click);
            // 
            // editpw_showpwbttn
            // 
            this.editpw_showpwbttn.Location = new System.Drawing.Point(459, 140);
            this.editpw_showpwbttn.Name = "editpw_showpwbttn";
            this.editpw_showpwbttn.Size = new System.Drawing.Size(67, 23);
            this.editpw_showpwbttn.TabIndex = 31;
            this.editpw_showpwbttn.Text = "show";
            this.editpw_showpwbttn.UseVisualStyleBackColor = true;
            this.editpw_showpwbttn.Click += new System.EventHandler(this.Editpw_showpwbttn_Click);
            // 
            // addpw_conpw_lable
            // 
            this.addpw_conpw_lable.AutoSize = true;
            this.addpw_conpw_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpw_conpw_lable.Location = new System.Drawing.Point(465, 98);
            this.addpw_conpw_lable.Name = "addpw_conpw_lable";
            this.addpw_conpw_lable.Size = new System.Drawing.Size(116, 16);
            this.addpw_conpw_lable.TabIndex = 34;
            this.addpw_conpw_lable.Text = "Confirm Password";
            // 
            // editpw_conpw_textbox
            // 
            this.editpw_conpw_textbox.Location = new System.Drawing.Point(459, 114);
            this.editpw_conpw_textbox.Name = "editpw_conpw_textbox";
            this.editpw_conpw_textbox.Size = new System.Drawing.Size(148, 20);
            this.editpw_conpw_textbox.TabIndex = 29;
            this.editpw_conpw_textbox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Titel";
            // 
            // addpw_pw_lable
            // 
            this.addpw_pw_lable.AutoSize = true;
            this.addpw_pw_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpw_pw_lable.Location = new System.Drawing.Point(465, 37);
            this.addpw_pw_lable.Name = "addpw_pw_lable";
            this.addpw_pw_lable.Size = new System.Drawing.Size(68, 16);
            this.addpw_pw_lable.TabIndex = 30;
            this.addpw_pw_lable.Text = "Password";
            // 
            // addpw_username_lable
            // 
            this.addpw_username_lable.AutoSize = true;
            this.addpw_username_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpw_username_lable.Location = new System.Drawing.Point(119, 142);
            this.addpw_username_lable.Name = "addpw_username_lable";
            this.addpw_username_lable.Size = new System.Drawing.Size(71, 16);
            this.addpw_username_lable.TabIndex = 28;
            this.addpw_username_lable.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Category";
            // 
            // editpw_category_combobox
            // 
            this.editpw_category_combobox.FormattingEnabled = true;
            this.editpw_category_combobox.Location = new System.Drawing.Point(113, 107);
            this.editpw_category_combobox.Name = "editpw_category_combobox";
            this.editpw_category_combobox.Size = new System.Drawing.Size(148, 21);
            this.editpw_category_combobox.TabIndex = 24;
            // 
            // editpw_titel_textbox
            // 
            this.editpw_titel_textbox.Location = new System.Drawing.Point(113, 53);
            this.editpw_titel_textbox.Name = "editpw_titel_textbox";
            this.editpw_titel_textbox.Size = new System.Drawing.Size(148, 20);
            this.editpw_titel_textbox.TabIndex = 23;
            // 
            // editpw_pw_textbox
            // 
            this.editpw_pw_textbox.Location = new System.Drawing.Point(459, 53);
            this.editpw_pw_textbox.Name = "editpw_pw_textbox";
            this.editpw_pw_textbox.Size = new System.Drawing.Size(148, 20);
            this.editpw_pw_textbox.TabIndex = 27;
            this.editpw_pw_textbox.UseSystemPasswordChar = true;
            // 
            // editpw_username_textbox
            // 
            this.editpw_username_textbox.Location = new System.Drawing.Point(113, 158);
            this.editpw_username_textbox.Name = "editpw_username_textbox";
            this.editpw_username_textbox.Size = new System.Drawing.Size(148, 20);
            this.editpw_username_textbox.TabIndex = 25;
            // 
            // addpw_savebttn
            // 
            this.addpw_savebttn.Location = new System.Drawing.Point(693, 394);
            this.addpw_savebttn.Name = "addpw_savebttn";
            this.addpw_savebttn.Size = new System.Drawing.Size(75, 23);
            this.addpw_savebttn.TabIndex = 40;
            this.addpw_savebttn.Text = "save";
            this.addpw_savebttn.UseVisualStyleBackColor = true;
            this.addpw_savebttn.Click += new System.EventHandler(this.Addpw_savebttn_Click);
            // 
            // addpw_cancelbttn
            // 
            this.addpw_cancelbttn.Location = new System.Drawing.Point(12, 394);
            this.addpw_cancelbttn.Name = "addpw_cancelbttn";
            this.addpw_cancelbttn.Size = new System.Drawing.Size(75, 23);
            this.addpw_cancelbttn.TabIndex = 41;
            this.addpw_cancelbttn.Text = "cancel";
            this.addpw_cancelbttn.UseVisualStyleBackColor = true;
            // 
            // addpw_ap_lable
            // 
            this.addpw_ap_lable.AutoSize = true;
            this.addpw_ap_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpw_ap_lable.Location = new System.Drawing.Point(9, 9);
            this.addpw_ap_lable.Name = "addpw_ap_lable";
            this.addpw_ap_lable.Size = new System.Drawing.Size(94, 16);
            this.addpw_ap_lable.TabIndex = 42;
            this.addpw_ap_lable.Text = "Edit Password";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 429);
            this.Controls.Add(this.addpw_ap_lable);
            this.Controls.Add(this.addpw_savebttn);
            this.Controls.Add(this.addpw_cancelbttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editpw_rtextbox_info);
            this.Controls.Add(this.editpw_textbox_website);
            this.Controls.Add(this.editpw_gensetlinklable);
            this.Controls.Add(this.editpw_genpwbttn);
            this.Controls.Add(this.editpw_showpwbttn);
            this.Controls.Add(this.addpw_conpw_lable);
            this.Controls.Add(this.editpw_conpw_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addpw_pw_lable);
            this.Controls.Add(this.addpw_username_lable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editpw_category_combobox);
            this.Controls.Add(this.editpw_titel_textbox);
            this.Controls.Add(this.editpw_pw_textbox);
            this.Controls.Add(this.editpw_username_textbox);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox editpw_rtextbox_info;
        private System.Windows.Forms.TextBox editpw_textbox_website;
        private System.Windows.Forms.LinkLabel editpw_gensetlinklable;
        private System.Windows.Forms.Button editpw_genpwbttn;
        private System.Windows.Forms.Button editpw_showpwbttn;
        private System.Windows.Forms.Label addpw_conpw_lable;
        private System.Windows.Forms.TextBox editpw_conpw_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label addpw_pw_lable;
        private System.Windows.Forms.Label addpw_username_lable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox editpw_category_combobox;
        private System.Windows.Forms.TextBox editpw_titel_textbox;
        private System.Windows.Forms.TextBox editpw_pw_textbox;
        private System.Windows.Forms.TextBox editpw_username_textbox;
        private System.Windows.Forms.Button addpw_savebttn;
        private System.Windows.Forms.Button addpw_cancelbttn;
        private System.Windows.Forms.Label addpw_ap_lable;
    }
}
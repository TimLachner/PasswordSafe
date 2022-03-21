
namespace PwSafe
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_user_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.login_password_textbox = new System.Windows.Forms.TextBox();
            this.login_login_lable = new System.Windows.Forms.Label();
            this.login_login_bttn = new System.Windows.Forms.Button();
            this.login_nu_lable = new System.Windows.Forms.Label();
            this.login_reg_linklabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // login_user_textbox
            // 
            this.login_user_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.login_user_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_user_textbox.Location = new System.Drawing.Point(543, 207);
            this.login_user_textbox.Name = "login_user_textbox";
            this.login_user_textbox.Size = new System.Drawing.Size(211, 24);
            this.login_user_textbox.TabIndex = 1;
            this.login_user_textbox.Tag = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(505, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(505, 266);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 36);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // login_password_textbox
            // 
            this.login_password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password_textbox.Location = new System.Drawing.Point(543, 281);
            this.login_password_textbox.Name = "login_password_textbox";
            this.login_password_textbox.Size = new System.Drawing.Size(211, 20);
            this.login_password_textbox.TabIndex = 4;
            this.login_password_textbox.UseSystemPasswordChar = true;
            // 
            // login_login_lable
            // 
            this.login_login_lable.AutoSize = true;
            this.login_login_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_login_lable.Location = new System.Drawing.Point(497, 94);
            this.login_login_lable.Name = "login_login_lable";
            this.login_login_lable.Size = new System.Drawing.Size(101, 39);
            this.login_login_lable.TabIndex = 5;
            this.login_login_lable.Text = "Login";
            // 
            // login_login_bttn
            // 
            this.login_login_bttn.BackColor = System.Drawing.Color.Transparent;
            this.login_login_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_login_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_login_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_login_bttn.ForeColor = System.Drawing.Color.White;
            this.login_login_bttn.Image = ((System.Drawing.Image)(resources.GetObject("login_login_bttn.Image")));
            this.login_login_bttn.Location = new System.Drawing.Point(540, 333);
            this.login_login_bttn.Name = "login_login_bttn";
            this.login_login_bttn.Size = new System.Drawing.Size(214, 35);
            this.login_login_bttn.TabIndex = 6;
            this.login_login_bttn.UseVisualStyleBackColor = false;
            this.login_login_bttn.Click += new System.EventHandler(this.login_login_bttn_Click);
            // 
            // login_nu_lable
            // 
            this.login_nu_lable.AutoSize = true;
            this.login_nu_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_nu_lable.ForeColor = System.Drawing.Color.Black;
            this.login_nu_lable.Location = new System.Drawing.Point(548, 392);
            this.login_nu_lable.Name = "login_nu_lable";
            this.login_nu_lable.Size = new System.Drawing.Size(82, 18);
            this.login_nu_lable.TabIndex = 7;
            this.login_nu_lable.Text = "New User?";
            // 
            // login_reg_linklabel
            // 
            this.login_reg_linklabel.AutoSize = true;
            this.login_reg_linklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_reg_linklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.login_reg_linklabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(143)))), ((int)(((byte)(196)))));
            this.login_reg_linklabel.Location = new System.Drawing.Point(628, 392);
            this.login_reg_linklabel.Name = "login_reg_linklabel";
            this.login_reg_linklabel.Size = new System.Drawing.Size(63, 18);
            this.login_reg_linklabel.TabIndex = 8;
            this.login_reg_linklabel.TabStop = true;
            this.login_reg_linklabel.Text = "Register";
            this.login_reg_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_reg_linklabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Here";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 615);
            this.Controls.Add(this.login_password_textbox);
            this.Controls.Add(this.login_user_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_reg_linklabel);
            this.Controls.Add(this.login_nu_lable);
            this.Controls.Add(this.login_login_bttn);
            this.Controls.Add(this.login_login_lable);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.newlogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox login_user_textbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox login_password_textbox;
        private System.Windows.Forms.Label login_login_lable;
        private System.Windows.Forms.Button login_login_bttn;
        private System.Windows.Forms.Label login_nu_lable;
        private System.Windows.Forms.LinkLabel login_reg_linklabel;
        private System.Windows.Forms.Label label2;
    }
}
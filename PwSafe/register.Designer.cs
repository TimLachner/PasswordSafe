namespace PwSafe
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.reg_userbox = new System.Windows.Forms.TextBox();
            this.reg_pwbox = new System.Windows.Forms.TextBox();
            this.reg_user_lable = new System.Windows.Forms.Label();
            this.reg_pw_lable = new System.Windows.Forms.Label();
            this.register_reg_lable = new System.Windows.Forms.Label();
            this.register_btl_linklabel = new System.Windows.Forms.LinkLabel();
            this.register_ar_lable = new System.Windows.Forms.Label();
            this.register_user_pb = new System.Windows.Forms.PictureBox();
            this.register_pw_pb = new System.Windows.Forms.PictureBox();
            this.register_register_bttn = new System.Windows.Forms.Button();
            this.reg_conpwbox = new System.Windows.Forms.TextBox();
            this.reg_conpw_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.register_user_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.register_pw_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_userbox
            // 
            this.reg_userbox.AccessibleDescription = "test";
            this.reg_userbox.AccessibleName = "";
            this.reg_userbox.Location = new System.Drawing.Point(557, 164);
            this.reg_userbox.Name = "reg_userbox";
            this.reg_userbox.Size = new System.Drawing.Size(214, 20);
            this.reg_userbox.TabIndex = 1;
            this.reg_userbox.Tag = "";
            // 
            // reg_pwbox
            // 
            this.reg_pwbox.Location = new System.Drawing.Point(557, 228);
            this.reg_pwbox.Name = "reg_pwbox";
            this.reg_pwbox.Size = new System.Drawing.Size(214, 20);
            this.reg_pwbox.TabIndex = 2;
            this.reg_pwbox.UseSystemPasswordChar = true;
            // 
            // reg_user_lable
            // 
            this.reg_user_lable.AutoSize = true;
            this.reg_user_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_user_lable.Location = new System.Drawing.Point(562, 145);
            this.reg_user_lable.Name = "reg_user_lable";
            this.reg_user_lable.Size = new System.Drawing.Size(36, 16);
            this.reg_user_lable.TabIndex = 4;
            this.reg_user_lable.Text = "User";
            // 
            // reg_pw_lable
            // 
            this.reg_pw_lable.AutoSize = true;
            this.reg_pw_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_pw_lable.Location = new System.Drawing.Point(562, 212);
            this.reg_pw_lable.Name = "reg_pw_lable";
            this.reg_pw_lable.Size = new System.Drawing.Size(67, 16);
            this.reg_pw_lable.TabIndex = 5;
            this.reg_pw_lable.Text = "Password";
            // 
            // register_reg_lable
            // 
            this.register_reg_lable.AutoSize = true;
            this.register_reg_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_reg_lable.Location = new System.Drawing.Point(535, 60);
            this.register_reg_lable.Name = "register_reg_lable";
            this.register_reg_lable.Size = new System.Drawing.Size(147, 39);
            this.register_reg_lable.TabIndex = 7;
            this.register_reg_lable.Text = "Register";
            // 
            // register_btl_linklabel
            // 
            this.register_btl_linklabel.AutoSize = true;
            this.register_btl_linklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btl_linklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.register_btl_linklabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(143)))), ((int)(((byte)(196)))));
            this.register_btl_linklabel.Location = new System.Drawing.Point(684, 393);
            this.register_btl_linklabel.Name = "register_btl_linklabel";
            this.register_btl_linklabel.Size = new System.Drawing.Size(94, 18);
            this.register_btl_linklabel.TabIndex = 9;
            this.register_btl_linklabel.TabStop = true;
            this.register_btl_linklabel.Text = "Back to login";
            this.register_btl_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_btl_linklabel_LinkClicked);
            // 
            // register_ar_lable
            // 
            this.register_ar_lable.AutoSize = true;
            this.register_ar_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_ar_lable.Location = new System.Drawing.Point(539, 393);
            this.register_ar_lable.Name = "register_ar_lable";
            this.register_ar_lable.Size = new System.Drawing.Size(139, 18);
            this.register_ar_lable.TabIndex = 10;
            this.register_ar_lable.Text = "Already Registered?";
            // 
            // register_user_pb
            // 
            this.register_user_pb.Image = ((System.Drawing.Image)(resources.GetObject("register_user_pb.Image")));
            this.register_user_pb.Location = new System.Drawing.Point(516, 152);
            this.register_user_pb.Name = "register_user_pb";
            this.register_user_pb.Size = new System.Drawing.Size(32, 32);
            this.register_user_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.register_user_pb.TabIndex = 12;
            this.register_user_pb.TabStop = false;
            // 
            // register_pw_pb
            // 
            this.register_pw_pb.Image = ((System.Drawing.Image)(resources.GetObject("register_pw_pb.Image")));
            this.register_pw_pb.Location = new System.Drawing.Point(516, 212);
            this.register_pw_pb.Name = "register_pw_pb";
            this.register_pw_pb.Size = new System.Drawing.Size(32, 36);
            this.register_pw_pb.TabIndex = 13;
            this.register_pw_pb.TabStop = false;
            // 
            // register_register_bttn
            // 
            this.register_register_bttn.BackColor = System.Drawing.Color.Transparent;
            this.register_register_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.register_register_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_register_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_register_bttn.ForeColor = System.Drawing.Color.White;
            this.register_register_bttn.Image = ((System.Drawing.Image)(resources.GetObject("register_register_bttn.Image")));
            this.register_register_bttn.Location = new System.Drawing.Point(557, 346);
            this.register_register_bttn.Name = "register_register_bttn";
            this.register_register_bttn.Size = new System.Drawing.Size(214, 35);
            this.register_register_bttn.TabIndex = 14;
            this.register_register_bttn.UseVisualStyleBackColor = false;
            this.register_register_bttn.Click += new System.EventHandler(this.register_register_bttn_Click);
            // 
            // reg_conpwbox
            // 
            this.reg_conpwbox.Location = new System.Drawing.Point(557, 294);
            this.reg_conpwbox.Name = "reg_conpwbox";
            this.reg_conpwbox.Size = new System.Drawing.Size(214, 20);
            this.reg_conpwbox.TabIndex = 15;
            this.reg_conpwbox.UseSystemPasswordChar = true;
            // 
            // reg_conpw_label
            // 
            this.reg_conpw_label.AutoSize = true;
            this.reg_conpw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_conpw_label.Location = new System.Drawing.Point(562, 275);
            this.reg_conpw_label.Name = "reg_conpw_label";
            this.reg_conpw_label.Size = new System.Drawing.Size(113, 16);
            this.reg_conpw_label.TabIndex = 16;
            this.reg_conpw_label.Text = "confirm Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 615);
            this.Controls.Add(this.reg_conpw_label);
            this.Controls.Add(this.reg_conpwbox);
            this.Controls.Add(this.register_register_bttn);
            this.Controls.Add(this.register_pw_pb);
            this.Controls.Add(this.register_user_pb);
            this.Controls.Add(this.register_ar_lable);
            this.Controls.Add(this.register_btl_linklabel);
            this.Controls.Add(this.register_reg_lable);
            this.Controls.Add(this.reg_pw_lable);
            this.Controls.Add(this.reg_user_lable);
            this.Controls.Add(this.reg_pwbox);
            this.Controls.Add(this.reg_userbox);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.register_user_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.register_pw_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox reg_userbox;
        private System.Windows.Forms.TextBox reg_pwbox;
        private System.Windows.Forms.Label reg_user_lable;
        private System.Windows.Forms.Label reg_pw_lable;
        private System.Windows.Forms.Label register_reg_lable;
        private System.Windows.Forms.LinkLabel register_btl_linklabel;
        private System.Windows.Forms.Label register_ar_lable;
        private System.Windows.Forms.PictureBox register_user_pb;
        private System.Windows.Forms.PictureBox register_pw_pb;
        private System.Windows.Forms.Button register_register_bttn;
        private System.Windows.Forms.TextBox reg_conpwbox;
        private System.Windows.Forms.Label reg_conpw_label;
    }
}
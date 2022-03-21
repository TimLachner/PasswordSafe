using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace PwSafe
{
    public partial class LoginForm : Form
    {
        int userID = 0;
        public static List<Passwort> pw = new List<Passwort>();
        
        public LoginForm()
        {
            InitializeComponent();
            db.InitConnection();
            //string path = @"H:\Eigene Dateien\test.txt";

            /*if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                
                tw.WriteLine("Du Hurensohn!");
                tw.Close();
            }
            else if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine("test");
                }
            }
            File.Encrypt(@"H:\Eigene Dateien\test.txt");*/
        }

        private void newlogin_Load(object sender, EventArgs e)
        {
            
        }

        private void login_reg_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form register = new Register();
            register.Show();
            this.Hide();
        }
        private void loginUser()
        {
            string user_hash = Crypto.ComputeSha256Hash(login_user_textbox.Text);
            string password_hash = Crypto.ComputeSha256Hash(login_password_textbox.Text);

            userID = db.getUserID(user_hash);


            if (db.checkSettings(userID) == false)
            {
                db.AddSettings(userID);
            }

            Form pwlist = new pwlist(userID);

            if (db.Login(user_hash, password_hash) == true)
            {
                pwlist.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong user or password!");
            }
        }
        private void login_login_bttn_Click(object sender, EventArgs e)
        {
            loginUser();
        }

        private void login_login_picbox_Click(object sender, EventArgs e)
        {
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loginUser();
            }
        }
    }
}
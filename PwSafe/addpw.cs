using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwSafe
{
    public partial class addpw : Form
    {
        bool pw_hidden = true;
        int userID = 0;
        public addpw(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            string[] categories = db.GetCategories(userID);

            for(int i = 0; i < categories.Length; i++)
            {
                addpw_category_combobox.Items.Add(categories[i]);
            }
        }

        private void Addpw_genpwbttn_Click(object sender, EventArgs e)
        {
            int length = db.GetSettings(userID).Item1;
            bool uppercase = db.GetSettings(userID).Item2;
            bool specialchar = db.GetSettings(userID).Item3;
            addpw_pw_textbox.Text = Crypto.randompw(length, uppercase, specialchar);
            addpw_conpw_textbox.Text = Crypto.randompw(length, uppercase, specialchar);
            
        }

        private void Addpw_showpwbttn_Click(object sender, EventArgs e)
        {
            if (pw_hidden)
            {
                addpw_pw_textbox.UseSystemPasswordChar = false;
                addpw_conpw_textbox.UseSystemPasswordChar = false;
                pw_hidden = false;
                addpw_showpwbttn.Text = "hide";
            }  else
            {
                addpw_pw_textbox.UseSystemPasswordChar = true;
                addpw_conpw_textbox.UseSystemPasswordChar = true;
                pw_hidden = true;
                addpw_showpwbttn.Text = "show";
            }
        }

        private void Addpw_gensetlinklable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form pwgen_set = new pwgen_settings(userID);
            pwgen_set.Show();
        }

        private void Addpw_savebttn_Click(object sender, EventArgs e)
        {
            //save Password
            string titel = addpw_titel_textbox.Text;
            string category = addpw_category_combobox.Text;
            string username = addpw_username_textbox.Text;
            string password = addpw_pw_textbox.Text;
            string conpassword = addpw_conpw_textbox.Text;
            string website = addpw_textbox_website.Text;
            string info = addpw_rtextbox_info.Text;
            bool checkNull = false;
            if (addpw_pw_textbox.Text != addpw_conpw_textbox.Text)
            {
                MessageBox.Show("Passwörter stimmen nicht überein!!");
                return;
            }
            string[] check = { titel, category, username, password, conpassword };

            foreach (string s in check)
            {
                if (s.Length == 0)
                {
                    checkNull = true;
                }
            }

            if (checkNull)
            {
                MessageBox.Show("Die Felder dürfen nicht leer sein!!");
                return;
            }

            if(db.GetIDbyTitle(titel, userID) != 0)
            {
                MessageBox.Show("Titel schon vorhanden!");
                return;
            }

            Passwort pw = new Passwort(1, titel, category, username, password, website, info);
            

            /*if(db.CheckCategory(userID, category) == false)
            {
                db.SaveCategories(userID, category);
            }

            db.SavePassword(userID, titel, category, username, password, website, info);*/

            
            this.Close();
            Form pwlist = new pwlist(userID);
            pwlist.Show();
        }

        private void Addpw_cancelbttn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form pwlist = new pwlist(userID);
            pwlist.Show();
        }
    }
}

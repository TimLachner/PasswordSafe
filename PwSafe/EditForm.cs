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
    public partial class EditForm : Form
    {
        bool pw_hidden = true;
        int userID = 0;

        public EditForm(int userID, string pwtitel)
        {
            InitializeComponent();
            int titelID = db.GetIDbyTitle(pwtitel, userID);
            editpw_titel_textbox.Text = pwtitel;
            editpw_category_combobox.Text = db.GetPassswordlistbyTitelID(titelID, userID).Item1;
            editpw_username_textbox.Text = db.GetPassswordlistbyTitelID(titelID, userID).Item2;
            editpw_pw_textbox.Text = db.GetPassswordlistbyTitelID(titelID, userID).Item3;
            editpw_conpw_textbox.Text = db.GetPassswordlistbyTitelID(titelID, userID).Item3;
            editpw_textbox_website.Text = db.GetPassswordlistbyTitelID(titelID, userID).Item4;
            editpw_rtextbox_info.Text = db.GetPassswordlistbyTitelID(titelID, userID).Item5;

            this.userID = userID;
            string[] categories = db.GetCategories(userID);

            for (int i = 0; i < categories.Length; i++)
            {
                editpw_category_combobox.Items.Add(categories[i]);
            }
        }

        private void Editpw_showpwbttn_Click(object sender, EventArgs e)
        {
            if (pw_hidden)
            {
                editpw_pw_textbox.UseSystemPasswordChar = false;
                editpw_conpw_textbox.UseSystemPasswordChar = false;
                pw_hidden = false;
                editpw_showpwbttn.Text = "hide";
            }
            else
            {
                editpw_pw_textbox.UseSystemPasswordChar = true;
                editpw_conpw_textbox.UseSystemPasswordChar = true;
                pw_hidden = true;
                editpw_showpwbttn.Text = "show";
            }
        }

        private void Editpw_genpwbttn_Click(object sender, EventArgs e)
        {
            int length = db.GetSettings(userID).Item1;
            bool uppercase = db.GetSettings(userID).Item2;
            bool specialchar = db.GetSettings(userID).Item3;
            editpw_pw_textbox.Text = Crypto.randompw(length, uppercase, specialchar);
            editpw_conpw_textbox.Text = Crypto.randompw(length, uppercase, specialchar);
        }

        private void Editpw_gensetlinklable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form pwgen_set = new pwgen_settings(userID);
            pwgen_set.Show();
        }

        private void Addpw_savebttn_Click(object sender, EventArgs e)
        {
            string titel = editpw_titel_textbox.Text;
            string category = editpw_category_combobox.Text;
            string username = editpw_username_textbox.Text;
            string password = editpw_pw_textbox.Text;
            string conpassword = editpw_conpw_textbox.Text;
            string website = editpw_textbox_website.Text;
            string info = editpw_rtextbox_info.Text;
            int id = db.GetIDbyTitle(titel, userID);
            if(password != conpassword)
            {
                MessageBox.Show("Die Passwörter stimmen nicht überein");
                return;
            }
            db.UpdatePassword(userID, titel, category, username, password, website, info, id);
            Form pwlist = new pwlist(userID);
            pwlist.Show();
            this.Hide();
        }
    }
}

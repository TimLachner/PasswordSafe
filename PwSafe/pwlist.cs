using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwSafe
{
    public partial class pwlist : Form
    {
        int userID = 0;
        bool pw_hidden = true;
        string pw = "";
        string hiddenpw = "";
        public List<Passwort> passworts = new List<Passwort>();
        public pwlist(int userID)
        {
            InitializeComponent();

            this.userID = userID;
            HideAll();
            TitelItem();
            CategoryTitelItem();
            
        }
        public pwlist()
        {
        }
        private void TitelItem()
        {
            pwlist_flowpanel.AutoScroll = true;
            pwlist_flowpanel.HorizontalScroll.Enabled = false;
            pwlist_flowpanel.HorizontalScroll.Visible = false;
            foreach (string s in db.getPasswordTitle(userID))
            {
                titelItem itm = new titelItem();
                itm.Titel = s;
                itm.TitelID = db.GetIDbyTitle(s, userID);
                pwlist_flowpanel.Controls.Add(itm);

                itm.Click += (sender, e) => OnClick(this, e, itm.Titel.ToString(), itm.TitelID);
                itm.labelTitel.Click += (sender, e) => OnClick(this, e, itm.Titel.ToString(), itm.TitelID);
            }
        }
        private void CategoryTitelItem()
        {
            pwlist_CategoryFlowlayoutpanel.AutoScroll = true;
            pwlist_CategoryFlowlayoutpanel.HorizontalScroll.Enabled = false;
            pwlist_CategoryFlowlayoutpanel.HorizontalScroll.Visible = false;
            foreach (string s in db.GetCategories(userID))
            {
                categoryItem itm1 = new categoryItem();
                itm1.Titel = s;
                pwlist_CategoryFlowlayoutpanel.Controls.Add(itm1);

                itm1.Click += (sender, e) => CategoryOnClick(this, e, itm1.Titel.ToString());
                itm1.labelCategoryTitel.Click += (sender, e) => CategoryOnClick(this, e, itm1.Titel.ToString());
            }
        }

        private void CategoryOnClick(object sender, EventArgs e, string category)
        {
            pwlist_flowpanel.Controls.Clear();
            foreach (string s in db.getPasswordtitleByCategory(userID, category))
            {
                titelItem itm = new titelItem();
                itm.Titel = s;
                itm.TitelID = db.GetIDbyTitle(s, userID);
                pwlist_flowpanel.Controls.Add(itm);

                itm.Click += (sender1, e1) => OnClick(this, e, itm.Titel.ToString(), itm.TitelID);
                itm.labelTitel.Click += (sender1, e1) => OnClick(this, e, itm.Titel.ToString(), itm.TitelID);
            }
        }

        public void OnClick(object sender, EventArgs e, string titel, int titelID)
        {
            pw = db.GetPassswordlistbyTitelID(titelID, userID).Item3;
            hiddenpw = "";
            pwlist_password_label.Show();
            pwlist_password_inputlabel.Show();
            pwlist_titel_inputlabel.Show();
            pwlist_titel_inputlabel.Text = titel;
            pwlist_username_label.Show();
            pwlist_user_inputlabel.Show();
            pwlist_website_label.Show();
            pwlist_notes_label.Show();
            pwlist_edit_button.Show();
            pwlist_frame_picbox.Show();
            pwlist_website_label.Show();
            pwlist_notes_label.Show();
            pwlist_sh_button.Show();
            delete_picbox_pwlist.Show();
            pwlist_user_inputlabel.Text = db.GetPassswordlistbyTitelID(titelID, userID).Item2;
            foreach(char c in pw)
            {
                hiddenpw += "*"; 
            }
            pwlist_password_inputlabel.Text = hiddenpw;
            pwlist_website_inputlabel.Text = db.GetPassswordlistbyTitelID(titelID, userID).Item4;
            pwlist_notes_inputlabel.Text = db.GetPassswordlistbyTitelID(titelID, userID).Item5;
            
        }
        private void HideAll()
        {
            pwlist_password_label.Hide();
            pwlist_password_inputlabel.Hide();
            pwlist_titel_inputlabel.Hide();
            pwlist_username_label.Hide();
            pwlist_user_inputlabel.Hide();
            pwlist_website_label.Hide();
            pwlist_notes_label.Hide();
            pwlist_edit_button.Hide();
            pwlist_frame_picbox.Hide();
            pwlist_sh_button.Hide();
            delete_picbox_pwlist.Hide();

        }
        private void Pwlist_addpwbttn_Click(object sender, EventArgs e)
        {
            Form addpw = new addpw(userID);
            addpw.Show();
            this.Hide();
        }
        private void pwlist_password_inputlabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string pw = pwlist_password_inputlabel.Text;
            if (pw.Contains("*"))
            {
                return;
            }
            Clipboard.SetText(pw);
            MessageBox.Show("Passwort in die Zwischenablage kopiert!");
        }

        private void pwlist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Pwlist_sh_button_Click(object sender, EventArgs e)
        {
            if (pw_hidden)
            {
                pwlist_password_inputlabel.Text = pw;
                pwlist_sh_button.Text = "hide";
                pw_hidden = false;
            }
            else
            {
                pwlist_password_inputlabel.Text = hiddenpw;
                pwlist_sh_button.Text = "show";
                pw_hidden = true;
            }

        }

        private void Pwlist_password_inputlabel_MouseEnter(object sender, EventArgs e)
        {
            if (pw_hidden)
            {
                return;
            }
            pwlist_password_inputlabel.ForeColor = Color.DodgerBlue;
        }

        private void Pwlist_password_inputlabel_MouseLeave(object sender, EventArgs e)
        {
            pwlist_password_inputlabel.ForeColor = Color.Black;
        }

        private void Pwlist_edit_button_Click(object sender, EventArgs e)
        {
            Form editform = new EditForm(userID, pwlist_titel_inputlabel.Text);
            editform.Show();
            this.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string titel = pwlist_titel_inputlabel.Text;
            DialogResult dialogResult = MessageBox.Show("Sind Sie sicher, dass Sie das Passwort löschen wollen?", "Achtung!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int titelID = db.GetIDbyTitle(titel, userID);
                db.deletePassword(userID, titelID);
                MessageBox.Show("gelöscht");
                this.Refresh();
                this.Invalidate();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("exit");
            }
        }
    }
}
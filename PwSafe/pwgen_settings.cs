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
    public partial class pwgen_settings : Form
    {
        int userID = 0;
        bool uppercase;
        bool specialchar;
        
        public pwgen_settings(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            //LOAD SETTINGS
            pwset_lengthselect.Text = Convert.ToString(db.GetSettings(userID).Item1);
            if(db.GetSettings(userID).Item2 == true)
            {
                pwset_uppercase_checkbox.Checked = true;
            }
            else
            {
                pwset_uppercase_checkbox.Checked = false;
            }
            if(db.GetSettings(userID).Item3 == true)
            {
                pwset_specchar_checkbox.Checked = true;
            }
            else
            {
                pwset_specchar_checkbox.Checked = false;
            }
        }

        private void Pwset_savebttn_Click(object sender, EventArgs e)
        {
            //save settings
            int length = Convert.ToInt16(pwset_lengthselect.Text);
            if (pwset_uppercase_checkbox.Checked)
            {
                uppercase = true;
            }
            if (pwset_specchar_checkbox.Checked)
            {
                specialchar = true;
            }
            db.UpdateSettings(userID, length, uppercase, specialchar);
            this.Close();
            
        }

        private void Pwset_cancelbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pwset_lengthselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pwgen_settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

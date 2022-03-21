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


namespace PwSafe
{
    public partial class Register : Form
    {
        bool conTrue = false;
        public Register()
        {
            InitializeComponent();

            var fileContent = string.Empty;
            var filePath = string.Empty;

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Cryptex Vault (*.cpx)|*.cpx";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        public Register(bool conTrue)
        {
            this.conTrue = conTrue;
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void register_btl_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void register_register_bttn_Click(object sender, EventArgs e)
        {
            string user_hash = Crypto.ComputeSha256Hash(reg_userbox.Text);
            string pw_hash = Crypto.ComputeSha256Hash(reg_pwbox.Text);
            string code = Crypto.randomCode();

            if (reg_pwbox.Text != reg_conpwbox.Text)
            {
                MessageBox.Show("Die Passwörter stimmen nicht überein!");
            }

            db.Register(user_hash, pw_hash);
            MessageBox.Show("Erfolgreich Registriert!");

            Form login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

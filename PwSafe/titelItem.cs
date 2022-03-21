using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwSafe
{
    public partial class titelItem : UserControl
    {
        public titelItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _titel;
        public string getTitel;
        private int _titelID;
        public int getTitelID;

        [Category("Custom Props")]
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; labelTitel.Text = value; }
        }

        public int TitelID
        {
            get { return _titelID; }
            set { _titelID = value; }
        }
        #endregion
        private void Item_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void TitelItem_Load(object sender, EventArgs e)
        {

        }
    }
}

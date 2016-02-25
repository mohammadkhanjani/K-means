using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace k_means
{
    public partial class back : Telerik.WinControls.UI.RadForm
    {
        public back()
        {
            InitializeComponent();
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            firstmenu d = new firstmenu();
            d.Show();
            this.Hide();
        }
    }
}

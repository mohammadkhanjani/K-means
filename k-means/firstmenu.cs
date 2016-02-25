using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.IO;

namespace k_means
{
    public partial class firstmenu : Telerik.WinControls.UI.RadForm
    {
        public firstmenu()
        {
            InitializeComponent();
        }


        public string[] s;

        private void glassButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "text file(*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            string address="";
            if(openFileDialog1.FileName!="")
                address = openFileDialog1.FileName;
            txtProNet1.Text = address;

            
            s = File.ReadAllLines(address);
            
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (give_k.Text != "")
                {
                    if (txtProNet1.Text != "")
                    {
                        this.Hide();
                        second d = new second(Int32.Parse(give_k.Text), s);
                        d.Show();
                    }
                    else
                    {
                        label5.Visible = true;
                        if(give_k.Text != "")
                            label2.Visible = false;
                    }
                }
                else
                    label2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void firstmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(117, 115);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(100, 88);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            back d = new back();
            d.Show();
        }

        private void firstmenu_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label5.Visible = false;
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            if(txtProNet1.Text!="")
                System.Diagnostics.Process.Start(txtProNet1.Text);

        }

    }
}

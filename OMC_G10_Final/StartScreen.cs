using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace OMC_G10_Final
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            MainPage newForm = new MainPage();
            newForm.Show();
            this.Hide();
        }



        private void btnuserguidelines_Click(object sender, EventArgs e)
        {
            ImageViewerForm newForm = new ImageViewerForm();
            newForm.Show();
            this.Hide();
        }
    }
}

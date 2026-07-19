using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class ImageViewerForm : Form
    {
        public ImageViewerForm()
        {
            InitializeComponent();
        }



        private void pageHeader1_BackClick(object sender, EventArgs e)
        {
            StartScreen newForm = new StartScreen();
            newForm.Show();
            this.Hide();
        }
    }
}

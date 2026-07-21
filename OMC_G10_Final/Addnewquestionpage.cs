using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class Addnewquestionpage : Form
    {
        public Addnewquestionpage()
        {
            InitializeComponent();
        }

        private void pageHeader1_BackClick(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is ManageQuestionform)
            {
                return;
            }
            // Open the Mobility Form
            ManageQuestionform newForm = new ManageQuestionform();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }

        private void Addnewquestionpage_Load(object sender, EventArgs e)
        {
            cmbQuestionType.Items.Clear();
            List<string> categories = DatabaseHelper.GetFAQCategories();

            foreach (string category in categories)
            {
                cmbQuestionType.Items.Add(category);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string question = txtquestion.Text.Trim();
            string answer = txtanswer.Text.Trim();

            if (string.IsNullOrEmpty(question) || string.IsNullOrEmpty(answer) || cmbQuestionType.SelectedIndex == -1)
            {
                CustomMessageBox.Show("Please fill in all fields and select a question type.");
                return;
            }

            string category = cmbQuestionType.Text.Trim();

            bool success = DatabaseHelper.AddFAQQuestion(question, category, answer);

            if (!success)
            {
                CustomMessageBox.Show("Something went wrong. Please try again.");
                return;
            }

            CustomMessageBox.Show("Question added successfully.");

            txtquestion.Clear();
            txtanswer.Clear();
            cmbQuestionType.SelectedIndex = -1;
        }
    }
}

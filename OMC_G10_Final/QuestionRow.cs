using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class QuestionRow : UserControl
    {
        private string questionId;

        public QuestionRow()
        {
            InitializeComponent();



            btndelete.Cursor = Cursors.Hand;
            btnedit.Cursor = Cursors.Hand;
        }

        public void SetQuestion(string id, string question, string category, string answer)
        {
            questionId = id;
            questiondisplay.Text = question;
            categorydisplay.Text = category;
            answerdisplay.Text = answer;
        }

        public static List<QuestionRow> LoadAllFromDatabase()
        {
            List<QuestionRow> rows = new List<QuestionRow>();
            DataTable table = DatabaseHelper.GetAllFAQs();

            foreach (DataRow row in table.Rows)
            {
                var questionRow = new QuestionRow();
                questionRow.SetQuestion(
                    row["QuestionID"].ToString(),
                    row["Question"].ToString(),
                    row["Type"].ToString(),
                    row["Answer"].ToString()
                );

                rows.Add(questionRow);
            }

            return rows;
        }

        private void DeleteQuestion()
        {
            if (string.IsNullOrEmpty(questionId)) return;

            DialogResult confirm = MessageBox.Show(
                "Delete this question?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            bool success = DatabaseHelper.DeleteFAQ(questionId);

            if (success)
            {
                MessageBox.Show("Question deleted.");

                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Failed to delete question.");
            }
        }

        private void EditQuestion()
        {
            using (EditQuestionDialog dialog = new EditQuestionDialog(
                questiondisplay.Text, categorydisplay.Text, answerdisplay.Text))
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    bool success = DatabaseHelper.UpdateFAQ(
                        questionId,
                        dialog.UpdatedQuestion,
                        dialog.UpdatedCategory,
                        dialog.UpdatedAnswer);

                    if (success)
                    {
                        // Update the row's display immediately without needing a full reload
                        questiondisplay.Text = dialog.UpdatedQuestion;
                        categorydisplay.Text = dialog.UpdatedCategory;
                        answerdisplay.Text = dialog.UpdatedAnswer;

                        MessageBox.Show("Question updated.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update question.");
                    }
                }
            }
        }
    }
}
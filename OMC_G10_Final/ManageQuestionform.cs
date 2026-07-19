using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    public partial class ManageQuestionform : Form
    {
        private FlowLayoutPanel flowQuestions;
        private List<QuestionRow> questionRows = new List<QuestionRow>();

        public ManageQuestionform()
        {
            InitializeComponent();
        }



        private void SetupPanel()
        {
            flowQuestions = new FlowLayoutPanel
            {
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = ColorTranslator.FromHtml("#6B7A52")
            };

            // Position below your header row — adjust Y to match where your
            // "Question | Category | Answer | Action" header row ends
            flowQuestions.Location = new Point(-3, 260); // adjust based on your header's actual bottom edge
            flowQuestions.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 260);
            flowQuestions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            this.Controls.Add(flowQuestions);
            flowQuestions.BringToFront();
        }

        private void LoadQuestions()
        {
            flowQuestions.Controls.Clear();

            questionRows = QuestionRow.LoadAllFromDatabase();

            foreach (var row in questionRows)
            {
                flowQuestions.Controls.Add(row);
            }
        }

        private void ManageQuestionform_Load_1(object sender, EventArgs e)
        {
            SetupPanel();
            LoadQuestions();
        }

        private void pageHeader1_BackClick(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is ProfilePage)
            {
                return;
            }
            // Open the Mobility Form
            ProfilePage newForm = new ProfilePage();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }
    }
}

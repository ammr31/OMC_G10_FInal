using OMC_G10_Final.Properties;
using static AntdUI.Table;
using Timer = System.Windows.Forms.Timer;
using System.Drawing.Drawing2D;

namespace OMC_G10_Final
{

    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void SwitchAccessibility_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            if (e.Value) // or e.Checked, depending on AntdUI's actual property name
            {
                btnCall.Enabled = false;
                btnCall.Visible = false;
                panel2.Visible = true;
                pictureBox4.Visible = false;
                label6.Visible = false;
                btnCall.Icon = Image.FromFile(@"C:\Users\User\source\repos\OMC_G10_Final\Images\telephone-call.png");

            }
            else
            {
                btnCall.Enabled = true;
                btnCall.Visible = true;
            }

            if (panelchat.Visible == false)
            {
                panelchat.Visible = true;    // show the chat UI
            }
            else
            {
                panelchat.Visible = false;
            }

            // Optional: greet the user when chat opens, only once
            if (flowlayoutchat.Controls.Count == 0)
            {
                AddMessage("Hi! How can I help you today?", isUser: false);
            }
        }



        private void AddMessage(string text, bool isUser)
        {
            Panel bubble = new Panel
            {
                AutoSize = true,
                MaximumSize = new Size(280, 0),
                Padding = new Padding(12, 8, 12, 8),
                BackColor = isUser ? Color.FromArgb(255, 220, 248) : Color.White,
                Margin = new Padding(8, 4, 8, 4)
            };

            Label lblText = new Label
            {
                Text = text,
                AutoSize = true,
                MaximumSize = new Size(256, 0),
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };

            Label lblTime = new Label
            {
                Text = DateTime.Now.ToString("h:mm tt"),
                AutoSize = true,
                Font = new Font("Segoe UI", 7),
                ForeColor = Color.Gray,
                BackColor = Color.Transparent
            };

            bubble.Controls.Add(lblText);
            bubble.Controls.Add(lblTime);
            lblText.Location = new Point(0, 0);
            lblTime.Location = new Point(0, lblText.Bottom + 2);

            bubble.Size = new Size(
                Math.Max(lblText.Width, lblTime.Width) + bubble.Padding.Horizontal,
                lblText.Height + lblTime.Height + bubble.Padding.Vertical + 2
            );

            // Rounded corners
            bubble.Paint += (s, e) =>
            {
                GraphicsPath path = RoundedRect(bubble.ClientRectangle, 14);
                bubble.Region = new Region(path);
            };

            // Wrapper handles left/right alignment within the chat panel
            FlowLayoutPanel wrapper = new FlowLayoutPanel
            {
                FlowDirection = isUser ? FlowDirection.RightToLeft : FlowDirection.LeftToRight,
                AutoSize = true,
                Dock = DockStyle.Top,
                WrapContents = false,
                Margin = new Padding(0)
            };
            wrapper.Controls.Add(bubble);

            flowlayoutchat.Controls.Add(wrapper);
            flowlayoutchat.ScrollControlIntoView(wrapper);
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }


        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadFAQCategories();
        }
        private void LoadFAQCategories()
        {
            slctQuestionCategory.Items.Clear();
            List<string> categories = DatabaseHelper.GetFAQCategories();

            foreach (string category in categories)
            {
                slctQuestionCategory.Items.Add(category);
            }
        }

        private void btnMedicine_Click_1(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is MedecinePage)
            {
                return;
            }

            MedecinePage newForm = new MedecinePage();
            newForm.Show();

            if (currentForm != null)
            {
                currentForm.Hide(); // Use Hide instead of Close so the application loop stays alive
            }
        }

        private void btnDailyNeeds_Click_1(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is DailyNeedsPage)
            {
                return;
            }

            DailyNeedsPage newForm = new DailyNeedsPage();
            newForm.Show();

            if (currentForm != null)
            {
                currentForm.Hide(); // Use Hide instead of Close so the application loop stays alive
            }
        }

        private void btnCall_Click_1(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                pictureBox4.Visible = true;
                label6.Visible = true;
                btnCall.Icon = Image.FromFile(@"C:\Users\User\source\repos\OMC_G10_Final\Images\back.png");

            }
            else
            {
                panel2.Visible = true;
                pictureBox4.Visible = false;
                label6.Visible = false;
                btnCall.Icon = Image.FromFile(@"C:\Users\User\source\repos\OMC_G10_Final\Images\telephone-call.png");

            }

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (panelchat.Visible == false)
            {
                panelchat.Visible = true;    // show the chat UI
                btnMessage.Icon = Image.FromFile(@"C:\Users\User\source\repos\OMC_G10_Final\Images\back.png");

            }
            else
            {
                panelchat.Visible = false;
                btnMessage.Icon = Image.FromFile(@"C:\Users\User\source\repos\OMC_G10_Final\Images\bubble-chat.png");


            }

            // Optional: greet the user when chat opens, only once
            if (flowlayoutchat.Controls.Count == 0)
            {
                AddMessage("Hi! How can I help you today?", isUser: false);
            }
        }

        private void slctQuestionCategory_SelectedIndexChanged(object sender, AntdUI.IntEventArgs e)
        {
            if (slctQuestionCategory.SelectedIndex < 0 || slctQuestionCategory.SelectedIndex >= slctQuestionCategory.Items.Count)
                return;

            // Get the actual selected TEXT, not the index number
            string selectedCategory = slctQuestionCategory.Items[slctQuestionCategory.SelectedIndex].ToString();

            dpdChoooseQuestion.Items.Clear();
            List<string> questions = DatabaseHelper.GetQuestionsByCategory(selectedCategory);

            foreach (string question in questions)
            {
                dpdChoooseQuestion.Items.Add(question);
            }

            dpdChoooseQuestion.Enabled = questions.Count > 0;
        }

        private void dpdChoooseQuestion_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            if (dpdChoooseQuestion.SelectedValue == null) return;

            string selectedQuestion = dpdChoooseQuestion.SelectedValue.ToString();

            AddMessage(selectedQuestion, isUser: true);

            string answer = DatabaseHelper.GetAnswerForQuestion(selectedQuestion);

            Timer replyDelay = new Timer { Interval = 600 };
            replyDelay.Tick += (s, args) =>
            {
                AddMessage(answer, isUser: false);
                replyDelay.Stop();
                replyDelay.Dispose();
            };
            replyDelay.Start();

            dpdChoooseQuestion.SelectedValue = null; // reset so the same question can be picked again later
        }

        private void radmobility_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            if (e.Value)
            {
                Session.AccessibilityFilter = "Mobility";
            }
            else if (Session.AccessibilityFilter == "Mobility")
            {
                Session.AccessibilityFilter = null;
            }
        }

        private void radhearing_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            if (e.Value)
            {
                Session.AccessibilityFilter = "Hearing";
            }
            else if (Session.AccessibilityFilter == "Hearing")
            {
                Session.AccessibilityFilter = null;
            }
        }
    }
}
using OMC_G10_Final.Properties;
using static AntdUI.Table;
using Timer = System.Windows.Forms.Timer;

namespace OMC_G10_Final
{

    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {

        }

        private void btnDailyNeeds_Click(object sender, EventArgs e)
        {

        }

        private void btnCall_Click(object sender, EventArgs e)
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

                txtchatinput.Focus();
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
            Label bubble = new Label
            {
                Text = text,
                AutoSize = true,
                MaximumSize = new Size(250, 0),
                Padding = new Padding(10),
                BackColor = isUser ? Color.FromArgb(230, 200, 210) : Color.FromArgb(220, 220, 220),
                Font = new Font("Segoe UI", 10),
                Margin = new Padding(5)
            };

            // Align right for user, left for bot
            FlowLayoutPanel wrapper = new FlowLayoutPanel
            {
                FlowDirection = isUser ? FlowDirection.RightToLeft : FlowDirection.LeftToRight,
                AutoSize = true,
                Dock = DockStyle.Top,
                WrapContents = false
            };
            wrapper.Controls.Add(bubble);

            flowlayoutchat.Controls.Add(wrapper); // flowLayoutChat = your scrollable FlowLayoutPanel
            flowlayoutchat.ScrollControlIntoView(wrapper); // auto-scroll to newest message
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string userText = txtchatinput.Text.Trim();
            if (string.IsNullOrEmpty(userText)) return;

            AddMessage(userText, isUser: true);
            txtchatinput.Clear();

            string reply = GetAutoReply(userText);

            // Optional: small delay to feel more natural
            Timer replyDelay = new Timer { Interval = 600 };
            replyDelay.Tick += (s, args) =>
            {
                AddMessage(reply, isUser: false);
                replyDelay.Stop();
                replyDelay.Dispose();
            };
            replyDelay.Start();
        }
        private string GetAutoReply(string input)
        {
            string msg = input.ToLower();

            if (msg.Contains("hello") || msg.Contains("hi"))
                return "Hi there! How can I help you today?";

            if (msg.Contains("medicine") || msg.Contains("medication"))
                return "You can check your medicine schedule under the Medicine tab.";

            if (msg.Contains("daily needs"))
                return "Head to the Daily Needs section to view your list.";

            if (msg.Contains("help"))
                return "I can help with Mobility, Hearing, Medicine, or Daily Needs. What do you need?";

            if (msg.Contains("thank"))
                return "You're welcome! Let me know if there's anything else.";

            return "Sorry, I didn't quite understand that. Could you rephrase?";
        }

        private void txtchatinput_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops the "ding" sound / newline
                btnsend_Click(sender, e);
            }
        }

        private void btnMessage_Click_1(object sender, EventArgs e)
        {
            if (panelchat.Visible == false)
            {
                panelchat.Visible = true;    // show the chat UI
                btnMessage.Icon = Image.FromFile(@"C:\Users\User\source\repos\OMC_G10_Final\Images\back.png");



                txtchatinput.Focus();
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

        private void lstQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstQuestion.SelectedItem != null)
            {
                string soalanDipilih = lstQuestion.SelectedItem.ToString();

                AddMessage(soalanDipilih, isUser: true);
                string reply = GetAutoReply(soalanDipilih);

                Timer replyDelay = new Timer { Interval = 600 };
                replyDelay.Tick += (s, args) =>
                {
                    AddMessage(reply, isUser: false);
                    replyDelay.Stop();
                    replyDelay.Dispose();
                };
                replyDelay.Start();

                lstQuestion.SelectedIndex = -1;
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            lstQuestion.Items.Add("I need help with my medicine");
            lstQuestion.Items.Add("Where is the daily needs list?");
            lstQuestion.Items.Add("What can you help me with?");
            lstQuestion.Items.Add("Hello! Hi");
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
    }
}

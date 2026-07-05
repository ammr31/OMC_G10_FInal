namespace OMC_G10_Final
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPageMobility_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is MobilityPage)
            {
                return;
            }
            // Open the Mobility Form
            MobilityPage newForm = new MobilityPage();
            newForm.Show();

            // Hide the current MainPage so it doesn't stay visible behind it
            this.Hide();
        }

        private void btnPageHearing_Click(object sender, EventArgs e)
        {
            Form? currentForm = this.FindForm();

            if (currentForm is HearingPage)
            {
                return;
            }
            // Open the Hearing Form (Assuming your form class is named HearingForm)
            HearingPage newForm = new HearingPage();
            newForm.Show();

            // Hide the current MainPage
            this.Hide();
        }
    }
}

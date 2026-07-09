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

        private void btnDailyNeeds_Click(object sender, EventArgs e)
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

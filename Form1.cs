using TSPP_ShoesSolution.source.view;

namespace TSPP_ShoesSolution
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Privet!");
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            //TODO return User
        }

        private void OurTeam_Click(object sender, EventArgs e)
        {
            OurTeamForm ourTeamForm = new OurTeamForm();
            ourTeamForm.Show();
        }
    }
}
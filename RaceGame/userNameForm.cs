
namespace Race
{
    public partial class userNameForm : Form
    {
        User user;
        public userNameForm(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                enterNameLabel.Text = "Need to enter a name!";
                enterNameLabel.Left = 0;
                return;
            }

            user.Name = nameTextBox.Text;
            Close();
        }
    }
}

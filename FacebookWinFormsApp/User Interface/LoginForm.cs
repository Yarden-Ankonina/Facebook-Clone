using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.User_Interface
{
    public partial class LoginForm : Form
    {
        private User LoggedInUser { get; set; }

        private LoginResult LoginResult { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;

            if (ApplicationSettings.Instance.RememberUser &&
                !string.IsNullOrEmpty(ApplicationSettings.Instance.AccessToken))
            {
                LoginResult = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);
            }
        }

        public bool IsLoggedIn
        {
            get
            {
                return ApplicationSettings.Instance.AutoLogin;
            }
        }

        private void buttonLogin_Click(object i_Sender, EventArgs e)
        {
            try
            {
                login();
                createMainForm();
            }
            catch
            {
                MessageBox.Show("Please Try Again", "Login Failed");
            }
        }

        private void createMainForm()
        {
            ApplicationSettings.Instance.AutoLogin = checkBox_RememberUser.Checked;
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.ShowDialog();
            this.Close();
        }

        private void login()
        {
            const string k_AppId = " 799553048113660";

            Clipboard.SetText("password");
            LoginResult = FacebookService.Login(
            k_AppId,
            "email",
            "public_profile",
            "user_gender",
            "user_age_range",
            "user_friends",
            "user_location",
            "user_likes",
            "user_photos",
            "user_posts",
            "user_birthday");

            checkLogin();
            buttonLogin.Text = $"Logged in as {LoginResult.LoggedInUser.Name}";

            if(!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;
                ApplicationSettings.Instance.AccessToken = LoginResult.AccessToken;
            }
        }

        private void checkLogin()
        {
            if(LoginResult.LoggedInUser == null)
            {
                throw new Exception();
            }
        }
    }
}
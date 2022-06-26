using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.CachingProxy;
using BasicFacebookFeatures.Strategy;
using FacebookWrapper;
using BasicFacebookFeatures.Iterator;
using BasicFacebookFeatures.Observer;
using Timer = System.Windows.Forms.Timer;

namespace BasicFacebookFeatures.User_Interface
{
    public partial class FormMain : Form
    {
        private List<Tuple<string, string, bool>> m_IntroList = new List<Tuple<string, string, bool>>();

        private User LoggedInUser { get; set; }

        private bool IsFormLoaded { get; set; } = false;

        private FormIntro m_FormIntro;
        private FacebookPosts m_FacebookPosts;
        private PetForm m_PetForm = null;

        private Timer m_MainTimer;

        private AlarmForm Alarm { get; set; }

        private bool IsUpdateLike { get; set; } = false;

        private IFetch FetchCachingProxy { get; set; }

        private FacebookObjectCollection<Page> m_PagesList;

        private List<Photo> m_PhotoList;

        private ISortStrategy<List<Photo>> m_PhotoStrategy;

        private ISortStrategy<List<Page>> m_PageStrategy;

        private IPostIterator m_PostIterator;

        private bool m_NotificationOpen = false;

        private ListBox m_NotificationsListBox = new ListBox();
       
        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 20;
            initializeMainForm();
        }

        private void initializeMainForm()
        {
            this.Size = new Size(1160, 750);
            this.MaximumSize = new Size(1160, 750);
            this.MinimumSize = new Size(1160, 750);
            m_MainTimer = new Timer();
            m_MainTimer.Interval = 1000;
            m_MainTimer.Tick += new EventHandler(mainTimer_OnClick);
            m_MainTimer.Start();
            m_PetForm = new PetForm();
            Alarm = new AlarmForm();
            notificationsInitialize();
        }

        private void notificationsInitialize()
        {
            NotificationsObserver notification = new NotificationsObserver(m_PetForm, Alarm);
            m_NotificationsListBox = notification.CreateNotificationsListBox(ref buttonNotification);
            pictureBoxCover.Controls.Add(m_NotificationsListBox);
        }

        private void mainTimer_OnClick(object i_Sender, EventArgs i_E)
        {
            if (Alarm != null)
            {
                if (Alarm.WaitToTriggerAlarm)
                {
                   Alarm.Bell();
                   string msg = "Your Using The App For " + Alarm.Time + "Please Take a Break";
                   MessageBox.Show(msg);
                   Alarm.Notify(msg);
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            this.Location = ApplicationSettings.Instance.LastWindowLocation;
            labelMyPet.Text = $"{ApplicationSettings.Instance.PetData.PetName}'s House";
            buttonPet.LoadAsync(ApplicationSettings.Instance.PetData.PetImageUrl);
            m_PetForm.SetPetFoodUrl(ApplicationSettings.Instance.PetData.PetFoodUrl);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            ApplicationSettings.Instance.LastWindowLocation = this.Location;
            ApplicationSettings.Instance.PetData.PetImageUrl = buttonPet.ImageLocation;
            ApplicationSettings.Instance.PetData.PetFoodUrl = m_PetForm.GetPetFoodUrl();
            ApplicationSettings.Instance.SaveToFile();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            try
            {
                if(ApplicationSettings.Instance.AutoLogin)
                {
                    LoginResult result = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);

                    if (string.IsNullOrEmpty(result.ErrorMessage))
                    {
                        LoggedInUser = result.LoggedInUser;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error With Access Token Please Re-Open The App", "Connection Failed");
                ApplicationSettings.ToDefaultSettings();
                ApplicationSettings.Instance.SaveToFile();
                this.Close();
            }

            fetchFormDetails();
        }

        private void fetchFormDetails()
        {
            try
            {
                new Thread(fetchFormLogos).Start();
                new Thread(fetchUserProfilePhoto).Start();
                new Thread(fetchFriendsLabel).Start();
                new Thread(fetchLabelUserName).Start();
                new Thread(fetchUserIntro).Start();
                new Thread(fetchCachingProxy).Start();
            }
            catch
            {
                MessageBox.Show("Sorry We Had An Issue To Fetch Your Data", "Error");
            }
        }

        private void fetchCachingProxy()
        {
            FetchCachingProxy = new FetchCachingProxy(LoggedInUser);
            waitUntilInvokeRequired();
            buttonLikedPages.Invoke(new Action(() => buttonLikedPages.Enabled = true));
            button_Posts.Invoke(new Action(() => button_Posts.Enabled = true));
            button_Photos.Invoke(new Action(() => button_Photos.Enabled = true));
            buttonFriends.Invoke(new Action(() => buttonFriends.Enabled = true));
            buttonFetchAllData.Invoke(new Action(() => buttonFetchAllData.Enabled = true));
        }

        /// We Dont want to Invoke before the control Window handle was created, ThereFor we check it before we Invoke the buttons
        private void waitUntilInvokeRequired()
        {
            bool isInvokeRequiredYet = buttonLikedPages.InvokeRequired;

            while (!isInvokeRequiredYet)
            {
                isInvokeRequiredYet = buttonLikedPages.InvokeRequired;
                if (isInvokeRequiredYet == false)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        private void initIntroCategoriesList()
        {
            m_IntroList.Add(new Tuple<string, string, bool>("Hometown: ", string.Empty, false));
            m_IntroList.Add(new Tuple<string, string, bool>("Study: ", string.Empty, false));
            m_IntroList.Add(new Tuple<string, string, bool>("Interested In: ", string.Empty, false));
            m_IntroList.Add(new Tuple<string, string, bool>("Quote: ", string.Empty, false));
            m_IntroList.Add(new Tuple<string, string, bool>("Religion: ", string.Empty, false));
        }

        private void fetchUserIntro()
        {
            try
            {
                m_IntroList.Add(new Tuple<string, string, bool>("Gender: ", this.LoggedInUser.Gender.ToString(), true));
                m_IntroList.Add(new Tuple<string, string, bool>("Email: ", this.LoggedInUser.Email.ToString(), true));
                m_IntroList.Add(
                    new Tuple<string, string, bool>("Birthday: ", this.LoggedInUser.Birthday.ToString(), true));
            }
            catch(Exception)
            {
                MessageBox.Show("Can Not Load All Data.");
            }

            initIntroCategoriesList();
            displayIntroToForm();
        }

        private void displayIntroToForm()
        {
            listBoxIntro.Invoke(new Action(() => listBoxIntro.Items.Clear()));

            foreach(Tuple<string, string, bool> introData in m_IntroList)
            {
                bool isContentNotEmpty = introData.Item2 != string.Empty;

                if(isContentNotEmpty && introData.Item3)
                {
                    listBoxIntro.Invoke(new Action(() => listBoxIntro.Items.Add($"{introData.Item1}{introData.Item2}")));
                }
            }

            listBoxIntro.Invoke(new Action(() => listBoxIntro.AutoSize = true));
        }

        private void fetchFriendsLabel()
        {
            labelFriendsCount.Invoke(new Action(() => labelFriendsCount.Text = LoggedInUser.Friends.Count.ToString() + " Friends"));
        }

        private void fetchLabelUserName()
        {
            labelUserName.Invoke(new Action(() => labelUserName.Text = LoggedInUser.Name));
        }

        private void fetchFormLogos()
        {
            facebookIcon.LoadAsync("https://www.facebook.com/images/fb_icon_325x325.png");
            facebookIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonLogout.LoadAsync("https://img.icons8.com/officel/452/shutdown.png");
            buttonLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonLogout.BackColor = Color.AliceBlue;
            buttonPet.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonNextPost.LoadAsync("https://img.icons8.com/flat-round/452/circled-chevron-right.png");
            buttonNextPost.SizeMode = PictureBoxSizeMode.Zoom;
            buttonPrevPost.LoadAsync("https://img.icons8.com/flat-round/452/back--v1.png");
            buttonPrevPost.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTimer.LoadAsync("https://img.icons8.com/external-flaticons-lineal-color-flat-icons/344/external-time-gig-economy-flaticons-lineal-color-flat-icons-2.png");
            pictureBoxTimer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDeleteNotifications.LoadAsync("https://img.icons8.com/plasticine/344/trash--v1.png");
            pictureBoxDeleteNotifications.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void fetchUserProfilePhoto()
        {
            pictureBoxProfile.LoadAsync(LoggedInUser.PictureNormalURL);
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            fetchFriends();
        }

        private void Posts_Click(object sender, EventArgs e)
        {
            posts_Handler();
        }

        private void posts_Handler()
        {
            try
            {
                m_FacebookPosts = FetchCachingProxy.Posts;
            }
            catch
            {
                MessageBox.Show("Cant Fetch Posts", " Error");
            }

            ///We are removing unwanted posts
            m_FacebookPosts.RemoveDuplicates();
            m_PostIterator = (IPostIterator)m_FacebookPosts.GetEnumerator();
            createPost();
            buttonNextPost.Enabled = true;
            buttonPrevPost.Enabled = true;
        }

        private void createPost()
        {
            if(m_PostIterator.Current != null)
            {
                postAdapterWinFormsBindingSource.DataSource = m_PostIterator.Current;
            }
            else
            {
                MessageBox.Show("There Are No More Posts", "Error");
            }
        }

        private void fetchFriends()
        {
            try
            {
                this.listBoxFriends.Items.Clear();
                FacebookObjectCollection<User> friendsList = FetchCachingProxy.Friends;

                if(friendsList.Count == 0)
                {
                    MessageBox.Show("No Friends to retrieve :(");
                }
                else
                {
                    foreach(User friend in friendsList)
                    {
                        this.listBoxFriends.Items.Add(friend);
                    }
                }

                this.listBoxFriends.AutoSize = true;
            }
            catch
            {
                MessageBox.Show("An error occurred while fetching user's friends.");
            }
        }

        private void formMainSizeChanged(object sender, EventArgs e)
        {
            if(IsFormLoaded)
            {
                pictureBoxCover.Width = Screen.PrimaryScreen.WorkingArea.Width + 10;
                backgroundLower.Width = Screen.PrimaryScreen.WorkingArea.Width + 10;
                backgroundLower.Height = Screen.PrimaryScreen.WorkingArea.Height + 10;
                buttonLogout.Location = new Point(this.Width - 80, buttonLogout.Location.Y);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            IsFormLoaded = true;
        }

        private void logoutLogo_Click(object sender, EventArgs e)
        {
            DialogResult isLogoutResult = MessageBox.Show(
                "Are You Sure You Want To Logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(isLogoutResult == DialogResult.Yes)
            {
                ApplicationSettings.ToDefaultSettings();
                MessageBox.Show("Thank You For Using Our App", " YOU LOGGED OUT");
                this.Close();
            }
        }

        private void buttonAddBio_Click(object sender, EventArgs e)
        {
            m_FormIntro = new FormIntro();

            m_FormIntro.InitIntroForm(m_IntroList);
            m_FormIntro.ListToIntro = m_IntroList;
            m_FormIntro.ShowDialog();
            m_IntroList = m_FormIntro.ListToIntro;
            displayIntroToForm();
        }

        private void button_Photos_Click(object sender, EventArgs e)
        {
            new Thread(initializePictureBoxPanel).Start();
        }

        private void buttonNextPost_Click(object sender, EventArgs e)
        {
            try
            {
                m_PostIterator.MoveNext();
                createPost();
            }
            catch(Exception)
            {
                MessageBox.Show("No Posts Were Loaded", "Error");
            }
        }

        private void buttonPrevPost_Click(object sender, EventArgs e)
        {
            try
            {
                if(m_PostIterator.MovePrev())
                {
                    createPost();
                }
                else
                {
                    MessageBox.Show("No Previous Posts", "Error");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No Posts Were Loaded", "Error");
            }
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            m_PetForm.ShowDialog();

            if(m_PetForm.PetImage != null && m_PetForm.DialogResult == DialogResult.OK)
            {
                buttonPet.Image = m_PetForm.PetImage;
                buttonPet.ImageLocation = m_PetForm.PetUrl;
            }

            if (m_PetForm.PetNameChanged)
            {
                labelMyPet.Text = $"{m_PetForm.PetName}'s House";
            }
        }

        private void buttonPostLike_Click(object sender, EventArgs e)
        {
            if(!IsUpdateLike)
            {
                try
                {
                    int likes = int.Parse(labelPostiLkesAmount.Text);
                    labelPostiLkesAmount.Text = (++likes).ToString();
                    IsUpdateLike = true;
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    int likes = int.Parse(labelPostiLkesAmount.Text);
                    labelPostiLkesAmount.Text = (--likes).ToString();
                    IsUpdateLike = false;
                }
                catch
                {
                }
            }
        }

        private void buttonFetchAllData_Click(object sender, EventArgs e)
        {
            new Thread(initializePictureBoxPanel).Start();
            posts_Handler();
            fetchFriends();
            fetchLikedPages();
        }

        private void pictureBoxTimer_Click(object sender, EventArgs e)
        {
            Alarm.ShowDialog();
        }

        private void fetchLikedPages()
        {
            try
            {
                m_PagesList = FetchCachingProxy.LikedPages;
                setLikedPagesListBox(m_PagesList.ToList());
                sortAscendingButton.Enabled = true;
                sortDescendingButton.Enabled = true;
            }
            catch
            {
                MessageBox.Show("An error occurred while fetching user's liked pages.");
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            fetchLikedPages();
        }

        private void linkLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLinkLabel.Text);
        }

        private void sortAscendingButton_Click(object sender, EventArgs e)
        {
            m_PageStrategy = new AlphabeticalAscendingStrategy(); 
            List<Page> sortedList = m_PageStrategy.Sort(m_PagesList.ToList());

            setLikedPagesListBox(sortedList);
        }

        private void setLikedPagesListBox(List<Page> i_ListToDisplay)
        {
            listBoxLikedPages.Items.Clear();

            if (i_ListToDisplay.Count == 0)
            {
                MessageBox.Show("No Liked Pages to retrieve :(");
            }
            else
            {
                foreach (Page page in i_ListToDisplay)
                {
                    listBoxLikedPages.Items.Add(page.Name);
                }
            }
        }

        private void sortPictureAscending_Click(object sender, EventArgs e)
        {
            m_PhotoStrategy = new PhotoAscendingStrategy();
            List<Photo> sortedList = m_PhotoStrategy.Sort(m_PhotoList);

            setPictureBox(sortedList);
        }

        private void setPictureBox(List<Photo> i_PhotosToDisplay)
        {
            int counterColumn = 0;
            Point panelLocation = new Point(10, 10);
            
            panelPictureBox.Invoke(new Action(() => panelPictureBox.Controls.Clear()));

            foreach (Photo photo in i_PhotosToDisplay)
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(90, 90);
                pic.Location = panelLocation;

                pic.Load(photo.PictureAlbumURL);

                pic.SizeMode = PictureBoxSizeMode.Zoom;
                panelPictureBox.Invoke(new Action(() => panelPictureBox.Controls.Add(pic)));
                panelLocation.X += pic.Width + 20;
                counterColumn++;

                if (counterColumn == 3)
                {
                    panelLocation.X = 10;
                    panelLocation.Y += pic.Height + 20;
                    counterColumn = 0;
                }
            }

            panelPictureBox.Invoke(new Action(() =>  panelPictureBox.AutoScroll = true));
        }
            
        private void sortDescendingButton_Click(object sender, EventArgs e)
        {
            m_PageStrategy = new AlphabeticalDescendingStrategy();
            List<Page> sortedList = m_PageStrategy.Sort(m_PagesList.ToList());

            setLikedPagesListBox(sortedList);
        }

        private void sortPictureDescending_Click(object sender, EventArgs e)
        {
            m_PhotoStrategy = new PhotoDescendingStrategy();
            List<Photo> sortedList = m_PhotoStrategy.Sort(m_PhotoList);

            setPictureBox(sortedList);
        }

        private void initializePictureBoxPanel()
        {
            FacebookObjectCollection<Photo> photoList = FetchCachingProxy.PhotosTaggedIn;
            int photoListLimit = photoList.Count < 15 ? photoList.Count : 15;

            if(m_PhotoList != null)
            {
                m_PhotoList.Clear();
            }

            m_PhotoList = photoList.ToList().GetRange(0, photoListLimit);

            setPictureBox(m_PhotoList);
            sortPictureAscending.Invoke(new Action(() => sortPictureAscending.Enabled = true));
            sortPictureDescending.Invoke(new Action(() => sortPictureDescending.Enabled = true));
        }

        private void buttonNotification_Click(object sender, EventArgs e)
        {
            if(m_NotificationOpen)
            {
                m_NotificationsListBox.Visible = false;
                m_NotificationOpen = false;
            }
            else
            {
                m_NotificationsListBox.Visible = true;
                m_NotificationOpen = true;
            }
        }

        private void pictureBoxDeleteNotifications_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are You Sure You Want To Delete All Selected Notifications?", "Delete", MessageBoxButtons.YesNo))
            {
                m_NotificationsListBox.Items.Clear();
            }
        }
    }
}

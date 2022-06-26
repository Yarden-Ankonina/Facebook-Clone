using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic;
using BasicFacebookFeatures.Observer;
using Timer = System.Windows.Forms.Timer;

namespace BasicFacebookFeatures.User_Interface
{
    public partial class PetForm : Form, INotifier
    {
        private Timer ProgressBarTimer { get; }

        private int ProgressBarValue { get; set; } = 80;

        private bool PetFed { get; set; } = false;

        private ChoosePetForm ChoosePetForm { get; set; } = new ChoosePetForm();

        public Image PetImage { get; private set; }

        public string PetUrl { get; set; }

        public string PetName { get; private set; }

        public bool PetNameChanged { get; set; } = false;

        private bool FirstLoad { get; set; } = true;

        private bool m_MessageOn = false;

        public PetForm()
        {
            InitializeComponent();
            ProgressBarTimer = new Timer();

            if(string.IsNullOrEmpty(PetName))
            {
              PetName = ApplicationSettings.Instance.PetData.PetName;
            }

            initialPetForm();
        }

        public event Action<string> ReportObserverDelegate;

        private void initialPetForm()
        {
            progressBarHappiness.Value = ProgressBarValue;
            labelPetHapinessBar.Text = $"Happiness: {ProgressBarValue.ToString()}";
            ProgressBarTimer.Interval = 20000;
            ProgressBarTimer.Tick += new EventHandler(progressBarTime);
            ProgressBarTimer.Start();
        }

        private void progressBarTime(object i_Sender, EventArgs i_E)
        {
            if (ProgressBarValue >= 2)
            {
                ProgressBarValue -= 1;
                progressBarHappiness.Value = ProgressBarValue;
            }
            else
            {
                ProgressBarValue = 0;

                if (m_MessageOn == false)
                {
                    m_MessageOn = true;
                    if(MessageBox.Show($"{PetName} Is Starving, Please Feed Him", "Pet Help")== DialogResult.OK)
                    {
                        m_MessageOn = false;
                    }
                    if (ReportObserverDelegate != null)
                    {
                        Notify($"{PetName} Is Starving, Please Feed Him");
                    }
                }
            }

            labelPetHapinessBar.Text = $"Happiness: {ProgressBarValue.ToString()}";

            if (PetFed)
            {
                PetFed = false;
                if(ChoosePetForm.AnimalType == null)
                {
                    pictureBoxFeed.LoadAsync(ApplicationSettings.Instance.PetData.PetFoodUrl);
                }
                else
                {
                    pictureBoxFeed.LoadAsync(ChoosePetForm.AnimalType.GetFoodByAnimalType(ChoosePetForm.AnimalType.AnimalCategory));
                }
            }

            if (ProgressBarValue <= 50 && m_MessageOn == false)
            {
                m_MessageOn = true;
                if (MessageBox.Show($"{PetName} Is Hungry", "Pet Help") == DialogResult.OK)
                {
                    m_MessageOn = false;
                }
                if (ReportObserverDelegate != null)
                {
                    Notify($"{PetName} Is Hungry");
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            pictureBoxPetProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFeed.SizeMode = PictureBoxSizeMode.Zoom;
            PetNameChanged = false;

            if (FirstLoad)
            {
                pictureBoxPetProfile.LoadAsync(ApplicationSettings.Instance.PetData.PetImageUrl);
                FirstLoad = false;
            }

            if (pictureBoxPetProfile != null)
            {
                buttonChoosePet.Hide();
            }

            PetName = ApplicationSettings.Instance.PetData.PetName;
            labelPetUserName.Text = $"{PetName}'s House";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ApplicationSettings.Instance.PetData.PetName = PetName;
        }

        private void buttonPetOk_Click(object i_Sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            if (ChoosePetForm != null)
            {
                PetImage = ChoosePetForm.Pet;
            }

            this.Close();
        }

        private void buttonPetCancel_Click(object i_Sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            buttonChoosePet.Hide();
            this.Close();
        }

        private void labelPetUserName_Click(object i_Sender, EventArgs e)
        {
            TextInputForm textInputForm = new TextInputForm();
            textInputForm.ShowDialog();

            if (textInputForm.DialogResult == DialogResult.OK)
            {
                labelPetUserName.Text = $"{textInputForm.TextInput}'s House";
                PetName = textInputForm.TextInput;
                PetNameChanged = true;
            }
        }

        private void buttonChoosePet_Click(object i_Sender, EventArgs e)
        {
            choosePet_Click();
        }

        private void pictureBoxPetProfile_Click(object i_Sender, EventArgs e)
        {
            choosePet_Click();
        }

        private void choosePet_Click()
        {
            ChoosePetForm.ShowDialog();
            
            if(ChoosePetForm.DialogResult == DialogResult.OK)
            {
                pictureBoxPetProfile.Image = ChoosePetForm.Pet;
                pictureBoxFeed.LoadAsync(ChoosePetForm.FoodUrl);
                PetUrl = ChoosePetForm.ImageUrl;
                buttonChoosePet.Hide();
            }
            else
            {
                buttonChoosePet.Show();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if(this.DialogResult != DialogResult.OK)
            {
                if(ChoosePetForm != null)
                {
                    pictureBoxPetProfile.Image = PetImage;
                }
            }
        }

        private void pictureBoxFeed_Click(object i_Sender, EventArgs e)
        {
            if(ProgressBarValue >= 95)
            {
                ProgressBarValue = 100;
                PetFed = true;
                pictureBoxFeed.LoadAsync("https://img.icons8.com/external-wanicon-flat-wanicon/344/external-fireworks-diwali-wanicon-flat-wanicon.png");
            }
            else
            {
                ProgressBarValue += 2;
            }

            progressBarHappiness.Value = ProgressBarValue;
            labelPetHapinessBar.Text = $"Happiness: {progressBarHappiness.Value.ToString()}";
        }

        public string GetPetFoodUrl()
        {
            return pictureBoxFeed.ImageLocation;
        }

        public void SetPetFoodUrl(string i_FoddUrl)
        {
            pictureBoxFeed.LoadAsync(i_FoddUrl);
        }

        public void Notify(string i_Message)
        {
            if (ReportObserverDelegate != null)
            {
                ReportObserverDelegate.Invoke(i_Message);
            }
        }
    }
}

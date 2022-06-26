using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BasicFacebookFeatures.Logic
{
    public class ApplicationSettings
    {
        private static readonly string sr_FileName;
        private static ApplicationSettings s_This;

        public static ApplicationSettings Instance
        {
            get
            {
                if (s_This == null)
                {
                    s_This = ApplicationSettings.fromFileOrDefault();
                }

                return s_This;
            }
        }

        public bool RememberUser { get; set; }

        public string AccessToken { get; set; }

        public bool AutoLogin { get; set; }

        public Point LastWindowLocation { get; set; }

        public PetLogic PetData { get; set; }

        public static void ToDefaultSettings()
        {
            ApplicationSettings.Instance.AutoLogin = false;
            ApplicationSettings.Instance.AccessToken = null;
            ApplicationSettings.Instance.LastWindowLocation = new Point(
                Screen.PrimaryScreen.WorkingArea.X / 2,
                Screen.PrimaryScreen.WorkingArea.Y / 2);
            ApplicationSettings.Instance.PetData = new PetLogic();
        }

        static ApplicationSettings()
        {
            sr_FileName = Application.ExecutablePath + ".setting.xml";
        }

        private ApplicationSettings()
        {
        }

        public void SaveToFile()
        {
            using(FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());

                serializer.Serialize(stream, this);
            }
        }

        private static ApplicationSettings fromFileOrDefault()
        {
            ApplicationSettings loadedThis = null;

            if(File.Exists(sr_FileName))
            {
                using(FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    loadedThis = (ApplicationSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                loadedThis = new ApplicationSettings()
                {
                    AccessToken = null,
                    AutoLogin = false,
                    LastWindowLocation = new Point(
                        Screen.PrimaryScreen.WorkingArea.X / 2,
                        Screen.PrimaryScreen.WorkingArea.Y / 2),
                    PetData = new PetLogic(),
                };
            }

            return loadedThis;
        }
    }
}

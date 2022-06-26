using System.Windows.Forms;
using BasicFacebookFeatures.User_Interface;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public static class RunApp
    {
        public static void RunApplication()
        {
            UserInterfaceHandler userInterfaceHandler = new UserInterfaceHandler();
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(UserInterfaceHandler.StartingForm);
        }
    }
}

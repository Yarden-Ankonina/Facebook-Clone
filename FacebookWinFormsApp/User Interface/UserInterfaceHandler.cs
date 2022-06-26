using System.Windows.Forms;

namespace BasicFacebookFeatures.User_Interface
{
    public class UserInterfaceHandler
    {
        public static Form StartingForm
        {
            get
            {
                Form startingForm = new LoginForm();

                if(((LoginForm)startingForm).IsLoggedIn)
                {
                    startingForm = new FormMain();
                }

                return startingForm;
            }
        }
    }
}

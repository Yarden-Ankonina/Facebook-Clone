using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.User_Interface;

namespace BasicFacebookFeatures.Observer
{
    public class NotificationsObserver
    {
        private readonly List<INotifier> r_Notifiers = new List<INotifier>();
        private readonly ListBox r_NotificationsListBox = new ListBox();

        public NotificationsObserver(PetForm i_PetForm, AlarmForm i_AlarmForm)
        {
            r_Notifiers.Add((INotifier)i_PetForm);
            r_Notifiers.Add((INotifier)i_AlarmForm);

            foreach (INotifier item in r_Notifiers)
            {
                item.ReportObserverDelegate += this.addNotificationToListBox;
            }
        }

        private void addNotificationToListBox(string i_Message)
        {
            r_NotificationsListBox.Items.Add(i_Message);
        }

        public ListBox CreateNotificationsListBox(ref Button i_ButtonNotification)
        {
            r_NotificationsListBox.Location = new Point(i_ButtonNotification.Location.X - (i_ButtonNotification.Width / 4),
                i_ButtonNotification.Location.Y + i_ButtonNotification.Height + 23);
            r_NotificationsListBox.BackColor = Color.LightBlue;
            r_NotificationsListBox.Size = new Size(200, 100);
            r_NotificationsListBox.Visible = false;
            r_NotificationsListBox.HorizontalScrollbar = true;

            return r_NotificationsListBox;
        }
    }
}

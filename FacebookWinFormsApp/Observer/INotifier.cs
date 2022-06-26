using System;

namespace BasicFacebookFeatures.Observer
{
    public interface INotifier
    {
        event Action<string> ReportObserverDelegate;

       void Notify(string i_Message);
    }
}

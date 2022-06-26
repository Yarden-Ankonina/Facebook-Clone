using System.Windows.Forms;

namespace BasicFacebookFeatures.Adapters
{
    internal interface IPostWinForms
    {
        PictureBox PostImage { get; set; }

        string[] DescreptionList { get; set; }
    }
}
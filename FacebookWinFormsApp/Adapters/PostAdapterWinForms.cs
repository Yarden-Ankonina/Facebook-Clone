using System.Windows.Forms;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Adapters
{
    public class PostAdapterWinForms : PostAdapter, IPostWinForms
    {
        public PictureBox PostImage { get; set; } = new PictureBox();

        public string[] DescreptionList { get; set; } 

        public PostAdapterWinForms(Post i_Post) : base(i_Post)
        {
            if (base.PostImageAddress != null)
            {
                PostImage.Load(i_Post.PictureURL);
                DescreptionList = createSubStrings(i_Post.Description);
            }
        }

        private string[] createSubStrings(string i_String)
        {
            string msg = i_String;
            List<string> stringList = new List<string>();

            while (!string.IsNullOrEmpty(msg))
            {
                if (msg.Length <= 40)
                {
                    stringList.Add(msg);
                    msg = null;
                }
                else
                {
                    stringList.Add(msg.Substring(0, 40));
                    msg = msg.Substring(40);
                }
            }

            return stringList.ToArray();
        }
    }
}

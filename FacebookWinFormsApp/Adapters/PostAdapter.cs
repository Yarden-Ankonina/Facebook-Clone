using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Adapters
{
    public class PostAdapter : IPost
    {
        public Post PostAdoptee { get; set; }

        public string PostImageAddress { get; set; }

        public string UserName { get; set; }

        public DateTime? UpdateTime { get; set; }

        public string Descreption { get; set; }

        public int LikeCount { get; set; } = 0;

        public string PostType { get; set; }

        public string Link { get; set; }

        private Random m_Random = new Random();

        public PostAdapter(Post i_Post)
        {
            PostAdoptee = i_Post;
            PostImageAddress = i_Post.PictureURL;
            UserName = i_Post.Name;
            UpdateTime = i_Post.UpdateTime;
            Descreption = i_Post.Description;
            PostType = i_Post.Type.ToString();
            Link = i_Post.Link;
            LikeCount = m_Random.Next(0, 3000);
        }
    }
}

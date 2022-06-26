using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.CachingProxy
{
    public class FetchCachingProxy : IFetch
    {
        private UserAdapter UserAdapter { get; set; }

        private FacebookObjectCollection<Page> m_LikedPages;
        private FacebookObjectCollection<User> m_Friends;
        private FacebookObjectCollection<Photo> m_PhotosTaggedIn;
        private FacebookPosts m_Posts;

        public FetchCachingProxy(User i_User)
        {
            UserAdapter = new UserAdapter(i_User);
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                if (isThereInternet() || m_LikedPages == null)
                {
                    m_LikedPages = UserAdapter.LikedPages;
                }

                return m_LikedPages;
            }

            set
            {
                m_LikedPages = value;
            }
        }

        public FacebookObjectCollection<User> Friends
        {
            get
            {
                if (isThereInternet() || m_Friends == null)
                {
                    m_Friends = UserAdapter.Friends;
                }

                return m_Friends;
            }

            set
            {
                m_Friends = value;
            }
        }

        public FacebookObjectCollection<Photo> PhotosTaggedIn
        {
            get
            {
                if (isThereInternet() || m_PhotosTaggedIn == null)
                {
                    m_PhotosTaggedIn = UserAdapter.PhotosTaggedIn;
                }

                return m_PhotosTaggedIn;
            }

            set
            {
                m_PhotosTaggedIn = value;
            }
        }

        public FacebookPosts Posts
        {
            get
            {
                if(isThereInternet() || m_Posts == null)
                {
                    m_Posts = UserAdapter.Posts;
                }

                return m_Posts;
            }

            set
            {
                m_Posts = value;
            }
        }

        private bool isThereInternet()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }
    }
}

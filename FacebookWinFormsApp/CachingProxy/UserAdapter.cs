using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.CachingProxy
{
    public class UserAdapter : IFetch
    {
        public FacebookObjectCollection<Page> LikedPages { get; }

        public FacebookObjectCollection<User> Friends { get; }

        public FacebookObjectCollection<Photo> PhotosTaggedIn { get; }

        public FacebookPosts Posts { get; }

        public UserAdapter(User i_User)
        {
            LikedPages = i_User.LikedPages;
            Friends = i_User.Friends;
            PhotosTaggedIn = i_User.PhotosTaggedIn;
            Posts = new FacebookPosts(i_User.Posts);
        }
    }
}

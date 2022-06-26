using BasicFacebookFeatures.Logic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.CachingProxy
{
    public interface IFetch
    {
        FacebookObjectCollection<Page> LikedPages { get; }

        FacebookObjectCollection<User> Friends { get; }

        FacebookObjectCollection<Photo> PhotosTaggedIn { get; }

        FacebookPosts Posts { get; }
    }
}
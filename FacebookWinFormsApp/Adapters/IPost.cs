using System;

namespace BasicFacebookFeatures.Adapters
{
    public interface IPost
    {
        string PostImageAddress { get; set; }

        string UserName { get; set; }

        DateTime? UpdateTime { get; set; }

        string Descreption { get; set; }

        string PostType { get; set; }

        string Link { get; set; }

        int LikeCount { get; set; } 
    }
}

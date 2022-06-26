using System;
using System.Collections;
using System.Collections.Generic;
using BasicFacebookFeatures.Adapters;
using BasicFacebookFeatures.Iterator;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic
{
    public class FacebookPosts : IEnumerable<PostAdapterWinForms>
    {
        private List<PostAdapterWinForms> Posts { get; set; }  
        
        public FacebookPosts(FacebookObjectCollection<Post> i_Posts)
        {
            deepCloneWinFormPost(i_Posts);
        }

        private void deepCloneWinFormPost(FacebookObjectCollection<Post> i_Posts)
        {
            Posts = new List<PostAdapterWinForms>();

            foreach (Post post in i_Posts)
            {
                try
                {
                    Posts.Add(new PostAdapterWinForms(post));
                }
                catch
                {
                    ///if something is null don't add to post
                }
            }
        }

        private class PostIterator : IPostIterator
        {
            private FacebookPosts m_FacebookPosts;
            private int m_currentIdx = 0;

            public PostIterator(FacebookPosts i_FacebookPosts)
            {
                this.m_FacebookPosts = i_FacebookPosts;
            }

            public PostAdapterWinForms Current
            {
                get
                {
                    return m_FacebookPosts.Posts[m_currentIdx];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return (this as IEnumerator<PostAdapterWinForms>).Current;
                }
            }

            public bool MoveNext()
            {
                ++m_currentIdx;

                return m_currentIdx < m_FacebookPosts.Posts.Count;
            }

            public bool MovePrev()
            {
                --m_currentIdx;

                return m_currentIdx > -1;
            }

            public void Dispose()
            {
                this.Reset();
            }

            public void Reset()
            {
                m_currentIdx = 0;
            }
        }

        public IEnumerator<PostAdapterWinForms> GetEnumerator()
        {
            ///return this.Posts.GetEnumerator();
            return new PostIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<PostAdapterWinForms>).GetEnumerator();
        }

        public void RemoveDuplicates()
        {
            List<PostAdapterWinForms> newPostList = new List<PostAdapterWinForms>();

            foreach (PostAdapterWinForms post in this.Posts)
            {
                if (post != null)
                {
                    if (post.PostImageAddress != null)
                    {
                        newPostList.Add(post);
                    }
                }
            }

            Posts = newPostList;
        }
    }
}

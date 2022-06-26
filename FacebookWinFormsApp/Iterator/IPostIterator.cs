using System.Collections.Generic;
using BasicFacebookFeatures.Adapters;

namespace BasicFacebookFeatures.Iterator
{
    public interface IPostIterator : IEnumerator<PostAdapterWinForms>
    {
        bool MovePrev();
    }
}

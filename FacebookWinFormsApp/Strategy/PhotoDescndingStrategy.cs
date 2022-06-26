using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Strategy
{
    public class PhotoDescendingStrategy : ISortStrategy<List<Photo>>
    {
        public List<Photo> Sort(List<Photo> i_List)
        {
            i_List = (from picture in i_List orderby picture.CreatedTime.Value.Date descending select picture).ToList();

            return i_List;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Strategy
{
    public class AlphabeticalAscendingStrategy : ISortStrategy<List<Page>>
    {
        public List<Page> Sort(List<Page> i_List)
        {
            i_List = (from page in i_List orderby page.Name ascending select page).ToList();

            return i_List;
        }
    }
}

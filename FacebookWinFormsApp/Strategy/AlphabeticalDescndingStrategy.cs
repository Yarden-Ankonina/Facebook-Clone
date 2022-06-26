using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Strategy
{
    public class AlphabeticalDescendingStrategy : ISortStrategy<List<Page>>
    {
        public List<Page> Sort(List<Page> i_List)
        {
            i_List = (from page in i_List orderby page.Name descending select page).ToList();

            return i_List;
        }
    }
}

using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public class Bear : Animal
    {
        public Bear(Image i_AnimalImage) : base(eAnimalCategories.Wild, i_AnimalImage)
        {
        }
    }
}

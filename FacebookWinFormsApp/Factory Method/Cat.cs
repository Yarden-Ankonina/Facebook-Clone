using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public class Cat : Animal
    {
        public Cat(Image i_AnimalImage) : base(eAnimalCategories.Domestic, i_AnimalImage)
        {
        }
    }
}

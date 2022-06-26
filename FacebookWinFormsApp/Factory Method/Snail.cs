using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public class Snail : Animal
    {
        public Snail(Image i_AnimalImage) : base(eAnimalCategories.Farm, i_AnimalImage)
        {
        }
    }
}

using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public class Pig : Animal
    {
        public Pig(Image i_AnimalImage) : base(eAnimalCategories.Farm, i_AnimalImage)
        {
        }
    }
}

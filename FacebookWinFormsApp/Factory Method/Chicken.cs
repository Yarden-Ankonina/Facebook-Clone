using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public class Chicken : Animal
    {
        public Chicken(Image i_AnimalImage) : base(eAnimalCategories.Farm, i_AnimalImage)
        {
        }
    }
}

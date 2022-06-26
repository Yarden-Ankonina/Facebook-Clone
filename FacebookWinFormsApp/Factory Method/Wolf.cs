using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public class Wolf : Animal
    {
        public Wolf(Image i_AnimalImage) : base(eAnimalCategories.Wild, i_AnimalImage)
        {
        }
    }
}

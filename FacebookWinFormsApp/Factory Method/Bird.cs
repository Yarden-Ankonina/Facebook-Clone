using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public class Bird : Animal
    {
        public Bird(Image i_AnimalImage) : base(eAnimalCategories.Flying, i_AnimalImage)
        {
        }
    }
}

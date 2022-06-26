using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public class Dog : Animal
    {
        public Dog(Image i_AnimalImage) : base(eAnimalCategories.Domestic, i_AnimalImage)
        {
        }
    }
}

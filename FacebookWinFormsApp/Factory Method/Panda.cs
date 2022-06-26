using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public class Panda : Animal
    {
        public Panda(Image i_AnimalImage) : base(eAnimalCategories.Wild, i_AnimalImage)
        {
        }
    }
}

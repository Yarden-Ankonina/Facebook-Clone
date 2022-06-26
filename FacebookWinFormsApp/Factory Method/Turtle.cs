using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Factory_Method
{
    public class Turtle : Animal
    {
        public Turtle(Image i_AnimalImage) : base(eAnimalCategories.Farm, i_AnimalImage)
        {
        }
    }
}

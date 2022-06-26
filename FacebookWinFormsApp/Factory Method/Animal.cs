using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public abstract class Animal
    {
        public eAnimalCategories AnimalCategory { get; set; }

        public Image AnimalPicture { get; set; }

        public Animal(eAnimalCategories i_AnimalCategory, Image i_AnimalImage)
        {
            AnimalCategory = i_AnimalCategory;
            AnimalPicture = i_AnimalImage;
        }

        public string GetFoodByAnimalType(eAnimalCategories i_AnimalCategory)
        {
            string pictureURL = string.Empty;

            switch(i_AnimalCategory)
            {
                case eAnimalCategories.Domestic:
                    pictureURL = "https://cdn-icons-png.flaticon.com/512/361/361285.png";
                    break;
                case eAnimalCategories.Wild:
                    pictureURL = "https://cdn-icons-png.flaticon.com/512/1046/1046769.png";
                    break;
                case eAnimalCategories.Farm:
                    pictureURL = "https://cdn-icons-png.flaticon.com/512/1407/1407945.png";
                    break;
                case eAnimalCategories.Flying:
                    pictureURL = "https://cdn-icons-png.flaticon.com/512/2817/2817858.png";
                    break;
                default:
                    pictureURL = "https://img.icons8.com/officel/452/dog-bowl.png";
                    break;
            }

            return pictureURL;
        }
    }
}

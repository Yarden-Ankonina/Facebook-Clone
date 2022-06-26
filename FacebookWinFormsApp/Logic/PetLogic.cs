namespace BasicFacebookFeatures.Logic
{
    public class PetLogic
    {
        public string PetImageUrl { get; set; }

        public string PetFoodUrl { get; set; } 

        public string PetName { get; set; }

        public PetLogic()
        {
            PetName = "My Pet's Name";
            PetImageUrl = "https://img.icons8.com/external-wanicon-flat-wanicon/452/external-pets-free-time-wanicon-flat-wanicon.png";
            PetFoodUrl = "https://img.icons8.com/officel/452/dog-bowl.png";
        }
    }
}

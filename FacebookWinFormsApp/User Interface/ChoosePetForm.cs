using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Factory_Method;

namespace BasicFacebookFeatures.User_Interface
{
    public partial class ChoosePetForm : Form
    {
        public Image Pet { get; set; }

        private bool Loaded { get; set; } = false;

        public string ImageUrl { get; set; }

        private Dictionary<PictureBox, string> PetList { get; set; }

        public Animal AnimalType { get; set; } = null;

        public string FoodUrl { get; private set; }

        public ChoosePetForm()
        {
            InitializeComponent();
            initializePetList();
        }

        private void initializePetList()
        {
            PetList = new Dictionary<PictureBox, string>()
            {
                { pictureBoxWolf, "https://img.icons8.com/office/452/wolf.png" },
                { pictureBoxCat, "https://img.icons8.com/external-justicon-flat-justicon/452/external-cat-dog-and-cat-justicon-flat-justicon-2.png" },
                { pictureBoxDog, "https://cdn-icons-png.flaticon.com/512/7280/7280914.png" },
                { pictureBoxPanda, "https://img.icons8.com/external-microdots-premium-microdot-graphic/452/external-animal-animal-kingdom-vol1-microdots-premium-microdot-graphic-22.png" },
                { pictureBoxChicken, "https://img.icons8.com/external-wanicon-lineal-color-wanicon/452/external-chicken-butcher-wanicon-lineal-color-wanicon.png" },
                { pictureBoxBird, "https://img.icons8.com/external-house-maxicons/452/external-animal-gardening-house-maxicons-6.png" },
                { pictureBoxSnail, "https://img.icons8.com/external-house-maxicons/452/external-animal-gardening-house-maxicons-15.png" },
                { pictureBoxTurtle, "https://img.icons8.com/external-house-maxicons/452/external-animal-gardening-house-maxicons-3.png" },
                { pictureBoxBear, "https://img.icons8.com/external-justicon-lineal-color-justicon/344/external-bear-autumn-season-justicon-lineal-color-justicon.png" },
                { pictureBoxPig, "https://img.icons8.com/plasticine/344/pig.png" },
            };

            foreach (KeyValuePair<PictureBox, string> pet in PetList)
            {
                pet.Key.SizeMode = PictureBoxSizeMode.Zoom;
                pet.Key.LoadAsync(pet.Value);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Loaded = true;
        }

        private void petClick(object i_Sender, EventArgs e)
        {
            if(Loaded)
            {
                PictureBox pictureBox = (PictureBox)i_Sender;
                this.DialogResult = DialogResult.OK;
                AnimalType = AnimalFactory.CreateAnimal((string)pictureBox.Tag, pictureBox.Image);
                FoodUrl = AnimalType.GetFoodByAnimalType(AnimalType.AnimalCategory);
                Pet = AnimalType.AnimalPicture;
                ImageUrl = pictureBox.ImageLocation;

                this.Close();
            }
        }
    }
}

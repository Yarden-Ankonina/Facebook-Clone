using System.Drawing;

namespace BasicFacebookFeatures.Factory_Method
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string i_AnimalType, Image i_AnimalImage)
        {
            Animal newAnimal;

            switch (i_AnimalType)
            {
                case "Wolf":
                    newAnimal = new Wolf(i_AnimalImage);
                    break;
                case "Cat":
                    newAnimal = new Cat(i_AnimalImage);
                    break;
                case "Dog":
                    newAnimal = new Dog(i_AnimalImage);
                    break;
                case "Panda":
                    newAnimal = new Panda(i_AnimalImage);
                    break;
                case "Chicken":
                    newAnimal = new Chicken(i_AnimalImage);
                    break;
                case "Bird":
                    newAnimal = new Bird(i_AnimalImage);
                    break;
                case "Snail":
                    newAnimal = new Snail(i_AnimalImage);
                    break;
                case "Turtle":
                    newAnimal = new Turtle(i_AnimalImage);
                    break;
                case "Bear":
                    newAnimal = new Bear(i_AnimalImage);
                    break;
                case "Pig":
                    newAnimal = new Pig(i_AnimalImage);
                    break;
                default:
                    newAnimal = null;
                    break;
            }

            return newAnimal;
        }
    }
}

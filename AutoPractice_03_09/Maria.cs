using System;

namespace AutoPractice_03_09
{
    class Maria : Human
    {
        public Maria()
        {
            this.Hunger = 6;
            this.Thirsty = 8;
            this.WaterAmount = 1;
            this.AppleAmount = 0;
            this.AppleToEatOnce = 3;
            this.WaterToDrinkOnce = 2;
            this.Money = 100;
        }

        public void Cycling()
        {
            if (this.Hunger - 3 < 0)
            {
                Console.WriteLine("I don't have energy. I'm to hungry!\n");
            }
            else if (this.Thirsty - 2 < 0)
            {
                Console.WriteLine("I'm to thirsty!\n");
            }
            else
            {
                this.Hunger -= 2;
                this.Thirsty -= 3;
                Console.WriteLine("Masha cycled!\n");
            }
        }
    }
}

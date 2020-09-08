using System;

namespace AutoPractice_03_09
{
    public class Human
    {
        public int Hunger;
        public int Thirsty;
        public int AppleAmount;
        public int ApplePrice = 2;
        public int WaterAmount;
        public int WaterPrice = 3;
        public int AppleToEatOnce;
        public int WaterToDrinkOnce;
        public int Money;

        public void ShowParameters(string name)
        {
            Console.WriteLine($"{name}s parameters");
            Console.WriteLine($"\nHunger -    {Hunger}      | \tThirsty - {Thirsty}");
            Console.WriteLine($"AppleAmount - {AppleAmount}    | \tWaterAmount - {WaterAmount}");
            Console.WriteLine($"AppleToEatOnce - {AppleToEatOnce} | \tWaterToDrinkOnce - {WaterToDrinkOnce}");
            Console.WriteLine($"Money - {Money}\n");
        }

        public void Buy(string item, int amount, Human partner, string name)
        {
            if (Money < ApplePrice * amount)
            {
                Console.WriteLine("\nSorry, but amount of your money is not enough!\n");
            }
            else if (partner.AppleAmount < amount || partner.WaterAmount < amount)
            {
                if (item == "apple") item += "s";
                Console.WriteLine($"\nSorry, but amount of {item} in your partner is not enough for selling!\n");
            }
            else if (item == "apple")
            {
                    AppleAmount += amount;
                    partner.AppleAmount -= amount;
                    Money -= ApplePrice * amount;
                    partner.Money += ApplePrice * amount;
                    Console.WriteLine($"\n{name} bought {amount} apples!\n");
            }
            else if (item == "water")
            {
                    WaterAmount += amount;
                    partner.WaterAmount -= amount;
                    Money -= WaterPrice * amount;
                    Console.WriteLine($"\n{name} bought {amount} water!\n");
            }
            else
            {
                Console.WriteLine("\nNot water and apple\n");
            }
        }

        public void Buy(string item, int amount, string name)
        {
            if (Money < ApplePrice * amount)
            {
                Console.WriteLine("\nSorry, but amount of your money is not enough!\n");
            }
            else if (item == "apple")
            {
                AppleAmount += amount;
                Money -= ApplePrice * amount;
                Console.WriteLine($"\n{name} bought {amount} apples!\n");
            }
            else if (item == "water")
            {
                WaterAmount += amount;
                Money -= WaterPrice * amount;
                Console.WriteLine($"\n{name} bought {amount} water!\n");
            }
            else
            {
                Console.WriteLine("\nNot water and apple\n");
            }
        }

        public void Sell(string item, int amount, Human partner, string name)
        {
            if (partner.Money < ApplePrice * amount)
            {
                Console.WriteLine("\nSorry, but amount of money in your buyer is not enough!\n");
            }
            else if (this.AppleAmount < amount || this.WaterAmount < amount)
            {
                if (item == "apple") item += "s";
                Console.WriteLine($"\nSorry, but amount of {item} that {name} has is not enough for selling!\n");
            }
            else if (item == "apple")
            {
                AppleAmount -= amount;
                partner.AppleAmount += amount;
                Money += ApplePrice * amount;
                partner.Money -= ApplePrice * amount;
                Console.WriteLine($"{name} sold {amount} apples!");
            }
            else if (item == "water")
            {
                WaterAmount -= amount;
                partner.WaterAmount += amount;
                Money += WaterPrice * amount;
                Console.WriteLine($"\n{name} sold {amount} water!\n");
            }
            else
            {
                Console.WriteLine("\nNot water and apple\n");
            }
        }

        public void Sell(string item, int amount, string name)
        {
            if (item == "apple")
            {
                AppleAmount -= amount;
                Money += ApplePrice * amount;
                Console.WriteLine($"\n{name} sold {amount} apples!\n");
            }
            else if (item == "water")
            {
                WaterAmount -= amount;
                Money += WaterPrice * amount;
                Console.WriteLine($"\n{name} sold {amount} water!\n");
            }
            else
            {
                Console.WriteLine("\nNot water and apple\n");
            }
        }

        public void Eat(string name)
        {
            if (Hunger == 0)
            {
                Console.WriteLine("\nI'm not hungry!\n");
            }
            else
            {
                if (Hunger - AppleToEatOnce < 0)
                {
                    int tmp = (Hunger - AppleToEatOnce) * -1;
                    Hunger = 0;
                    AppleAmount += tmp;
                }
                else if (Hunger + AppleToEatOnce > 10)
                {
                    int tmp = (Hunger + AppleToEatOnce) - 10;
                    Hunger = 10;
                    AppleAmount -= tmp;
                }
                else
                {
                    Hunger -= AppleToEatOnce;
                    AppleAmount -= AppleToEatOnce;
                }
                Console.WriteLine($"\n{name} eate!\n");
            }
        }

        public void Drink(string name)
        {
            if (this.Thirsty == 0)
            {
                Console.WriteLine("\nI'm not thirsty!\n");
            }
            else if (this.WaterAmount < this.WaterToDrinkOnce)
            {
                Console.WriteLine("\nI don't have enough water =(!\n");
            }
            else
            {
                if (this.Thirsty - this.WaterToDrinkOnce < 0)
                {
                    int tmp = (Thirsty - WaterToDrinkOnce) * -1;
                    this.Thirsty = 0;
                    this.WaterAmount -= tmp;
                }
                else if (Thirsty + WaterToDrinkOnce > 10)
                {
                    int tmp = (Thirsty + WaterToDrinkOnce) - 10;
                    this.Thirsty = 0;
                    this.WaterAmount -= tmp;
                }
                else
                {
                    this.Thirsty -= WaterToDrinkOnce;
                    this.WaterAmount -= WaterAmount;
                }
                Console.WriteLine($"\n{name} drank water!\n");
            }
        }
    }
}

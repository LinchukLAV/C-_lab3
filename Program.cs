using System;
using System.Collections.Generic;
using System.Linq;
using MainClasses;
using ExtraElements.Ingredients;
using ExtraElements.Types;
using Selectors;
using Builders;

namespace NastyLab
{
    static class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            StorageSelector sSelector = new();
            IEnumerable<Beverage> beverages = sSelector
                .GetParticularDayPartBeverages(DishBeverageDayPart.Ранок);
            IEnumerable<MainDish> mainDishes = sSelector
                .GetParticularDayPartMainDish(DishBeverageDayPart.Ранок);
            IEnumerable<Dessert> desserts = sSelector
                .GetParticularDayPartDessert(DishBeverageDayPart.Ранок);


            Beverage currentBeverage = beverages
                .Where(x => x.Type == BeverageType.Кофе)
                .Single();

            IBeverageBuilder beverageBuilder = new CoffeeBuilder();
            beverageBuilder.AddMainIngredient(CoffeeMainIngredient.Лате);
            beverageBuilder.AddExtraIngredient(ExtraCoffeeTeaIngredient.Молоко);
            beverageBuilder.AddExtraIngredient(ExtraCoffeeTeaIngredient.Цукор);
            beverageBuilder.AddSize(Size.Середній);
            beverageBuilder.AddContainer(BeverageContainer.Кружка);
            currentBeverage = beverageBuilder.GetBeverage();

            MainDish mainDish = mainDishes
                .Where(x => x.Type == MainDishType.Пюре)
                .Single();

            IMainDishBuilder mainDishBuilder = new PureeBuilder();
            mainDishBuilder.AddMainComponent(PureeMainIngredient.Картопля);
            mainDishBuilder.AddMeat(Meat.Курячі_крильця);
            mainDishBuilder.AddMakeready(Makeready.Кечуп);
            mainDishBuilder.AddSize(Size.Великий);
            mainDish = mainDishBuilder.GetMainDish();


            Dessert dessert = desserts
                .Where(x => x.Type == DessertType.Ягоди)
                .Single();

            IDessertBuilder dessertBuilder = new BerriesBuilder();
            dessertBuilder.AddMainIngredient(BerriesMainIngredient.Полуниця);
            dessertBuilder.AddSecondIngredient(ExtraDessertIngredient.Ананас);
            dessertBuilder.AddSize(Size.Великий);
            dessert = dessertBuilder.GetDessert();

            Console.WriteLine($"{currentBeverage}\n{mainDish}\n{dessert}");

        }
    }
}
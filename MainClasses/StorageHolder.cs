using System.Collections.Generic;
using ExtraElements.Types;

namespace MainClasses
{
    public class StorageHolder
    {
        public List<Beverage> Beverages { get; } = new()
        {
            new()
            {
                Type = BeverageType.Сік,
                DayParts = new()
                {
                    DishBeverageDayPart.Ранок,
                    DishBeverageDayPart.Обід,
                }
            },
            new()
            {
                Type = BeverageType.Кофе,
                DayParts = new()
                {
                    DishBeverageDayPart.Ранок,
                    DishBeverageDayPart.Обід
                }
            },
            new()
            {
                Type = BeverageType.Чай,
                DayParts = new()
                {
                    DishBeverageDayPart.Обід
                }
            },
            new()
            {
                Type = BeverageType.Вино,
                DayParts = new()
                {
                    DishBeverageDayPart.Вечер
                }
            }
        };
        public List<MainDish> MainDishes { get; } = new()
        {
            new()
            {
                Type = MainDishType.Рис,
                DayParts = new()
                {
                    DishBeverageDayPart.Ранок
                }
            },
            new()
            {
                Type = MainDishType.Гречка,
                DayParts = new()
                {
                    DishBeverageDayPart.Ранок,
                    DishBeverageDayPart.Вечер
                }
            },
            new()
            {
                Type = MainDishType.Паста,
                DayParts = new()
                {
                    DishBeverageDayPart.Обід,
                    DishBeverageDayPart.Вечер
                }
            },
            new()
            {
                Type = MainDishType.Пюре,
                DayParts = new()
                {
                    DishBeverageDayPart.Ранок,
                    DishBeverageDayPart.Обід,
                    DishBeverageDayPart.Ранок
                }
            }
        };
        public List<Dessert> Desserts { get; } = new()
        {
            new()
            {
                Type = DessertType.Сир,
                DayParts = new()
                {
                    DishBeverageDayPart.Ранок
                }
            },
            new()
            {
                Type = DessertType.Ягоди,
                DayParts = new()
                {
                    DishBeverageDayPart.Ранок
                }
            },
            new()
            {
                Type = DessertType.Морозиво,
                DayParts = new()
                {
                    DishBeverageDayPart.Обід,
                    DishBeverageDayPart.Вечер
                }
            },
            new()
            {
                Type = DessertType.Періг,
                DayParts = new()
                {
                    DishBeverageDayPart.Обід
                }
            }
        };
    }
}

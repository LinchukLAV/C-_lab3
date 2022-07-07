using System.Collections.Generic;
using System.Linq;
using MainClasses;

namespace Selectors
{
    public class StorageSelector
    {
        private StorageHolder _storageHolder = new();

        public IEnumerable<Beverage> GetParticularDayPartBeverages(DishBeverageDayPart dayPart)
        {
            return _storageHolder.Beverages
                .Where(beverage => beverage.DayParts.Any(part => part == dayPart));
        }
        public IEnumerable<MainDish> GetParticularDayPartMainDish(DishBeverageDayPart dayPart)
        {
            return _storageHolder.MainDishes
                .Where(mainDish => mainDish.DayParts.Any(part => part == dayPart));
        }
        public IEnumerable<Dessert> GetParticularDayPartDessert(DishBeverageDayPart dayPart)
        {
            return _storageHolder.Desserts
                .Where(dessert => dessert.DayParts.Any(part => part == dayPart));
        }
    }
}

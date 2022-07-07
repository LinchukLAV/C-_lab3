using System;
using MainClasses;
using ExtraElements.Ingredients;
using ExtraElements.Types;

namespace Builders
{
    public class CakeBuilder : IDessertBuilder
    {
        private Dessert _dessert = new()
        {
            Type = DessertType.Періг
        };

        public void AddMainIngredient(Enum mainIngredient)
        {
            if (mainIngredient.GetType() != typeof(CakeMainIngredient))
            {
                throw new ArgumentException();
            }
            _dessert.MainIngredient = mainIngredient;
        }
        public void AddSecondIngredient(ExtraDessertIngredient secondIngredient)
        {
            throw new NotImplementedException();
        }
        public void AddSupplement(Supplement supplement)
        {
            _dessert.Supplement = supplement;
        }
        public void AddSize(Size size)
        {
            _dessert.Size = size;
        }
        public Dessert GetDessert()
        {
            return _dessert;
        }
    }
}

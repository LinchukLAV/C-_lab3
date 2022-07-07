using System;
using MainClasses;
using ExtraElements.Ingredients;
using ExtraElements.Types;

namespace Builders
{
    public class BerriesBuilder : IDessertBuilder
    {
        private Dessert _dessert = new()
        {
            Type = DessertType.Ягоди
        };

        public void AddMainIngredient(Enum mainIngredient)
        {
            if (mainIngredient.GetType() != typeof(BerriesMainIngredient))
            {
                throw new ArgumentException();
            }
            _dessert.MainIngredient = mainIngredient;
        }
        public void AddSecondIngredient(ExtraDessertIngredient secondIngredient)
        {
            if (_dessert.ExtraIngredients is null)
            {
                _dessert.ExtraIngredients = new();
            }
            _dessert.ExtraIngredients.Add(secondIngredient);
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

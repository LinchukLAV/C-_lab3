using System;
using MainClasses;
using ExtraElements.Ingredients;
using ExtraElements.Types;

namespace Builders
{
    public class SchmearBuilder : IDessertBuilder
    {
        private Dessert _dessert = new()
        {
            Type = DessertType.Сир
        };

        public void AddMainIngredient(Enum mainIngredient)
        {
            if (mainIngredient.GetType() != typeof(IcecreamMainIngredient))
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
            if (_dessert.ExtraIngredients.Count < 1)
            {
                _dessert.ExtraIngredients.Add(secondIngredient);
            }
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

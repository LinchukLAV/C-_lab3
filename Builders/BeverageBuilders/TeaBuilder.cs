using System;
using System.Linq;
using MainClasses;
using ExtraElements.Ingredients;
using ExtraElements.Types;

namespace Builders
{
    public class TeaBuilder : IBeverageBuilder
    {
        private Beverage _beverage = new()
        {
            Type = BeverageType.Чай
        };

        public void AddMainIngredient(Enum mainIngredient)
        {
            if (mainIngredient.GetType() != typeof(TeaMainIngredient))
            {
                throw new ArgumentException();
            }
            _beverage.MainComponent = mainIngredient;
        }
        public void AddExtraIngredient(Enum extraIngredient)
        {
            if (extraIngredient.GetType() != typeof(ExtraCoffeeTeaIngredient))
            {
                throw new ArgumentException();
            }
            if (_beverage.ExtraComponents is null)
            {
                _beverage.ExtraComponents = new();
            }
            if (!_beverage.ExtraComponents.Any(ingr => ingr == extraIngredient))
            {
                _beverage.ExtraComponents.Add(extraIngredient);
            }
        }
        public void AddSize(Size size)
        {
            _beverage.Size = size;
        }
        public void AddContainer(BeverageContainer container)
        {
            _beverage.Container = container;
        }
        public Beverage GetBeverage()
        {
            return _beverage;
        }
    }
}

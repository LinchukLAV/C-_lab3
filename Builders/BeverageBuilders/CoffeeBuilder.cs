using System;
using System.Linq;
using ExtraElements.Ingredients;
using ExtraElements.Types;
using MainClasses;

namespace Builders
{
    public class CoffeeBuilder : IBeverageBuilder
    {
        private Beverage _beverage = new()
        {
            Type = BeverageType.Кофе
        };

        public void AddMainIngredient(Enum mainComponent)
        {
            if (mainComponent.GetType() != typeof(CoffeeMainIngredient))
            {
                throw new ArgumentException();
            }
            _beverage.MainComponent = mainComponent;
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
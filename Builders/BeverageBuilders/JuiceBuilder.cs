using System;
using System.Linq;
using MainClasses;
using ExtraElements.Ingredients;
using ExtraElements.Types;

namespace Builders
{
    public class JuiceBuilder : IBeverageBuilder
    {
        private Beverage _beverage = new()
        {
            Type = BeverageType.Сік
        };

        public void AddMainIngredient(Enum mainIngredient)
        {
            if (mainIngredient.GetType() != typeof(JuiceMainIngredient))
            {
                throw new ArgumentException();
            }
            _beverage.MainComponent = mainIngredient;
        }
        public void AddExtraIngredient(Enum secondComponent)
        {
            if (secondComponent.GetType() != typeof(JuiceMainIngredient))
            {
                throw new ArgumentException();
            }
            if (_beverage.ExtraComponents is null)
            {
                _beverage.ExtraComponents = new();
            }
            if (!_beverage.ExtraComponents.Any(component => component == secondComponent))
            {
                _beverage.ExtraComponents.Add(secondComponent);
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

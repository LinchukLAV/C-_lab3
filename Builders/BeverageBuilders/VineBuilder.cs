using System;
using MainClasses;
using ExtraElements.Ingredients;
using ExtraElements.Types;


namespace Builders
{
    public class VineBuilder : IBeverageBuilder
    {
        private Beverage _beverage = new()
        {
            Type = BeverageType.Вино
        };

        public void AddMainIngredient(Enum mainIngredient)
        {
            if (mainIngredient.GetType() != typeof(VineMainIngredient))
            {
                throw new ArgumentException();
            }
            _beverage.MainComponent = mainIngredient;
        }
        public void AddExtraIngredient(Enum secondComponent)
        {
            throw new NotImplementedException();
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

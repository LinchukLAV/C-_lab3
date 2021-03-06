using System;
using MainClasses;
using ExtraElements.Ingredients;
using ExtraElements.Types;

namespace Builders
{
    public class PureeBuilder : IMainDishBuilder
    {
        private MainDish _mainDish = new()
        {
            Type = MainDishType.Пюре
        };

        public void AddMainComponent(Enum mainIngredient)
        {
            if (mainIngredient.GetType() != typeof(PureeMainIngredient))
            {
                throw new ArgumentException();
            }
            _mainDish.MainIngredient = mainIngredient;
        }
        public void AddMeat(Meat meat)
        {
            _mainDish.Meat = meat;
        }
        public void AddMakeready(Makeready makeready)
        {
            if (_mainDish.Makereadies is null)
            {
                _mainDish.Makereadies = new();
            }
            _mainDish.Makereadies.Add(makeready);
        }
        public void AddSize(Size size)
        {
            _mainDish.Size = size;
        }
        public MainDish GetMainDish()
        {
            return _mainDish;
        }
    }
}

using System;
using System;
using MainClasses;
using ExtraElements.Ingredients;
using ExtraElements.Types;

namespace Builders
{
    public class BuckwheatBuilder : IMainDishBuilder
    {
        private MainDish _mainDish = new()
        {
            Type = MainDishType.Гречка
        };

        public void AddMainComponent(Enum mainIngredient)
        {
            if (mainIngredient.GetType() != typeof(BuckwheatMainIngredient))
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
            throw new NotImplementedException();
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

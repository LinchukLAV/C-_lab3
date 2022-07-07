using System;
using MainClasses;
using ExtraElements.Ingredients;
using ExtraElements.Types;

namespace Builders
{
    public class PasteBuilder : IMainDishBuilder
    {
        private MainDish _mainDish = new()
        {
            Type = MainDishType.Паста
        };

        public void AddMainComponent(Enum mainIngredient)
        {
            if (mainIngredient.GetType() != typeof(PasteMainIngredient))
            {
                throw new ArgumentException();
            }
            _mainDish.MainIngredient = mainIngredient;
        }
        public void AddMeat(Meat meat)
        {
            throw new NotImplementedException();
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

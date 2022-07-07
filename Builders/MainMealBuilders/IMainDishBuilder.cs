using System;
using MainClasses;
using ExtraElements.Ingredients;

namespace Builders
{
    public interface IMainDishBuilder
    {
        void AddMainComponent(Enum mainIngredient);
        void AddMeat(Meat meat);
        void AddMakeready(Makeready makeready);
        void AddSize(Size size);
        MainDish GetMainDish();
    }
}

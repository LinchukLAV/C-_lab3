using System;
using ExtraElements.Ingredients;
using MainClasses;

namespace Builders
{
    public interface IBeverageBuilder
    {
        void AddMainIngredient(Enum mainIngredient);
        void AddExtraIngredient(Enum secondIngredient);
        void AddSize(Size capacity);
        void AddContainer(BeverageContainer container);
        Beverage GetBeverage();
    }
}

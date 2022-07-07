using System;
using ExtraElements.Ingredients;
using MainClasses;

namespace Builders
{
    public interface IDessertBuilder
    {
        void AddMainIngredient(Enum mainIngredient);
        void AddSecondIngredient(ExtraDessertIngredient secondIngredietn);
        void AddSupplement(Supplement supplement);
        void AddSize(Size size);
        Dessert GetDessert();
    }
}

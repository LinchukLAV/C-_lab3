using System;
using System.Text;
using System.Collections.Generic;
using ExtraElements.Types;
using ExtraElements.Ingredients;

namespace MainClasses
{
    public class Dessert : IDayPartable
    {
        public DessertType Type { get; init; }
        public Enum MainIngredient { get; set; }
        public List<ExtraDessertIngredient>? ExtraIngredients { get; set; }
        public Supplement? Supplement { get; set; }
        public Size Size { get; set; }
        public List<DishBeverageDayPart> DayParts { get; init; } = new();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Десерт: {Type} Базується на: {MainIngredient} ");
            if (ExtraIngredients is not null)
            {
                sb.Append("З додаванням до: ");
                foreach (ExtraDessertIngredient extraDessertIngredient in ExtraIngredients)
                {
                    sb.Append($"{extraDessertIngredient} ");
                }
            }
            if (Supplement is not null)
            {
                sb.Append($"Политий {Supplement} ");
            }
            sb.Append($"Розмір порції: {Size}");
            return sb.ToString();
        }
    }
}
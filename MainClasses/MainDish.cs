using System;
using System.Text;
using System.Collections.Generic;
using ExtraElements.Ingredients;
using ExtraElements.Types;

namespace MainClasses
{
    public class MainDish : IDayPartable
    {
        public MainDishType Type { get; init; }
        public Enum MainIngredient { get; set; }
        public Meat? Meat { get; set; }
        public List<Makeready>? Makereadies { get; set; }
        public Size Size { get; set; }
        public List<DishBeverageDayPart> DayParts { get; init; } = new();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Основна страва: {Type} " +
                $"Зроблена з: { MainIngredient } ");
            if (Meat is not null)
            {
                sb.Append($"М'ясо: {Meat} ");
            }
            if (Makereadies is not null)
            {
                sb.Append("В яку додано: ");
                foreach (Makeready makeready in Makereadies)
                {
                    sb.Append($"{makeready} ");
                }
            }
            sb.Append($"Розмір порції {Size}");
            return sb.ToString();
        }
    }
}
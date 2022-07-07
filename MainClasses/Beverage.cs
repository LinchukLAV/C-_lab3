using System;
using System.Text;
using System.Collections.Generic;
using ExtraElements.Ingredients;
using ExtraElements.Types;

namespace MainClasses
{
    public class Beverage : IDayPartable
    {
        public BeverageType Type { get; set; }
        public Enum MainComponent { get; set; }
        public List<Enum>? ExtraComponents { get; set; }
        public Size Size { get; set; }
        public BeverageContainer Container { get; set; }
        public List<DishBeverageDayPart> DayParts { get; init; } = new();

        public override string ToString()
        {
            StringBuilder sb = new($"Напій: {Type} Базується на: {MainComponent} " +
                $"Розміру: {Size} Налитий в {Container} ");
            if (ExtraComponents is not null)
            {
                sb.Append("В який додано: ");
                foreach (Enum extraComponent in ExtraComponents)
                {
                    sb.Append(extraComponent.ToString() + " ");
                }
            }
            return sb.ToString();
        }
    }
}

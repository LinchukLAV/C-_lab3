using System.Collections.Generic;

namespace MainClasses
{
    public interface IDayPartable
    {
        List<DishBeverageDayPart> DayParts { get; init; }
    }
}

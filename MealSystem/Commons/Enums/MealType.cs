using System.ComponentModel;

namespace MealSystem.Commons.Enums
{
    public enum MealType
    {
        [Description("아침")]
        BREAKFAST = 0,

        [Description("점심")]
        LUNCH = 1,

        [Description("저녁")]
        DINNER = 2,

        [Description("기타")]
        NONE = 3
    }
}

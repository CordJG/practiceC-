using System.ComponentModel;

namespace MealSystem.Commons.Enums
{
    public enum StatusEnum
    {
        [Description("요청 성공")]
        OK = 200,

        [Description("요청 실패")]
        BAD_REQUEST = 400,

        [Description("찾을 수 없는 요청입니다")]
        NOT_FOUND = 404,

        [Description("서버 에러")]
        INTERNAL_SERVER_ERROR = 500
    }
}

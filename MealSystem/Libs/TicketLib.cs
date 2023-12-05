using MealSystem.Commons;
using MealSystem.Contexts;
using MealSystem.Models;
using MealSystem.Commons.Enums;

namespace MealSystem.Libs
{
    public class TicketLib
    {
        private readonly MealContext? _mealContext;

        public TicketLib(MealContext? mealContext)
        {
            _mealContext = mealContext;
        }

        public ApiResponse<object> AddTicket(Ticket ticket)

        {
            return new ApiResponse<object>(StatusEnum.OK, ticket);
        }
    }
}

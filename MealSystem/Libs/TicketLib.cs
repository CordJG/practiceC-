using MealSystem.Commons;
using MealSystem.Contexts;
using MealSystem.Models;
using MealSystem.Commons.Enums;
using Microsoft.EntityFrameworkCore;

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

            try
            {
                _mealContext.Add(ticket);   // db 추가
                _mealContext.SaveChanges(); // db 변경 사항 커밋(반영)
                return new ApiResponse<object>(StatusEnum.OK, ticket);
            }
            catch (DbUpdateException ex)
            {
                // DbUpdateException 발생 시 InnerException을 출력
                Console.WriteLine(ex.InnerException?.Message);
                throw; // 예외를 다시 throw하여 호출자에게 전달
            }
            catch (Exception ex)
            {
                // 기타 예외를 로깅
                Console.WriteLine("Exception: " + ex.Message);

                // 예외를 다시 throw하여 호출자에게 전달
                throw;
            }
        }
}
}

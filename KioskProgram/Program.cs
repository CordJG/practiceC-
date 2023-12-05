
using System;
namespace KioskProgram
{
    public class Program
    {
        public static void Main()
        {
            var menuService = new Services.MenuService();
            var orderService = new Services.OrderService();

            var menuItems = menuService.GetMenu();
            menuService.GetMenuBoard();
            
        }
    }
}
    
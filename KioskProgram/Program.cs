
using System;
namespace KioskProgram
{
    internal class Program
    {
        private static void Main()
        {
            var menuService = new Services.MenuService();
            var orderService = new Services.OrderService();

            var menuItems = menuService.GetMenu();
            menuService.GetMenuBoard();
            
        }
    }
}
    
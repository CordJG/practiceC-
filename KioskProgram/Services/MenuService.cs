using KioskProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KioskProgram.Services;


namespace KioskProgram.Services
{
    internal class MenuService
    {   
        private readonly OrderService _orderService;

        public MenuService()
        {
            _orderService = new OrderService();
        }
        public Dictionary<int, MenuItem> GetMenu()
        {
            return new Dictionary<int, MenuItem> ()
            {
                {1, new Burger {Name = "치즈 와퍼", Price = 5000}},
                {2, new Burger {Name = "머쉬룸 와퍼", Price = 8000}},
                {3, new Burger {Name = "갈릭 와퍼", Price = 6000}},
                {4, new Side {Name = "감자튀김", Price = 2000}},
                {5, new Side {Name = "치즈스틱", Price = 1200}},
                {6, new Drink {Name = "콜라", Price = 1000} },
                {7, new Drink {Name = "사이다", Price = 1000}}
            };
        }

        public void GetMenuBoard()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("         버거킹         ");
            Console.WriteLine("**************************");
            Console.WriteLine();
            foreach (var item in GetMenu())
            {
                {
                    Console.WriteLine($"{item.Key}. {item.Value.Name}  = ${item.Value.Price} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**************************");
            Console.WriteLine("메뉴보기: 0, 주문하기: 1");
            Console.WriteLine("장바구니: 2, 종료하기: 3");
            Console.WriteLine();
            Console.WriteLine("원하는 기능의 번호를 입력하세요: ");
            
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                ProcessUserChoice(choice);
            }
        }

        public void ProcessUserChoice(int choice)
        {
            switch (choice)
            {
                case 0:
                    GetMenuBoard();
                    break;

                case 1:
                    _orderService.AddToOrder(GetMenu());
                    GetMenuBoard();
                    break;

                case 2:
                    _orderService.DisplayBascket();
                    if (int.TryParse(Console.ReadLine(), out int bascketChoice))
                    {
                        ProcessUserChoice(bascketChoice);
                    }
                    break;
                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("유효하지 않은 선택입니다.");
                    break;
            }

        }

        public void AddOption<T>(T menuItem)
        {

        }
    }
}

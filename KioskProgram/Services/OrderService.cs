using KioskProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskProgram.Services
{
    internal class OrderService
    {
        private List<MenuItem> orderItems;
        

        public OrderService() 
        {
            orderItems = new List<MenuItem>();

        }

        public void AddToOrder(Dictionary<int, MenuItem> menuItems)
        {
            bool orderCheck = true;
            while (orderCheck)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("메뉴 번호를 입력하세요: ");
                Console.WriteLine("");
                Console.WriteLine("**************************");
                Console.WriteLine("뒤로가기 : 0");
                
                if (int.TryParse(Console.ReadLine(), out int menuChoice))
                {
                    switch (menuChoice)
                    {
                        case 0:
                            orderCheck = false; break;
                            
                        default:
                            orderItems.Add(menuItems[menuChoice]);
                            break;
                    }                       
                }
            }
            
        }

        public void DisplayBascket()
        {
            int sumPrice = 0;
            Console.WriteLine("**************************");
            Console.WriteLine("        주문 내역        ");
            foreach (var item in orderItems)
            {
                Console.WriteLine($"{item.Name} = ${item.Price}");
                sumPrice += item.Price;
            }
            Console.WriteLine("");
            Console.WriteLine($"주문 금액 : {sumPrice}");
            Console.WriteLine("");
            Console.WriteLine("돌아가기: 0");
         
            Console.WriteLine("**************************");
            
        }
    }
}

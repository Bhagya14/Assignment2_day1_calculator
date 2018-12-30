using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account ID :");
            int AccountId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name :");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Customer Address :");
            string CustomerAddress = Console.ReadLine();
            Console.WriteLine("Enter Type of Account :");
            string TypeofAccount = Console.ReadLine();
            Console.WriteLine("Enter Balance :");
            double Balance = Convert.ToDouble(Console.ReadLine());
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Deposit -1,Withdraw -2,CheckBalance -3,Exit -4");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch(opt)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Deposit :");
                            int Deposit = Convert.ToInt32(Console.ReadLine());
                            if (Deposit >= 500)
                            {
                                Console.WriteLine("Deposited :" + Deposit);
                                Balance = Balance + Deposit;
                                Console.WriteLine("Total Balance :" + Balance);
                            }
                            else
                            {
                                Console.WriteLine("Minimum 500");
                            }
                            break;
                         }
                    case 2:
                        {
                            Console.WriteLine("Enter WithDraw Amount :");
                            int Withdraw = Convert.ToInt32(Console.ReadLine());
                            Balance = Balance - Withdraw;
                            Console.WriteLine("Remaining Balance :" + Balance);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Check Balance :" + Balance);
                            break;
                        }
                    case 4:
                        {
                            flag = false;
                            break;
                        }
                }
            }
        }
    }
}

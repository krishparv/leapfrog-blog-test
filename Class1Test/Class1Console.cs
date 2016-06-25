using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Test
{
    class Class1Console
    {
        static void Main(string[] args)
        {
            //hungary naming convention
            //cw refers shortcut of Console.WriteLine
            string userName = string.Empty;
           // userName = CheckUserName(userName);
            int i=0;
            while (CheckUserName(userName) != "admin" && i < 2)
            {
                i++;
                
              
            }

            if(i==2)
            {
                Environment.Exit(0);
            }

            else
            {
                string password = string.Empty;
                int j = 0;

                Console.Write("Password:");
                // password = string.Empty;//Console.ReadLine();

                while (ReadPassword(password) != "password" && j < 2)
                {
                    j++;
                    Console.WriteLine("");
                    Console.WriteLine("Password:");
                }

                if (j == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("--Menu--");
                    Console.WriteLine("---SubMenu---");
                    Console.ReadLine();
                }

            }

            
        }

        private static string CheckUserName(string userName)
        {
            Console.Write("User Name: ");
            userName = Console.ReadLine();
            return userName;
        }

        private static bool Authenticate(string userName, string password)
        {
            if (userName == "admin" && password == "password")
            {
                Console.WriteLine("Welcome admin " + userName);
                return true;

            }

            else if (userName == "user" && password == "pwd")
            {
                Console.WriteLine("welcome" + userName);
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Login");
                return false;
            }

           
        }

        private static string ReadPassword(string password)
        {
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                info = Console.ReadKey(true);
            }
            return password;
        }
    }
}

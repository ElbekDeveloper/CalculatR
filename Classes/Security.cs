using System;

namespace CalculatR.Classes
{
    class Security
    {
        public void CheckPassword()
        {
            string password = "";

            do
            {
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
            } while (password != "pa$$w0rd");
        }
    }
}
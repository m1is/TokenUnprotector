using System;
using TokenUnprotector;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a token:");
            var token = Console.ReadLine();

            Console.WriteLine("Enter a decryption key:");
            var decryptionKey = Console.ReadLine();

            Console.WriteLine("Enter a validation key:");
            var validationKey = Console.ReadLine();

            var ticket = Unprotector.Unprotect(token, decryptionKey, validationKey);

            Console.WriteLine();
            Console.WriteLine("Claims:");

            foreach (var item in ticket.Identity.Claims)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Issued: {0}", ticket.Properties.IssuedUtc);
            Console.WriteLine("Expires: {0}", ticket.Properties.ExpiresUtc);

            Console.ReadKey();
        }
    }
}

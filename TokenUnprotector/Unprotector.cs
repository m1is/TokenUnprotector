using System;
using TokenUnprotector.DataHandler.Encoder;

namespace TokenUnprotector
{
    public class Unprotector
    {
        public static AuthenticationTicket Unprotect(string token, string decryptionKey, string validationKey)
        {
            var decoded = Decode(token);
            var unprotected = MachineKey.Unprotect(decoded, validationKey, decryptionKey, "User.MachineKey.Protect", "Microsoft.Owin.Security.OAuth", "Access_Token", "v1");
            var serializer = new TicketSerializer();
            var ticket = serializer.Deserialize(unprotected);
            return ticket;
        }

        private static byte[] Decode(string token)
        {
            var encoder = new Base64UrlTextEncoder();
            return encoder.Decode(token);
        }
    }
}

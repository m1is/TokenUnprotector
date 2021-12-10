using System;

namespace TokenUnprotector.DataHandler.Encoder
{
    public class Base64UrlTextEncoder : ITextEncoder
    {
        public string Encode(byte[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            var base64 = Convert.ToBase64String(data);
            return base64.TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }

        public byte[] Decode(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            return Convert.FromBase64String(Pad(text.Replace('-', '+').Replace('_', '/')));
        }

        private static string Pad(string text)
        {
            var padding = 3 - ((text.Length + 3) % 4);
            if (padding == 0)
            {
                return text;
            }
            return text + new string('=', padding);
        }
    }
}

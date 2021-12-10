
namespace TokenUnprotector.DataHandler.Encoder
{
    public interface ITextEncoder
    {
        string Encode(byte[] data);
        byte[] Decode(string text);
    }
}

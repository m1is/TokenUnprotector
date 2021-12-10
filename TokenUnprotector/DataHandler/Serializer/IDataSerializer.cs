using System;

namespace TokenUnprotector.DataHandler.Serializer
{
    public interface IDataSerializer<TModel>
    {
        byte[] Serialize(TModel model);
        TModel Deserialize(byte[] data);
    }
}

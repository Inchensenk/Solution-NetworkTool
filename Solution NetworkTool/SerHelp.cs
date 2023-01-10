using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_NetworkTool
{
    /// <summary>
    /// Обертка над протобаф сериализатором
    /// </summary>
    public static class SerHelp
    {
        public static MemoryStream Serialize<T>(T obj)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    ProtoBuf.Serializer.Serialize<T>(ms, obj);

                    return ms;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public static T Deserialize<T>(byte[] data)
        {
            try
            {
                T res = ProtoBuf.Serializer.Deserialize<T>(data.AsSpan());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

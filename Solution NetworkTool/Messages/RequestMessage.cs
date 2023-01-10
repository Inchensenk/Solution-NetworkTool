using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_NetworkTool.Messages
{
    [ProtoContract]
    public class RequestMessage
    {
        [ProtoMember(1)]
        /// <summary>
        /// имя метода который на сервере обработает запрос
        /// </summary>
        public string Method { get; set; }
        //так как не во всех запросах есть данные делаем налбл
        [ProtoMember(2)]
        public byte[]? Data { get; set; }

        //для того чтобы протобаф работал нужен конструктор по умолчанию
        public RequestMessage()
        {

        }

        public override string ToString() => $"Request: Method "

    }
}

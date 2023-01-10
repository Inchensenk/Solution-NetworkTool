using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_NetworkTool.Messages
{
    [ProtoContract]
    public class ResponseMessage
    {
        //статус реквеста обработан он или не обработан
        [ProtoMember(1)]
        public RequestStatus Status { get; set; }

        //Если непонятно какая ошибка
        public string Context { get; set; }
        public byte[]? Data { get; private set; }

        //для протобаф
        public ResponseMessage()
        {

        }

        public ResponseMessage(RequestStatus sratus, string? context, byte[]? data)
        {
            Status = sratus;
            Context = context;
            Data = data;
        }

        public override string ToString() => $"Status {Status}, {Context ?? "NULL"}, {Data !=null}";

    }
}

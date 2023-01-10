using Solution_NetworkTool.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServerCore
{
    internal class RequestProvider
    {
        private readonly Dictionary<string, MethodInfo> _method = new Dictionary<string, MethodInfo>();

        public RequestProvider(Assembly assembly)
        {
            //проверка на то что 
            //у сборки берем все типы, потом берем все типы которые содержат кастомный атрибут
            foreach (var type in assembly.)
        }

        public async Task<ResponseMessage> ProcessRequest(RequestMessage request)
        {
            if(_)
        }
    }
}

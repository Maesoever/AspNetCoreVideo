using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public class HardCodedMessageService : IMessageService
    {
        public string GetMessage()
        {
            return "This is a hardcoded message from a service";
        }
    }
}

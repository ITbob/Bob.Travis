using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Travis
{
    public static class TravisPacketConvertor
    {
        public static TravisPacket Translate(String message)
        {
            var infos = message.Split(':');
            var packectType = PacketType.None;
            var priority = 0;


            if(infos[0] == "I")
            {
                packectType = PacketType.Init;
            }

            priority = Convert.ToInt32(infos[1]);

            return new TravisPacket()
            {
                Priority = priority,
                Type = packectType
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Travis.Global
{
    public interface ITravisReceiver
    {
        TravisPacket CurrentPacket { get; }
        void ReceiveMessage();
    }
}

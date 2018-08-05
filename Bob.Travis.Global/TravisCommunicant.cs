using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Travis.Global
{
    public class TravisCommunicant:ITravisCommunicant
    {
        private ITravisSender Sender { get; set; }
        private ITravisReceiver Receiver { get; set; }

        public void Communicate()
        {
            var message = Sender.GetCurrentMessage();
            this.Receiver.ReceiveMessage();
        }
    }
}

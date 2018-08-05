using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bob.Travis.Global;
using Moq;

namespace Bob.Travis.Integration
{
    [TestFixture]
    public class TravisCommunicationFeature
    {
        [Test]
        public void ShouldReceiveInit3Packet()
        {
            Mock<ITravisSender> mockingSender = new Mock<ITravisSender>();
            mockingSender.Setup(m => m.GetCurrentMessage()).Returns(() => new TravisPacket() {
                Priority = 3,
                Type = PacketType.Init
            });
            Mock<ITravisReceiver> mockingReceiver = new Mock<ITravisReceiver>();

            

            Assert.AreEqual(3, mockingReceiver.Object.CurrentPacket.Priority);
            Assert.AreEqual(PacketType.Init, mockingReceiver.Object.CurrentPacket.Type);

        }
    }
}

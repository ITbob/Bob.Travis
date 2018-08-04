using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Travis.Test
{
    [TestFixture]
    class TravisConvertorFeatures
    {
        [Test]
        public void ShouldGetInit4Packet()
        {
            String message = @"I:4";
            var result = TravisPacketConvertor.Translate(message);
            Assert.AreEqual(PacketType.Init, result.Type);
            Assert.AreEqual(4, result.Priority);
        }

        [Test]
        public void ShouldGetProcessing7Packect()
        {
            String message = @"P:7";
            var result = TravisPacketConvertor.Translate(message);
            Assert.AreEqual(PacketType.Processing, result.Type);
            Assert.AreEqual(7, result.Priority);
        }
    }
}

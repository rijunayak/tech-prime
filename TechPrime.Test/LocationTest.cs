using NUnit.Framework;
using static TechPrime.Location;

namespace TechPrime.Test
{
    [TestFixture]
    public class LocationTest
    {
        [Test]
        public void Should_Tax_In_Byte_Space_Correctly()
        {
            var byteSpace = ByteSpace;

            Assert.That(byteSpace.MotherboardTax, Is.EqualTo(0.02m));
            Assert.That(byteSpace.RamTax, Is.EqualTo(0.025m));
            Assert.That(byteSpace.CpuTax, Is.EqualTo(0.03m));
            Assert.That(byteSpace.GpuTax, Is.EqualTo(0.04m));
        }

        [Test]
        public void Should_Tax_In_Encryptionia_Correctly()
        {
            var encryptionia = Encryptionia;

            Assert.That(encryptionia.MotherboardTax, Is.EqualTo(0.03m));
            Assert.That(encryptionia.RamTax, Is.EqualTo(0.03m));
            Assert.That(encryptionia.CpuTax, Is.EqualTo(0.02m));
            Assert.That(encryptionia.GpuTax, Is.EqualTo(0.03m));
        }

        [Test]
        public void Should_Tax_In_Compression_Land_Correctly()
        {
            var compressionLand = CompressionLand;

            Assert.That(compressionLand.MotherboardTax, Is.EqualTo(0.025m));
            Assert.That(compressionLand.RamTax, Is.EqualTo(0.015m));
            Assert.That(compressionLand.CpuTax, Is.EqualTo(0.04m));
            Assert.That(compressionLand.GpuTax, Is.EqualTo(0.05m));
        }
    }
}

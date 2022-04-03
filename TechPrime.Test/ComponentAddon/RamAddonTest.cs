using NUnit.Framework;
using static TechPrime.ComponentAddon.ComponentAddon<TechPrime.ComponentAddon.IRamAddon>;

namespace TechPrime.Test.ComponentAddon
{
    [TestFixture]
    public class RamAddonTest
    {
        [Test]
        public void Should_Price_DDR_Chip_At_Two_Hundred()
        {
            var ramAddon = DdrChipType();

            Assert.That(ramAddon.Price(), Is.EqualTo(200));
        }

        [Test]
        public void Should_Price_DDR_Chip_And_Error_Checking_Parity_At_Three_Hundred()
        {
            var ramAddon = DdrChipType(ErrorCheckingParity());

            Assert.That(ramAddon.Price(), Is.EqualTo(300));
        }
    }
}

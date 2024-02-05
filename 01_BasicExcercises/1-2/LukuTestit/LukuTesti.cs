using _1_2;

namespace LukuTestit
{
    [TestClass]
    public class LukuTesti
    {
        [TestMethod]
        public void LukuTasmaa()
        {
            int alkuLuku = 5;
            int vahennettavaLuku = 4;
            int odotettuLuku = 1;

            Luvut testiLuvut = new Luvut(alkuLuku, vahennettavaLuku);

            testiLuvut.Vahenna();

            int testinTulos = testiLuvut.miinusTulos;

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe vähennyksessä, luvut eivät tuota odotettua lopputulosta.");
        }

        [TestMethod]
        public void VahennettavaLukuEiNolla()
        {
            int alkuLuku = 5;
            int vahennettavaLuku = 4;
            int odotettuLuku = 1;

            Luvut testiLuvut = new Luvut(alkuLuku, vahennettavaLuku);

            testiLuvut.Vahenna();

            int testinTulos = testiLuvut.miinusTulos;

            if (odotettuLuku < alkuLuku || vahennettavaLuku == 0)
            {
                return;
            }
            else
            {
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => testinTulos);
            }

        }

        [TestMethod]
        public void lukuVahentaa()
        {
            int alkuLuku = 5;
            int vahennettavaLuku = 4;
            int odotettuLuku = 1;

            Luvut testiLuvut = new Luvut(alkuLuku, vahennettavaLuku);

            testiLuvut.Vahenna();

            int testinTulos = testiLuvut.miinusTulos;

            if (testinTulos > alkuLuku)
            {
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => testinTulos);
            }
            else
            {
                return;
            }

        }
    }
}
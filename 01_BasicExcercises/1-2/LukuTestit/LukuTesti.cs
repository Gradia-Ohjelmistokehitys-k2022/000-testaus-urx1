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
        public void TulosNegatiivinen()
        {
            int alkuLuku = 5;
            int vahennettavaLuku = 10;
            int odotettuLuku = -5;

            Luvut testiLuvut = new Luvut(alkuLuku, vahennettavaLuku);

            testiLuvut.Vahenna();

            int testinTulos = testiLuvut.miinusTulos;

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe vähennyksessä, luvut eivät tuota odotettua lopputulosta.");


        }

        [TestMethod]
        public void negatiivisetLuvut()
        {
            int alkuLuku = -5;
            int vahennettavaLuku = -6;
            int odotettuLuku = 1;

            Luvut testiLuvut = new Luvut(alkuLuku, vahennettavaLuku);

            testiLuvut.Vahenna();

            int testinTulos = testiLuvut.miinusTulos;

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe vähennyksessä, luvut eivät tuota odotettua lopputulosta.");

        }
    }
}
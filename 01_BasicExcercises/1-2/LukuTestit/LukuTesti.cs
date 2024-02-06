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
        [TestMethod]
        public void P_LukuTasmaa()
        {
            int alkuLuku = 5;
            int toinenLuku = alkuLuku;
            int odotettuLuku = 25;

            Luvut testiLuvut = new Luvut(alkuLuku, toinenLuku);

            testiLuvut.Potenssi();

            int testinTulos = testiLuvut.potenssiTulos;

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe potenssilaskussa, luvut eivät tuota odotettua lopputulosta.");
        }

        [TestMethod]
        public void P_YliSata()
        {
            int alkuLuku = 100;
            int toinenLuku = alkuLuku;

            Luvut testiLuvut = new Luvut(alkuLuku, toinenLuku);

            if (alkuLuku > 100)
            {
                throw new ArgumentOutOfRangeException("Luku ei saa olla yli 100.");
            }
            else
            {
                testiLuvut.Potenssi();
            }
        }

        [TestMethod]
        public void P_Negatiivinen()
        {
            int alkuLuku = -5;
            int toinenLuku = alkuLuku;
            int odotettuLuku = -25;

            Luvut testiLuvut = new Luvut(alkuLuku, toinenLuku);

            testiLuvut.Potenssi();

            int testinTulos = testiLuvut.potenssiTulos;

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe vähennyksessä, luvut eivät tuota odotettua lopputulosta.");

        }
    }
}
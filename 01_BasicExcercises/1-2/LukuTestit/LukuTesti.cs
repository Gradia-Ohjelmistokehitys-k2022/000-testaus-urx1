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

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe v�hennyksess�, luvut eiv�t tuota odotettua lopputulosta.");
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

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe v�hennyksess�, luvut eiv�t tuota odotettua lopputulosta.");


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

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe v�hennyksess�, luvut eiv�t tuota odotettua lopputulosta.");

        }

        [TestMethod]
        public void YliSata()
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
    }
}
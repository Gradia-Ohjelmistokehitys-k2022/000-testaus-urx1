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

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe v‰hennyksess‰, luvut eiv‰t tuota odotettua lopputulosta.");
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

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe v‰hennyksess‰, luvut eiv‰t tuota odotettua lopputulosta.");
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

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe v‰hennyksess‰, luvut eiv‰t tuota odotettua lopputulosta.");

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

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe potenssilaskussa, luvut eiv‰t tuota odotettua lopputulosta.");
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

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe laskussa, luvut eiv‰t tuota odotettua lopputulosta.");

        }
        [TestMethod]
        public void N_LukuTasmaa()
        {
            int alkuLuku = 3;
            double odotettuLuku = 1.7320508075688772;

            Luvut testiLuvut = new Luvut(alkuLuku);

            testiLuvut.NelioJuuri();

            double testinTulos = testiLuvut.nelioJuuriTulos;

            Assert.AreEqual(odotettuLuku, testinTulos, 0.001, "Virhe laskussa, luvut eiv‰t tuota odotettua lopputulosta.");
        }
        [TestMethod]
        public void N_Negatiivinen()
        {
            int alkuLuku = -5;
            double odotettuLuku = double.NaN;

            Luvut testiLuvut = new Luvut(alkuLuku);

            testiLuvut.NelioJuuri();

            double testinTulos = testiLuvut.nelioJuuriTulos;

            Assert.AreEqual(odotettuLuku, testinTulos, "Virhe laskussa, luvut eiv‰t tuota odotettua lopputulosta.");

        }
        [TestMethod]
        public void N_OnDouble()
        {
            var alkuLuku = 3;
            var odotettuLuku = 1.7320508075688772;

            Luvut testiLuvut = new Luvut(alkuLuku);

            testiLuvut.NelioJuuri();

            Assert.AreEqual(odotettuLuku.GetType(), typeof(double), "Tulos on v‰‰r‰‰ tyyppi‰.");

        }
        [TestMethod]
        public void pieninOnPienin()
        {
            double[] numeroita2 = { 4.234, 1.23, 9.1235, 0.23, 10.234 };
            List<double> testiLista = new List<double>(numeroita2);
            double odotettuLuku = 0.23;
            int i = 0;
            double listanPienin = testiLista[0];
            for (i = 0; i < testiLista.Count; i++)
            {
                if (listanPienin > testiLista[i])
                {
                    listanPienin = testiLista[i];
                }
            }
            Assert.AreEqual(odotettuLuku, listanPienin, "Virhe loopissa, laskettu luku ei ole listan pienin.");
        }
        [TestMethod]
        public void suurinOnSuurin()
        {
            double[] numeroita2 = { 4.234, 1.23, 9.1235, 0.23, 10.234 };
            List<double> testiLista = new List<double>(numeroita2);
            double odotettuLuku = 10.234;
            int i = 0;
            double listanPienin = testiLista[0];
            for (i = 0; i < testiLista.Count; i++)
            {
                if (listanPienin < testiLista[i])
                {
                    listanPienin = testiLista[i];
                }
            }
            Assert.AreEqual(odotettuLuku, listanPienin, "Virhe loopissa, laskettu luku ei ole listan pienin.");
        }
        [TestMethod]
        public void onKeskiarvo()
        {
            float[] numeroita = { 4.234F, 1.23F, 9.1235F, 0.23F, 10.234F };
            List<float> m_fLista = new List<float>(numeroita);
            float odotettuLuku = 5.0103F;
            float summa = m_fLista.Sum();
            float lukumaara = m_fLista.Count();
            float keskiarvo = summa / lukumaara;
            Assert.AreEqual(odotettuLuku, keskiarvo, "Virhe laskussa, laskettu luku ei ole listan keskiarvo.");
        }
    }
}
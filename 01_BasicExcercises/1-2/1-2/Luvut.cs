namespace _1_2
{
    public class Luvut
    {
        public int m_nro1;
        public int m_nro2;
        public int kerroin;
        public int miinusTulos;
        public int potenssiTulos;
        public double nelioJuuriTulos;
        public double odotettuLuku;
        public List<double> m_dLista;

        private Luvut() { }

        public Luvut(int nro1, int nro2) 
        {
            m_nro1 = nro1;
            m_nro2 = nro2;        
        }

        public Luvut(int nro1)
        { 
            m_nro1 = nro1;
        }

        public Luvut(List<double> dLista) 
        {
            m_dLista = dLista;
        }
        

        /*
        public int Nro1
        {
            get { return m_nro1; }
        }

        public int Nro2
        {
            get { return m_nro2; }
        }

        public int YhteenLaskuTulos
        {
            get { return m_yhteenLaskuTulos; }
        }
        */

        public void Vahenna()
        {
            miinusTulos = m_nro1 - m_nro2;
            Console.WriteLine(miinusTulos);
        }

        public void Potenssi()
        {
            if (m_nro1 > 100)
            {
                Console.WriteLine("Luku saa olla max 100");
            }
            if (m_nro1 < 0)
            {
                m_nro1 = System.Math.Abs(m_nro1);
                m_nro2 = m_nro1;
                int juuri = m_nro1 * m_nro2;
                potenssiTulos = juuri * -1;
                Console.WriteLine(potenssiTulos);
            }
            else
            {
                m_nro2 = m_nro1;
                /*
                kerroin = (m_nro1-1);
                for (int i = 0; i < (kerroin); i++)
                {
                    potenssiTulos = m_nro1 += m_nro2;
                }
                //potenssiTulos = m_nro1 * m_nro2;
                */
                potenssiTulos = m_nro1 * m_nro2;
                Console.WriteLine(potenssiTulos);
            }
        }

        public void NelioJuuri()
        {
            nelioJuuriTulos = Math.Sqrt(m_nro1);
            Console.WriteLine(nelioJuuriTulos);
        }

        public static void doubleListaPienin()
        {
            int i = 0;
            double[] numeroita = { 4.234, 1.23, 9.1235, 0.23, 10.234 };
            List<double> m_dLista = new List<double>(numeroita);
            double pienin = m_dLista[0];
            for (i = 0; i < m_dLista.Count; i++)
            {
                if (pienin > m_dLista[i])
                {
                    pienin = m_dLista[i];
                }
            }
                Console.WriteLine(pienin);
        }

        public static void doubleListaSuurin()
        {
            int i = 0;
            double[] numeroita = { 4.234D, 1.23D, 9.1235D, 0.23D, 10.234D };
            List<double> m_dLista = new List<double>(numeroita);
            double suurin = m_dLista[0];
            for (i = 0; i < m_dLista.Count; i++)
            {
                if (suurin < m_dLista[i])
                {
                    suurin = m_dLista[i];
                }
            }
            Console.WriteLine(suurin);
        }
        public static void FloatLista()
        {
            int i = 0;
            float[] numeroita = { 4.234F, 1.23F, 9.1235F, 0.23F, 10.234F };
            List<float> m_fLista = new List<float>(numeroita);
            float summa = m_fLista.Sum();
            float lukumaara = m_fLista.Count();
            float keskiarvo = summa / lukumaara;
            Console.WriteLine(keskiarvo);
        }

        public static void Main()
        {
            //Luvut Luvut1 = new Luvut(5, 0);
            //Luvut1.Vahenna();
            //Luvut1.Potenssi();
            //Luvut Luvut2 = new Luvut(-3);
            //Luvut2.NelioJuuri();
            //doubleListaPienin();
            //doubleListaSuurin();
            FloatLista();
        }


    }
}

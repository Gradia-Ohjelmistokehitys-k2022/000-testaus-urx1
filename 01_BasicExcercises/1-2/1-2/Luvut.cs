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

        public static void Main()
        {
            //Luvut Luvut1 = new Luvut(5, 0);
            //Luvut1.Vahenna();
            //Luvut1.Potenssi();
            Luvut Luvut2 = new Luvut(-3);
            Luvut2.NelioJuuri();
        }
    }
}

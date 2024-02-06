namespace _1_2
{
    public class Luvut
    {
        public int m_nro1;
        public int m_nro2;
        public int miinusTulos;
        public int potenssiTulos;

        private Luvut() { }

        public Luvut(int nro1, int nro2) 
        {
            m_nro1 = nro1;
            m_nro2 = nro2;        
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
                Console.WriteLine("Luku saa olla max 100");
            else
            {
                m_nro2 = m_nro1;
                potenssiTulos = m_nro1 * m_nro2;
                Console.WriteLine(potenssiTulos);
            }
        }

        public static void Main()
        {
            Luvut Luvut1 = new Luvut(111, 0);
            //Luvut1.Vahenna();
            Luvut1.Potenssi();
        }
    }
}

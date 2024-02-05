namespace _1_2
{
    public class Luvut
    {
        public int m_nro1;
        public int m_nro2;
        public int yhteenLaskuTulos;

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

        public void LaskeYhteen()
        {
            yhteenLaskuTulos = m_nro1 + m_nro2;
        }

        public static void Main()
        {
            Luvut Luvut1 = new Luvut(1, 3);
            Luvut1.LaskeYhteen();
            Console.WriteLine(Luvut1.yhteenLaskuTulos);
        }
    }
}

using System;

namespace Gestione_Tariffa
{
    public class Gestione
    {
        public static string TariffaConveniente(int mesi)
        {
            if(mesi == 1 )
            {
                return "La tariffa più convenite è quella Open 1 mese";
            }
            else if(mesi == 2)
            {
                return "La tariffa più convenite è quella Open 1 mese X 2";
            }
            else if (mesi == 3)
            {
                return "La tariffa più convenite è quella Open 3 mese";
            }
            else if (mesi == 4)
            {
                return "La tariffa più convenite è quella Open 3 mese + Open 1 mese";
            }
            else if (mesi == 5)
            {
                return "La tariffa più convenite è quella Open 3 mese + Open 1 mese X 2";
            }
            else if (mesi == 6)
            {
                return "La tariffa più convenite è quella Open 3 mese X 2";
            }
            else if (mesi == 7)
            {
                return "La tariffa più convenite è quella Open 3 mese X 2 + Open 1 mese";
            }
            else if (mesi == 8)
            {
                return "La tariffa più convenite è quella Open 3 mese X 2 + Open 1 mese X 2";
            }
            else if (mesi == 9)
            {
                return "La tariffa più convenite è quella Open 3 mese X 3";
            }
            else if (mesi == 10)
            {
                return "La tariffa più convenite è quella Open 3 mese X 3 + Open 1 mese";
            }
            else if (mesi == 11)
            {
                return "La tariffa più convenite è quella Open 3 mese X 3 + Open 1 mese X 2";
            }
            else
                return "La tariffa più convenite è quella Open 12 mese";
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class LinearnoPretrazivanje : Pretrazivanja
    {
        public void find(double[] polje,int trazeniBroj)
        {
            int brojac = 0;
            for(int i = 0; i < polje.Length; i++)
            {
                if (polje[i] == trazeniBroj)
                {
                    Console.WriteLine("Trazeni broj " + trazeniBroj + " naden je na " + brojac + ". mjestu");
                }
               
                brojac++;
            }



        }
    }
}

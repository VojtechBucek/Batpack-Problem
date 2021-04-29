using System;
using System.Collections.Generic;
using System.Text;

namespace Batuzek
{
    class item
    {
        
        public int cena;    
        public int vaha;

        public item( int cena, int vaha)
        {
            
            this.cena = cena;
            this.vaha = vaha;
        }

        public override string ToString()
        {
            return "cena: "+ cena + " vaha: "+ vaha;
        }
    }

}

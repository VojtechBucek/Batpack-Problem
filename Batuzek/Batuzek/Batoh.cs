using System;
using System.Collections.Generic;
using System.Text;

namespace Batuzek
{

    class Batoh
    {

        private int volneMisto;
        private int nosnost = 0;
        private LinkedList<item> vybrane;

        public Batoh(int nosnost)
        {

            this.nosnost = nosnost;
            this.vybrane = new LinkedList<item>();
            this.volneMisto = nosnost;
        }

      

        public bool add(item predmet)
        {
            if (predmet.vaha <= volneMisto)
            {
                vybrane.AddLast(predmet);
                volneMisto -= predmet.vaha;
                return true;
            }
            else 
            {
                return false;
            }


        }
        public override string ToString()
        {
            StringBuilder vypis = new StringBuilder("");
            foreach (item i in vybrane)
            {
                vypis.Append(i + "\n" );
            }

            return vypis.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_refresh.Indexers
{
    public class IP
    {
        public int[] segmets = new int[4];
        public int this[int index]
        {
            get
            {
                return segmets[index];
            }
            set
            {
                segmets[index] = value;
            }
        }

        public IP(int segmet1, int segmet2, int segmet3, int segmet4)
        {
            segmets[0] = segmet1;
            segmets[1] = segmet2;
            segmets[2] = segmet3;
            segmets[3] = segmet4;
        }

        public string Address => string.Join(".", segmets);
    }
}

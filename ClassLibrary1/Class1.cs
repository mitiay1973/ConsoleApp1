using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int GetQuantityForProduct(int productType,
int materialType,
int count,
float width,
float length, int percent_br)
        {
            int brak = count/percent_br;
            return brak;
        }
    }
}

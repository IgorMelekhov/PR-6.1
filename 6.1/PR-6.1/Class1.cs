using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6._1
{
    internal class Airplane
    {
        int result;
        public Airplane() 
        {
            this.result = Serviceability();
        }
        int Serviceability()
        {
            Random random = new Random();
            int randomint = random.Next(2);
            return randomint;
        }
        public int Get()
        {
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6._1
{
    internal class AirlineHub
    {
        static int result;
        static AirlineHub instance;
        public AirlineHub()
        {
            result = weather();
            Get();
        }
        public int weather()
        { 
            Random random = new Random();
            int randomint=random.Next(2);
            return randomint;
        }
        //public static AirlineHub airlineHub()
        //{
        //    if(instance==null)
        //        instance = new AirlineHub();
        //    return instance;
        //}
        public int Get()
        {
            return result;
        }
    }
}

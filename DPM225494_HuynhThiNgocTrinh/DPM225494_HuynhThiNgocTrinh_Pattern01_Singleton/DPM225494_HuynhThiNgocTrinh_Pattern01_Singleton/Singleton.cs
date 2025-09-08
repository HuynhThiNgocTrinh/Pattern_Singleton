using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225494_HuynhThiNgocTrinh_Pattern01_Singleton
{
    internal class Singleton
    {
        static Singleton instance;
        protected Singleton()
        {
        }
        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}

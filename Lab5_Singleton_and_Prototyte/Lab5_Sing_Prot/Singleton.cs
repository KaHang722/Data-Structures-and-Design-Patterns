using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Sing_Prot
{
    public sealed class Singleton
    {
        private Singleton() { }
        private static Singleton Instance;

        public static Singleton getInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }

    }
}

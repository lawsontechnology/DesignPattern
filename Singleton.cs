using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern
{   
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
               if(instance == null) 
                {
                    instance = new Singleton();
                }
               return instance;
            }
         }

        private Singleton()
        {
        }

        public void PrintDetails(string message) 
          {
             Console.WriteLine(message);
          }
    }
}

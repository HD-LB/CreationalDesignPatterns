using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLogger
{
    public class Logger
    {
        private static Logger instance;
        private static object lockObject = new object();

        private Logger() //private Constructor
        {

        }

        public static Logger Instance
        {
            get
            {
                if (instance == null) 
                {
                    lock (lockObject)
                    {
                        if (instance == null) //Lazy initialisation
                        {
                            instance = new Logger();
                        }
                    }
                }
                return instance;
            }
        }

        public void Log(string log)
        {
            Console.WriteLine(DateTime.UtcNow + " " + log);
        }


    }
}

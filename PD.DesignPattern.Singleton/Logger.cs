using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.DesignPattern.Singleton
{
    class Logger
    {
        private static Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

        public static Logger Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private Logger() { }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}

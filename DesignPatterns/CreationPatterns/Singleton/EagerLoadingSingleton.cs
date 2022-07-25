using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPatterns.Singleton
{
    internal sealed class EagerLoadingSingleton
    {
        private static int counter = 0;
        private static readonly EagerLoadingSingleton _instance = new EagerLoadingSingleton();
        public static EagerLoadingSingleton GetInstance
        {
            get
            {
                return _instance;
            }
        }

        private EagerLoadingSingleton()
        {
            counter++;

            Console.WriteLine($"Number of instances: {counter}");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

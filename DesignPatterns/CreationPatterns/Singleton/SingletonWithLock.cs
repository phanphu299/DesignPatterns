namespace DesignPatterns.CreationPatterns.Singleton
{
    internal class SingletonWithLock
    {
        private static int counter = 0;
        private static SingletonWithLock _instance = null;
        private static readonly object Instancelock = new object();
        public static SingletonWithLock GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Instancelock)
                    {
                        if (_instance == null)
                            _instance = new SingletonWithLock();
                    }
                }
                
                return _instance;
            }
        }

        private SingletonWithLock()
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

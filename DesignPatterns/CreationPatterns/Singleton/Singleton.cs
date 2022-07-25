namespace DesignPatterns.CreationPatterns.Singleton
{
    internal sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton _instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null )
                    _instance = new Singleton();
                return _instance;
            }
        }

        private Singleton()
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

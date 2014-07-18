namespace Slms.Common
{
    using System;

    public static class RandomGenerator
    {
        private static readonly object SyncRoot = new object();

        private static volatile Random instance;

        public static Random Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Random();
                        }
                    }
                }

                return instance;
            }
        }
    }
}

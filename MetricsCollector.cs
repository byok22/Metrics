namespace Metrics
{
    public class MetricsCollector
    {
        public MetricsCollector()
        {
            new Thread(MetricsPoller)
            {
                IsBackground = true,
                Name = "Collector"

            }.Start();

            
        }
        private static void MetricsPoller()
        {
            while (true)
            {
                // This is the place to add your custom metrics
                Console.WriteLine("Started from Hook");
                var gen0 = GC.CollectionCount(0);
                var gen1 = GC.CollectionCount(1);
                var gen2 = GC.CollectionCount(2);
                
                Console.WriteLine($"Gen0: {gen0}");
                Console.WriteLine($"Gen1: {gen1}");
                Console.WriteLine($"Gen2: {gen2}");
                Thread.Sleep(2000);
            }
        }
    }
}
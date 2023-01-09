using Metrics;
internal class StartupHook
{
    private static MetricsCollector _collector;
    public static void Initialize()
    {
        // This is the place to add your custom metrics
        Console.WriteLine("Started from Hook");
        _collector = new MetricsCollector();
    }
}
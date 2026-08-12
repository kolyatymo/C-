using _42_Pattern_factoryMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        SeaLogistics seaLogistics = new SeaLogistics();
        seaLogistics.PlanDelivery(10_000);

        Logistics logistics = new RoadLogistics();
        logistics.PlanDelivery(10_000);

        logistics.PlanDelivery(400);

    }
}
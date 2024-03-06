namespace VehicleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new Vehicle();
            VehicleController vehicleController = new VehicleController(vehicle);
            vehicleController.Run();
        }
    }
}

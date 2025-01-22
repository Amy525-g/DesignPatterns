using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethod
{
    public class ExplorerFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new CarModelBuilder()
                .setColor("Black")
                .setBrand("Ford")
                .setModel("Explorer")
                .setYear(2022)
                .Build();
        }
    }
}

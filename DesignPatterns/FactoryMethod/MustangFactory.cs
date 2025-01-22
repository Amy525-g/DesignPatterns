using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethod
{
    public class MustangFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new CarModelBuilder()
                .setColor("Red")
                .setBrand("Ford")
                .setModel("Mustang")
                .setYear(2023)
                .Build();
        }
    }
}

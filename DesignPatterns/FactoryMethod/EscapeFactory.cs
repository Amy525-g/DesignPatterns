using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;
using System;

namespace DesignPatterns.FactoryMethod
{
    public class EscapeFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new CarModelBuilder()
                .setColor("Red")
                .setBrand("Ford")
                .setModel("Escape")
                .setYear(DateTime.Now.Year)
                .Build();
        }
    }
}

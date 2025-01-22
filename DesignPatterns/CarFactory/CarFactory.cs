using DesignPatterns.Models;

namespace DesignPatterns.CarFactory
{
    public abstract class CarFactory
    {
        public abstract Vehicle Create();
    }
}

using DesignPatterns.Models;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singleton
{
    public class MemoryCollection
    {
        private static MemoryCollection _instance;
        public ICollection<Vehicle> Vehicles { get; set; }

        public MemoryCollection()
        {
            Vehicles = new List<Vehicle>();
        }
        public static MemoryCollection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MemoryCollection();
                }
                return _instance;
            }
        }
    }
}

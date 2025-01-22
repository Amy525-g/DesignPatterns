using DesignPatterns.Infraestructure.Singleton;
using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        private readonly MemoryCollection _memoryCollection = MemoryCollection.Instance;

        public void AddVehicle(Vehicle vehicle)
        {
            // Validar duplicados antes de agregar
            if (_memoryCollection.Vehicles.Any(v => v.ID == vehicle.ID))
            {
                throw new InvalidOperationException("El vehículo ya existe en el repositorio.");
            }
            _memoryCollection.Vehicles.Add(vehicle);
        }

        public Vehicle Find(string id)
        {
            // Buscar vehículo por ID
            var vehicle = _memoryCollection.Vehicles.FirstOrDefault(v => v.ID.Equals(new Guid(id)));
            if (vehicle == null)
            {
                throw new KeyNotFoundException($"No se encontró ningún vehículo con el ID: {id}");
            }
            return vehicle;
        }

        public ICollection<Vehicle> GetVehicles()
        {
            // Devolver una copia de la lista para evitar modificaciones externas
            return _memoryCollection.Vehicles.ToList();
        }

        public void UpdateVehicle(Vehicle updatedVehicle)
        {
            // Actualizar vehículo
            var existingVehicle = Find(updatedVehicle.ID.ToString());
            _memoryCollection.Vehicles.Remove(existingVehicle);
            _memoryCollection.Vehicles.Add(updatedVehicle);
        }

        public void DeleteVehicle(string id)
        {
            // Eliminar vehículo por ID
            var vehicle = Find(id);
            _memoryCollection.Vehicles.Remove(vehicle);
        }
    }
}

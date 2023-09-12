
using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace EDriveRent.Repositories
{
    public class VehicleRepository : IRepository<IVehicle>
    {
        private List<IVehicle> vehicles;
        public VehicleRepository()
        {
            vehicles = new List<IVehicle>();
        }
        public void AddModel(IVehicle model)
        {
           this.vehicles.Add(model);
        }

        public IVehicle FindById(string identifier)
            => this.vehicles.FirstOrDefault(v => v.LicensePlateNumber == identifier);
        

        public IReadOnlyCollection<IVehicle> GetAll()
            =>(IReadOnlyCollection<IVehicle>)this.vehicles;
       

        public bool RemoveById(string identifier)
            =>this.vehicles.Remove(FindById(identifier));
       
    }
}

using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Repositories
{
    public class UserRepository : IRepository<IUser>
    {
        private List<IUser> models;
        public UserRepository()
        {
            models = new List<IUser>();
        }
        public void AddModel(IUser model)
        {
           this.models.Add(model);
        }

        public IUser FindById(string identifier) => this.models.
            FirstOrDefault(m => m.DrivingLicenseNumber == identifier);
       

        public IReadOnlyCollection<IUser> GetAll()=>
            this.models.AsReadOnly();
       

        public bool RemoveById(string identifier)=>this.models.Remove(FindById(identifier));
          
       
    }
}

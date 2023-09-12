using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace EDriveRent.Repositories
{
    public class UserRepository : IRepository<IUser>
    {
        private List<IUser> users;
        public UserRepository() 
        {
            users = new List<IUser>();
        }

        public void AddModel(IUser model)
        {
            this.users.Add(model);
        }

        public IUser FindById(string identifier)
            => this.users.FirstOrDefault(u => u.DrivingLicenseNumber == identifier);
        

        public IReadOnlyCollection<IUser> GetAll()=>(IReadOnlyCollection<IUser>)this.users;
       
        public bool RemoveById(string identifier)=>this.users.Remove(FindById(identifier));
       
    }
}

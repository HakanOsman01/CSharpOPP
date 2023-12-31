﻿using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace EDriveRent.Repositories
{
    public class RouteRepository : IRepository<IRoute>
    {
        private List<IRoute> routes;
        public RouteRepository()
        {
            this.routes = new List<IRoute>();
        }
        public void AddModel(IRoute model)
        {
            this.routes.Add(model);
        }

        public IRoute FindById(string identifier) 
            => this.routes.FirstOrDefault(r => r.RouteId == int.Parse(identifier));
        

        public IReadOnlyCollection<IRoute> GetAll()
            =>(IReadOnlyCollection<IRoute>)this.routes;
       
        public bool RemoveById(string identifier)
            =>this.routes.Remove(FindById(identifier));    
        
    }
}

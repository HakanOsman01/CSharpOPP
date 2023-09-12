using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Repositories
{
    public class RoomRepository : IRepository<IRoom>
    {
        private ICollection<IRoom> rooms;
        public RoomRepository()
        {
            rooms = new HashSet<IRoom>();
            
        }
        public void AddNew(IRoom model)
        {
            rooms.Add(model);
        }

        public IReadOnlyCollection<IRoom> All()
            =>(IReadOnlyCollection<IRoom>)rooms;



        public IRoom Select(string roomTypeName)
            => this.rooms.FirstOrDefault(r => r.GetType().Name == roomTypeName);
       
    }
}

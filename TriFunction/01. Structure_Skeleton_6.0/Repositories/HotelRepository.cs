using BookingApp.Models.Hotels.Contacts;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Repositories
{
    public class HotelRepository : IRepository<IHotel>
    {
        private ICollection<IHotel> hotels;
        public HotelRepository()
        {
            this.hotels = new HashSet<IHotel>();
        }
        public void AddNew(IHotel model)
        {
            this.hotels.Add(model);
        }

        public IReadOnlyCollection<IHotel> All()
            => (IReadOnlyCollection<IHotel>)this.hotels;


        public IHotel Select(string hotelName) => 
            this.hotels.FirstOrDefault(h => h.FullName == hotelName);
       
    }
}

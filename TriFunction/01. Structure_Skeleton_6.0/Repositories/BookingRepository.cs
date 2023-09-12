using BookingApp.Models.Bookings.Contracts;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Repositories
{
    public class BookingRepository : IRepository<IBooking>
    {
        private ICollection<IBooking> books;
        public BookingRepository()
        {
            
        }
        public void AddNew(IBooking model)
        {
           this.books.Add(model);
        }

        public IReadOnlyCollection<IBooking> All()
            =>(IReadOnlyCollection<IBooking>)this.books;

        public IBooking Select(string bookingNumberToString) =>
            this.books.FirstOrDefault(f => 
            f.BookingNumber == int.Parse(bookingNumberToString));
       
    }
}

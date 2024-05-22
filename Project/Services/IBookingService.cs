using System.Collections.Generic;
using TurfBooking.Models;

namespace TurfBooking.Services
{
    public interface IBookingService
    {
        IEnumerable<BookingDTO> GetBookings();
        BookingDTO GetBooking(int id);
        BookingDTO AddBooking(NewBookingDTO booking);
        //void UpdateBooking(UpdateBookingDTO booking);
        void UpdateBooking(Booking booking);
        void DeleteBooking(int id);
        //bool CheckAvailability(int turfId, DateTime date, string startTime, string endTime);
        //IEnumerable<BookingDTO> GetBookingsByUser(int userId);
        IEnumerable<BookingDTO> GetBookingsByUser(int userId);
    }
}

namespace TurfBooking.Models
{
    
    public class BookingDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int SlotId { get; set; }
        
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int TurfId { get; set; }
        public string TurfName { get; set; }
    }

    public class NewBookingDTO
    {
        
        public DateTime Date{ get; set; }
        public int SlotId { get; set; }
        public int UserId { get; set; }
        public int TurfId { get; set; }
    }
   

}

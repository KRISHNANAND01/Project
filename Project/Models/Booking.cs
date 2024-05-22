
/*{
    public class Booking
    {
       
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime {  get; set; } 
        
        public int UserId { get; set; }
        public User User { get; set; }
        public int TurfId { get; set; }
        public Turf Turf { get; set; }
        
    }
}*/

namespace TurfBooking.Models
{
    public class Booking
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        public int SlotId { get;set; }
       

        public int UserId { get; set; }
        public User User { get; set; }
        public int TurfId { get; set; }
        public Turf Turf { get; set; }
    }
}


using BusinessObjects;

namespace DataAccessLayer
{
    public class BookRoomDAO
    {
        private static List<BookRoom> bookings = new List<BookRoom>
    {
        new BookRoom
        {
            CustomerId = 1,
            RoomId = 101,
            DateFrom = new DateTime(2023, 7, 1),
            DateTo = new DateTime(2023, 7, 5),
        },
        new BookRoom
        {
            CustomerId = 2,
            RoomId = 102,
            DateFrom = new DateTime(2023, 8, 15),
            DateTo = new DateTime(2023, 8, 20)
        },
        new BookRoom
        {
            CustomerId = 3,
            RoomId = 201,
            DateFrom = new DateTime(2023, 9, 10),
            DateTo = new DateTime(2023, 9, 15)
        }
    };

        public static List<BookRoom> GetListBooking()
        {
            var listC = CustomerDAO.GetListCustomer();
            foreach (var booking in bookings)
            {
                foreach(var c in listC)
                {
                    if(booking.CustomerId == c.CustomerId)
                    {
                        booking.Customer = c;
                    }
                }
            }
            return bookings;
        }

        public static void Create(BookRoom booking)
        {
            bookings.Add(booking);
        }
    }
}

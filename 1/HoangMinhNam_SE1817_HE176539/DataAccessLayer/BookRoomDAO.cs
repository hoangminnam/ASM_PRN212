
using BusinessObjects;

namespace DataAccessLayer
{
    public class BookRoomDAO
    {
        public static List<BookRoom> GetListBooking()
        {
            var bookings = new List<BookRoom>
            {
                new BookRoom
                {
                    CustomerId = 1,
                    RoomId = 101,
                    DateFrom = new DateTime(2023, 7, 1),
                    DateTo = new DateTime(2023, 7, 5)
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

            return bookings;
        }
    }
}

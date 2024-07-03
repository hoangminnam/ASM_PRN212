using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RoomTypeDAO
    {
         public static List<RoomType> GetListRoomType()
        {
            var roomTypes = new List<RoomType>
            {
                new RoomType
                {
                    RoomTypeId = 1,
                    RoomTypeName = "Single",
                    TypeDescription = "Single room, suitable for 1-2 people",
                    TypeNote = "Sea view"
                },
                new RoomType
                {
                    RoomTypeId = 2,
                    RoomTypeName = "Double",
                    TypeDescription = "Double room, suitable for 2-4 people",
                    TypeNote = "With balcony"
                },
                new RoomType
                {
                    RoomTypeId = 3,
                    RoomTypeName = "Family",
                    TypeDescription = "Family room, suitable for 4-6 people",
                    TypeNote = "With kitchen"
                }
            };
            return roomTypes;
        }
    }
}

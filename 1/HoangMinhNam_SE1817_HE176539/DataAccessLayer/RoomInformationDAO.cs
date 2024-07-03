using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RoomInformationDAO
    {
        public static List<RoomInformation> GetListRoom()
        {
            var rooms = new List<RoomInformation>
            {
                new RoomInformation
                {
                    RoomId = 1,
                    RoomNumber = "101",
                    RoomDescription = "Single room, with sea view",
                    RoomMaxCapacity = 2,
                    RoomStatus = true,
                    RoomPricePerDate = 500000,
                    RoomTypeId = 1
                },
                new RoomInformation
                {
                    RoomId = 2,
                    RoomNumber = "102",
                    RoomDescription = "Double room, with balcony",
                    RoomMaxCapacity = 4,
                    RoomStatus = false,
                    RoomPricePerDate = 800000,
                    RoomTypeId = 2
                },
                new RoomInformation
                {
                    RoomId = 3,
                    RoomNumber = "201",
                    RoomDescription = "Family room, with kitchen",
                    RoomMaxCapacity = 6,
                    RoomStatus = true,
                    RoomPricePerDate = 1200000,
                    RoomTypeId = 3
                },
                new RoomInformation
                {
                    RoomId = 4,
                    RoomNumber = "202",
                    RoomDescription = "Deluxe room, with pool view",
                    RoomMaxCapacity = 3,
                    RoomStatus = false,
                    RoomPricePerDate = 1000000,
                    RoomTypeId = 4
                },
                new RoomInformation
                {
                    RoomId = 5,
                    RoomNumber = "301",
                    RoomDescription = "Suite, with city view",
                    RoomMaxCapacity = 5,
                    RoomStatus = true,
                    RoomPricePerDate = 1500000,
                    RoomTypeId = 5
                },
                new RoomInformation
                {
                    RoomId = 6,
                    RoomNumber = "302",
                    RoomDescription = "Single room, with garden view",
                    RoomMaxCapacity = 2,
                    RoomStatus = false,
                    RoomPricePerDate = 550000,
                    RoomTypeId = 1
                },
                new RoomInformation
                {
                    RoomId = 7,
                    RoomNumber = "401",
                    RoomDescription = "Double room, with sea view",
                    RoomMaxCapacity = 4,
                    RoomStatus = true,
                    RoomPricePerDate = 850000,
                    RoomTypeId = 2
                },
                new RoomInformation
                {
                    RoomId = 8,
                    RoomNumber = "402",
                    RoomDescription = "Family room, with kitchen and balcony",
                    RoomMaxCapacity = 6,
                    RoomStatus = true,
                    RoomPricePerDate = 1250000,
                    RoomTypeId = 3
                }
            };

            return rooms;
        }

    }
}

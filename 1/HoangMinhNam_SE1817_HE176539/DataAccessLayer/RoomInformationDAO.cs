using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class RoomInformationDAO
    {
        private static List<RoomInformation> rooms = new List<RoomInformation>
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
                RoomTypeId = 1
            },
            new RoomInformation
            {
                RoomId = 5,
                RoomNumber = "301",
                RoomDescription = "Suite, with city view",
                RoomMaxCapacity = 5,
                RoomStatus = true,
                RoomPricePerDate = 1500000,
                RoomTypeId = 2
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

        public static List<RoomInformation> GetListRoom()
        {
            return rooms;
        }

        public static void UpdateRoomInformation(RoomInformation updatedRoom)
        {
            var room = rooms.FirstOrDefault(r => r.RoomId == updatedRoom.RoomId);

            if (room != null)
            {
                room.RoomNumber = updatedRoom.RoomNumber;
                room.RoomDescription = updatedRoom.RoomDescription;
                room.RoomMaxCapacity = updatedRoom.RoomMaxCapacity;
                room.RoomStatus = updatedRoom.RoomStatus;
                room.RoomPricePerDate = updatedRoom.RoomPricePerDate;
                room.RoomTypeId = updatedRoom.RoomTypeId;
            }
        }

        public static void Add(RoomInformation roomInformation)
        {
            rooms.Add(roomInformation);
        }

        public static void Delete(RoomInformation roomInformation)
        {
            rooms.Remove(roomInformation);
        }
    }
}

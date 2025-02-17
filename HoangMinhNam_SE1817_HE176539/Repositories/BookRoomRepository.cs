﻿using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRoomRepository : IBookRoomRepository
    {
        public void CreateBookRoom(BookRoom bookRoom) => BookRoomDAO.Create(bookRoom);

        public List<BookRoom> GetListBookRoom() => BookRoomDAO.GetListBooking();
    }
}

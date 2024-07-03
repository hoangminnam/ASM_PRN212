using BusinessObjects;
using DataAccessLayer;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookRoomService : IBookRoomService
    {
        private readonly IBookRoomRepository bookRoomRepository;

        public BookRoomService()
        {
            bookRoomRepository = new BookRoomRepository();
        }

        public List<BookRoom> GetListBookRoom() => bookRoomRepository.GetListBookRoom();
    }
}

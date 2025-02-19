using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IBookRoomService
    {
        public List<BookRoom> GetListBookRoom();

        public void CreateBookRoom(BookRoom bookRoom);
    }
}

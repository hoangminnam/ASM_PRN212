using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        public RoomTypeService()
        {
            _roomTypeRepository = new RoomTypeRepository();
        }
        public List<RoomType> GetListRoomType() => _roomTypeRepository.GetListRoomType();
    }
}

using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RoomInformationService : IRoomInformationService
    {
        private readonly IRoomInformationRepository _roomInformationRepository;

        public RoomInformationService()
        {
            _roomInformationRepository = new RoomInformationRepository();
        }
        public List<RoomInformation> GetListRoomInformation() => _roomInformationRepository.GetListRoomInformation();    
    }
}

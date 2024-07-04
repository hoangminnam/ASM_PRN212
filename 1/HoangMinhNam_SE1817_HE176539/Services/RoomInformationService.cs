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

        public void AddRoomInformation(RoomInformation newRoomInformation)
        {
            _roomInformationRepository.AddRoomInfomation(newRoomInformation);
        }

        public List<RoomInformation> GetListRoomInformation() => _roomInformationRepository.GetListRoomInformation();

        public void RemoveRoomInformation(RoomInformation newRoomInformation)
        {
            _roomInformationRepository.RemoveRoomInformation(newRoomInformation);
        }

        public void UpdateRoomInfomation(RoomInformation roomInformation)
        {
            _roomInformationRepository.UpdateRoomInfomation(roomInformation);
        }
    }
}

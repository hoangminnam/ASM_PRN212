using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RoomInformationRepository : IRoomInformationRepository
    {
        public void AddRoomInfomation(RoomInformation newRoomInformation)
        {
            RoomInformationDAO.Add(newRoomInformation);
        }

        public List<RoomInformation> GetListRoomInformation() => RoomInformationDAO.GetListRoom();

        public void RemoveRoomInformation(RoomInformation newRoomInformation)
        {
            RoomInformationDAO.Delete(newRoomInformation);
        }

        public void UpdateRoomInfomation(RoomInformation roomInformation)
        {
            RoomInformationDAO.UpdateRoomInformation(roomInformation);
        }
    }
}

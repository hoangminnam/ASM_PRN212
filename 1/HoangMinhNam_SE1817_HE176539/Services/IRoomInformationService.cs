using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IRoomInformationService
    {
        public List<RoomInformation> GetListRoomInformation();

        public void UpdateRoomInfomation(RoomInformation roomInformation);

        public void AddRoomInformation(RoomInformation newRoomInformation);

        public void RemoveRoomInformation(RoomInformation newRoomInformation);
    }
}

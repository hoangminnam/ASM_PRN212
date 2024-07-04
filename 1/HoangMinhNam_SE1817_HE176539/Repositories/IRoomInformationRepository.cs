﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRoomInformationRepository
    {
        public List<RoomInformation> GetListRoomInformation();
        public void UpdateRoomInfomation(RoomInformation roomInformation);
        public void AddRoomInfomation(RoomInformation newRoomInformation);
        public void RemoveRoomInformation(RoomInformation newRoomInformation);
    }
}

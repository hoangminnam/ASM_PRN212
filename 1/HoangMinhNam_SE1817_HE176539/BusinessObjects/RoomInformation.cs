﻿
namespace BusinessObjects;

public partial class RoomInformation
{
    public int RoomId { get; set; }

    public string RoomNumber { get; set; } = null!;

    public string RoomDescription { get; set; } = null!;

    public int RoomMaxCapacity { get; set; }

    public bool RoomStatus { get; set; }

    public decimal RoomPricePerDate { get; set; }

    public int RoomTypeId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Repositories.Models;

public partial class RoomInformation
{
    public int RoomId { get; set; }

    public string RoomNumber { get; set; } = null!;

    public string RoomDescription { get; set; } = null!;

    public int RoomMaxCapacity { get; set; }

    public bool RoomStatus { get; set; }

    public decimal RoomPricePerDate { get; set; }

    public int RoomTypeId { get; set; }

    public virtual ICollection<BookRoom> BookRooms { get; set; } = new List<BookRoom>();

    public virtual RoomType RoomType { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Repositories.Models;

public partial class BookRoom
{
    public int CustomerId { get; set; }

    public int RoomId { get; set; }

    public DateOnly DateFrom { get; set; }

    public string DateTo { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual RoomInformation Room { get; set; } = null!;
}

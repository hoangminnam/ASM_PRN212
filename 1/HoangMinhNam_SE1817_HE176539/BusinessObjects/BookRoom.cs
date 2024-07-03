
namespace BusinessObjects;

public partial class BookRoom
{
    public int CustomerId { get; set; }

    public int RoomId { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual RoomInformation Room { get; set; } = null!;
}

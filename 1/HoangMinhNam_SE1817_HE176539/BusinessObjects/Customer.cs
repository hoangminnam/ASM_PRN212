using System;
using System.Collections.Generic;

namespace Repositories.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerFullName { get; set; }

    public string? Telephone { get; set; }

    public string? EmailAddress { get; set; }

    public bool? CustomerStatus { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<BookRoom> BookRooms { get; set; } = new List<BookRoom>();
}

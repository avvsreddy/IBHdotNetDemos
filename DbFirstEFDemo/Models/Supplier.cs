using System;
using System.Collections.Generic;

namespace DbFirstEFDemo.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? Name { get; set; }

    public int Rating { get; set; }

    public string? AddressArea { get; set; }

    public string? AddressCity { get; set; }

    public string? AddressCountry { get; set; }

    public string? AddressPincode { get; set; }

    public virtual ICollection<TblProduct> ProductProducts { get; } = new List<TblProduct>();
}

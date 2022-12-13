using System;
using System.Collections.Generic;

namespace DbFirstEFDemo.Models;

public partial class Catagory
{
    public int CatagoryId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<TblProduct> TblProducts { get; } = new List<TblProduct>();
}

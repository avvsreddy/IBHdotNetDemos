using System;
using System.Collections.Generic;

namespace DbFirstEFDemo.Models;

public partial class TblProduct
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int Price { get; set; }

    public string? Brand { get; set; }

    public string? Color { get; set; }

    public int? CatagoryCatagoryId { get; set; }

    public virtual Catagory? CatagoryCatagory { get; set; }

    public virtual ICollection<Supplier> SupplierSuppliers { get; } = new List<Supplier>();
}

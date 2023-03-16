using SEMCommerce.Domain.Entities.Common;

namespace SEMCommerce.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public long Price { get; set; }
}
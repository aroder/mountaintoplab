using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab.domain.interfaces
{
    public interface IProduct
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int TurnaroundDays { get; set; }
        double ListPrice { get; set; }
        string Category { get; set; }
    }
}

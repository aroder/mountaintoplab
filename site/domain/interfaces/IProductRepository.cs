using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab.domain.interfaces
{
    public interface IProductRepository
    {
        List<IProduct> All();
        IProduct Get(string Id);
    }
}

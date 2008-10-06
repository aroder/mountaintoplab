using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab.domain
{
    public class Product : interfaces.IProduct
    {
        #region IProduct Members

        public string Id{ get; set; }
        public string Name { get; set; }
        public int TurnaroundDays { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double ListPrice { get; set; }

        #endregion
    }
}

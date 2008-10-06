using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab.domain.interfaces;
using System.Net;
using System.Xml;
using System.Xml.XPath;

namespace lab.domain
{
    public class ZohoProductRepository : interfaces.IProductRepository
    {
        #region IProductRepository Members

        public List<interfaces.IProduct> All()
        {
            List<IProduct> products = new List<IProduct>();
            XmlDocument doc = new XmlDocument();

            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator iter;

            //open the xml
            docNav = new XPathDocument(Constants.Zoho.Urls.GetProductsUrl);
            //create a navigator to query w/ xpath
            nav = docNav.CreateNavigator();
            //select and place the results in an iterator
            iter = nav.Select("/response/records/record");
            //iterate through the results
            while (iter.MoveNext())
            {
                IProduct p = new Product();
                p.Name = GetColumnValue(iter, "Name");
                p.Id = p.Name;
                p.ListPrice = double.Parse(GetColumnValue(iter, "ListPrice"));
                p.TurnaroundDays = int.Parse(GetColumnValue(iter, "Turnaround_days"));
                p.Category = GetColumnValue(iter, "Category");
                p.Description = GetColumnValue(iter, "Description");
                products.Add(p);
            }

            return products;
        }

        public interfaces.IProduct Get(string Id)
        {
            throw new NotImplementedException();
        }

        #endregion

        private string GetColumnValue(XPathNodeIterator iter, string column)
        {
            return iter.Current.SelectSingleNode(
                string.Format("column[@name='{0}']/value", column)
            ).Value;
        }
    }
}

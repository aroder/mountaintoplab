using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace lab.domain
{
    public class Constants
    {
        public class Zoho
        {
            private static string _apiTicket = string.Empty;
            private static string _username = WebConfigurationManager.AppSettings["ZohoApiUsername"];
            private static string _password = WebConfigurationManager.AppSettings["ZohoApiPassword"];
            public static string ApiKey = WebConfigurationManager.AppSettings["ZohoApiKey"];
            public static string ApiTicket
            {
                get
                {
                    if (string.IsNullOrEmpty(_apiTicket))
                    {
                        HttpWebRequest request = WebRequest.Create(Urls.GetTicketUrl) as HttpWebRequest;
                        using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                        {
                            StreamReader reader = new StreamReader(response.GetResponseStream());
                            string contents = reader.ReadToEnd();
                            Match m = Regex.Match(contents, @"TICKET=(\w+)");
                            _apiTicket = m.Groups[1].Value;
                        }
                    }
                    return _apiTicket;
                }
            }

            public class Urls
            {
                private static string _getProductsUrl;
                public static string GetProductsUrl
                {
                    get
                    {
                        if (string.IsNullOrEmpty(_getProductsUrl))
                        {
                            _getProductsUrl = string.Format(
                                "http://creator.zoho.com/api/xml/mountaintop-lab/view/Products_View/apikey={0}&ticket={1}"
                                , ApiKey
                                , ApiTicket
                            );
                        }
                        return _getProductsUrl;
                    }
                }

                private static string _getTicketUrl;
                public static string GetTicketUrl
                {
                    get
                    {
                        if (string.IsNullOrEmpty(_getTicketUrl))
                        {
                            _getTicketUrl = string.Format(
                                "https://accounts.zoho.com/login?servicename=ZohoCreator&FROM_AGENT=true&LOGIN_ID={0}&PASSWORD={1}"
                                , _username
                                , _password
                            );
                        }
                        return _getTicketUrl;
                    }
                } 
            }
        }


    }
}

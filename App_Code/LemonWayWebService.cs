using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml;

/// <summary>
/// Summary description for LemonWayWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class LemonWayWebService : System.Web.Services.WebService
{
    private static readonly ILog log = LogManager.GetLogger(typeof(LemonWayWebService));

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string Fibonacci(int n)
    {
        int res = getFibonacci(n);

        var keyValues = new Dictionary<string, string>
            {
                { "response", res.ToString()}
            };

        JavaScriptSerializer js = new JavaScriptSerializer();
        return js.Serialize(keyValues);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string XmlToJson(string xml)
    {
        try
        {
            // To convert an XML node contained in string xml into a JSON string   
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string jsonText = JsonConvert.SerializeXmlNode(doc);

            log.Debug(String.Format("La fonction XmlToJson avec le paramètre {0} a retourné {1}", xml, jsonText));

            return jsonText;
        }

        catch (XmlException)
        {
            log.Debug(String.Format("La fonction XmlToJson avec le paramètre {0} a retourné {1}", xml, "Bad Xml format"));

            return "Bad Xml format";
        }
    }

    public int getFibonacci(int n)
    {
        if (n < 1 || n > 100)
        {
            log.Debug(String.Format("La fonction Fibonacci avec le paramètre {0} a retourné {1}", n, -1));
            return -1;
        }

        int a = 0;
        int b = 1;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        log.Debug(String.Format("La fonction Fibonacci avec le paramètre {0} a retourné {1}", n, a));

        return a;
    }


}

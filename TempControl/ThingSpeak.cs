using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Xml;

namespace TempControl
{
    public class ThingSpeak
    {
        public XmlDocument XmlDoc { get; private set; }
        private int _nFields;
        private int _resultCount;

        public Collection<Feed> GetRemoteData(int channelId, string key, int nFields, int resultCount = 1)
        {
            _nFields = nFields;
            _resultCount = resultCount;

            Collection<Feed> entries = new Collection<Feed>();
            try
            {
                // Create a request using a URL that can receive a post. 
                var request = WebRequest.Create("http://api.thingspeak.com/channels/" +
                    channelId + "/feed.xml?key=" + key + "&results=" + resultCount);
                request.Method = "GET";
                using (var response = request.GetResponse())
                {
                    using (var dataStream = response.GetResponseStream())
                    {
                        // Open the stream.
                        using (var reader = new StreamReader(dataStream))
                        {
                            XmlDoc = new XmlDocument();
                            // Read the content.
                            XmlDoc.LoadXml(reader.ReadToEnd());
                            entries =  ParseXml(XmlDoc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return entries;
        }

        private Collection<Feed> ParseXml(XmlDocument xDoc)
        {
            Collection<Feed>  Feeds = new Collection<Feed>();
            try
            {
                for (int i = 1; i <= _resultCount; i++)
                {
                    var feed = new Feed(_nFields);
                    for (int e = 0; e < _nFields; e++)
                    {
                        feed.Fields[e] = xDoc.GetElementsByTagName("field" + (e + 1)).Item(i).InnerText;
                    }
                    Feeds.Add(feed);
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return Feeds;
        }

        public class Feed
        {
            public string[] Fields { get; set; }

            public Feed(int nFields)
            {
                Fields = new string[nFields];
                for (int i = 0; i < nFields; i++)
                    Fields[i] = string.Empty;
            }
        }
    }
}
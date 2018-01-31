using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace MQTT
{
    public class ThingSpeak
    {
        public XmlDocument XmlDoc { get; private set; }
        private string [] _nFields;
        private int _resultCount;

        //=======================================Costructor=======================================//

        public Collection<Feed> GetRemoteData(string mqttSite, string[] nFields, string node = null, int resultCount = 1)
        {
            _nFields = nFields;
            _resultCount = resultCount;

            Collection<Feed> entries = new Collection<Feed>();
            try
            {
                // Create a request using a URL that can receive a post. 
                var request = WebRequest.Create(mqttSite);
                request.Method = "GET";

                using (var response = request.GetResponse())
                {
                    using (var dataStream = response.GetResponseStream())
                    {
                        // Open the stream.
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            XmlDoc = new XmlDocument();
                            // Read the content.
                            XmlDoc.LoadXml(reader.ReadToEnd());
                            entries = ParseXml(XmlDoc, node);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No temperature values found in MQTT server",
                    "Connection to MQTT server failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return entries;
        }

        //========================================Methods=========================================//

        private Collection<Feed> ParseXml(XmlDocument xDoc, string node)
        {
            Collection<Feed> GetFeeds = new Collection<Feed>();

            if (node == null)
            {
                GetFeeds = FeedsWithoutNode(xDoc);
                return GetFeeds;
            }

            GetFeeds = FeedsWithNode(xDoc, node);
            return GetFeeds;
        }

        private Collection<Feed> FeedsWithoutNode(XmlDocument xDoc)
        {
            Collection<Feed> Feeds = new Collection<Feed>();
            try
            {
                for (int i = 1; i <= _resultCount; i++)
                {
                    int e = 0;
                    var feed = new Feed(_nFields.Length);
                    foreach (var item in _nFields)
                    {
                        feed.SetField(e, xDoc.GetElementsByTagName(item).Item(i).InnerText);
                        e++;
                    }
                    Feeds.Add(feed);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No temperature values found in MQTT server",
                    "Connection to MQTT server failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Feeds;
        }

        private Collection<Feed> FeedsWithNode(XmlDocument xDoc, string node)
        {
            Collection<Feed> Feeds = new Collection<Feed>();
            try
            {
                for (int i = 1; i <= _resultCount; i++)
                {
                    int e = 0;
                    var feed = new Feed(_nFields.Length);
                    foreach (var item in _nFields)
                    {
                        XmlNode temp_node = xDoc.SelectSingleNode("//" + item);
                        XmlAttribute temp_value = temp_node.Attributes[node];
                        feed.SetField(e, temp_value.Value);
                    }
                    Feeds.Add(feed);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No temperature values found in MQTT server",
                    "Connection to MQTT server failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Feeds;
        }
    }
}

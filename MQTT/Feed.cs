namespace MQTT
{
    public class Feed
    {
        public string[] Fields { get; private set; }

        //=======================================Costructor=======================================//

        public Feed(int nFields)
        {
            Fields = new string[nFields];
        }

        //========================================Methods=========================================//

        public void SetField(int idx, string value)
        {
            Fields[idx] = value;
        }
    }
}

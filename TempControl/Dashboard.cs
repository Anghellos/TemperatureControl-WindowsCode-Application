using System;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Telerik.WinControls.UI;
using Telerik.Charting;
using AzureConnection;
using MQTT;

namespace TempControl
{
    public partial class Dashboard : UserControl
    {
        private const int CHANNEL_NUM_IN = 376531;
        private const string READ_APIKEY_IN = "AHVAOB5BO0DYLP90";
        private const int RESULTS_IN = 12;
        private readonly string[] READ_FIELDS_NAME_IN = { "field1" };

        private const string CITY_OUT = "Cluj-Napoca";
        private const string READ_APIKEY_OUT = "d4faf390b65735df4c02021008fcf40e";
        private readonly string[] READ_FIELDS_NAME_OUT = { "temperature" };
        private readonly string READ_NODE_NAME_OUT = "value";

        private const int TEMP_DELAY = 30 * 1000;

        private Broker _broker;
        private ThingSpeak _thingSpeak;

        public Dashboard()
        {
            _broker = new Broker();
            _thingSpeak = new ThingSpeak();

            InitializeComponent();

            GetUpdateTempIn();
            GetUpdateTempOut();
            InitializeChart();
            FillChart();

            StartUpdateTemp();
        }

        //=======================================Functions========================================//

        private void InitializeChart()
        {
            TempHumChart.ShowTrackBall = true;
            TempHumChart.Area.View.Palette = KnownPalette.Autumn;

            CategoricalAxis categoricalAxis = TempHumChart.Axes[0] as CategoricalAxis;
            categoricalAxis.PlotMode = AxisPlotMode.OnTicksPadded;
            categoricalAxis.LabelFitMode = AxisLabelFitMode.Rotate;
            categoricalAxis.LabelRotationAngle = 310;

            LinearAxis verticalAxis = TempHumChart.Axes[1] as LinearAxis;
            verticalAxis.MajorStep = 1;
            verticalAxis.Maximum = 30;
            verticalAxis.Minimum = 20;
            verticalAxis.LabelInterval = 2;
        }

        private void StartUpdateTemp()
        {
            Timer timer = new Timer();
            timer.Tick += UpdateData;
            timer.Interval = TEMP_DELAY;
            timer.Start();
        }

        private void UpdateData(object sender, EventArgs e)
        {
            GetUpdateTempIn();
            GetUpdateTempOut();
            FillChart();
        }

        private void GetUpdateTempIn()
        {
            string mqttSite = "http://api.thingspeak.com/channels/" +
                    CHANNEL_NUM_IN + "/feed.xml?key=" + READ_APIKEY_IN + "&results=" + 1;

            Collection<Feed> Feeds = new Collection<Feed>();
            Feeds = _thingSpeak.GetRemoteData(mqttSite, READ_FIELDS_NAME_IN);

            TempValueInLbl.Text = Math.Round(Convert.ToDouble(Feeds[0].Fields[0]),1).ToString() +" °C";
            TempPrgInBr.Value = Convert.ToInt32(Convert.ToDouble(Feeds[0].Fields[0]));
        }

        private void GetUpdateTempOut()
        {
            string mqttSite = "http://api.openweathermap.org/data/2.5/weather?q=" +
                    CITY_OUT + "&units=metric&mode=xml&appid=" + READ_APIKEY_OUT;

            Collection<Feed> Feeds = new Collection<Feed>();
            Feeds = _thingSpeak.GetRemoteData(mqttSite, READ_FIELDS_NAME_OUT, READ_NODE_NAME_OUT);

            TempValueOutLbl.Text = Math.Round(Convert.ToDouble(Feeds[0].Fields[0]), 1).ToString() + " °C";
            TempPrgOutBr.Value = Convert.ToInt32(Convert.ToDouble(Feeds[0].Fields[0]));
        }

        private void FillChart()
        {
            TempHumChart.Series.Clear();

            string mqttSite = "http://api.thingspeak.com/channels/" +
                    CHANNEL_NUM_IN + "/feed.xml?key=" + READ_APIKEY_IN + "&results=" + RESULTS_IN;

            Collection<Feed> Feeds = new Collection<Feed>();
            Feeds = _thingSpeak.GetRemoteData(mqttSite, READ_FIELDS_NAME_IN, null, RESULTS_IN);

            int vertical = 65;
            LineSeries lineSeries = new LineSeries();
            for (int i = 0; i <= RESULTS_IN - 1; i++)
            {
                try
                {
                    double temp = Math.Round(Convert.ToDouble(Feeds[i].Fields[0]), 1);
                    lineSeries.DataPoints.Add(new CategoricalDataPoint(temp, (vertical -= 5) + "m"));
                }
                catch (Exception e)
                {
                }
            }
            TempHumChart.Series.Add(lineSeries);
        }
    }
}

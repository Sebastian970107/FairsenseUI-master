using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Threading;
using FairsenseUI.Converts;
using System.Threading;

namespace FairsenseUI.Controls
{
    /// <summary>
    /// DataShow.xaml 的交互逻辑
    /// </summary>
    public partial class DataShow : UserControl
    {
        public SeriesCollection SeriesCollection_1 { get; set; }
        public SeriesCollection SeriesCollection_2 { get; set; }
        public SeriesCollection SeriesCollection_3 { get; set; }
        public SeriesCollection SeriesCollection_4 { get; set; }
        public SeriesCollection SeriesCollection_5 { get; set; }
        public SeriesCollection SeriesCollection_6 { get; set; }
        public SeriesCollection SeriesCollection_7 { get; set; }
        public SeriesCollection SeriesCollection_8 { get; set; }
        public SeriesCollection SeriesCollection_9 { get; set; }
        public SeriesCollection SeriesCollection_10 { get; set; }
        public SeriesCollection SeriesCollection_11 { get; set; }
        public SeriesCollection SeriesCollection_12 { get; set; }
        public List<string> Labels_1 { get; set; }
        public List<string> Labels_2 { get; set; }
        public List<string> Labels_3 { get; set; }
        public List<string> Labels_4 { get; set; }
        public List<string> Labels_5 { get; set; }
        public List<string> Labels_6 { get; set; }
        public List<string> Labels_7 { get; set; }
        public List<string> Labels_8 { get; set; }
        public List<string> Labels_9 { get; set; }
        public List<string> Labels_10 { get; set; }
        public List<string> Labels_11 { get; set; }
        public List<string> Labels_12 { get; set; }
        private DispatcherTimer timer;
        private double Data;
        private StringToDisplay callDuration_1 = new StringToDisplay();
        private StringToDisplay callDuration_2 = new StringToDisplay();


        public DataShow()
        {
            InitializeComponent();
            InitChart();
            InitString();
            InitTimer();
        }

        private void InitChart()
        {
            //实例化一条折线图
            LineSeries mylineseries_1 = new LineSeries();
            LineSeries mylineseries_2 = new LineSeries();
            LineSeries mylineseries_3 = new LineSeries();
            LineSeries mylineseries_4 = new LineSeries();
            LineSeries mylineseries_5 = new LineSeries();
            LineSeries mylineseries_6 = new LineSeries();
            //设置折线的标题
            mylineseries_1.Title = "设备1";
            mylineseries_2.Title = "设备3";
            mylineseries_3.Title = "设备1";
            mylineseries_4.Title = "设备3";
            mylineseries_5.Title = "设备1";
            mylineseries_6.Title = "设备3";
            //折线图直线形式
            mylineseries_1.LineSmoothness = 1;
            mylineseries_2.LineSmoothness = 1;
            mylineseries_3.LineSmoothness = 1;
            mylineseries_4.LineSmoothness = 1;
            mylineseries_5.LineSmoothness = 1;
            mylineseries_6.LineSmoothness = 1;
            //折线图的无点样式
            //mylineseries.PointGeometry = null;
            //添加横坐标
            Labels_1 = new List<string> { };
            Labels_3 = new List<string> { };
            Labels_5 = new List<string> { };
            Labels_7 = new List<string> { };
            Labels_9 = new List<string> { };
            Labels_11 = new List<string> { };
            //添加折线图的数据
            mylineseries_1.Values = new ChartValues<double>();
            mylineseries_2.Values = new ChartValues<double>();
            mylineseries_3.Values = new ChartValues<double>();
            mylineseries_4.Values = new ChartValues<double>();
            mylineseries_5.Values = new ChartValues<double>();
            mylineseries_6.Values = new ChartValues<double>();
            SeriesCollection_1 = new SeriesCollection { };
            SeriesCollection_1.Add(mylineseries_1);

            SeriesCollection_3 = new SeriesCollection { };
            SeriesCollection_3.Add(mylineseries_2);

            SeriesCollection_5 = new SeriesCollection { };
            SeriesCollection_5.Add(mylineseries_3);

            SeriesCollection_7 = new SeriesCollection { };
            SeriesCollection_7.Add(mylineseries_4);

            SeriesCollection_9 = new SeriesCollection { };
            SeriesCollection_9.Add(mylineseries_5);

            SeriesCollection_11 = new SeriesCollection { };
            SeriesCollection_11.Add(mylineseries_6);

            //实例化一条柱状图
            ColumnSeries mybarseries_1 = new ColumnSeries();
            ColumnSeries mybarseries_2 = new ColumnSeries();
            ColumnSeries mybarseries_3 = new ColumnSeries();
            ColumnSeries mybarseries_4 = new ColumnSeries();
            ColumnSeries mybarseries_5 = new ColumnSeries();
            ColumnSeries mybarseries_6 = new ColumnSeries();
            //设置柱状图的标题
            mybarseries_1.Title = "设备2";
            mybarseries_2.Title = "设备4";
            mybarseries_3.Title = "设备2";
            mybarseries_4.Title = "设备4";
            mybarseries_5.Title = "设备2";
            mybarseries_6.Title = "设备4";
            //添加横坐标
            Labels_2 = new List<string> { };
            Labels_4 = new List<string> { };
            Labels_6 = new List<string> { };
            Labels_8 = new List<string> { };
            Labels_10 = new List<string> { };
            Labels_12 = new List<string> { };
            //添加柱状图的数据
            mybarseries_1.Values = new ChartValues<double>();
            SeriesCollection_2 = new SeriesCollection { };
            SeriesCollection_2.Add(mybarseries_1);

            mybarseries_2.Values = new ChartValues<double>();
            SeriesCollection_4 = new SeriesCollection { };
            SeriesCollection_4.Add(mybarseries_2);

            mybarseries_3.Values = new ChartValues<double>();
            SeriesCollection_6 = new SeriesCollection { };
            SeriesCollection_6.Add(mybarseries_3);

            mybarseries_4.Values = new ChartValues<double>();
            SeriesCollection_8 = new SeriesCollection { };
            SeriesCollection_8.Add(mybarseries_4);

            mybarseries_5.Values = new ChartValues<double>();
            SeriesCollection_10 = new SeriesCollection { };
            SeriesCollection_10.Add(mybarseries_5);

            mybarseries_6.Values = new ChartValues<double>();
            SeriesCollection_12 = new SeriesCollection { };
            SeriesCollection_12.Add(mybarseries_6);

            DataContext = this;

        }
        private void InitString()
        {
            textblock_2.DataContext = callDuration_1;
            callDuration_1.Text = "正常运行";

            textblock_3.DataContext = callDuration_2;
            callDuration_2.Text = "解放路88号";
        }

        private void InitTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(10000000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private async void timer_Tick(object sender, EventArgs e)
        {
            Labels_1.Clear();
            SeriesCollection_1[0].Values.Clear();
            var data = await GetData<SensorData>.GetSensorData();

            for (int i = 0; i < data.Count(); i++)
            {
                var str = data[i].SensorTimeStamp;
                string[] sArray = str.Split(new string[] { "T", "." }, StringSplitOptions.RemoveEmptyEntries);
                var x = sArray[1];
                var y = Convert.ToDouble(data[i].Voltage);

                Labels_1.Add(x);
                SeriesCollection_1[0].Values.Add(y);
            }

        }

    }
}

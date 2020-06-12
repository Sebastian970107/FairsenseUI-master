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


namespace FairsenseUI.Controls
{
    /// <summary>
    /// DataShow.xaml 的交互逻辑
    /// </summary>
    public partial class DataShow : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public List<string> Labels { get; set; }
        private DispatcherTimer timer;

        public DataShow()
        {
            InitializeComponent();
            InitChart();
            InitTimer();
        }

        private void InitChart()
        {
            //实例化一条折线图
            LineSeries mylineseries = new LineSeries();
            //设置折线的标题
            mylineseries.Title = "设备";
            //折线图直线形式
            mylineseries.LineSmoothness = 1;
            //折线图的无点样式
            //mylineseries.PointGeometry = null;
            //添加横坐标
            Labels = new List<string> { };
            //添加折线图的数据
            mylineseries.Values = new ChartValues<double>();
            SeriesCollection = new SeriesCollection { };
            SeriesCollection.Add(mylineseries);

            DataContext = this;

        }

        private void InitTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(10000000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Labels.Clear();
            SeriesCollection[0].Values.Clear();
            Labels.Add("18:00");
            SeriesCollection[0].Values.Add(1);
        }

    }
}

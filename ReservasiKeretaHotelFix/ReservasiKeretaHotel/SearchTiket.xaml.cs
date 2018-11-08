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
using System.Windows.Shapes;
using ReservasiKeretaHotel.BaseContext;
using ReservasiKeretaHotel.Model;

namespace ReservasiKeretaHotel
{
    /// <summary>
    /// Interaction logic for SearchTiket.xaml
    /// </summary>
    public partial class SearchTiket : Window
    {


        public SearchTiket()
        {
            InitializeComponent();
            LoadData();
        }
        MyContext context = new MyContext();
        Train train = new Train();
        Station stasiun = new Station();
        Province provinsi = new Province();
        City city = new City();
        Regency regency = new Regency();
        Village village = new Village();
        Schedule schedule = new Schedule();
        TrainClass kelaskereta = new TrainClass();
        Wagon wagoon = new Wagon();
        TrainWagon trwagon = new TrainWagon();

        private void combostasiunasal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void LoadData()
        {
            int id = Convert.ToInt32(combostasiunasal.SelectedValue);
            var getcombo = context.stations.Where(x => x.Isdelete == false).ToList();
            var getall = context.schedules.Where(x => x.Isdelete == false).ToList();
            var gettrain = context.trains.Where(x => x.Isdelete == false).ToList();
            var getstation = context.stations.Include("cities").Where(x => x.Isdelete == false).ToList();
            combostasiunasal.ItemsSource = getcombo;
            combostasiuntujuan.ItemsSource = getcombo;
            jadwalGrid.ItemsSource = getall;
            var getWagon = context.wagons.Where(x => x.Isdelete == false).ToList();
            var getDtlTrain = context.trainwagons.Where(x => x.Isdelete == false).ToList();
            var getTrainClass = context.trainsclass.Where(x => x.Isdelete == false).ToList();
            

        }

        private void jadwalGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          

            var listclass = new List<Wagon>();


            var trainall = context.schedules.Include("trains").Include("trains.wagons").ToList();
            //int a= Convert.ToInt32((jadwalGrid.SelectedCells[1].Column.GetCellContent(cell) as TextBlock).Text);
            //var b = context.trains.Find(a);
            //var getall = context.trainwagons.Include("trains").Include("wagons").Where(x => x.trains.Id == a);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                int id = Convert.ToInt32(combostasiunasal.SelectedValue);
                var stasiun = context.stations.Find(id);
                var findStation = context.schedules.Where(x => x.stations == stasiun).ToList();
                tschedule.ItemsSource = findStation;            
        }

        private void tschedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedJob = tschedule.SelectedItem;
            int id = Convert.ToInt16((tschedule.SelectedCells[0].Column.GetCellContent(selectedJob) as TextBlock).Text);

        }
    }
}

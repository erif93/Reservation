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
    /// Interaction logic for admintrain.xaml
    /// </summary>
    public partial class admintrain : Window
    {
        public admintrain()
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

        private void save_Click(object sender, RoutedEventArgs e)
        {
            train.Name = NamaKereta.Text;
            context.trains.Add(train);
            context.SaveChanges();
            LoadData();
        }

        private void LoadData()
        {
            var gettrain = context.trains.Where(x => x.Isdelete == false).ToList();
            TrainGrid.ItemsSource = gettrain;
            traincombo.ItemsSource = gettrain;
            detilTrainCombo.ItemsSource = gettrain;
            var getKota = context.provinces.Where(x => x.Isdelete == false).ToList();
            kotacombo.ItemsSource = getKota;
            ProvinceGrid.ItemsSource = getKota;
            var getCity = context.cities.Where(x => x.Isdelete == false).ToList();
            stasiuncombo.ItemsSource = getCity;
            KotaGrid.ItemsSource = getCity;
            var getRegency = context.regencies.Where(x => x.Isdelete == false).ToList();
            RegencyGrid.ItemsSource = getRegency;
            kecamatancombo.ItemsSource = getCity;
            var getVillage = context.villages.Where(x => x.Isdelete == false).ToList();
            desacombo.ItemsSource = getRegency;
            VillageGrid.ItemsSource = getVillage;
            var getstation = context.stations.Include("cities").Where(x => x.Isdelete == false).ToList();
            StationGrid.ItemsSource = getstation;
            asalstasiuncombo.ItemsSource = getstation;
            tujuanstasiuncombo.ItemsSource = getstation;
            var getall = context.schedules.Where(x => x.Isdelete == false).ToList();
            ScheduleGrid.ItemsSource = getall;
            var getTrainClass = context.trainsclass.Where(x => x.Isdelete == false).ToList();
            trainClass.ItemsSource = getTrainClass;
            kelascombo.ItemsSource = getTrainClass;
            var getWagon = context.wagons.Where(x => x.Isdelete == false).ToList();
            wagon.ItemsSource = getWagon;
            detilGerbongCombo.ItemsSource = getWagon;
            var getDtlTrain = context.trainwagons.Where(x => x.Isdelete == false).ToList();
            detailTrain.ItemsSource = getDtlTrain;
           
        }

        private void tambahprovince_Click(object sender, RoutedEventArgs e)
        {
            provinsi.Name = Province.Text;
            context.provinces.Add(provinsi);
            context.SaveChanges();
            LoadData();
        }

        private void tambahkecamatan_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(kecamatancombo.SelectedValue);
            var getRegency = context.cities.Find(id);
            regency.Name = kecamatanku.Text;
            regency.cities = getRegency;
            context.regencies.Add(regency);
            context.SaveChanges();
            LoadData();
        }

        private void tambahkota_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(kotacombo.SelectedValue);
            var provinsi = context.provinces.Find(id);
            city.Name = Kotaku.Text;
            city.provinces = provinsi;
            context.cities.Add(city);
            context.SaveChanges();
            LoadData();
        }
        private void tambahdesa_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(desacombo.SelectedValue);
            var getVillage = context.regencies.Find(id);
            village.Name = desaku.Text;
            village.regencies = getVillage;
            context.villages.Add(village);
            context.SaveChanges();
            LoadData();

        }
        private void kotacombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int id = Convert.ToInt32(kotacombo.SelectedValue);
            var provinsi = context.provinces.Find(id);
            city.Name = Kotaku.Text;
            city.provinces = provinsi;
            context.cities.Add(city);
            context.SaveChanges();
            LoadData();

        }
        private void SaveStation_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(stasiuncombo.SelectedValue);
            var getcity = context.cities.Find(id);
            stasiun.Name = StationName.Text;
            stasiun.cities = getcity;
            context.stations.Add(stasiun);
            context.SaveChanges();
            LoadData();
        }
        private void SaveSchedule_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(traincombo.SelectedValue);
            var getSelectedTrain = context.trains.Find(id);
            int idarrival = Convert.ToInt32(asalstasiuncombo.SelectedValue);
            var getArrivalStation = context.stations.Find(idarrival);
            int iddeparture = Convert.ToInt32(tujuanstasiuncombo.SelectedValue);
            var getDepartureStation = context.stations.Find(iddeparture);
            schedule.trains = getSelectedTrain;
            schedule.stations = getArrivalStation;
            schedule.destinations = getDepartureStation;
            schedule.information = ScheduleInfo.Text;
            schedule.departure = DateTime.Now.ToLocalTime();
            schedule.arrival = DateTime.Now.ToLocalTime();
            context.schedules.Add(schedule);
            context.SaveChanges();
            LoadData();  
        }
        private void tambahklas_Click(object sender, RoutedEventArgs e)
        {
            kelaskereta.Name = tclass.Text; 
            context.trainsclass.Add(kelaskereta);
            context.SaveChanges();
            LoadData();
        }
        private void tambahgerbong_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(kelascombo.SelectedValue);
            var getTclass = context.trainsclass.Find(id);
            wagoon.Name = gerbong.Text;
            wagoon.trainclas = getTclass;
            context.wagons.Add(wagoon);
            context.SaveChanges();
            LoadData();
        }

        private void tambahDtlKereta_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(detilTrainCombo.SelectedValue);
            var getDetilTrain = context.trains.Find(id);
            int idWagon = Convert.ToInt32(detilGerbongCombo.SelectedValue);
            var getDetilWagon = context.wagons.Find(idWagon);
            trwagon.trains = getDetilTrain;
            trwagon.wagons = getDetilWagon;
            context.trainwagons.Add(trwagon);
            context.SaveChanges();
            LoadData();
        }

        private void TrainGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = TrainGrid.SelectedItem;
            KeretaId.Text= (TrainGrid.SelectedCells[0].Column.GetCellContent(cell) as TextBlock).Text;
            NamaKereta.Text = (TrainGrid.SelectedCells[1].Column.GetCellContent(cell) as TextBlock).Text;
        }

        private void StationGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = StationGrid.SelectedItem;
            StationId.Text = (StationGrid.SelectedCells[0].Column.GetCellContent(cell) as TextBlock).Text;
            StationName.Text = (StationGrid.SelectedCells[1].Column.GetCellContent(cell) as TextBlock).Text;
            stasiuncombo.Text= (StationGrid.SelectedCells[2].Column.GetCellContent(cell) as TextBlock).Text;
        }

        private void ScheduleGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = ScheduleGrid.SelectedItem;
            ScheduleId.Text = (ScheduleGrid.SelectedCells[0].Column.GetCellContent(cell) as TextBlock).Text;
            traincombo.Text = (ScheduleGrid.SelectedCells[1].Column.GetCellContent(cell) as TextBlock).Text;
            asalstasiuncombo.Text = (ScheduleGrid.SelectedCells[2].Column.GetCellContent(cell) as TextBlock).Text;
            tujuanstasiuncombo.Text = (ScheduleGrid.SelectedCells[3].Column.GetCellContent(cell) as TextBlock).Text;
            ScheduleInfo.Text = (ScheduleGrid.SelectedCells[4].Column.GetCellContent(cell) as TextBlock).Text;
            Departure.Text= (ScheduleGrid.SelectedCells[5].Column.GetCellContent(cell) as TextBlock).Text;
            Arrival.Text =(ScheduleGrid.SelectedCells[6].Column.GetCellContent(cell) as TextBlock).Text;
        }

        private void wagon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell =wagon.SelectedItem;
            gerbongId.Text = (wagon.SelectedCells[0].Column.GetCellContent(cell) as TextBlock).Text;
            gerbong.Text = (wagon.SelectedCells[1].Column.GetCellContent(cell) as TextBlock).Text;
            kelascombo.Text= (wagon.SelectedCells[2].Column.GetCellContent(cell) as TextBlock).Text;
        }

        private void trainClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = trainClass.SelectedItem;
            idTclass.Text = (trainClass.SelectedCells[0].Column.GetCellContent(cell) as TextBlock).Text;
            tclass.Text = (trainClass.SelectedCells[1].Column.GetCellContent(cell) as TextBlock).Text;
        }

        private void detailTrain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = detailTrain.SelectedItem;
            idDtlTrain.Text = (detailTrain.SelectedCells[0].Column.GetCellContent(cell) as TextBlock).Text;
            detilTrainCombo.Text = (detailTrain.SelectedCells[1].Column.GetCellContent(cell) as TextBlock).Text;
            detilGerbongCombo.Text = (detailTrain.SelectedCells[2].Column.GetCellContent(cell) as TextBlock).Text;
            trainclas.Text = (detailTrain.SelectedCells[3].Column.GetCellContent(cell) as TextBlock).Text;
            trainPrice.Text = (detailTrain.SelectedCells[4].Column.GetCellContent(cell) as TextBlock).Text;

        }

        private void ProvinceGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = ProvinceGrid.SelectedItem;
            idProvince.Text = (ProvinceGrid.SelectedCells[0].Column.GetCellContent(cell) as TextBlock).Text;
            Province.Text = (ProvinceGrid.SelectedCells[1].Column.GetCellContent(cell) as TextBlock).Text;
        }

        private void KotaGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = KotaGrid.SelectedItem;
            idCity.Text = (KotaGrid.SelectedCells[0].Column.GetCellContent(cell) as TextBlock).Text;
            kotacombo.Text= (KotaGrid.SelectedCells[2].Column.GetCellContent(cell) as TextBlock).Text;
            Kotaku.Text = (KotaGrid.SelectedCells[1].Column.GetCellContent(cell) as TextBlock).Text;
        }

        private void editrain_Click(object sender, RoutedEventArgs e)
        {
            var train = context.trains.Find(Convert.ToInt32(KeretaId.Text));
            train.Name =NamaKereta.Text;
            context.Entry(train).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            LoadData();
        }

        private void ubahStation_Click(object sender, RoutedEventArgs e)
        {
            var station = context.stations.Find(Convert.ToInt32(StationId.Text));
            int id = Convert.ToInt32(stasiuncombo.SelectedValue);
            var city = context.cities.Find(id);
            station.Name = StationName.Text;
            station.cities = city;
            context.Entry(station).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            LoadData();
        }

        private void UbahSchedule_Click(object sender, RoutedEventArgs e)
        {
            var schedule = context.schedules.Find(Convert.ToInt32(ScheduleId.Text));
            var train = context.trains.Find(Convert.ToInt32(traincombo.SelectedValue));
            var station = context.stations.Find(Convert.ToInt32(asalstasiuncombo.SelectedValue));
            var destination = context.stations.Find(Convert.ToInt32(tujuanstasiuncombo.SelectedValue));
            schedule.trains = train;
            schedule.stations = station;
            schedule.destinations = destination;
            schedule.information = ScheduleInfo.Text;
            schedule.departure = Convert.ToDateTime(Departure.Text);
            schedule.arrival = Convert.ToDateTime(Arrival.Text);
            context.Entry(schedule).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            LoadData();
        }

        private void ubahDtlKereta_Click(object sender, RoutedEventArgs e)
        {
            var detil = context.trainwagons.Find(Convert.ToInt32(idDtlTrain.Text));
            var train = context.trains.Find(Convert.ToInt32(detilTrainCombo.SelectedValue));
            var wagon = context.wagons.Find(Convert.ToInt32(detilGerbongCombo.SelectedValue));
            detil.trains = train;
            detil.wagons = wagon;
            context.Entry(detil).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            LoadData();
        }
    }
}

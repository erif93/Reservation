using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservasiKeretaHotel.Model;

namespace ReservasiKeretaHotel.BaseContext
{
   class MyContext:DbContext
    {
        public MyContext():base("booking"){}

        
        public DbSet<Account> accounts { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Chair> chairs { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<DestinationStation> destinations { get; set; }
        public DbSet<OriginStation> origins { get; set; }
        public DbSet<Province> provinces { get; set; }
        public DbSet<Regency> regencies { get; set; }
        public DbSet<Station> stations { get; set; }
        public DbSet<Schedule> schedules { get; set; }
        public DbSet<Train> trains { get; set; }
        public DbSet<TrainClass> trainsclass { get; set; }
        public DbSet<TrainWagon> trainwagons { get; set; }
        public DbSet<Village> villages { get; set; }
        public DbSet<Wagon> wagons { get; set; }
    }
}

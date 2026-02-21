using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using TransCRM_ERP.Entites.BaseData;
using TransCRM_ERP.Entites.SecondaryData;
using TransCRM_ERP.Infrastructure.Data;
using TransCRM_ERP.Infrastructure.Data;

namespace TransCRM_ERP.cliTest
{
    public static class Program
    {
        public async static Task Main(string[] args)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    var req = new Required
                    {
                        RequestNumb = "ReqTest",
                        RequestDate = DateOnly.FromDateTime(DateTime.Now),
                        RequestNumbAdd = "ReqTestAdd",
                        RequestCostStart = 1d,
                        TypeTransportation = Entites.Enums.TypeTransportation.RegularTransportation,
                        RequestStatus = Entites.Enums.RequestStatus.New,
                        Autotransport = AutotransportTest,
                        Driver = DriverTest,
                        RequestCostFinal = 2d,
                        Waybills = new List<Waybill> { Waybill1, Waybill2 },
                        DrivingRoutes = new List<DrivingRoute> { DrivingRouteTest1, DrivingRouteTest2 }
                    };

                    // Requiered
                    //await db.Requireds.AddAsync(req);

                    var auto = new Autotransport
                    {
                        TypeTransport = Entites.Enums.TypeTransport.TruckTractor,
                        AutobodyType = Entites.Enums.AutobodyType.Crane,
                        CarRegNumber = "TEST",
                        RegionNumber = 999,
                        CarBrand = "UnknownBrand",
                        CarModel = "UnknownModel",
                        Lifting = 9.990f,
                        CarVolume = 1.10f
                    };

                    await db.Autotransports.AddAsync(auto);

                    db.SaveChanges();
                    db.Database.CloseConnection();

                    Console.WriteLine($"{db.ChangeTracker.DebugView.LongView}\n" +
                        $"======================> Done! <======================");
                }
            }
            catch (Exception ex) { Console.WriteLine($"{ex.Message} => {ex.InnerException}"); }

            Console.ReadKey();
        }

        public static AddressPoint AddrLoad1 = new AddressPoint
        {
            AddressPointText = "Партизанск"
        };
        public static AddressPoint AddrUnload1 = new AddressPoint
        {
            AddressPointText = "Уссурийск"
        };

        public static DrivingRoute DrivingRouteTest1 = new DrivingRoute
        {
            DataLoading = DateTime.Now,
            AddressLoading = AddrLoad1,
            DateUnloading = DateTime.Now,
            AddressUnloading = AddrUnload1
        };
        public static DrivingRoute DrivingRouteTest2 { get; set; } = new DrivingRoute
        {
            DataLoading = DateTime.Now,
            AddressLoading = AddrUnload1,
            DateUnloading = DateTime.Now,
            AddressUnloading = AddrLoad1
        };

        public static Autotransport AutotransportTest { get; set; } = new Autotransport
        {
            TypeTransport = Entites.Enums.TypeTransport.SingleCar,
            AutobodyType = Entites.Enums.AutobodyType.Tent,
            CarRegNumber = "O123YN",
            RegionNumber = 125,
            CarBrand = "Toyota",
            CarModel = "Toyoace",
            Lifting = 1.5f,
            CarVolume = 4.2f
        };

        public static Driver DriverTest { get; set; } = new Driver
        {
            Surname = "SurnameTest",
            Name = "NameTest",
            Lastname = "LastnameTest",
            DriverLicense = new DriverLicense
            {
                NumberLicence = 123,
                SeriesLicence = 999,
                DateIssue = DateOnly.FromDateTime(DateTime.Now),
                DateEnd = DateOnly.FromDateTime(DateTime.Now).AddDays(100),
            },
            Passport = new Passport
            {
                SeriesPassport = 123,
                NumberPassport = 999999,
                DateIssue = DateOnly.FromDateTime(DateTime.Now).AddDays(100),
                DepartmentCode = 123321,
                IssuedBy = "Otdelom",
                Gender = "Male",
                Birthdate = new DateOnly(1999, 1, 2),
                Birthplace = "Kukuevo"
            }
        };

        public static Waybill Waybill1 = new Waybill
        {
            WaybillNumb = $"LLS{GetRandomNumb()}"
        };
        public static Waybill Waybill2 = new Waybill
        {
            WaybillNumb = $"LLS{GetRandomNumb()}"
        };

        private static int GetRandomNumb([Optional] int seed)
        {
            Random rand;

            if (seed == 0)
                rand = new Random(DateTime.Now.Second);
            else
                rand = new Random(seed);

            return rand.Next(minValue: 100000, maxValue: 999999);
        }
    }
}
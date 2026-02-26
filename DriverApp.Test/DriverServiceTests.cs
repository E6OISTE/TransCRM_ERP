using AutoMapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using TransCRM_ERP.API;
using TransCRM_ERP.Infrastructure;

namespace DriverApp.Test
{
    public class ControllerTestBase : IDisposable
    {
        protected readonly AppDbContext Context;
        protected readonly IMapper Mapper;
        private readonly SqliteConnection _connection;

        public ControllerTestBase()
        {
            _connection = new SqliteConnection("Filename=:memory:");
            _connection.Open();

            var option = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite(_connection)
                .Options;

            Context = new AppDbContext(option);
            Context.Database.EnsureCreated();

            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile<MappingProfile>();
            });

            Mapper = config.CreateMapper();
        }

        public void Dispose()
        {
            _connection.Close();
            Context.Dispose();
        }
    }
}
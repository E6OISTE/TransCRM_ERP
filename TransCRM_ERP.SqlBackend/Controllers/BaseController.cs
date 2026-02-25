using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TransCRM_ERP.Infrastructure;

namespace TransCRM_ERP.API.Controllers
{
    /// <summary>
    /// Запрос на получение названий таблиц из БД
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BaseController(AppDbContext context) => _context = context;

        [HttpGet("tables")]
        public async Task<ActionResult<IEnumerable<string>>> GetNameTables()
        {
            using var connection = new SqliteConnection();
            connection.ConnectionString = _context.Database.GetConnectionString();

            await connection.OpenAsync();

            var command = new SqliteCommand("SELECT name FROM sqlite_master WHERE type='table' AND name NOT LIKE 'sqlite_%'", connection);
            var reader = await command.ExecuteReaderAsync();

            var tables = new List<string>();
            while (reader.Read())
                tables.Add(reader.GetString(0));
            return Ok(tables);
        }
    }
}
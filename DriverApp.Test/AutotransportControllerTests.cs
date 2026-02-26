using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransCRM_ERP.API.Controllers;
using TransCRM_ERP.DTO;
using TransCRM_ERP.Entites.BaseData;
using TransCRM_ERP.Entites.Enums;
using Xunit;

namespace DriverApp.Test
{
    public class AutotransportControllerTests : ControllerTestBase
    {
        private readonly AutotransportController _controller;

        public AutotransportControllerTests()
        {
            _controller = new AutotransportController(Context, Mapper);
        }

        [Fact]
        public async Task Get_ReturnsAllItems()
        {
            // Arrange
            var autotransport = new Autotransport
            {
                TypeTransport = TypeTransport.SingleCar,
                AutobodyType = AutobodyType.Other,
                CarRegNumber = "1234",
                RegionNumber = 125,
                CarBrand = "TestCarBrand",
                CarModel = "TestCarModel",
                Lifting = 1.5f,
                CarVolume = 4.5f,
                SpaceDimensionsLength = 1.5f,
                SpaceDimensionsWidth = 1.5f,
                SpaceDimensionsHeight = 1.5f,
                LoadingUnloadingTypeAddit =
                new[] {
                    LoadingUnloadingTypeAddit.Strapping,
                    LoadingUnloadingTypeAddit.Strapping
                },
                RightUseVehicle = RightUseVehicle.Own,
                CarRegistrationCertificateNumb = "TestCarRegCertNumb",
                CarRegistrationCertificateDate = DateOnly.FromDateTime(new DateTime())
            };
            Context.Autotransports.Add(autotransport);
            await Context.SaveChangesAsync();



            // Check save to Db
            //Context.Autotransports.Should().Contain(autotransport);
        }

        [Fact]
        public async Task 
    }
}
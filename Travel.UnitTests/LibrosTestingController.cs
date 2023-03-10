using co.Travel.Application;
using co.Travel.Application.AppServices;
using co.Travel.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Travel.Ui.WebApi.Controllers;

namespace Travel.UnitTests
{
    public class LibrosTestingController
    {
        private readonly LibrosController LibroCller;
        private readonly LibroAppService _Service;
        public readonly IApplicationService<Libro> LibroService;

        public LibrosTestingController(IApplicationService<Libro> libroService, LibroAppService libroAppService)
        {
             this._Service = libroAppService;   
            this.LibroCller = new LibrosController(_Service);

        }
        [Fact]
        public void IsGetOK()
        {
            var httpResult = LibroCller.GetAll();

            Assert.IsType<OkObjectResult>(httpResult);

        }

        [Fact]
        public void IsPostOK()
        {
            //    var libroPruebaData=

            //    var httpResult = LibroCller.Post(LibroPruebaData);

            //    Assert.IsType<OkObjectResult>(httpResult);

            //var f = new FootballTeam()
            //{
            //    Name = dto.Name,
            //    Score = dto.Score,
            //    Manager = dto.Manager,
            //};

        }
    }
}
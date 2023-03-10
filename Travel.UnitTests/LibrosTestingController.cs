using co.Travel.Application;
using co.Travel.Application.AppServices;
using co.Travel.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using NuGet.Frameworks;
using Travel.Ui.WebApi.Controllers;

namespace Travel.UnitTests
{
    public class LibrosTestingController
    {
        private readonly LibrosController LibroCller;
        public readonly IApplicationService<Libro> LibroService;

        public LibrosTestingController(IApplicationService<Libro> libroService, LibroAppService libroAppService)
        {

            this.LibroCller = new LibrosController(LibroService);

        }
        [Fact]
        public void IsGetOK()
        {
            var httpResult = LibroCller.GetAll();

            Assert.IsType<OkObjectResult>(httpResult);

        }

        [Fact]
        public void IsGetHasAny()
        {
            var result = (OkObjectResult)LibroCller.GetAll();

            var libros = Assert.IsType<List<Libro>>(result.Value);
             Assert.True(libros.Any());
                            
        }
    }
}
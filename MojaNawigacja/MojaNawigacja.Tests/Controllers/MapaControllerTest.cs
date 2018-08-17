using Microsoft.VisualStudio.TestTools.UnitTesting;
using MojaNawigacja.Controllers;
using System.Web.Mvc;

namespace MojaNawigacja.Tests.Controllers
{
    [TestClass]
    public class MapaControllerTest
    {
        [TestMethod]
        public void SprawdzMape()
        {
            MapaController mapaController = new MapaController();
            ViewResult viewResult = mapaController.Index() as ViewResult;
            Assert.IsNotNull(viewResult);
        }
    }
}

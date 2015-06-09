using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using CardMates.Controllers;
using CardMates.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CardMates.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod]
        public void TestForumView()
        {
            var controller = new HomeController();
            var result = controller.Forum() as ViewResult;
            Assert.AreEqual("Forum", result.ViewName);
        }
        [TestMethod]
        public void SearchTitle()
        {
            var controller = new HomeController();
            var result = controller.Forum() as ViewResult;
            Assert.AreEqual("Your Forum page.", result.ViewBag.Message);
        }
    }
}

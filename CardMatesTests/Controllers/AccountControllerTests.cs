using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardMates.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
namespace CardMates.Controllers.Tests
{
    [TestClass()]
    public class AccountControllerTests
    {
        [TestMethod]
        public void TestLoginUrl()
        {
            var controller = new AccountController();
            var result = controller.Login("") as ViewResult;
            Assert.AreEqual("", result.ViewBag.ReturnUrl);
        }

        [TestMethod]
        public void TestLoginView()
        {
            var controller = new AccountController();
            var result = controller.Login("") as ViewResult;
            Assert.AreEqual("Login", result.ViewName);
        }

        [TestMethod]
        public void TestRegisterView()
        {
            var controller = new AccountController();
            var result = controller.Register() as ViewResult;
            Assert.AreEqual("Register", result.ViewName);
        }

        [TestMethod]
        public void TestExternalLoginFailureView()
        {
            var controller = new AccountController();
            var result = controller.ExternalLoginFailure() as ViewResult;
            Assert.AreEqual("ExternalLoginFailure", result.ViewName);
        }
    }
}

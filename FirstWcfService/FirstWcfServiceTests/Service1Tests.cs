using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstWcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWcfService.Tests {
    [TestClass()]
    public class Service1Tests {
        [TestMethod()]
        public void SayMyNameTest() {
            //arrange
            Service1 service1 = new Service1();
            string expected = "heisenberg";

            //act
            string actual = service1.SayMyName();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayMyEmailTest() {
            //arrange
            Service1 service1 = new Service1();
            string expected = "walter.white1855@gmail.fuck";

            //act
            string actual = service1.SayMyEmail();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
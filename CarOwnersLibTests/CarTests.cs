using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarOwnersLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnersLib.Tests
{
    [TestClass()]
    public class CarTests
    {
        /// <summary>
        /// Her bliver der testet om der er mellem 2 og 5 døre (det er der)
        /// </summary>
        [TestMethod()]
        
        public void DoorsNoTest()
        {
            //Arrenge
            var car = new Car();
            //Act
            car.Doors = 4;
            
            //Assert
            Assert.AreEqual(4, car.Doors);
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        
        public void ModelNotNullTest()
        {
            var car = new Car();
            car.Model = null;
            
            Assert.AreEqual(null, car.Model);
        }

        /// <summary>
        /// Her bliver der testet om der er kun 7 tegn (det er der)
        /// </summary>
        [TestMethod()]
        
        public void regNummerTest()
        {
            var car = new Car();
            car.registrationNo = "XX88777";
            
            Assert.AreEqual("XX88777", car.registrationNo);
        }
        /// <summary>
        /// Her bliver der testet igen om der er mellem 2 og 5 døre (Den fejlede)
        /// </summary>
        [TestMethod()]
        
        public void DoorsNoTest6()
        {
            var car = new Car();
            car.Doors = 6;
            
            Assert.AreEqual(6, car.Doors);
        }

        [TestMethod()]
        
        public void ModelNotNullTest2()
        {
            var car = new Car();
            car.Model = "B";
            
            Assert.AreEqual("B", car.Model);
        }

        /// <summary>
        /// Her bliver der testet igen om der er 7 tegn i regnummret (Den fejlede)
        /// </summary>
        [TestMethod()]
        
        public void regNummerTest8()
        {
            var car = new Car();
            car.registrationNo = "XX887777";
           
            Assert.AreEqual("XX887777", car.registrationNo);
        }
    }
}
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
    public class OwnerTests
    {
       /// <summary>
       /// Her bliver der testet om der er 6 tegn (det er der)
       /// </summary>
        [TestMethod()]
        
        public void AddressCharsTest()
        {
            //Arrange
            var owner = new Owner();
            //Act
            owner.Address = "EnVej12";
            
            //Assert
            Assert.AreEqual("EnVej12", owner.Address);

        }
        /// <summary>
        /// Her bliver der testet om der er 4 tegn eller mere (det er der)
        /// </summary>

        [TestMethod()]
       
        public void NameCharsTest()
        {
            var owner = new Owner();
            owner.Name = "Timmy";
            
            Assert.AreEqual("Timmy", owner.Name);
        }
        /// <summary>
        /// Her bliver der testet om der er 8 tegn (det er der)
        /// </summary>
        [TestMethod()]
       
        public void PhoneCharsTest()
        {
            var owner = new Owner();
            owner.Phone = "12345678";
            
            Assert.AreEqual("12345678", owner.Phone);
        }
        /// <summary>
        /// Her bliver der testet igen med 5 tegn (Den fejlede)
        /// </summary>
        [TestMethod()]
        
        public void AddressCharsTest6()
        {
            //Arrange
            var owner = new Owner();
            //Act
            owner.Address = "EnVej1";
           
            //Assert
            Assert.AreEqual("EnVej1", owner.Address);

        }
        /// <summary>
        /// Her bliver der testet igen med under 4 tegn (Den fejlede)
        /// </summary>
        [TestMethod()]
        
        public void NameCharsTest3()
        {
            var owner = new Owner();
            owner.Name = "Tim";
            
            Assert.AreEqual("Tim", owner.Name);
        }
        /// <summary>
        /// Her bliver der testet igen med mere end 8 tegn (Den fejlede)
        /// </summary>
        [TestMethod()]
        
        public void PhoneCharsTest9()
        {
            var owner = new Owner();
            owner.Phone = "123456789";
            
            Assert.AreEqual("123456789", owner.Phone);
        }
    }
}
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
        [ExpectedException(typeof(ArgumentException), "Addressen skal være længere end 6.")]
        public void AddressCharsTest()
        {
            //Arrange
            var owner = new Owner();
            //Act
            owner.Address = "EnVej12";
            owner.AddressChars();
            //Assert
            Assert.AreEqual("EnVej12", owner.Address);

        }
        /// <summary>
        /// Her bliver der testet om der er 4 tegn eller mere (det er der)
        /// </summary>

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Dit navn skal være fire karaktere langt eller mere.")]
        public void NameCharsTest()
        {
            var owner = new Owner();
            owner.Name = "Timmy";
            owner.NameChars();
            Assert.AreEqual("Timmy", owner.Name);
        }
        /// <summary>
        /// Her bliver der testet om der er 8 tegn (det er der)
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Dit telefon nummer må kun være 8 karaktere langt.")]
        public void PhoneCharsTest()
        {
            var owner = new Owner();
            owner.Phone = "12345678";
            owner.PhoneChars();
            Assert.AreEqual("12345678", owner.Phone);
        }
        /// <summary>
        /// Her bliver der testet igen med 5 tegn (Den fejlede)
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Addressen skal være længere end 6.")]
        public void AddressCharsTest6()
        {
            //Arrange
            var owner = new Owner();
            //Act
            owner.Address = "EnVej1";
            owner.AddressChars();
            //Assert
            Assert.AreEqual("EnVej1", owner.Address);

        }
        /// <summary>
        /// Her bliver der testet igen med under 4 tegn (Den fejlede)
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Dit navn skal være fire karaktere langt eller mere.")]
        public void NameCharsTest3()
        {
            var owner = new Owner();
            owner.Name = "Tim";
            owner.NameChars();
            Assert.AreEqual("Tim", owner.Name);
        }
        /// <summary>
        /// Her bliver der testet igen med mere end 8 tegn (Den fejlede)
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Dit telefon nummer må kun være 8 karaktere langt.")]
        public void PhoneCharsTest9()
        {
            var owner = new Owner();
            owner.Phone = "123456789";
            owner.PhoneChars();
            Assert.AreEqual("123456789", owner.Phone);
        }
    }
}
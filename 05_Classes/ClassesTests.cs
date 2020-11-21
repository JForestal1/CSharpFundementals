using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            //* use the blank constructor
            
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Butter";


            //* override constructor with 3 parameters

            Cookie Thinmint = new Cookie("Thinmint", false, 20);
            Cookie PeanutButter = new Cookie("PeanutButter", true, 8.75);
        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.Type = VehicleType.sailboat;

            Vehicle newVehicle = new Vehicle
            {
                Type = VehicleType.motorcycle,
                IsNew = true,
                Model = "Harley"
            };
        }
    } 
}

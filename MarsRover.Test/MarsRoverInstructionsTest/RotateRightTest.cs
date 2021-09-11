using MarsRover.Data.Entities;
using MarsRover.Service.ServiceRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Test.MarsRoverInstructionsTest
{
    [TestClass]
    public class RotateRightTest
    {
        [TestMethod]
        public void Test_12N_RotateRight()
        {
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.N,
                XCoordinate = 1,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "R";

            var expectedResult = "1 2 E";
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);
            var actualResult = finalLocation.XCoordinate.ToString() + " " + finalLocation.YCoordinate.ToString() + " " + finalLocation.Direction.ToString();

            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_12E_RotateRight()
        {
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.E,
                XCoordinate = 1,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "R";

            var expectedResult = "1 2 S";
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);
            var actualResult = finalLocation.XCoordinate.ToString() + " " + finalLocation.YCoordinate.ToString() + " " + finalLocation.Direction.ToString();

            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Test_12S_RotateRight()
        {
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.S,
                XCoordinate = 1,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "R";

            var expectedResult = "1 2 W";
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);
            var actualResult = finalLocation.XCoordinate.ToString() + " " + finalLocation.YCoordinate.ToString() + " " + finalLocation.Direction.ToString();

            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Test_12W_RotateRight()
        {
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.W,
                XCoordinate = 1,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "R";

            var expectedResult = "1 2 N";
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);
            var actualResult = finalLocation.XCoordinate.ToString() + " " + finalLocation.YCoordinate.ToString() + " " + finalLocation.Direction.ToString();

            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

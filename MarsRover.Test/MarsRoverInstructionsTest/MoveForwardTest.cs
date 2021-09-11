using MarsRover.Data.Entities;
using MarsRover.Service.ServiceRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Test.MarsRoverInstructionsTest
{
    [TestClass]
    public class MoveForwardTest
    {
        #region Success_Test_Results
        [TestMethod]
        public void Test_12N_MoveForward_Success()
        {
            //Arrannge
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.N,
                XCoordinate = 1,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "M";

            //Act
            var expectedResult = "1 3 N";
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);
            var actualResult = finalLocation.XCoordinate.ToString() + " " + finalLocation.YCoordinate.ToString() + " " + finalLocation.Direction.ToString();

            //Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_12E_MoveForward_Success()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.E,
                XCoordinate = 1,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "M";

            //Act
            var expectedResult = "2 2 E";
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);
            var actualResult = finalLocation.XCoordinate.ToString() + " " + finalLocation.YCoordinate.ToString() + " " + finalLocation.Direction.ToString();

            //Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Test_12S_MoveForward_Success()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.S,
                XCoordinate = 1,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "M";

            //Act
            var expectedResult = "1 1 S";
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);
            var actualResult = finalLocation.XCoordinate.ToString() + " " + finalLocation.YCoordinate.ToString() + " " + finalLocation.Direction.ToString();

            //Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Test_12W_MoveForward_Success()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.W,
                XCoordinate = 1,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "M";

            //Act
            var expectedResult = "0 2 W";
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);
            var actualResult = finalLocation.XCoordinate.ToString() + " " + finalLocation.YCoordinate.ToString() + " " + finalLocation.Direction.ToString();

            //Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Failure_Test_Results
        [TestMethod]
        public void Test_12N_MoveForward_Failure()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.N,
                XCoordinate = 1,
                YCoordinate = 5
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "M";

            //Act
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);

            //Assert
            Assert.IsNull(finalLocation);
        }

        [TestMethod]
        public void Test_12E_MoveForward_Failure()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.E,
                XCoordinate = 5,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "M";

            //Act
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);

            //Assert
            Assert.IsNull(finalLocation);
        }
        [TestMethod]
        public void Test_12S_MoveForward_Failure()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.S,
                XCoordinate = 1,
                YCoordinate = 0
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "M";

            //Act
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);

            //Assert
            Assert.IsNull(finalLocation);
        }
        [TestMethod]
        public void Test_12W_MoveForward_Failure()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.W,
                XCoordinate = 0,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "M";

            //Act
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);

            //Assert
            Assert.IsNull(finalLocation);
        }
        #endregion
    }
}
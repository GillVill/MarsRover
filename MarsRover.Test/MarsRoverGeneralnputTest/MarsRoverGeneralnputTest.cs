using MarsRover.Data.Entities;
using MarsRover.Service.ServiceRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Test.MarsRoverGeneralInputTest
{
    [TestClass]
    public class MarsRoverGeneralnputTest
    {
        #region Success_Test_Results
        [TestMethod]
        public void Test_12N_LMLMLMLMM_Input_Success()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.N,
                XCoordinate = 1,
                YCoordinate = 2
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "LMLMLMLMM";

            //Act
            var expectedResult = "1 3 N";
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);
            var actualResult = finalLocation.XCoordinate.ToString() + " " + finalLocation.YCoordinate.ToString() + " " + finalLocation.Direction.ToString();

            //Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_33E_MMRMMRMRRM_Input_Success()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.E,
                XCoordinate = 3,
                YCoordinate = 3
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "MMRMMRMRRM";

            //Act
            var expectedResult = "5 1 E";
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);
            var actualResult = finalLocation.XCoordinate.ToString() + " " + finalLocation.YCoordinate.ToString() + " " + finalLocation.Direction.ToString();

            //Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Failure_Test_Result
        [TestMethod]
        public void Test_61N_LMLMLMLMM_Input_Failure()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.N,
                XCoordinate = 6,
                YCoordinate = 1
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "LMLMLMLMM";

            //Act
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);

            //Assert
            Assert.IsNull(finalLocation);
        }

        [TestMethod]
        public void Test_16E_MMRMMRMRRM_Input_Failure()
        {
            //Arrange
            MarsRoverServiceRepository mockServiceRepository = new MarsRoverServiceRepository();
            Locations MockLocation = new Locations
            {
                Direction = Directions.E,
                XCoordinate = 1,
                YCoordinate = 6
            };
            var maxPoints = new List<int>() { 5, 5 };
            var movement = "MMRMMRMRRM";

            //Act
            var finalLocation = mockServiceRepository.GetFinalLocation(maxPoints, MockLocation, movement);

            //Assert
            Assert.IsNull(finalLocation);
        }
        #endregion
    }
}

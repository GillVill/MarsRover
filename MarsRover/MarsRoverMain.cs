using MarsRover.Data.Entities;
using MarsRover.Service.ServiceRepository;
using System;
using System.Linq;

namespace MarsRover
{
    class MarsRoverMain
    {
        static void Main(string[] args)
        {
            var marsServiceProvider = new MarsRoverServiceRepository();
            Locations originLocation = new Locations();

            var maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var originPositions = Console.ReadLine().ToUpper().Trim().Split(' ');
            var movementInstruction = Console.ReadLine().ToUpper();

            if (originPositions.Count() == 3)
            {
                originLocation.XCoordinate = Convert.ToInt32(originPositions[0]);
                originLocation.YCoordinate = Convert.ToInt32(originPositions[1]);
                originLocation.Direction = (Directions)Enum.Parse(typeof(Directions), originPositions[2]);
            }

            var finalLocation = marsServiceProvider.GetFinalLocation(maxPoints, originLocation, movementInstruction);

            if (finalLocation != null)
                Console.WriteLine(finalLocation.XCoordinate + " " + finalLocation.YCoordinate + " " + finalLocation.Direction);
            else
                Console.WriteLine("Rover can't Move");

            Console.ReadKey();
        }
    }
}

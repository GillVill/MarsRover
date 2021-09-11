using MarsRover.Data.Entities;
using MarsRover.Service.ServiceProvider;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Service.ServiceRepository
{
    public class MarsRoverServiceRepository : IMarsRoverServiceProvider
    {
        /// <summary>
        /// This service calculates the final position of the rover based on the given location and instructions.
        /// </summary>
        /// <param name="maxPoints">Boundaries coordinates</param>
        /// <param name="originLocation">Origin location of rover</param>
        /// <param name="movementInstructions">Instructions for rover direction</param>
        /// <returns>Locations</returns>
        public Locations GetFinalLocation(List<int> maxPoints, Locations originLocation, string movementInstructions)
        {
            if (originLocation.XCoordinate < 0 || originLocation.XCoordinate > maxPoints[0] ||
                originLocation.YCoordinate < 0 || originLocation.YCoordinate > maxPoints[1])
            {
                Console.WriteLine("Wrong input! The location you entered cannot be beyond the boundaries. Boundaries are {0}, {1}", 
                    maxPoints[0], maxPoints[1]);
                return null;
            }
            else
            {
                Locations finalLocation = new Locations();
                foreach (var movement in movementInstructions)
                {
                    switch (movement)
                    {
                        case 'M':
                            finalLocation = MoveForward(originLocation);
                            break;
                        case 'L':
                            finalLocation = RotateLeft(originLocation);
                            break;
                        case 'R':
                            finalLocation = RotateRight(originLocation);
                            break;
                        default:
                            break;
                    }
                }

                if (finalLocation.XCoordinate < 0 || finalLocation.XCoordinate > maxPoints[0] ||
                    finalLocation.YCoordinate < 0 || finalLocation.YCoordinate > maxPoints[1])
                {
                    Console.WriteLine("Wrong instructions. The location of rover is {0}, {1} after executed your instructions. They need to be (0, {2}) and (0, {3})",
                        finalLocation.XCoordinate, finalLocation.YCoordinate, maxPoints[0], maxPoints[1]);
                    return null;
                }
                else
                    return finalLocation;
            }
        }

        public Locations MoveForward(Locations location)
        {
            switch (location.Direction)
            {
                case Directions.N:
                    location.YCoordinate += 1;
                    break;
                case Directions.E:
                    location.XCoordinate += 1;
                    break;
                case Directions.S:
                    location.YCoordinate -= 1;
                    break;
                case Directions.W:
                    location.XCoordinate -= 1;
                    break;
                default:
                    break;
            }

            return location;
        }

        public Locations RotateLeft(Locations location)
        {
            switch (location.Direction)
            {
                case Directions.N:
                    location.Direction = Directions.W;
                    break;
                case Directions.E:
                    location.Direction = Directions.N;
                    break;
                case Directions.S:
                    location.Direction = Directions.E;
                    break;
                case Directions.W:
                    location.Direction = Directions.S;
                    break;
                default:
                    break;
            }

            return location;
        }

        public Locations RotateRight(Locations location)
        {
            switch (location.Direction)
            {
                case Directions.N:
                    location.Direction = Directions.E;
                    break;
                case Directions.E:
                    location.Direction = Directions.S;
                    break;
                case Directions.S:
                    location.Direction = Directions.W;
                    break;
                case Directions.W:
                    location.Direction = Directions.N;
                    break;
                default:
                    break;
            }

            return location;
        }
    }
}

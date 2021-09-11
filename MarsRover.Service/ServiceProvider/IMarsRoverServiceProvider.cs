using MarsRover.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Service.ServiceProvider
{
    /// <summary>
    /// Interface for rover movement service
    /// </summary>
    public interface IMarsRoverServiceProvider
    {
        Locations GetFinalLocation(List<int> maxPoints, Locations originLocation, string movementInstructions);
        Locations MoveForward(Locations location);
        Locations RotateLeft(Locations location);
        Locations RotateRight(Locations location);
    }
}

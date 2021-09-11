using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Data.Entities
{
    public class Locations
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Directions Direction { get; set; }
        public string ErrorMessage { get; set; }
    }
}

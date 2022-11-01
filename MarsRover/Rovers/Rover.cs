using MarsExplorer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer.Rovers
{
    //This class is held separate from MarsRover so that it is open for extension (e.g. future plans to allow rovers to move in reverse and in diagonal axes)
    public abstract class Rover
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Cardinal Direction { get; set; }
    }
}

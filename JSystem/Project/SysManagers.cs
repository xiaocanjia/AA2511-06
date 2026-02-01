using JSystem.Station;
using JSystem.Param;
using System.Collections.Generic;
using Meas2D;

namespace JSystem.Project
{
    public class SysManagers
    {
        public List<PointPos> PointsList;

        public Meas2DManager Meas2DMgrA = new Meas2DManager();

        public Meas2DManager Meas2DMgrB = new Meas2DManager();

        public Meas2DManager Meas2DMgrL = new Meas2DManager();

        public Meas2DManager Meas2DMgrR = new Meas2DManager();
    }
}

using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;

namespace BH.oM.dKoP
{
    public interface IWallOpening : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        double StructuralWidth { get; set; }

        double StructuralHeight { get; set; }

        ParameterPoint PositionAlongWall { get; set; }

        bool ConfirmationGeometryRequirementsAreMet { get; set; }

        DoorAndWindowFire Fire { get; set; }

        DoorAndWindowAcoustics AcousticPerformance { get; set; }

        DoorAndWindowThermalPerformance ThermalPerformance { get; set; }

        /***************************************************/
    }
}
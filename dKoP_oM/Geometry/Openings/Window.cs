using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;

namespace BH.oM.dKoP
{
    public class Window : IWallOpening, IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double StructuralWidth { get; set; }

        public virtual double StructuralHeight { get; set; }

        public virtual ParameterPoint PositionAlongWall { get; set; } = new ParameterPoint();

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }

        public virtual DoorAndWindowFire Fire { get; set; } = new DoorAndWindowFire();

        public virtual DoorAndWindowAcoustics AcousticPerformance { get; set; } = new DoorAndWindowAcoustics();

        public virtual DoorAndWindowThermalPerformance ThermalPerformance { get; set; } = new DoorAndWindowThermalPerformance();

        public virtual WindowStyle WindowStyle { get; set; }

        public virtual WindowOpeningType OpeningType { get; set; }

        public virtual OpeningPartFinish InsideFinish { get; set; } = new OpeningPartFinish();

        public virtual OpeningPartFinish OutsideFinish { get; set; } = new OpeningPartFinish();
        
        public virtual string WindowFurniture { get; set; }
        
        public virtual string FinishesStyleAndOpeningDirection { get; set; }

        public virtual string Product { get; set; }

        /***************************************************/
    }
}
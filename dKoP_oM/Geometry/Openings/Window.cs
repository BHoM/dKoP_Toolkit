using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;

namespace BH.oM.dKoP.Geometry
{
    public class Window : IWallOpening, IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double StructuralWidth { get; set; }

        public virtual double StructuralHeight { get; set; }

        public virtual ParameterPoint PositionAlongWall { get; set; }

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }

        public virtual DoorAndWindowFire Fire { get; set; }

        public virtual DoorAndWindowAcoustics AcousticPerformance { get; set; }

        public virtual DoorAndWindowThermalPerformance ThermalPerformance { get; set; }

        public virtual WindowStyle WindowStyle { get; set; }

        public virtual WindowOpeningType OpeningType { get; set; }

        public virtual OpeningPartFinish InsideFinish { get; set; }

        public virtual OpeningPartFinish OutsideFinish { get; set; }
        
        public virtual string WindowFurniture { get; set; }
        
        public virtual string FinishesStyleAndOpeningDirection { get; set; }

        public virtual string Product { get; set; }

        /***************************************************/
    }
}
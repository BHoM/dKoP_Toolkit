using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Door : IWallOpening, IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double StructuralWidth { get; set; }

        [Length]
        public virtual double StructuralHeight { get; set; }

        public virtual ParameterPoint PositionAlongWall { get; set; } = new ParameterPoint();

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }

        public virtual DoorAndWindowFire Fire { get; set; } = new DoorAndWindowFire();

        public virtual DoorAndWindowAcoustics AcousticPerformance { get; set; } = new DoorAndWindowAcoustics();

        public virtual DoorAndWindowThermalPerformance ThermalPerformance { get; set; } = new DoorAndWindowThermalPerformance();

        public virtual DoorFinish DoorFinish { get; set; } = new DoorFinish();

        public virtual OpeningPartFinish FrameFinish { get; set; } = new OpeningPartFinish();

        public virtual string DoorFurniture { get; set; }
        
        public virtual Architrave ArchitraveSpecification { get; set; }

        public virtual Direction DirectionOfOpening { get; set; }

        public virtual string FinishesStyleAndOpeningDirection { get; set; }

        public virtual string Product { get; set; }

        /***************************************************/
    }
}
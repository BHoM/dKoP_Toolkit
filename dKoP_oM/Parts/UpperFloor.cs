using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class UpperFloor : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual AdministrativeInformation AdministrativeInformation { get; set; } = new AdministrativeInformation();

        public virtual QualityAndCertification QualityAndCertification { get; set; } = new QualityAndCertification();

        public virtual HealthAndSafety HealthAndSafety { get; set; } = new HealthAndSafety();

        public virtual FloorGeometry Geometry { get; set; } = new FloorGeometry();

        public virtual RoofPerformance Performance { get; set; } = new RoofPerformance();

        public virtual Assembly Assembly { get; set; } = new Assembly();

        public virtual FloorAndRoofInterfaces Interfaces { get; set; } = new FloorAndRoofInterfaces();

        /***************************************************/
    }
}
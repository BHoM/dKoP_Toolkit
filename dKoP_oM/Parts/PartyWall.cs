using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class PartyWall : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual AdministrativeInformation AdministrativeInformation { get; set; } = new AdministrativeInformation();

        public virtual QualityAndCertification QualityAndCertification { get; set; } = new QualityAndCertification();

        public virtual HealthAndSafety HealthAndSafety { get; set; } = new HealthAndSafety();

        public virtual WallGeometry Geometry { get; set; } = new WallGeometry();

        public virtual PartyWallPerformance Performance { get; set; } = new PartyWallPerformance();

        public virtual Assembly Assembly { get; set; } = new Assembly();

        public virtual WallInterfaces Interfaces { get; set; } = new WallInterfaces();

        /***************************************************/
    }
}
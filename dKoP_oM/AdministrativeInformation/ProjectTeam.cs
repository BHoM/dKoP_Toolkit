using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP.AdministrativeInformation
{
    public class ProjectTeam : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual ContactDetails Client { get; set; }

        public virtual ContactDetails Architect { get; set; }

        public virtual ContactDetails StructuralEngineer { get; set; }

        public virtual ContactDetails SeriveEngineer { get; set; }

        /***************************************************/
    }
}
